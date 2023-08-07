namespace WinFormsApp1
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            panel1 = new Panel();
            pnJob = new Panel();
            btnPreviousDay = new Button();
            btnNextDay = new Button();
            dtpkDate = new DateTimePicker();
            pnlJob = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            lbtime = new Label();
            lbStatus = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            LbTensk = new Label();
            menuStrip1 = new MenuStrip();
            mnAddJob = new ToolStripMenuItem();
            mnsToday = new ToolStripMenuItem();
            panel1.SuspendLayout();
            pnJob.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnJob);
            panel1.Controls.Add(pnlJob);
            panel1.Location = new Point(2, 21);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 353);
            panel1.TabIndex = 0;
            // 
            // pnJob
            // 
            pnJob.BackColor = Color.LightGray;
            pnJob.Controls.Add(btnPreviousDay);
            pnJob.Controls.Add(btnNextDay);
            pnJob.Controls.Add(dtpkDate);
            pnJob.Location = new Point(-2, 0);
            pnJob.Margin = new Padding(2);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(903, 34);
            pnJob.TabIndex = 1;
            // 
            // btnPreviousDay
            // 
            btnPreviousDay.BackColor = Color.DarkGray;
            btnPreviousDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviousDay.Location = new Point(234, 2);
            btnPreviousDay.Margin = new Padding(2);
            btnPreviousDay.Name = "btnPreviousDay";
            btnPreviousDay.Size = new Size(78, 27);
            btnPreviousDay.TabIndex = 3;
            btnPreviousDay.Text = "Hôm qua ";
            btnPreviousDay.UseVisualStyleBackColor = false;
            btnPreviousDay.Click += btnPreviousDay_Click;
            // 
            // btnNextDay
            // 
            btnNextDay.BackColor = Color.DarkGray;
            btnNextDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextDay.Location = new Point(583, 3);
            btnNextDay.Margin = new Padding(2);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(78, 27);
            btnNextDay.TabIndex = 2;
            btnNextDay.Text = "Ngày mai ";
            btnNextDay.UseVisualStyleBackColor = false;
            btnNextDay.Click += btnNextDay_Click_1;
            // 
            // dtpkDate
            // 
            dtpkDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkDate.Location = new Point(339, 7);
            dtpkDate.Margin = new Padding(2);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(213, 23);
            dtpkDate.TabIndex = 1;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged_1;
            // 
            // pnlJob
            // 
            pnlJob.BackColor = Color.Transparent;
            pnlJob.Location = new Point(-4, 71);
            pnlJob.Margin = new Padding(2);
            pnlJob.Name = "pnlJob";
            pnlJob.Size = new Size(906, 268);
            pnlJob.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lbStatus);
            panel2.Location = new Point(2, 55);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 38);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(lbtime);
            panel4.Location = new Point(378, -1);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 38);
            panel4.TabIndex = 4;
            // 
            // lbtime
            // 
            lbtime.AutoSize = true;
            lbtime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbtime.Location = new Point(16, 10);
            lbtime.Margin = new Padding(2, 0, 2, 0);
            lbtime.Name = "lbtime";
            lbtime.Size = new Size(126, 19);
            lbtime.TabIndex = 1;
            lbtime.Text = "Thời gian sự kiện ";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbStatus.Location = new Point(632, 9);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(116, 19);
            lbStatus.TabIndex = 2;
            lbStatus.Text = "Chọn trang thái ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(LbTensk);
            panel3.Location = new Point(2, 55);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 38);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(-2, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 38);
            panel5.TabIndex = 1;
            // 
            // LbTensk
            // 
            LbTensk.AutoSize = true;
            LbTensk.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbTensk.Location = new Point(38, 9);
            LbTensk.Margin = new Padding(2, 0, 2, 0);
            LbTensk.Name = "LbTensk";
            LbTensk.Size = new Size(87, 19);
            LbTensk.TabIndex = 0;
            LbTensk.Text = "Tên sự kiện ";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnAddJob, mnsToday });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(906, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnAddJob
            // 
            mnAddJob.Name = "mnAddJob";
            mnAddJob.Size = new Size(76, 22);
            mnAddJob.Text = "Thêm việc ";
            mnAddJob.Click += mnAddJob_Click;
            // 
            // mnsToday
            // 
            mnsToday.Name = "mnsToday";
            mnsToday.Size = new Size(71, 22);
            mnsToday.Text = "Hôm nay ";
            mnsToday.Click += mnsToday_Click;
            // 
            // DailyPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(906, 376);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "DailyPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch trong ngày ";
            panel1.ResumeLayout(false);
            pnJob.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpkDate;
        private Panel pnlJob;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnAddJob;
        private ToolStripMenuItem mnsToday;
        private Panel pnJob;
        private Button btnPreviousDay;
        private Button btnNextDay;
        private Panel panel2;
        private Panel panel4;
        private Label lbtime;
        private Panel panel3;
        private Label LbTensk;
        private Label lbStatus;
        private Panel panel5;
    }
}