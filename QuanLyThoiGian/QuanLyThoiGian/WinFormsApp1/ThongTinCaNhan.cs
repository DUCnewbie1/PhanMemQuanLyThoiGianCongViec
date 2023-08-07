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
        //Giới hạn kí tự khi chỉnh sửa thông tin cá nhân
        KiemTraNhapChuoi HoTextBoxHandler;
        KiemTraNhapChuoi TenTextBoxHandler;
        KiemTraNhapChuoi DiaChiTextBoxHandler;
        public ThongTinCaNhan(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            HoTextBoxHandler = Helper.HoTextBoxHandler;
            TenTextBoxHandler = Helper.TenTextBoxHandler;
            DiaChiTextBoxHandler = Helper.DiaChiTextBoxHandler;
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
            if (Helper.ConfirmBack())
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
            button2.Enabled = true;
            button2.Visible = true;
        }
        //cho phép chỉnh sửa
        public void enableText()
        {
            textBoxHo.Enabled = true;
            textBoxTen.Enabled = true;
            Nam.Enabled = true;
            Nu.Enabled = true;
            NgaySinh.Enabled = true;
            textBoxDiaChi.Enabled = true;
            luu.Enabled = true;
            button2.Enabled = false;
        }
        //đóng chỉnh sữa thông tin
        public void disableText()
        {
            textBoxHo.Enabled = false;
            textBoxTen.Enabled = false;
            Nam.Enabled = false;
            Nu.Enabled = false;
            NgaySinh.Enabled = false;
            textBoxDiaChi.Enabled = false;
            luu.Enabled = false;
        }
        // lưu thông tin
        private void luu_Click(object sender, EventArgs e)
        {
            string hoMoi = textBoxHo.Text;
            string tenMoi = textBoxTen.Text;
            string gioiTinhMoi = Nam.Checked ? "Nam" : (Nu.Checked ? "Nữ" : "");
            string ngaySinhMoi = "";
            string diaChiMoi = textBoxDiaChi.Text;
            // Lấy chuỗi ngày tháng năm từ TextBox
            string ngayThangNam = NgaySinh.Text;

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
        // Giới hạn nhập dữ liệu cho các TextBox
        // giới hạn kí tự cho TextBox Họ
        private void textBoxHo_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.HoVuotQuaDoDaiMax = HoTextBoxHandler.KiemTraNhap(textBoxHo, textBoxHo.Name);
            Helper.TextThayDoi = false;
        }
        // giới hạn kí tự cho TextBox Tên
        private void textBoxTen_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.TenVuotQuaDoDaiMax = TenTextBoxHandler.KiemTraNhap(textBoxTen, textBoxTen.Name);
            Helper.TextThayDoi = false;
        }
        // giới hạn kí tự cho TextBox Địa chỉ
        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.DiaChiVuotQuaDoDaiMax = DiaChiTextBoxHandler.KiemTraNhap(textBoxDiaChi, textBoxDiaChi.Name);
            Helper.TextThayDoi = false;
        }
    }
}