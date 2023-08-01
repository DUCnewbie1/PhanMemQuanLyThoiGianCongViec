using System.Windows.Forms;

namespace WinFormsApp1
{
    public class KiemTraNhapChuoi
    {
        private int doDaiToiDa = 20;
        private bool vuotQuaDoDaiToiDa = false;

        public KiemTraNhapChuoi(int doDaiToiDa)
        {
            this.doDaiToiDa = doDaiToiDa;
        }

        public bool KiemTraNhap(TextBox textBox, string tenTextBox)
        {
            if (textBox.Text.Length > doDaiToiDa && !vuotQuaDoDaiToiDa)
            {
                vuotQuaDoDaiToiDa = true;
                if (tenTextBox.Contains("Ho"))
                {
                    MessageBox.Show("Họ chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("Ten"))
                {
                    MessageBox.Show("Tên chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("DiaChi"))
                {
                    MessageBox.Show("Địa chỉ chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("TenDangNhap"))
                {
                    MessageBox.Show("Tên đăng nhập chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("MatKhau"))
                {
                    MessageBox.Show("Mật khẩu chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("NhapLaiMatKhau"))
                {
                    MessageBox.Show("Nhập lại mật khẩu chỉ được nhập tối đa " + doDaiToiDa + " kí tự.");
                }

                textBox.Text = textBox.Text.Substring(0, doDaiToiDa);
                textBox.Select(doDaiToiDa, 0);
            }
            else
            {
                vuotQuaDoDaiToiDa = false;
            }
            return vuotQuaDoDaiToiDa;
        }
    }
}
