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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Dang_Ky : Form
    {
        string connectionString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=QLTG";
        public Dang_Ky()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // quay lại màn hình đăng nhập
        private void button3_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }

        // hủy đăng kí 
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy đăng ký?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }
        }

        // đăng kí tài khoản 
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên giao diện
            string ho = textBoxHo.Text;
            string ten = textBoxTen.Text;
            string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ"; // Giới tính được chọn dựa vào RadioButton
            string ngaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            string diaChi = textBoxDiaChi.Text;
            string tenDangNhap = textBoxTenDangNhap.Text;
            string matKhau = textBoxMatKhau.Text;

            // Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Thêm thông tin vào bảng NGUOIDUNG
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO NGUOIDUNG (HO, TEN, GIOITINH, NGAYSINH, DIACHI) VALUES (@HO, @TEN, @GIOITINH, @NGAYSINH, @DIACHI)";
                        cmd.Parameters.AddWithValue("HO", ho);
                        cmd.Parameters.AddWithValue("TEN", ten);
                        cmd.Parameters.AddWithValue("GIOITINH", gioiTinh);
                        cmd.Parameters.AddWithValue("NGAYSINH", ngaySinh);
                        cmd.Parameters.AddWithValue("DIACHI", diaChi);
                        cmd.ExecuteNonQuery();
                    }

                    // Thêm thông tin vào bảng THONGTINTK
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO THONGTINTK (TENTK, MATKHAU) VALUES (@TENTK, @MATKHAU)";
                        cmd.Parameters.AddWithValue("TENTK", tenDangNhap);
                        cmd.Parameters.AddWithValue("MATKHAU", matKhau);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng ký: " + ex.Message);
            }
        }
    }
}

