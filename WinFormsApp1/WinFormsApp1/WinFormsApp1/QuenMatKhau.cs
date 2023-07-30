using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace WinFormsApp1
{
    public partial class QuenMatKhau : Form
    {
        string connectionString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=QLTG";
        //Hai 1234
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        //Giúp thoát chương trình bằng nút X
        private void QuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên giao diện
            string taikhoan = textBox_TK.Text;
            string matkhau = textBox_newMK.Text;
            string ktraMK = textBox_CheckPass.Text;

            // Kiểm tra nếu có trường nào chưa nhập dữ liệu thì hiển thị hộp thoại cảnh báo
            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(ktraMK))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            // Kiểm tra tên đăng nhập chỉ chứa chữ và số (không chứa kí tự đặc biệt)
            if (!Regex.IsMatch(taikhoan, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ và số, không chứa kí tự đặc biệt.");
                return;
            }
            // Kiểm tra mật khẩu chỉ chứa chữ và số (không chứa ký tự đặc biệt)
            if (!Regex.IsMatch(matkhau, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mật khẩu chỉ được chứa chữ và số, không chứa ký tự đặc biệt và dấu cách.");
                return;
            }
            // Kiểm tra mật khẩu và mật khẩu nhập lại có khớp hay không
            if (matkhau != ktraMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại mật khẩu.");
                return;
            }
            // Kiểm tra mật khẩu có độ dài ít nhất 6 kí tự
            if (matkhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự.");
                return;
            }
            // Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string matkhaucu = null;
                    //Lấy mật khẩu trong database
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT MATKHAU FROM THONGTINTK WHERE TENTK = @TENTK";
                        cmd.Parameters.AddWithValue("TENTK", taikhoan);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            matkhaucu = result.ToString();
                        }
                    }
                    if (matkhaucu != null)
                    {
                        //Ghi đề mật khẩu cũ với mật khẩu mới, tra bằng tên tài khoản
                        string query = "UPDATE THONGTINTK SET MATKHAU = @mkmoi WHERE TENTK = @TENTK";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@mkmoi", matkhau);
                            cmd.Parameters.AddWithValue("@TENTK", taikhoan);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        DangNhap f = new DangNhap();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập này không tồn tại. Vui lòng kiểm tra lại.");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đổi mật khẩu: " + ex.Message);
            }
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy tạo mật khẩu mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Hủy sự kiện đóng form để ngăn form đóng đi khi người dùng nhấn nút "X"
                e.Cancel = true;
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }
        }
    }
}
