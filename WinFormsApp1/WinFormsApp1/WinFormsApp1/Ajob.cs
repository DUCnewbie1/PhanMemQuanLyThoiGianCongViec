using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static WinFormsApp1.AJob;


namespace WinFormsApp1
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        private string gioBatDau;
        private string gioKetThuc;
        public int MaSK { get; set; }
        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
          
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        private int userId; // Thêm thuộc tính userId
        private string ngaytaosukien;
        public AJob(PlanItem job, int userId, int maSK, DateTime selectedDate)
        {
            InitializeComponent();
            cbStatus.DataSource = PlanItem.ListStatus;
            this.Job = job;
            ShowInfo();
            this.userId = userId;
            this.MaSK = maSK;

            // Chuyển đổi ngày đã chọn thành chuỗi ngày tháng có định dạng "yyyy-MM-dd" (10 ký tự)
            this.ngaytaosukien = selectedDate.ToString("yyyy-MM-dd");
        }

        void ShowInfo()
        {
            txbJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            ckbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txbJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            if (string.IsNullOrEmpty(Job.Job))
            {
                MessageBox.Show("Bạn chưa nhập tên sự kiện.");
                return;
            }

            // Kiểm tra và cập nhật công việc vào cơ sở dữ liệu sử dụng userId
            using (NpgsqlConnection conn = new NpgsqlConnection(Helper.ConnectionString))
            {
                conn.Open();

                // Kiểm tra sự kiện có tồn tại trong bảng "sukien" với sukien_id và tensk tương ứng
                string checkExistQuery = "SELECT COUNT(*) FROM sukien WHERE sukien_id = @sukien_id AND tensk = @tensk";
                using (var cmdCheck = new NpgsqlCommand(checkExistQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@sukien_id", this.userId);
                    cmdCheck.Parameters.AddWithValue("@tensk", Job.Job);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Sự kiện đã tồn tại.");
                        return;
                    }
                }

                // Thêm sự kiện vào bảng "sukien"
                string insertQuery = "INSERT INTO sukien (sukien_id, tensk, thoigianbd, thoigiankt, trangthai) VALUES (@sukien_id, @tensk, @thoigianbd, @thoigiankt, @trangthai)";
                using (var cmdInsert = new NpgsqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@sukien_id", this.userId); // Truyền userId vào tham số @sukien_id
                    cmdInsert.Parameters.AddWithValue("@tensk", Job.Job);

                    // Tạo giá trị TimeSpan cho giờ bắt đầu và giờ kết thúc
                    TimeSpan fromTime = new TimeSpan(Job.FromTime.X, Job.FromTime.Y, 0);
                    TimeSpan toTime = new TimeSpan(Job.ToTime.X, Job.ToTime.Y, 0);

                    // Gán giá trị TimeSpan cho các tham số
                    cmdInsert.Parameters.AddWithValue("@thoigianbd", fromTime);
                    cmdInsert.Parameters.AddWithValue("@thoigiankt", toTime);
                    cmdInsert.Parameters.AddWithValue("@trangthai", Job.Status);
                    cmdInsert.ExecuteNonQuery();

                    // Lấy giá trị "MaSK" sau khi được tự động tăng trong bảng "sukien"
                    string getMaSKQuery = "SELECT MAX(MaSK) FROM sukien WHERE sukien_id = @sukien_id AND tensk = @tensk";
                    using (var cmdGetMaSK = new NpgsqlCommand(getMaSKQuery, conn))
                    {
                        cmdGetMaSK.Parameters.AddWithValue("@sukien_id", this.userId);
                        cmdGetMaSK.Parameters.AddWithValue("@tensk", Job.Job);
                        this.MaSK = Convert.ToInt32(cmdGetMaSK.ExecuteScalar());
                    }
                }

                // Thêm sự kiện vào bảng "lich"
                string insertLichQuery = "INSERT INTO lich (ngaytaosukien, id, MaSK) VALUES (@ngaytaosukien, @id, @MaSK)";
                using (var cmdInsertLich = new NpgsqlCommand(insertLichQuery, conn))
                {
                    cmdInsertLich.Parameters.AddWithValue("@ngaytaosukien", ngaytaosukien); // Sử dụng chuỗi ngày tháng đã chọn từ form Dailyplan
                    cmdInsertLich.Parameters.AddWithValue("@id", this.userId); // Truyền userId vào tham số @id
                    cmdInsertLich.Parameters.AddWithValue("@MaSK", this.MaSK); // Truyền giá trị "MaSK" từ bảng "sukien" vào tham số @MaSK
                    cmdInsertLich.ExecuteNonQuery();
                }
            }

            if (edited != null)
                edited(this, new EventArgs());
        }


        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbStatus = sender as ComboBox;
            ckbDone.Checked = (cbStatus.SelectedIndex == (int)EPlanItem.DONE);
        }

        private void nmFromHours_ValueChanged(object sender, EventArgs e)
        {
            if (nmFromHours.Value > 24)
                nmFromHours.Value = 24;

            if (nmFromHours.Value == 24)
                nmFromMinute.Maximum = 0;
            else
                nmFromMinute.Maximum = 59;
        }

        private void nmFromMinute_ValueChanged(object sender, EventArgs e)
        {
            if (nmFromMinute.Value > 59)
                nmFromMinute.Value = 59;
        }

        private void nmToHours_ValueChanged(object sender, EventArgs e)
        {
            if (nmToHours.Value > 24)
                nmToHours.Value = 24;

            if (nmToHours.Value == 24)
                nmToMinute.Maximum = 0;
            else
                nmToMinute.Maximum = 59;
        }

        private void nmToMinute_ValueChanged(object sender, EventArgs e)
        {
            if (nmToMinute.Value > 59)
                nmToMinute.Value = 59;
        }
    }
}
