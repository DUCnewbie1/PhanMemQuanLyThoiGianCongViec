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
            panel5 = new Panel();
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
            LabelMunute = new Label();
            nmNotify = new NumericUpDown();
            cbnotify = new CheckBox();
            button1 = new Button();
            dtpk = new DateTimePicker();
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
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 32);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 335);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Location = new Point(88, 46);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 287);
            panel5.TabIndex = 1;
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
            btnPreviours.Location = new Point(3, 9);
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
            btnSun.Location = new Point(586, 9);
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
            btnnext.Location = new Point(668, 10);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(78, 28);
            btnnext.TabIndex = 6;
            btnnext.Text = "Tháng sau ";
            btnnext.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            btnSat.Location = new Point(503, 9);
            btnSat.Margin = new Padding(2);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(78, 28);
            btnSat.TabIndex = 5;
            btnSat.Text = "Th7";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Location = new Point(421, 10);
            btnFri.Margin = new Padding(2);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(78, 28);
            btnFri.TabIndex = 4;
            btnFri.Text = "Th6";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            btnTue.Location = new Point(173, 10);
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
            btnWed.Location = new Point(256, 10);
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
            btnThu.Location = new Point(338, 10);
            btnThu.Margin = new Padding(2);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(78, 28);
            btnThu.TabIndex = 1;
            btnThu.Text = "Th5";
            btnThu.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Location = new Point(90, 10);
            btnMon.Margin = new Padding(2);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(78, 28);
            btnMon.TabIndex = 0;
            btnMon.Text = "Th2";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dtpk);
            panel2.Location = new Point(1, 5);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 27);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(LabelMunute);
            panel6.Controls.Add(nmNotify);
            panel6.Controls.Add(cbnotify);
            panel6.Location = new Point(6, 3);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 22);
            panel6.TabIndex = 2;
            // 
            // LabelMunute
            // 
            LabelMunute.AutoSize = true;
            LabelMunute.Location = new Point(131, 3);
            LabelMunute.Margin = new Padding(2, 0, 2, 0);
            LabelMunute.Name = "LabelMunute";
            LabelMunute.Size = new Size(35, 15);
            LabelMunute.TabIndex = 7;
            LabelMunute.Text = "phút ";
            LabelMunute.Click += lbTo_Click;
            // 
            // nmNotify
            // 
            nmNotify.Location = new Point(67, 2);
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
            cbnotify.Size = new Size(59, 19);
            cbnotify.TabIndex = 0;
            cbnotify.Text = "Notify";
            cbnotify.UseVisualStyleBackColor = true;
            cbnotify.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(487, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(73, 25);
            button1.TabIndex = 1;
            button1.Text = "Hôm nay ";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpk
            // 
            dtpk.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpk.Location = new Point(261, 3);
            dtpk.Margin = new Padding(2);
            dtpk.Name = "dtpk";
            dtpk.Size = new Size(211, 23);
            dtpk.TabIndex = 0;
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
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private DateTimePicker dtpk;
        private Button btnSun;
        private Button btnnext;
        private Button btnSat;
        private Button btnFri;
        private Button btnTue;
        private Button btnWed;
        private Button btnThu;
        private Button btnMon;
        private Button button1;
        private Button btnPreviours;
        private Panel panel6;
        private CheckBox cbnotify;
        private NumericUpDown nmNotify;
        private Label LabelMunute;
    }
}