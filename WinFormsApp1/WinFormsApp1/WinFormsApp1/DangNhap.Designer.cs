﻿namespace WinFormsApp1
{
    partial class DangNhap
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
            Thoat = new Button();
            txt_TK = new TextBox();
            txt_MK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DN = new Button();
            DangKi = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // Thoat
            // 
            Thoat.Location = new Point(253, 126);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(75, 23);
            Thoat.TabIndex = 1;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // txt_TK
            // 
            txt_TK.Location = new Point(147, 29);
            txt_TK.Name = "txt_TK";
            txt_TK.Size = new Size(181, 23);
            txt_TK.TabIndex = 2;
            txt_TK.TextChanged += txt_TK_TextChanged;
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(147, 72);
            txt_MK.Name = "txt_MK";
            txt_MK.ShortcutsEnabled = false;
            txt_MK.Size = new Size(181, 23);
            txt_MK.TabIndex = 3;
            txt_MK.UseSystemPasswordChar = true;
            txt_MK.TextChanged += txt_MK_TextChanged;
            txt_MK.KeyPress += txt_MK_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // DN
            // 
            DN.Location = new Point(147, 126);
            DN.Name = "DN";
            DN.Size = new Size(75, 23);
            DN.TabIndex = 6;
            DN.Text = "Đăng nhập";
            DN.UseVisualStyleBackColor = true;
            DN.Click += DN_Click;
            // 
            // DangKi
            // 
            DangKi.Location = new Point(336, 178);
            DangKi.Name = "DangKi";
            DangKi.RightToLeft = RightToLeft.No;
            DangKi.Size = new Size(88, 23);
            DangKi.TabIndex = 7;
            DangKi.Text = "Đăng ký ngay";
            DangKi.UseVisualStyleBackColor = true;
            DangKi.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(201, 182);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 8;
            label3.Text = "Bạn chưa có tài khoản?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(147, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(201, 167);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 206);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(DangKi);
            Controls.Add(DN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MK);
            Controls.Add(txt_TK);
            Controls.Add(Thoat);
            Location = new Point(282, 151);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            FormClosing += DangNhap_FormClosing;
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Thoat;
        private TextBox txt_TK;
        private TextBox txt_MK;
        private Label label1;
        private Label label2;
        private Button DN;
        private Button DangKi;
        private Label label3;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}