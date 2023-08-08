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
        //Giới hạn kí tự khi điền thông tin quên mật khẩu 
        KiemTraNhapChuoi TKTextBoxHandler;
        KiemTraNhapChuoi MKTextBoxHandler;
        KiemTraNhapChuoi MKCheckTextBoxHandler;
        public QuenMatKhau()
        {
            InitializeComponent();
            TKTextBoxHandler = Helper.TKTextBoxHandler;
            MKTextBoxHandler = Helper.MKTextBoxHandler;
            MKCheckTextBoxHandler = Helper.MKCheckTextBoxHandler;
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            //Lấy thông tin từ các điều khiển trên giao diện
            string taikhoan = txt_TK.Text;
            string matkhau = txt_MK.Text;
            string ktraMK = txt_CheckPass.Text;

            //Kiểm tra nếu có trường nào chưa nhập dữ liệu thì hiển thị hộp thoại cảnh báo
            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(ktraMK))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            //Kiểm tra tên đăng nhập chỉ chứa chữ và số (không chứa kí tự đặc biệt)
            if (!Regex.IsMatch(taikhoan, "^[a-zA-Z0-9\u00C0-\u1EF9]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ và số, không chứa kí tự đặc biệt.");
                return;
            }
            //Kiểm tra mật khẩu chỉ chứa chữ, số và kí tự đặc biệt, không chứa dấu cách
            if (!Regex.IsMatch(matkhau, "^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9\\s])"))
            {
                MessageBox.Show("Mật khẩu chỉ được chứa chữ, số và kí tự đặc biệt, không chứa dấu cách.");
                return;
            }
            // Kiểm tra mật khẩu và mật khẩu nhập lại có khớp hay không
            if (matkhau != ktraMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại mật khẩu.");
                return;
            }
            //Kiểm tra mật khẩu có độ dài ít nhất 6 kí tự
            if (matkhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự.");
                return;
            }
            //Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Helper.ConnectionString))
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
        //Tắt form Quên Mật Khẩu
        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra nếu như form được đóng bởi người dùng
            {
                if (Helper.ConfirmExit())
                {
                    // Hủy sự kiện đóng form để ngăn form đóng đi khi người dùng nhấn nút "X"
                    DangNhap f = new DangNhap();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        // Giới hạn nhập dữ liệu cho các TextBox
        // giới hạn kí tự cho TextBox tài khoản
        private void textBox_TK_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.TKVuotQuaDoDaiMax = TKTextBoxHandler.KiemTraNhap(txt_TK, txt_TK.Name);
            Helper.TextThayDoi = false;
        }
        //giới hạn kí tự cho TextBox mật khẩu mới
        private void textBox_newMK_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.MKVuotQuaDoDaiMax = MKTextBoxHandler.KiemTraNhap(txt_MK, txt_MK.Name);
            Helper.TextThayDoi = false;
        }
        //giới hạn kí tự cho TextBox nhập lại mật khẩu mới
        private void textBox_CheckPass_TextChanged(object sender, EventArgs e)
        {
            if (Helper.TextThayDoi)
            {
                return;
            }
            Helper.TextThayDoi = true;
            Helper.MKCheckVuotQuaDoDaiMax = MKCheckTextBoxHandler.KiemTraNhap(txt_CheckPass, txt_CheckPass.Name);
            Helper.TextThayDoi = false;
        }
    }
}
