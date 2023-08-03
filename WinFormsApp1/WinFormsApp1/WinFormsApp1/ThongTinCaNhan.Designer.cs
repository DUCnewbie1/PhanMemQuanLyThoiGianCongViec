namespace WinFormsApp1
{
    partial class ThongTinCaNhan
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
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ho = new TextBox();
            ten = new TextBox();
            diaChi = new TextBox();
            panel1 = new Panel();
            Nu = new RadioButton();
            Nam = new RadioButton();
            ngaySinh = new DateTimePicker();
            dataGridView1 = new DataGridView();
            luu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(453, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Cá Nhân";
            // 
            // button1
            // 
            button1.Location = new Point(1059, 485);
            button1.Name = "button1";
            button1.Size = new Size(111, 53);
            button1.TabIndex = 8;
            button1.Text = "Trở Lại ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(934, 485);
            button2.Name = "button2";
            button2.Size = new Size(111, 53);
            button2.TabIndex = 7;
            button2.Text = "Chỉnh sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 3;
            label2.Text = "Họ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 50);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 5;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 127);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 6;
            label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 220);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 7;
            label6.Text = "Địa Chỉ";
            // 
            // ho
            // 
            ho.Enabled = false;
            ho.Location = new Point(100, 37);
            ho.Name = "ho";
            ho.Size = new Size(205, 31);
            ho.TabIndex = 1;
            // 
            // ten
            // 
            ten.Enabled = false;
            ten.Location = new Point(577, 40);
            ten.Name = "ten";
            ten.Size = new Size(300, 31);
            ten.TabIndex = 2;
            // 
            // diaChi
            // 
            diaChi.Enabled = false;
            diaChi.Location = new Point(100, 207);
            diaChi.Name = "diaChi";
            diaChi.Size = new Size(205, 31);
            diaChi.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(Nu);
            panel1.Controls.Add(Nam);
            panel1.Controls.Add(ngaySinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ho);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ten);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(diaChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(133, 198);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 278);
            panel1.TabIndex = 10;
            // 
            // Nu
            // 
            Nu.AutoSize = true;
            Nu.Enabled = false;
            Nu.Location = new Point(181, 127);
            Nu.Name = "Nu";
            Nu.Size = new Size(61, 29);
            Nu.TabIndex = 10;
            Nu.TabStop = true;
            Nu.Text = "Nữ";
            Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            Nam.AutoSize = true;
            Nam.Enabled = false;
            Nam.Location = new Point(100, 127);
            Nam.Name = "Nam";
            Nam.Size = new Size(75, 29);
            Nam.TabIndex = 9;
            Nam.TabStop = true;
            Nam.Text = "Nam";
            Nam.UseVisualStyleBackColor = true;
            // 
            // ngaySinh
            // 
            ngaySinh.Enabled = false;
            ngaySinh.Location = new Point(577, 130);
            ngaySinh.Name = "ngaySinh";
            ngaySinh.Size = new Size(300, 31);
            ngaySinh.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1184, 127);
            dataGridView1.TabIndex = 11;
            // 
            // luu
            // 
            luu.Enabled = false;
            luu.Location = new Point(793, 485);
            luu.Name = "luu";
            luu.Size = new Size(111, 53);
            luu.TabIndex = 12;
            luu.Text = "Lưu ";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 548);
            Controls.Add(luu);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ThongTinCaNhan";
            Text = "ThongTinCaNhan";
            FormClosing += ThongTinCaNhan_FormClosing;
            Load += ThongTinCaNhan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ho;
        private TextBox ten;
        private TextBox diaChi;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button luu;
        private RadioButton Nu;
        private RadioButton Nam;
        private DateTimePicker ngaySinh;
    }
}