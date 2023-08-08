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
using Npgsql;
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace WinFormsApp1
{
    public partial class XacNhanMatKhau : Form
    {
        private ThongTinCaNhan ThongTinCaNhan;

        public XacNhanMatKhau(ThongTinCaNhan ThongTinCaNhan)
        {
            InitializeComponent();
            this.ThongTinCaNhan = ThongTinCaNhan;
        }
        //nút hủy
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //nút xác nhận
        private void XN_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Helper.ConnectionString))
                {
                    conn.Open();
                    String matkhau = NhapMatKhau.Text;
                    //string taikhoan = "SELECT * FROM THONGTINTK WHERE TENTK=@tk";
                    // Kiểm tra nếu người dùng chưa nhập  mật khẩu
                    if (string.IsNullOrWhiteSpace(matkhau))
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu.");
                        return;
                    }

                    string sql = "SELECT * FROM THONGTINTK WHERE MATKHAU=@mk";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        //cmd.Parameters.AddWithValue("@tk", taikhoan);
                        cmd.Parameters.AddWithValue("@mk", matkhau);

                        using (NpgsqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                this.Close();
                                ThongTinCaNhan.enableText();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu.");
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
        // nút hiện mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NhapMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void XacNhanMatKhau_Load(object sender, EventArgs e)
        {
            NhapMatKhau.Select();
        }

        private void NhapMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                XN_Click_1(sender, e);
            }
        }
    }
}