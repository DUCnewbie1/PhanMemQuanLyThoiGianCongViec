namespace WinFormsApp1
{
    partial class Dang_Ky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxHo = new TextBox();
            textBoxTen = new TextBox();
            textBoxMatKhau = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            QuayVeDangNhap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxTenDangNhap = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxDiaChi = new TextBox();
            label10 = new Label();
            textBoxNhapLaiMatKhau = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBoxHo
            // 
            textBoxHo.Location = new Point(191, 70);
            textBoxHo.Margin = new Padding(4, 5, 4, 5);
            textBoxHo.Name = "textBoxHo";
            textBoxHo.Size = new Size(220, 31);
            textBoxHo.TabIndex = 1;
            textBoxHo.KeyPress += textBoxHo_KeyPress;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(639, 70);
            textBoxTen.Margin = new Padding(4, 5, 4, 5);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(265, 31);
            textBoxTen.TabIndex = 2;
            textBoxTen.KeyPress += textBoxTen_KeyPress;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(191, 273);
            textBoxMatKhau.Margin = new Padding(4, 5, 4, 5);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(220, 31);
            textBoxMatKhau.TabIndex = 8;
            textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(191, 395);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(390, 395);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(121, 38);
            button2.TabIndex = 11;
            button2.Text = "Hủy đăng ký";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(599, 402);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 8;
            label4.Text = "Đã có tài khoản?";
            // 
            // QuayVeDangNhap
            // 
            QuayVeDangNhap.Location = new Point(743, 395);
            QuayVeDangNhap.Margin = new Padding(4, 5, 4, 5);
            QuayVeDangNhap.Name = "QuayVeDangNhap";
            QuayVeDangNhap.Size = new Size(163, 38);
            QuayVeDangNhap.TabIndex = 12;
            QuayVeDangNhap.Text = "Đăng nhập ngay";
            QuayVeDangNhap.UseVisualStyleBackColor = true;
            QuayVeDangNhap.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 220);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 10;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 11;
            label2.Text = "Họ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 83);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 12;
            label3.Text = "Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(321, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(358, 45);
            label5.TabIndex = 13;
            label5.Text = "Nhập thông tin đăng ký";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 14;
            label6.Text = "Mật khẩu";
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Location = new Point(639, 207);
            textBoxTenDangNhap.Margin = new Padding(4, 5, 4, 5);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(265, 31);
            textBoxTenDangNhap.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 143);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 17;
            label7.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(476, 143);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 18;
            label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 220);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ";
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(191, 207);
            textBoxDiaChi.Margin = new Padding(4, 5, 4, 5);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(220, 31);
            textBoxDiaChi.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(476, 287);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 25);
            label10.TabIndex = 22;
            label10.Text = "Nhập lại mật khẩu";
            // 
            // textBoxNhapLaiMatKhau
            // 
            textBoxNhapLaiMatKhau.Location = new Point(639, 273);
            textBoxNhapLaiMatKhau.Margin = new Padding(4, 5, 4, 5);
            textBoxNhapLaiMatKhau.Name = "textBoxNhapLaiMatKhau";
            textBoxNhapLaiMatKhau.Size = new Size(265, 31);
            textBoxNhapLaiMatKhau.TabIndex = 9;
            textBoxNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(639, 143);
            dateTimePickerNgaySinh.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(265, 31);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(191, 140);
            radioButtonNam.Margin = new Padding(4, 5, 4, 5);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(75, 29);
            radioButtonNam.TabIndex = 3;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(279, 140);
            radioButtonNu.Margin = new Padding(4, 5, 4, 5);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(61, 29);
            radioButtonNu.TabIndex = 4;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(191, 337);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 29);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Dang_Ky
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 520);
            Controls.Add(checkBox1);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(textBoxNhapLaiMatKhau);
            Controls.Add(label10);
            Controls.Add(textBoxDiaChi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxTenDangNhap);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QuayVeDangNhap);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxTen);
            Controls.Add(textBoxHo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dang_Ky";
            Text = "Dang_Ky";
            FormClosing += Dang_Ky_FormClosing;
            Load += Dang_Ky_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxHo;
        private TextBox textBoxTen;
        private TextBox textBoxMatKhau;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button QuayVeDangNhap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBoxTenDangNhap;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxDiaChi;
        private Label label10;
        private TextBox textBoxNhapLaiMatKhau;
        private DateTimePicker dateTimePickerNgaySinh;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private CheckBox checkBox1;
    }
}