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
            SuspendLayout();
            // 
            // textBoxHo
            // 
            textBoxHo.Location = new Point(134, 42);
            textBoxHo.Name = "textBoxHo";
            textBoxHo.Size = new Size(155, 23);
            textBoxHo.TabIndex = 1;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(447, 42);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(187, 23);
            textBoxTen.TabIndex = 2;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(134, 164);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(155, 23);
            textBoxMatKhau.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(134, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 237);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 11;
            button2.Text = "Hủy đăng ký";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 245);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 8;
            label4.Text = "Đã có tài khoản?";
            // 
            // QuayVeDangNhap
            // 
            QuayVeDangNhap.Location = new Point(502, 237);
            QuayVeDangNhap.Name = "QuayVeDangNhap";
            QuayVeDangNhap.Size = new Size(114, 23);
            QuayVeDangNhap.TabIndex = 12;
            QuayVeDangNhap.Text = "Đăng nhập ngay";
            QuayVeDangNhap.UseVisualStyleBackColor = true;
            QuayVeDangNhap.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 132);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 10;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 50);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 11;
            label2.Text = "Họ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 50);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 12;
            label3.Text = "Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(240, -1);
            label5.Name = "label5";
            label5.Size = new Size(229, 30);
            label5.TabIndex = 13;
            label5.Text = "Nhập thông tin đăng kí";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 172);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Mật khẩu";
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Location = new Point(447, 124);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(187, 23);
            textBoxTenDangNhap.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 86);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 17;
            label7.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 86);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 18;
            label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 132);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ";
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(134, 124);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(155, 23);
            textBoxDiaChi.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(333, 172);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 22;
            label10.Text = "Nhập lại mật khẩu";
            // 
            // textBoxNhapLaiMatKhau
            // 
            textBoxNhapLaiMatKhau.Location = new Point(447, 164);
            textBoxNhapLaiMatKhau.Name = "textBoxNhapLaiMatKhau";
            textBoxNhapLaiMatKhau.Size = new Size(187, 23);
            textBoxNhapLaiMatKhau.TabIndex = 9;
            //textBoxNhapLaiMatKhau.KeyPress += textBoxNhapLaiMatKhau_KeyPress;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(447, 86);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(187, 23);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(134, 84);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(51, 19);
            radioButtonNam.TabIndex = 3;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(195, 84);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(41, 19);
            radioButtonNu.TabIndex = 4;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // Dang_Ky
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 312);
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
    }
}