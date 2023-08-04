namespace WinFormsApp1
{
    partial class QuenMatKhau
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
            label2 = new Label();
            label3 = new Label();
            textBox_TK = new TextBox();
            textBox_newMK = new TextBox();
            textBox_CheckPass = new TextBox();
            ChangePass = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 75);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 110);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập mật khẩu mới ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(226, 67);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(181, 23);
            textBox_TK.TabIndex = 3;
            // 
            // textBox_newMK
            // 
            textBox_newMK.Location = new Point(226, 102);
            textBox_newMK.Name = "textBox_newMK";
            textBox_newMK.Size = new Size(181, 23);
            textBox_newMK.TabIndex = 4;
            // 
            // textBox_CheckPass
            // 
            textBox_CheckPass.Location = new Point(226, 143);
            textBox_CheckPass.Name = "textBox_CheckPass";
            textBox_CheckPass.Size = new Size(181, 23);
            textBox_CheckPass.TabIndex = 5;
            // 
            // ChangePass
            // 
            ChangePass.Location = new Point(226, 182);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(180, 23);
            ChangePass.TabIndex = 6;
            ChangePass.Text = "Đổi mật khẩu";
            ChangePass.UseVisualStyleBackColor = true;
            ChangePass.Click += ChangePass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(226, 20);
            label4.Name = "label4";
            label4.Size = new Size(160, 30);
            label4.TabIndex = 7;
            label4.Text = "Quên Mật Khẩu";
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 248);
            Controls.Add(label4);
            Controls.Add(ChangePass);
            Controls.Add(textBox_CheckPass);
            Controls.Add(textBox_newMK);
            Controls.Add(textBox_TK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            FormClosing += QuenMatKhau_FormClosing;
            FormClosed += QuenMatKhau_FormClosed;
            Load += QuenMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_TK;
        private TextBox textBox_newMK;
        private TextBox textBox_CheckPass;
        private Button ChangePass;
        private Label label4;
    }
}