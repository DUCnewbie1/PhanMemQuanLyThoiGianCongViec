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
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 35);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(816, 0);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(52, 26);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(758, 0);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(52, 26);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Lưu ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(631, 2);
            cbStatus.Margin = new Padding(4, 4, 4, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(120, 23);
            cbStatus.TabIndex = 3;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmToMinute);
            panel2.Controls.Add(nmToHours);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nmFromMinute);
            panel2.Controls.Add(nmFromHours);
            panel2.Location = new Point(394, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 35);
            panel2.TabIndex = 2;
            // 
            // nmToMinute
            // 
            nmToMinute.Location = new Point(187, 4);
            nmToMinute.Margin = new Padding(4, 4, 4, 4);
            nmToMinute.Name = "nmToMinute";
            nmToMinute.Size = new Size(43, 23);
            nmToMinute.TabIndex = 4;
            nmToMinute.ValueChanged += nmToMinute_ValueChanged;
            // 
            // nmToHours
            // 
            nmToHours.Location = new Point(136, 4);
            nmToHours.Margin = new Padding(4, 4, 4, 4);
            nmToHours.Name = "nmToHours";
            nmToHours.Size = new Size(43, 23);
            nmToHours.TabIndex = 3;
            nmToHours.ValueChanged += nmToHours_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Đến";
            // 
            // nmFromMinute
            // 
            nmFromMinute.Location = new Point(54, 4);
            nmFromMinute.Margin = new Padding(4, 4, 4, 4);
            nmFromMinute.Name = "nmFromMinute";
            nmFromMinute.Size = new Size(43, 23);
            nmFromMinute.TabIndex = 1;
            nmFromMinute.ValueChanged += nmFromMinute_ValueChanged;
            // 
            // nmFromHours
            // 
            nmFromHours.Location = new Point(4, 4);
            nmFromHours.Margin = new Padding(4, 4, 4, 4);
            nmFromHours.Name = "nmFromHours";
            nmFromHours.Size = new Size(43, 23);
            nmFromHours.TabIndex = 0;
            nmFromHours.ValueChanged += nmFromHours_ValueChanged;
            // 
            // txbJob
            // 
            txbJob.Location = new Point(29, 4);
            txbJob.Margin = new Padding(4, 4, 4, 4);
            txbJob.Name = "txbJob";
            txbJob.Size = new Size(359, 23);
            txbJob.TabIndex = 1;
            // 
            // ckbDone
            // 
            ckbDone.AutoSize = true;
            ckbDone.Location = new Point(7, 8);
            ckbDone.Margin = new Padding(4, 4, 4, 4);
            ckbDone.Name = "ckbDone";
            ckbDone.Size = new Size(15, 14);
            ckbDone.TabIndex = 0;
            ckbDone.UseVisualStyleBackColor = true;
            ckbDone.CheckedChanged += ckbDone_CheckedChanged;
            // 
            // AJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AJob";
            Size = new Size(878, 38);
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
    }
}
