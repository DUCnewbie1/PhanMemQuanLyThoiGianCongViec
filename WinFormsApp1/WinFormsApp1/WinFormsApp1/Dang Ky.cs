﻿using System;
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
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Dang_Ky : Form
    {
        string connectionString = "Host=127.0.0.1;Username=postgres;Password=123;Database=QUANLYTHOIGIAN";

        private KiemTraNhapChuoi hoTextBoxHandler;
        private KiemTraNhapChuoi tenTextBoxHandler;
        private KiemTraNhapChuoi diaChiTextBoxHandler;
        private KiemTraNhapChuoi tenDangNhapTextBoxHandler;
        private KiemTraNhapChuoi matKhauTextBoxHandler;
        private KiemTraNhapChuoi nhapLaiMatKhauTextBoxHandler;
        public Dang_Ky()
        {
            InitializeComponent();
            // Thiết lập giá trị mặc định cho DateTimePicker
            dateTimePickerNgaySinh.Value = new DateTime(1990, 1, 1);
            // Khởi tạo đối tượng KiemTraNhapChuoi cho các TextBox
            hoTextBoxHandler = new KiemTraNhapChuoi(15);
            tenTextBoxHandler = new KiemTraNhapChuoi(20);
            diaChiTextBoxHandler = new KiemTraNhapChuoi(20);
            tenDangNhapTextBoxHandler = new KiemTraNhapChuoi(20);
            matKhauTextBoxHandler = new KiemTraNhapChuoi(20);
            nhapLaiMatKhauTextBoxHandler = new KiemTraNhapChuoi(20);
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
            string gioiTinh = "";
            string ngaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");
            string diaChi = textBoxDiaChi.Text;
            string tenDangNhap = textBoxTenDangNhap.Text;
            string matKhau = textBoxMatKhau.Text;
            string nhapLaiMatKhau = textBoxNhapLaiMatKhau.Text;
            if (radioButtonNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (radioButtonNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }
            // Kiểm tra các trường thông tin có được nhập đủ hay không
            if (string.IsNullOrWhiteSpace(ho) || string.IsNullOrWhiteSpace(ten) ||
                string.IsNullOrWhiteSpace(ngaySinh) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            // Kiểm tra tên đăng nhập chỉ chứa chữ và số (không chứa kí tự đặc biệt)
            if (!Regex.IsMatch(tenDangNhap, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ và số, không chứa kí tự đặc biệt.");
                return;
            }
            // Kiểm tra mật khẩu phải chứa cả chữ hoa, chữ thường, số và ký tự đặc biệt
            if (!Regex.IsMatch(matKhau, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9\\s])"))
            {
                MessageBox.Show("Mật khẩu phải chứa cả chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }
            // Kiểm tra mật khẩu có chứa dấu cách hay không
            if (Regex.IsMatch(matKhau, "\\s"))
            {
                MessageBox.Show("Mật khẩu không được chứa dấu cách.");
                return;
            }

            // Kiểm tra mật khẩu và mật khẩu nhập lại có khớp hay không
            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại mật khẩu.");
                return;
            }
            // Kiểm tra mật khẩu có độ dài ít nhất 6 kí tự
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự.");
                return;
            }
            // Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra tên đăng nhập đã tồn tại
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT COUNT(*) FROM THONGTINTK WHERE TENTK = @TENTK";
                        cmd.Parameters.AddWithValue("TENTK", tenDangNhap);
                        object result = cmd.ExecuteScalar();

                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                            return;
                        }
                    }

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
                    MessageBox.Show("Đăng ký tài khoản thành công, đăng nhập ngay!");
                    DangNhap f = new DangNhap();
                    f.Show();
                    this.Hide();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng ký: " + ex.Message);
            }
        }

        // Kiểm tra người dùng có muốn hủy đăng ký hay không
        private void Dang_Ky_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đăng ký?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        // đặt dấu nháy ở ô Họ 
        private void Dang_Ky_Load(object sender, EventArgs e)
        {
            textBoxHo.Select();
            // Đăng ký sự kiện KeyPress cho TextBox textBoxNhapLaiMatKhau
            textBoxNhapLaiMatKhau.KeyPress += TextBoxNhapLaiMatKhau_KeyPress;
        }

        // gán nút đăng ký với nút enter 
        private void TextBoxNhapLaiMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        // hàm ràng buộc họ không được có kí tự đặc biệt 
        private void textBoxHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // hàm ràng buộc tên không được có kí tự đặc biệt 
        private void textBoxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // hàm để hiện mật khẩu 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxMatKhau.UseSystemPasswordChar = false;
                textBoxNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxMatKhau.UseSystemPasswordChar = true;
                textBoxNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }

        // GIỚI HẠN NHẬP LIỆU CHO CÁC TEXT BOX
        //--------------------------------------------------------------------------------------
        private bool dangXuLyTextChanged = false;
        private bool vuotQuaDoDaiToiDaHo = false;
        private bool vuotQuaDoDaiToiDaTen = false;
        private bool vuotQuaDoDaiToiDaDiaChi = false;
        private bool vuotQuaDoDaiToiDaTenDangNhap = false;
        private bool vuotQuaDoDaiToiDaMatKhau = false;
        private bool vuotQuaDoDaiToiDaNhapLaiMatKhau = false;

        // giới hạn kí tự cho  TextBox Họ
        private void textBoxHo_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaHo = hoTextBoxHandler.KiemTraNhap(textBoxHo, textBoxHo.Name);
            dangXuLyTextChanged = false;
        }

        // giới hạn kí tự cho  TextBox Tên
        private void textBoxTen_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaTen = tenTextBoxHandler.KiemTraNhap(textBoxTen, textBoxTen.Name);
            dangXuLyTextChanged = false;
        }

        // giới hạn kí tự cho  TextBox Địa chỉ
        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaDiaChi = diaChiTextBoxHandler.KiemTraNhap(textBoxDiaChi, textBoxDiaChi.Name);
            dangXuLyTextChanged = false;
        }

        // giới hạn kí tự cho  TextBox Tên đăng nhập
        private void textBoxTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaTenDangNhap = tenDangNhapTextBoxHandler.KiemTraNhap(textBoxTenDangNhap, textBoxTenDangNhap.Name);
            dangXuLyTextChanged = false;
        }

        //giới hạn kí tự cho  TextBox Mật khẩu
        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaMatKhau = matKhauTextBoxHandler.KiemTraNhap(textBoxMatKhau, textBoxMatKhau.Name);
            dangXuLyTextChanged = false;
        }

        // giới hạn kí tự cho TextBox Nhập lại mật khẩu
        private void textBoxNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyTextChanged)
            {
                return;
            }
            dangXuLyTextChanged = true;
            vuotQuaDoDaiToiDaNhapLaiMatKhau = nhapLaiMatKhauTextBoxHandler.KiemTraNhap(textBoxNhapLaiMatKhau, textBoxNhapLaiMatKhau.Name);
            dangXuLyTextChanged = false;
        }
    }
}

