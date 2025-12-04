namespace SchoolProject.Salary_Deduction
{
    partial class frmSalaryDeductionSummary
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
            dgvSummary = new DataGridView();
            cmbMonth = new ComboBox();
            comboBox4 = new ComboBox();
            btnGenerateSummary = new Button();
            nudYear = new NumericUpDown();
            cmbDeductionPerDay = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // dgvSummary
            // 
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(6, 108);
            dgvSummary.Margin = new Padding(5, 3, 5, 3);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.Size = new Size(729, 338);
            dgvSummary.TabIndex = 1;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(126, 80);
            cmbMonth.Margin = new Padding(5, 3, 5, 3);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(99, 24);
            cmbMonth.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(235, 80);
            comboBox4.Margin = new Padding(5, 3, 5, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(107, 24);
            comboBox4.TabIndex = 3;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnGenerateSummary.Location = new Point(638, 78);
            btnGenerateSummary.Margin = new Padding(5, 3, 5, 3);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(97, 26);
            btnGenerateSummary.TabIndex = 4;
            btnGenerateSummary.Text = "generate";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudYear.Location = new Point(8, 79);
            nudYear.Margin = new Padding(5, 3, 5, 3);
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(108, 22);
            nudYear.TabIndex = 5;
            // 
            // cmbDeductionPerDay
            // 
            cmbDeductionPerDay.Font = new Font("Microsoft Sans Serif", 9.75F);
            cmbDeductionPerDay.FormattingEnabled = true;
            cmbDeductionPerDay.Location = new Point(501, 78);
            cmbDeductionPerDay.Margin = new Padding(5, 3, 5, 3);
            cmbDeductionPerDay.Name = "cmbDeductionPerDay";
            cmbDeductionPerDay.Size = new Size(127, 24);
            cmbDeductionPerDay.TabIndex = 6;
            cmbDeductionPerDay.SelectedIndexChanged += cmbDeductionPerDay_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(170, 10);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(395, 33);
            label3.TabIndex = 31;
            label3.Text = "Deduction Salary Summary";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(501, 59);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 32;
            label1.Text = "Deduct per Day:";
            // 
            // frmSalaryDeductionSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 455);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cmbDeductionPerDay);
            Controls.Add(nudYear);
            Controls.Add(btnGenerateSummary);
            Controls.Add(comboBox4);
            Controls.Add(cmbMonth);
            Controls.Add(dgvSummary);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmSalaryDeductionSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalaryDeductionSummary";
            Load += frmSalaryDeductionSummary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cmbDeductionPerDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}