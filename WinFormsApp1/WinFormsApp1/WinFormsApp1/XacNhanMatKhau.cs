using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace WinFormsApp1
{
    public partial class XacNhanMatKhau : Form
    {
        public XacNhanMatKhau()
        {
            InitializeComponent();
        }
        // nút xác nhận
        private void button1_Click(object sender, EventArgs e)
        {
            String matKhau = NhapMatKhau.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy không?", "Xác nhận trở lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ThongTinCaNhan g = new ThongTinCaNhan();
                g.Show();
                this.Hide();
            }
        }
    }
}
