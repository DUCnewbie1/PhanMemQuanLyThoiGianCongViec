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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class ThongTinCaNhan : Form
    {
        // id người dùng hiện tại 
        private int currentUserId;

        string connectionString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=QUANLYTHOIGIAN";

        public ThongTinCaNhan(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
        private bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT ND.HO, ND.TEN, ND.GIOITINH, ND.NGAYSINH, ND.DIACHI " +
                                 "FROM NGUOIDUNG ND " +
                                 "JOIN THONGTINTK TK ON ND.id = TK.id " +
                                 "WHERE ND.id = @UserId"; // Thay @UserId bằng tên parameter thích hợp

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", currentUserId); // Gán giá trị cho parameter

                        using (NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            ad.Fill(table);
                            // Gắn table vào DataGridView
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // thoát và trở lại giao diện chương trình
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result2 = MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận trở lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                Form1 form1 = new Form1(currentUserId);
                form1.Show();
                this.Hide();
            }
        }

        // Nút X để thoát và trở lại giao diện chương trình
        private void ThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f = new Form1(currentUserId);
                f.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
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