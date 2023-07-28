using System;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class DangNhap : Form
    {
        private const string connectionString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=QLTG";

        public DangNhap()
        {
            InitializeComponent();
            // Khởi tạo các xử lý cho txt_TK và txt_MK
            tkTextBoxHandler = new KiemTraNhapKiTu(20);
            mkTextBoxHandler = new KiemTraNhapKiTu(20);
        }

        private void DN_Click(object sender, EventArgs e)
        {
            string tk = txt_TK.Text.Trim();
            string mk = txt_MK.Text.Trim();

            // Kiểm tra nếu người dùng chưa nhập tên đăng nhập hoặc mật khẩu
            if (string.IsNullOrWhiteSpace(tk) || string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu.");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM THONGTINTK WHERE TENTK=@tk AND MATKHAU=@mk";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
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

        private bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        // Kiểm tra xem người dùng có muốn thoát chương trình hay không
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && ConfirmExit())
            {
                // Nếu người dùng chọn "Yes" để xác nhận muốn thoát, thực hiện dừng chương trình.
                Application.Exit();
            }
            else
            {
                // Nếu người dùng chọn "No" hoặc không muốn thoát, hủy sự kiện đóng form để ngăn form đóng đi.
                e.Cancel = true;
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

        // Thực hiện đăng nhập khi ấn phím Enter trên ô nhập mật khẩu
        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DN_Click(sender, e);
            }
        }

        private KiemTraNhapKiTu tkTextBoxHandler;
        private KiemTraNhapKiTu mkTextBoxHandler;
        private bool isHandlingTextChanged = false;
        private bool isTKMaxLengthExceeded = false;
        private bool isMKMaxLengthExceeded = false;

        // kiểm tra nhập tên đăng nhập có quá kí tự quy định không
        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            if (isHandlingTextChanged)
            {
                return;
            }

            isHandlingTextChanged = true;
            bool tkExceeded = tkTextBoxHandler.HandleTextChanged(txt_TK, txt_TK.Name);
            isHandlingTextChanged = false;

            isTKMaxLengthExceeded = tkExceeded;
        }

        // kiểm tra nhập mật khẩu có quá kí tự quy định không
        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            bool mkExceeded = mkTextBoxHandler.HandleTextChanged(txt_MK, txt_MK.Name);
            isMKMaxLengthExceeded = mkExceeded;
        }

        //  hiện mật khẩu 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_MK.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
