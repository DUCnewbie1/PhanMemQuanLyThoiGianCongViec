namespace WinFormsApp1
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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Thoat
            // 
            Thoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Thoat.Location = new Point(256, 139);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(75, 23);
            Thoat.TabIndex = 1;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // txt_TK
            // 
            txt_TK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_TK.Location = new Point(141, 33);
            txt_TK.Name = "txt_TK";
            txt_TK.Size = new Size(190, 23);
            txt_TK.TabIndex = 2;
            txt_TK.TextChanged += txt_TK_TextChanged;
            // 
            // txt_MK
            // 
            txt_MK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_MK.Location = new Point(141, 73);
            txt_MK.Name = "txt_MK";
            txt_MK.ShortcutsEnabled = false;
            txt_MK.Size = new Size(190, 23);
            txt_MK.TabIndex = 3;
            txt_MK.UseSystemPasswordChar = true;
            txt_MK.TextChanged += txt_MK_TextChanged;
            txt_MK.KeyPress += txt_MK_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(67, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(67, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // DN
            // 
            DN.Location = new Point(141, 139);
            DN.Name = "DN";
            DN.Size = new Size(75, 23);
            DN.TabIndex = 6;
            DN.Text = "Đăng nhập";
            DN.UseVisualStyleBackColor = true;
            DN.Click += DN_Click;
            // 
            // DangKi
            // 
            DangKi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DangKi.Location = new Point(276, 178);
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
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(141, 186);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 8;
            label3.Text = "Bạn chưa có tài khoản?";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(141, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(141, 171);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txt_TK);
            panel1.Controls.Add(Thoat);
            panel1.Controls.Add(DN);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(DangKi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txt_MK);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 206);
            panel1.TabIndex = 11;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 206);
            Controls.Add(panel1);
            Location = new Point(282, 151);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            FormClosing += DangNhap_FormClosing;
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}