namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            Thoat = new Button();
            DangXuat = new Button();
            pnMatrix = new Panel();
            panel4 = new Panel();
            btnPreviours = new Button();
            btnSun = new Button();
            btnnext = new Button();
            btnSat = new Button();
            btnFri = new Button();
            btnTue = new Button();
            btnWed = new Button();
            btnThu = new Button();
            btnMon = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            nmNotify = new NumericUpDown();
            cbnotify = new CheckBox();
            button1 = new Button();
            HomNay = new Button();
            dtpkDate = new DateTimePicker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 660);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(Thoat);
            panel3.Controls.Add(DangXuat);
            panel3.Controls.Add(pnMatrix);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(4, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 558);
            panel3.TabIndex = 1;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(951, 517);
            Thoat.Margin = new Padding(4, 5, 4, 5);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(140, 42);
            Thoat.TabIndex = 4;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // DangXuat
            // 
            DangXuat.AccessibleDescription = "";
            DangXuat.Location = new Point(951, 467);
            DangXuat.Margin = new Padding(4, 5, 4, 5);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(141, 42);
            DangXuat.TabIndex = 3;
            DangXuat.Text = "Đăng xuất";
            DangXuat.UseVisualStyleBackColor = true;
            DangXuat.Click += DangXuat_Click;
            // 
            // pnMatrix
            // 
            pnMatrix.Location = new Point(126, 77);
            pnMatrix.Name = "pnMatrix";
            pnMatrix.Size = new Size(820, 478);
            pnMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnPreviours);
            panel4.Controls.Add(btnSun);
            panel4.Controls.Add(btnnext);
            panel4.Controls.Add(btnSat);
            panel4.Controls.Add(btnFri);
            panel4.Controls.Add(btnTue);
            panel4.Controls.Add(btnWed);
            panel4.Controls.Add(btnThu);
            panel4.Controls.Add(btnMon);
            panel4.Location = new Point(-4, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(1101, 65);
            panel4.TabIndex = 0;
            // 
            // btnPreviours
            // 
            btnPreviours.Location = new Point(7, 18);
            btnPreviours.Name = "btnPreviours";
            btnPreviours.Size = new Size(119, 47);
            btnPreviours.TabIndex = 8;
            btnPreviours.Text = "Tháng trước ";
            btnPreviours.UseVisualStyleBackColor = true;
            btnPreviours.Click += btnPreviours_Click;
            // 
            // btnSun
            // 
            btnSun.Location = new Point(831, 18);
            btnSun.Name = "btnSun";
            btnSun.Size = new Size(111, 47);
            btnSun.TabIndex = 7;
            btnSun.Text = "CN";
            btnSun.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(956, 18);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(111, 47);
            btnnext.TabIndex = 6;
            btnnext.Text = "Tháng sau ";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnSat
            // 
            btnSat.Location = new Point(714, 18);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(111, 47);
            btnSat.TabIndex = 5;
            btnSat.Text = "Th7";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Location = new Point(597, 18);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(111, 47);
            btnFri.TabIndex = 4;
            btnFri.Text = "Th6";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            btnTue.Location = new Point(246, 18);
            btnTue.Name = "btnTue";
            btnTue.Size = new Size(111, 47);
            btnTue.TabIndex = 3;
            btnTue.Text = "Th3";
            btnTue.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            btnWed.Location = new Point(363, 18);
            btnWed.Name = "btnWed";
            btnWed.Size = new Size(111, 47);
            btnWed.TabIndex = 2;
            btnWed.Text = "Th4";
            btnWed.UseVisualStyleBackColor = true;
            // 
            // btnThu
            // 
            btnThu.Location = new Point(480, 18);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(111, 47);
            btnThu.TabIndex = 1;
            btnThu.Text = "Th5";
            btnThu.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Location = new Point(129, 18);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(111, 47);
            btnMon.TabIndex = 0;
            btnMon.Text = "Th2";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(HomNay);
            panel2.Controls.Add(dtpkDate);
            panel2.Location = new Point(1, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 45);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Controls.Add(nmNotify);
            panel6.Controls.Add(cbnotify);
            panel6.Location = new Point(9, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(319, 37);
            panel6.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 2;
            label1.Text = "Phút";
            // 
            // nmNotify
            // 
            nmNotify.Location = new Point(124, 0);
            nmNotify.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmNotify.Name = "nmNotify";
            nmNotify.Size = new Size(86, 31);
            nmNotify.TabIndex = 1;
            nmNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbnotify
            // 
            cbnotify.AutoSize = true;
            cbnotify.Location = new Point(3, 3);
            cbnotify.Name = "cbnotify";
            cbnotify.Size = new Size(125, 29);
            cbnotify.TabIndex = 0;
            cbnotify.Text = "Thông báo";
            cbnotify.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(927, 5);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(169, 38);
            button1.TabIndex = 2;
            button1.Text = "Thông tin cá nhân";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // HomNay
            // 
            HomNay.Location = new Point(696, 3);
            HomNay.Name = "HomNay";
            HomNay.Size = new Size(104, 42);
            HomNay.TabIndex = 1;
            HomNay.Text = "Hôm nay ";
            HomNay.UseVisualStyleBackColor = true;
            HomNay.Click += button1_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpkDate.Location = new Point(373, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(300, 31);
            dtpkDate.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1111, 675);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calendar";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel pnMatrix;
        private Panel panel4;
        private Panel panel2;
        private DateTimePicker dtpkDate;
        private Button btnSun;
        private Button btnnext;
        private Button btnSat;
        private Button btnFri;
        private Button btnTue;
        private Button btnWed;
        private Button btnThu;
        private Button btnMon;
        private Button HomNay;
        private Button btnPreviours;
        private Panel panel6;
        private CheckBox cbnotify;
        private NumericUpDown nmNotify;
        private Button Thoat;
        private Button DangXuat;
        private Label label1;
        private Button button1;
    }
}