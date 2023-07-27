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
            textBox_ChecknewMK = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 75);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 110);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập mật khẩu mới ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 146);
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
            // textBox_ChecknewMK
            // 
            textBox_ChecknewMK.Location = new Point(226, 143);
            textBox_ChecknewMK.Name = "textBox_ChecknewMK";
            textBox_ChecknewMK.Size = new Size(181, 23);
            textBox_ChecknewMK.TabIndex = 5;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 248);
            Controls.Add(textBox_ChecknewMK);
            Controls.Add(textBox_newMK);
            Controls.Add(textBox_TK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_TK;
        private TextBox textBox_newMK;
        private TextBox textBox_ChecknewMK;
    }
}