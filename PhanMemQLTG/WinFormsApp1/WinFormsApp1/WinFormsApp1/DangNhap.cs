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

namespace WinFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VF44UALL;Initial Catalog=QLTG;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txt_TK.Text;
                string mk = txt_MK.Text;
                string sql = "SELECT * FROM THONGTINTK WHERE TENTK='" + tk + "' AND MATKHAU='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form1 f = new Form1();
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void txt_TK_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
