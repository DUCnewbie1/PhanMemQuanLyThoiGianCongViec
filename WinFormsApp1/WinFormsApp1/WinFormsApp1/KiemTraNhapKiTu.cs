using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class KiemTraNhapKiTu
    {
        private int maxLength = 20;
        private bool isMaxLengthExceeded = false;

        public KiemTraNhapKiTu(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public bool HandleTextChanged(TextBox textBox, string textBoxName)
        {
            if (textBox.Text.Length > maxLength && !isMaxLengthExceeded)
            {
                isMaxLengthExceeded = true;
                if (textBoxName.Contains("txt_TK"))
                {
                    MessageBox.Show("Tài khoản chỉ được nhập tối đa " + maxLength + " kí tự.");
                }
                else if (textBoxName.Contains("txt_MK"))
                {
                    MessageBox.Show("Mật khẩu chỉ được nhập tối đa " + maxLength + " kí tự.");
                }

                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.Select(maxLength, 0);
            }
            else
            {
                isMaxLengthExceeded = false;
            }
            return isMaxLengthExceeded;
        }
    }
}

