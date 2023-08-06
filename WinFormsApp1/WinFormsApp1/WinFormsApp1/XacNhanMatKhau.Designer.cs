namespace WinFormsApp1
{
    partial class XacNhanMatKhau
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
            label1 = new Label();
            XN = new Button();
            NhapMatKhau = new TextBox();
            button2 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 107);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập Mật Khẩu";
            // 
            // XN
            // 
            XN.Location = new Point(201, 192);
            XN.Name = "XN";
            XN.Size = new Size(111, 47);
            XN.TabIndex = 1;
            XN.Text = "Xác Nhận";
            XN.UseVisualStyleBackColor = true;

            // 
            // NhapMatKhau
            // 
            NhapMatKhau.Location = new Point(201, 93);
            NhapMatKhau.Name = "NhapMatKhau";
            NhapMatKhau.Size = new Size(261, 31);
            NhapMatKhau.TabIndex = 2;
            NhapMatKhau.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Location = new Point(350, 192);
            button2.Name = "button2";
            button2.Size = new Size(111, 47);
            button2.TabIndex = 3;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(187, 15);
            label2.Name = "label2";
            label2.Size = new Size(322, 41);
            label2.TabIndex = 4;
            label2.Text = "Xác Nhận Lại Mật Khẩu";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(201, 157);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // XacNhanMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 300);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(NhapMatKhau);
            Controls.Add(XN);
            Controls.Add(label1);
            Name = "XacNhanMatKhau";
            Text = "XacNhanMatKhau";
            Load += XacNhanMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button XN;
        private TextBox NhapMatKhau;
        private Button button2;
        private Label label2;
        private CheckBox checkBox1;
    }
}