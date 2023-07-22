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
            panel1 = new Panel();
            pnJob = new Panel();
            btnPreviousDay = new Button();
            btnNextDay = new Button();
            dtpkDate = new DateTimePicker();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            mnAddJob = new ToolStripMenuItem();
            mnsToday = new ToolStripMenuItem();
            panel1.SuspendLayout();
            pnJob.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnJob);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 21);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 353);
            panel1.TabIndex = 0;
            // 
            // pnJob
            // 
            pnJob.Controls.Add(btnPreviousDay);
            pnJob.Controls.Add(btnNextDay);
            pnJob.Controls.Add(dtpkDate);
            pnJob.Location = new Point(1, 1);
            pnJob.Margin = new Padding(2, 2, 2, 2);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(712, 31);
            pnJob.TabIndex = 1;
            // 
            // btnPreviousDay
            // 
            btnPreviousDay.Location = new Point(154, 3);
            btnPreviousDay.Margin = new Padding(2, 2, 2, 2);
            btnPreviousDay.Name = "btnPreviousDay";
            btnPreviousDay.Size = new Size(78, 25);
            btnPreviousDay.TabIndex = 3;
            btnPreviousDay.Text = "Hôm qua ";
            btnPreviousDay.UseVisualStyleBackColor = true;
            // 
            // btnNextDay
            // 
            btnNextDay.Location = new Point(482, 3);
            btnNextDay.Margin = new Padding(2, 2, 2, 2);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(78, 26);
            btnNextDay.TabIndex = 2;
            btnNextDay.Text = "Ngày mai ";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Click += button1_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(250, 4);
            dtpkDate.Margin = new Padding(2, 2, 2, 2);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(211, 23);
            dtpkDate.TabIndex = 1;
            dtpkDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 35);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 335);
            panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnAddJob, mnsToday });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(727, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnAddJob
            // 
            mnAddJob.Name = "mnAddJob";
            mnAddJob.Size = new Size(76, 22);
            mnAddJob.Text = "Thêm việc ";
            // 
            // mnsToday
            // 
            mnsToday.Name = "mnsToday";
            mnsToday.Size = new Size(71, 22);
            mnsToday.Text = "Hôm nay ";
            // 
            // DailyPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 376);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "DailyPlan";
            Text = "Lịch trong ngày ";
            panel1.ResumeLayout(false);
            pnJob.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpkDate;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnAddJob;
        private ToolStripMenuItem mnsToday;
        private Panel pnJob;
        private Button btnPreviousDay;
        private Button btnNextDay;
    }
}