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
            Thoat = new Button();
            DangXuat = new Button();
            panel6 = new Panel();
            nmNotify = new NumericUpDown();
            cbnotify = new CheckBox();
            HomNay = new Button();
            dtpkDate = new DateTimePicker();
            label1 = new Label();
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
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 396);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnMatrix);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 32);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 335);
            panel3.TabIndex = 1;
            // 
            // pnMatrix
            // 
            pnMatrix.Location = new Point(88, 46);
            pnMatrix.Margin = new Padding(2);
            pnMatrix.Name = "pnMatrix";
            pnMatrix.Size = new Size(574, 287);
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
            panel4.Location = new Point(-3, 4);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 39);
            panel4.TabIndex = 0;
            // 
            // btnPreviours
            // 
            btnPreviours.Location = new Point(5, 11);
            btnPreviours.Margin = new Padding(2);
            btnPreviours.Name = "btnPreviours";
            btnPreviours.Size = new Size(83, 28);
            btnPreviours.TabIndex = 8;
            btnPreviours.Text = "Tháng trước ";
            btnPreviours.UseVisualStyleBackColor = true;
            btnPreviours.Click += btnPreviours_Click;
            // 
            // btnSun
            // 
            btnSun.Location = new Point(582, 11);
            btnSun.Margin = new Padding(2);
            btnSun.Name = "btnSun";
            btnSun.Size = new Size(78, 28);
            btnSun.TabIndex = 7;
            btnSun.Text = "CN";
            btnSun.UseVisualStyleBackColor = true;
            btnSun.Click += button9_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(669, 11);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(78, 28);
            btnnext.TabIndex = 6;
            btnnext.Text = "Tháng sau ";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnSat
            // 
            btnSat.Location = new Point(500, 11);
            btnSat.Margin = new Padding(2);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(78, 28);
            btnSat.TabIndex = 5;
            btnSat.Text = "Th7";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Location = new Point(418, 11);
            btnFri.Margin = new Padding(2);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(78, 28);
            btnFri.TabIndex = 4;
            btnFri.Text = "Th6";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            btnTue.Location = new Point(172, 11);
            btnTue.Margin = new Padding(2);
            btnTue.Name = "btnTue";
            btnTue.Size = new Size(78, 28);
            btnTue.TabIndex = 3;
            btnTue.Text = "Th3";
            btnTue.UseVisualStyleBackColor = true;
            btnTue.Click += button5_Click;
            // 
            // btnWed
            // 
            btnWed.Location = new Point(254, 11);
            btnWed.Margin = new Padding(2);
            btnWed.Name = "btnWed";
            btnWed.Size = new Size(78, 28);
            btnWed.TabIndex = 2;
            btnWed.Text = "Th4";
            btnWed.UseVisualStyleBackColor = true;
            btnWed.Click += button4_Click;
            // 
            // btnThu
            // 
            btnThu.Location = new Point(336, 11);
            btnThu.Margin = new Padding(2);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(78, 28);
            btnThu.TabIndex = 1;
            btnThu.Text = "Th5";
            btnThu.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Location = new Point(90, 11);
            btnMon.Margin = new Padding(2);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(78, 28);
            btnMon.TabIndex = 0;
            btnMon.Text = "Th2";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(Thoat);
            panel2.Controls.Add(DangXuat);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(HomNay);
            panel2.Controls.Add(dtpkDate);
            panel2.Location = new Point(1, 5);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 27);
            panel2.TabIndex = 0;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(692, 3);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(75, 25);
            Thoat.TabIndex = 4;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // DangXuat
            // 
            DangXuat.AccessibleDescription = "";
            DangXuat.Location = new Point(591, 3);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(95, 25);
            DangXuat.TabIndex = 3;
            DangXuat.Text = "Đăng xuất";
            DangXuat.UseVisualStyleBackColor = true;
            DangXuat.Click += DangXuat_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Controls.Add(nmNotify);
            panel6.Controls.Add(cbnotify);
            panel6.Location = new Point(6, 3);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 22);
            panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            nmNotify.Location = new Point(87, 0);
            nmNotify.Margin = new Padding(2);
            nmNotify.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmNotify.Name = "nmNotify";
            nmNotify.Size = new Size(60, 23);
            nmNotify.TabIndex = 1;
            nmNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbnotify
            // 
            cbnotify.AutoSize = true;
            cbnotify.Location = new Point(2, 2);
            cbnotify.Margin = new Padding(2);
            cbnotify.Name = "cbnotify";
            cbnotify.Size = new Size(83, 19);
            cbnotify.TabIndex = 0;
            cbnotify.Text = "Thông báo";
            cbnotify.UseVisualStyleBackColor = true;
            cbnotify.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // HomNay
            // 
            HomNay.Location = new Point(487, 2);
            HomNay.Margin = new Padding(2);
            HomNay.Name = "HomNay";
            HomNay.Size = new Size(73, 25);
            HomNay.TabIndex = 1;
            HomNay.Text = "Hôm nay ";
            HomNay.UseVisualStyleBackColor = true;
            HomNay.Click += button1_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpkDate.Location = new Point(261, 3);
            dtpkDate.Margin = new Padding(2);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(211, 23);
            dtpkDate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 5);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Phút";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(778, 405);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Calendar";
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
    }
}