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
            button1 = new Button();
            NhapMatKhau = new TextBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập Mật Khẩu";
            // 
            // button1
            // 
            button1.Location = new Point(141, 115);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 28);
            button1.TabIndex = 1;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NhapMatKhau
            // 
            NhapMatKhau.Location = new Point(141, 73);
            NhapMatKhau.Margin = new Padding(2, 2, 2, 2);
            NhapMatKhau.Name = "NhapMatKhau";
            NhapMatKhau.Size = new Size(184, 23);
            NhapMatKhau.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(245, 115);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 28);
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
            label2.Location = new Point(131, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 4;
            label2.Text = "Xác Nhận Lại Mật Khẩu";
            // 
            // XacNhanMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 180);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(NhapMatKhau);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "XacNhanMatKhau";
            Text = "XacNhanMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox NhapMatKhau;
        private Button button2;
        private Label label2;
    }
}