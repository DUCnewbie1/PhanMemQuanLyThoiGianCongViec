using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            ho.Select();
        }

        // thoát và trở lại giao diện chương trình
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result2 = MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận trở lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        // Nút X để thoát và trở lại giao diện chương trình
        private void ThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = !XacNhanThoatChuongTrinh.ConfirmBack();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }
        // nút chỉnh sửa thông tin
        private void button2_Click(object sender, EventArgs e)
        {
            XacNhanMatKhau xn = new XacNhanMatKhau();
            xn.ShowDialog();
        }
    }
}
