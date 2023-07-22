namespace WinFormsApp1
{
    partial class Ajob
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
            comboBox1 = new ComboBox();
            LabelTo = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            ChbDone = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(LabelTo);
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(ChbDone);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 85);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(834, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa ";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(716, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            // 
            // LabelTo
            // 
            LabelTo.AutoSize = true;
            LabelTo.Location = new Point(301, 5);
            LabelTo.Name = "LabelTo";
            LabelTo.Size = new Size(38, 25);
            LabelTo.TabIndex = 6;
            LabelTo.Text = "tới ";
            LabelTo.Click += label1_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(421, 2);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(70, 31);
            numericUpDown4.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(345, 2);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(70, 31);
            numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(225, 3);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(70, 31);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(149, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 31);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(988, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ChbDone
            // 
            ChbDone.AutoSize = true;
            ChbDone.Location = new Point(18, 5);
            ChbDone.Name = "ChbDone";
            ChbDone.Size = new Size(81, 29);
            ChbDone.TabIndex = 0;
            ChbDone.Text = "Done";
            ChbDone.UseVisualStyleBackColor = true;
            ChbDone.CheckedChanged += ChbDone_CheckedChanged;
            // 
            // Ajob
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Ajob";
            Size = new Size(1001, 91);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private CheckBox ChbDone;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private Label LabelTo;
        private ComboBox comboBox1;
        private Button btnDelete;
        private Button btnEdit;
    }
}
