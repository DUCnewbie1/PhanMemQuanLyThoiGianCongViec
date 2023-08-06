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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class ThongTinCaNhan : Form
    {
        // id người dùng hiện tại 
        private int currentUserId;
        public ThongTinCaNhan(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
        private bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(Helper.ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT ND.HO, ND.TEN, ND.GIOITINH, ND.NGAYSINH, ND.DIACHI " +
                                 "FROM NGUOIDUNG ND " +
                                 "JOIN THONGTINTK TK ON ND.id = TK.id " +
                                 "WHERE ND.id = @UserId"; // Thay @UserId bằng tên parameter thích hợp

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", currentUserId); // Gán giá trị cho parameter

                        using (NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            ad.Fill(table);
                            // Gắn table vào DataGridView
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // thoát và trở lại giao diện chương trình
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result2 = MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận trở lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                Form1 form1 = new Form1(currentUserId);
                form1.Show();
                this.Hide();
            }
        }

        // Nút X để thoát và trở lại giao diện chương trình
        private void ThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f = new Form1(currentUserId);
                f.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }
        // nút chỉnh sửa thông tin
        private void button2_Click(object sender, EventArgs e)
        {
            XacNhanMatKhau xn = new XacNhanMatKhau(this);
            xn.ShowDialog();
        }
        //cho phép chỉnh sửa
        public void enableText()
        {
            ho.Enabled = true;
            ten.Enabled = true;
            Nam.Enabled = true;
            Nu.Enabled = true;
            ngaySinh.Enabled = true;
            diaChi.Enabled = true;
            luu.Enabled = true;
            button2.Enabled = false;
        }
        //đóng chỉnh sữa thông tin
        public void disableText() 
        {
            ho.Enabled = false;
            ten.Enabled = false;
            Nam.Enabled = false;
            Nu.Enabled = false;
            ngaySinh.Enabled = false;
            diaChi.Enabled = false;
            luu.Enabled = false;
        }
        // lưu thông tin
        private void luu_Click(object sender, EventArgs e)
        {
            string hoMoi = ho.Text;
            string tenMoi = ten.Text;
            string gioiTinhMoi = Nam.Checked ? "Nam" : (Nu.Checked ? "Nữ" : "");
            string ngaySinhMoi = "";
            string diaChiMoi = diaChi.Text;
            // Lấy chuỗi ngày tháng năm từ TextBox
            string ngayThangNam = ngaySinh.Text;

            // Kiểm tra nếu không nhập gì thì không cập nhật thông tin
            if (string.IsNullOrWhiteSpace(ngayThangNam))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển đổi chuỗi ngày tháng năm thành định dạng ngày hợp lệ
            DateTime ngaySinhDateTime;
            if (DateTime.TryParse(ngayThangNam, out ngaySinhDateTime))
            {
                ngaySinhMoi = ngaySinhDateTime.ToString("yyyy-MM-dd");
            }
            else
            {
                // Hiển thị thông báo lỗi nếu ngày tháng năm không hợp lệ
                MessageBox.Show("Ngày tháng năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // cập nhật dữ liệu cho bảng người dùng
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(Helper.ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE NGUOIDUNG SET HO = COALESCE(@Ho, HO), TEN = COALESCE(@Ten, TEN), " +
                         "GIOITINH = COALESCE(@GioiTinh, GIOITINH), NGAYSINH = COALESCE(@NgaySinh, NGAYSINH), " +
                         "DIACHI = COALESCE(@DiaChi, DIACHI) WHERE id = @UserId";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Ho", string.IsNullOrWhiteSpace(hoMoi) ? (object)DBNull.Value : hoMoi);
                        command.Parameters.AddWithValue("@Ten", string.IsNullOrWhiteSpace(tenMoi) ? (object)DBNull.Value : tenMoi);
                        command.Parameters.AddWithValue("@GioiTinh", string.IsNullOrWhiteSpace(gioiTinhMoi) ? (object)DBNull.Value : gioiTinhMoi);
                        command.Parameters.AddWithValue("@NgaySinh", string.IsNullOrWhiteSpace(ngaySinhMoi) ? (object)DBNull.Value : ngaySinhMoi);
                        command.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(diaChiMoi) ? (object)DBNull.Value : diaChiMoi);
                        command.Parameters.AddWithValue("@UserId", currentUserId);
                        int soHangAnhHuong = command.ExecuteNonQuery();
                        if (soHangAnhHuong > 0)
                        {
                            LoadData();
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            disableText();                         
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}