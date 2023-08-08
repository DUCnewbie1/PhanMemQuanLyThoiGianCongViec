namespace WinFormsApp1
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            cbStatus = new ComboBox();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nmToMinute = new NumericUpDown();
            nmToHours = new NumericUpDown();
            label1 = new Label();
            nmFromMinute = new NumericUpDown();
            nmFromHours = new NumericUpDown();
            txbJob = new TextBox();
            ckbDone = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txbJob);
            panel1.Controls.Add(ckbDone);
            panel1.Location = new Point(5, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 58);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1298, 8);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 33);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1213, 8);
            btnEdit.Margin = new Padding(5, 6, 5, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Lưu ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(1020, 8);
            cbStatus.Margin = new Padding(5, 6, 5, 6);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(183, 33);
            cbStatus.TabIndex = 3;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(nmToMinute);
            panel2.Controls.Add(nmToHours);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nmFromMinute);
            panel2.Controls.Add(nmFromHours);
            panel2.Location = new Point(495, 0);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 58);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(351, 13);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 8;
            label5.Text = "giờ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(179, 13);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 7;
            label4.Text = "phút";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(466, 13);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 6;
            label3.Text = "phút ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(64, 13);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 5;
            label2.Text = "giờ ";
            // 
            // nmToMinute
            // 
            nmToMinute.Location = new Point(396, 8);
            nmToMinute.Margin = new Padding(5, 6, 5, 6);
            nmToMinute.Name = "nmToMinute";
            nmToMinute.Size = new Size(62, 31);
            nmToMinute.TabIndex = 4;
            // 
            // nmToHours
            // 
            nmToHours.Location = new Point(281, 8);
            nmToHours.Margin = new Padding(5, 6, 5, 6);
            nmToHours.Name = "nmToHours";
            nmToHours.Size = new Size(62, 31);
            nmToHours.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 2;
            label1.Text = "Đến";
            // 
            // nmFromMinute
            // 
            nmFromMinute.Location = new Point(109, 8);
            nmFromMinute.Margin = new Padding(5, 6, 5, 6);
            nmFromMinute.Name = "nmFromMinute";
            nmFromMinute.Size = new Size(62, 31);
            nmFromMinute.TabIndex = 1;
            nmFromMinute.ValueChanged += nmFromMinute_ValueChanged;
            // 
            // nmFromHours
            // 
            nmFromHours.Location = new Point(0, 8);
            nmFromHours.Margin = new Padding(5, 6, 5, 6);
            nmFromHours.Name = "nmFromHours";
            nmFromHours.Size = new Size(62, 31);
            nmFromHours.TabIndex = 0;
            nmFromHours.ValueChanged += nmFromHours_ValueChanged;
            // 
            // txbJob
            // 
            txbJob.Location = new Point(42, 7);
            txbJob.Margin = new Padding(5, 6, 5, 6);
            txbJob.Name = "txbJob";
            txbJob.Size = new Size(443, 31);
            txbJob.TabIndex = 1;
//            txbJob.TextChanged += txbJob_TextChanged;
            // 
            // ckbDone
            // 
            ckbDone.AutoSize = true;
            ckbDone.Location = new Point(10, 13);
            ckbDone.Margin = new Padding(5, 6, 5, 6);
            ckbDone.Name = "ckbDone";
            ckbDone.Size = new Size(22, 21);
            ckbDone.TabIndex = 0;
            ckbDone.UseVisualStyleBackColor = true;
            ckbDone.CheckedChanged += ckbDone_CheckedChanged;
            // 
            // AJob
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AJob";
            Size = new Size(1388, 63);
 //           Load += AJob_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private NumericUpDown nmFromHours;
        private TextBox txbJob;
        private CheckBox ckbDone;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cbStatus;
        private NumericUpDown nmToMinute;
        private NumericUpDown nmToHours;
        private Label label1;
        private NumericUpDown nmFromMinute;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
