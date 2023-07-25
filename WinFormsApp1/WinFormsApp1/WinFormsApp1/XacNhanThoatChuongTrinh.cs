using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class XacNhanThoatChuongTrinh
    {
        // Phương thức hiển thị hộp thoại xác nhận thoát chương trình
        public static bool ConfirmExit()
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
