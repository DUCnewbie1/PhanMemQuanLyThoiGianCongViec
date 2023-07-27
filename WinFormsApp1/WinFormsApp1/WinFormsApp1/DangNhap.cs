using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace WinFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private bool ConfirmExit()
        {
            return XacNhanThoatChuongTrinh.ConfirmExit();
        }
        private void DN_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=QLTG";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string tk = txt_TK.Text;
                    string mk = txt_MK.Text;
                    // Kiểm tra nếu người dùng chưa nhập tên đăng nhập hoặc mật khẩu
                    if (string.IsNullOrWhiteSpace(tk) || string.IsNullOrWhiteSpace(mk))
                    {
                        MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu.");
                        return;
                    }

                    string sql = "SELECT * FROM THONGTINTK WHERE TENTK=@tk AND MATKHAU=@mk";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        using (NpgsqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                MessageBox.Show("Đăng nhập thành công");
                                Form1 f = new Form1();
                                f.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            if (ConfirmExit())
            {
                Application.Exit();
            }
        }
        // Kiểm tra xem người dùng có muốn thoát chương trình hay không
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && ConfirmExit())
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dang_Ky f = new Dang_Ky();
            f.Show();
            this.Hide();
        }

        // Đặt con trỏ chuột vào ô nhập tên tài khoản
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_TK.Select();
        }

        // Thực hiện hàm đăng nhập khi ấn phím Enter trên ô nhập mật khẩu
        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DN_Click(sender, e);
            }
        }

        // Kiểm tra xem người dùng có sử dụng Alt + F4 hoặc ấn nút "X" để đóng form không
        private void DangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && (Control.ModifierKeys == Keys.Alt || e.CloseReason == CloseReason.UserClosing))
            {
                e.Cancel = !ConfirmExit();
            }
        }
        private int mkMaxLength = 20;
        private bool isMKMaxLengthExceeded = false; // Biến cờ để theo dõi trạng thái cảnh báo cho TextBox txt_MK

        // Kiểm tra số lượng kí tự khi nội dung của TextBox txt_MK thay đổi
        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            if (txt_MK.Text.Length > mkMaxLength && !isMKMaxLengthExceeded)
            {
                isMKMaxLengthExceeded = true; // Đánh dấu đã hiển thị cảnh báo
                MessageBox.Show("Mật khẩu chỉ được nhập tối đa " + mkMaxLength + " kí tự.");
                txt_MK.Text = txt_MK.Text.Substring(0, mkMaxLength);
                txt_MK.Select(mkMaxLength, 0); // Di chuyển con trỏ nhập liệu về cuối TextBox
            }
            else
            {
                isMKMaxLengthExceeded = false; // Đặt lại biến cờ khi người dùng nhập dưới giới hạn
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_MK.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MK.UseSystemPasswordChar = true;
            }
        }
    }
}
