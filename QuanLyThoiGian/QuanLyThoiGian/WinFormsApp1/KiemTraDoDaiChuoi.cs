using System.Windows.Forms;

namespace WinFormsApp1
{
    public class KiemTraNhapChuoi
    {
        private int DoDaiToiDa = 20;
        private bool VuotQuaDoDaiToiDa = false;

        public KiemTraNhapChuoi(int doDaiToiDa)
        {
            this.DoDaiToiDa = doDaiToiDa;
        }

        public bool KiemTraNhap(TextBox textBox, string tenTextBox)
        {
            if (textBox.Text.Length > DoDaiToiDa && !VuotQuaDoDaiToiDa)
            {
                VuotQuaDoDaiToiDa = true;
                if (tenTextBox.Contains("textBoxHo"))
                {
                    MessageBox.Show("Họ chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("textBoxTen"))
                {
                    MessageBox.Show("Tên chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("textBoxDiaChi"))
                {
                    MessageBox.Show("Địa chỉ chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }               
                if (tenTextBox.Contains("txt_TK"))
                {
                    MessageBox.Show("Tài khoản chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("txt_MK"))
                {
                    MessageBox.Show("Mật khẩu chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }
                else if (tenTextBox.Contains("txt_CheckPass"))
                {
                    MessageBox.Show("Mật khẩu nhập lại chỉ được nhập tối đa " + DoDaiToiDa + " kí tự.");
                }
                textBox.Text = textBox.Text.Substring(0, DoDaiToiDa);
                textBox.Select(DoDaiToiDa, 0);
            }
            else
            {
                VuotQuaDoDaiToiDa = false;
            }
            return VuotQuaDoDaiToiDa;
        }
    }
}
