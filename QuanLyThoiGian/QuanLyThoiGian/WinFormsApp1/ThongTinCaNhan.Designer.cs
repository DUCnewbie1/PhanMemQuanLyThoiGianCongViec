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
            textBoxHo = new TextBox();
            textBoxTen = new TextBox();
            textBoxDiaChi = new TextBox();
            panel1 = new Panel();
            NgaySinh = new TextBox();
            Nu = new RadioButton();
            Nam = new RadioButton();
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
            label1.Location = new Point(317, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Cá Nhân";
            // 
            // button1
            // 
            button1.Location = new Point(741, 291);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 32);
            button1.TabIndex = 8;
            button1.Text = "Trở Lại ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(654, 291);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 32);
            button2.TabIndex = 7;
            button2.Text = "Chỉnh sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "Họ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 132);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 7;
            label6.Text = "Địa Chỉ";
            // 
            // textBoxHo
            // 
            textBoxHo.Enabled = false;
            textBoxHo.Location = new Point(70, 22);
            textBoxHo.Margin = new Padding(2);
            textBoxHo.Name = "textBoxHo";
            textBoxHo.Size = new Size(145, 23);
            textBoxHo.TabIndex = 1;
            textBoxHo.TextChanged += textBoxHo_TextChanged;
            // 
            // textBoxTen
            // 
            textBoxTen.Enabled = false;
            textBoxTen.Location = new Point(404, 22);
            textBoxTen.Margin = new Padding(2);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(211, 23);
            textBoxTen.TabIndex = 2;
            textBoxTen.TextChanged += textBoxTen_TextChanged;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Location = new Point(70, 124);
            textBoxDiaChi.Margin = new Padding(2);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(145, 23);
            textBoxDiaChi.TabIndex = 5;
            textBoxDiaChi.TextChanged += textBoxDiaChi_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(NgaySinh);
            panel1.Controls.Add(Nu);
            panel1.Controls.Add(Nam);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxHo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxTen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxDiaChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(93, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 167);
            panel1.TabIndex = 10;
            // 
            // NgaySinh
            // 
            NgaySinh.Enabled = false;
            NgaySinh.Location = new Point(404, 72);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(211, 23);
            NgaySinh.TabIndex = 11;
            // 
            // Nu
            // 
            Nu.AutoSize = true;
            Nu.Enabled = false;
            Nu.Location = new Point(127, 76);
            Nu.Margin = new Padding(2);
            Nu.Name = "Nu";
            Nu.Size = new Size(41, 19);
            Nu.TabIndex = 10;
            Nu.TabStop = true;
            Nu.Text = "Nữ";
            Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            Nam.AutoSize = true;
            Nam.Enabled = false;
            Nam.Location = new Point(70, 76);
            Nam.Margin = new Padding(2);
            Nam.Name = "Nam";
            Nam.Size = new Size(51, 19);
            Nam.TabIndex = 9;
            Nam.TabStop = true;
            Nam.Text = "Nam";
            Nam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(829, 76);
            dataGridView1.TabIndex = 11;
            // 
            // luu
            // 
            luu.Enabled = false;
            luu.Location = new Point(555, 291);
            luu.Margin = new Padding(2);
            luu.Name = "luu";
            luu.Size = new Size(78, 32);
            luu.TabIndex = 12;
            luu.Text = "Lưu ";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 329);
            Controls.Add(luu);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private TextBox textBoxHo;
        private TextBox textBoxTen;
        private TextBox textBoxDiaChi;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button luu;
        private RadioButton Nu;
        private RadioButton Nam;
        private TextBox NgaySinh;
    }
}