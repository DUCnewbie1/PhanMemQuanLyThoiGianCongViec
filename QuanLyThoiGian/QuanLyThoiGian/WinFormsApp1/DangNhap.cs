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
        //Giới hạn kí tự khi điền thông tin đăng nhập
        KiemTraNhapChuoi TKTextBoxHandler;
        KiemTraNhapChuoi MKTextBoxHandler;
        public DangNhap()
        {
            InitializeComponent();
            // Khởi tạo các xử lý cho txt_TK và txt_MK
            TKTextBoxHandler = Helper.TKTextBoxHandler;
            MKTextBoxHandler = Helper.MKTextBoxHandler;
        }
        //Kiểm tra khi nhấn nút đăng nhập
        private void DN_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Helper.ConnectionString))
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

                    string sql = "SELECT id FROM THONGTINTK WHERE TENTK=@tk AND MATKHAU=@mk";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        using (NpgsqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                int userId = data.GetInt32(0); // Lấy user id từ cột "id" trong kết quả truy vấn
                                MessageBox.Show("Đăng nhập thành công");
                                Form1 form1 = new Form1(userId); // Truyền user id vào Form1
                                form1.Show();
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
            if (Helper.ConfirmExit())
            {
                Application.ExitThread();
            }
        }
        // Kiểm tra xem người dùng có muốn thoát chương trình hay không
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Helper.ConfirmExit())
            {
                Application.ExitThread();
            }
            else
            {
                // Nếu người dùng chọn "No" hoặc không muốn thoát, hủy sự kiện đóng form để ngăn form đóng đi.
                e.Cancel = true;
            }
        }
        //Khi nhấn nút đăng ký
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
        // Thực hiện đăng nhập khi ấn phím Enter trên ô nhập mật khẩu
        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DN_Click(sender, e);
            }
        }

        // kiểm tra nhập tên đăng nhập có quá kí tự quy định không
        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.TKVuotQuaDoDaiMax = TKTextBoxHandler.KiemTraNhap(txt_TK, txt_TK.Name); ;
            Helper.TextThayDoi = false;
        }
        // kiểm tra nhập mật khẩu có quá kí tự quy định không
        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.MKVuotQuaDoDaiMax = MKTextBoxHandler.KiemTraNhap(txt_MK, txt_MK.Name);
            Helper.TextThayDoi = false;
        }

        //  hiện mật khẩu 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_MK.UseSystemPasswordChar = !checkBox1.Checked;
        }
        // quên mật khẩu 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau QuenMK = new QuenMatKhau();
            QuenMK.Show();
            this.Hide();
        }

    }
}
