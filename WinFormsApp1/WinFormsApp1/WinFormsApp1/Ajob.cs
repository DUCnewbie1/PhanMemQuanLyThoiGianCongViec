using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }
        // Khai báo sửa, xóa sự kiện 
        //---------------------------------------------------------------------------------------------------------
        private event EventHandler edited; // Khai báo một trường sự kiện kiểu EventHandler tên là 'edited'
        public event EventHandler Edited // Khai báo một sự kiện kiểu EventHandler có tên là 'Edited'
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted; // Khai báo một trường sự kiện kiểu EventHandler tên là 'deleted'
        public event EventHandler Deleted // Khai báo một sự kiện kiểu EventHandler có tên là 'Deleted'
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        //---------------------------------------------------------------------------------------------------------
        public AJob(PlanItem job)
        {
            InitializeComponent(); // Khởi tạo các thành phần của lớp

            cbStatus.DataSource = PlanItem.ListStatus; // Đặt nguồn dữ liệu cho điều khiển cbStatus

            this.Job = job; // Đặt giá trị cho thuộc tính Job

            ShowInfo(); // Hiển thị thông tin
        }

        // Phương thức hiển thị thông tin của 1 sự kiện 
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

        // Xử lý sự kiện khi người dùng nhấn vào nút btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Nếu biến deleted khác null
            if (deleted != null)
                // Gọi sự kiện deleted với tham số là đối tượng hiện tại và một đối tượng EventArgs mới
                deleted(this, new EventArgs());
        }

        // Xử lý sự kiện khi người dùng nhấn vào nút btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Cập nhật các thuộc tính của đối tượng Job với các giá trị mới từ các điều khiển nhập liệu
            Job.Job = txbJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            // Nếu biến edited khác null
            if (edited != null)
                // Gọi sự kiện edited với tham số là đối tượng hiện tại và một đối tượng EventArgs mới
                edited(this, new EventArgs());
        }

        // nêú ấn vào ô tích thì sẽ chuyển trạng thái công việc sang DONE. 
        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
        // => Đã ràng buộc 2 chiều nếu DONE thì điều khiển ckbDone được chọn (Checked) và ngược lại  
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbStatus = sender as ComboBox;
            ckbDone.Checked = (cbStatus.SelectedIndex == (int)EPlanItem.DONE);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        // RÀNG BUỘC GIỜ BẮT ĐẦU và GIỜ KẾT THÚC 
        private void ResetInput()
        {
            // Đặt lại giá trị của nmFromHours và nmFromMinute về 0
            nmFromHours.Value = 0;
            nmFromMinute.Value = 0;

            // Hiển thị cửa sổ thông báo yêu cầu người dùng nhập lại giá trị
            MessageBox.Show("Vui lòng nhập lại giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-----------------------------------RÀNG BUỘC Ở NGÀY BẮT ĐẦU------------------------------
        private void nmFromHours_ValueChanged(object sender, EventArgs e)
        {
            // Ràng buộc giá trị của nmFromHours tối đa là 24
            if (nmFromHours.Value > 24)
                nmFromHours.Value = 24;

            // Nếu nmFromHours có giá trị là 24 thì nmFromMinute có giá trị tối đa là 0
            if (nmFromHours.Value == 24)
                nmFromMinute.Maximum = 0;
            else
                nmFromMinute.Maximum = 59;
        }

        private void nmFromMinute_ValueChanged(object sender, EventArgs e)
        {
            // Ràng buộc giá trị của nmFromMinute tối đa là 59
            if (nmFromMinute.Value > 59)
                nmFromMinute.Value = 59;
        }

        //-----------------------------------RÀNG BUỘC Ở NGÀY KẾT THÚC------------------------------
        private void nmToHours_ValueChanged(object sender, EventArgs e)
        {
            // Ràng buộc giá trị của nmToHours tối đa là 24
            if (nmToHours.Value > 24)
                nmToHours.Value = 24;

            // Nếu nmFromHours có giá trị là 24 thì nmToMinute có giá trị tối đa là 0
            if (nmToHours.Value == 24)
                nmToMinute.Maximum = 0;
            else
                nmToMinute.Maximum = 59;
        }

        private void nmToMinute_ValueChanged(object sender, EventArgs e)
        {
            // Ràng buộc giá trị của nmToMinute tối đa là 59
            if (nmToMinute.Value > 59)
                nmToMinute.Value = 59;
        }
    }
}
