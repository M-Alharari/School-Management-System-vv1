namespace SchoolProject.Attendance
{
    partial class frmEmployeesPayroll
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tcEnrollHistory = new TabControl();
            tpTeachersSalary = new TabPage();
            lblRecordCount = new Label();
            label2 = new Label();
            dgvPayroll = new DataGridView();
            label4 = new Label();
            dtpPayrollDate = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            tcEnrollHistory.SuspendLayout();
            tpTeachersSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tcEnrollHistory);
            groupBox1.Location = new Point(2, 90);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(676, 458);
            groupBox1.TabIndex = 141;
            groupBox1.TabStop = false;
            // 
            // tcEnrollHistory
            // 
            tcEnrollHistory.Controls.Add(tpTeachersSalary);
            tcEnrollHistory.Location = new Point(8, 13);
            tcEnrollHistory.Margin = new Padding(4, 3, 4, 3);
            tcEnrollHistory.Name = "tcEnrollHistory";
            tcEnrollHistory.SelectedIndex = 0;
            tcEnrollHistory.Size = new Size(666, 424);
            tcEnrollHistory.TabIndex = 131;
            // 
            // tpTeachersSalary
            // 
            tpTeachersSalary.Controls.Add(lblRecordCount);
            tpTeachersSalary.Controls.Add(label2);
            tpTeachersSalary.Controls.Add(dgvPayroll);
            tpTeachersSalary.Location = new Point(4, 24);
            tpTeachersSalary.Margin = new Padding(4, 3, 4, 3);
            tpTeachersSalary.Name = "tpTeachersSalary";
            tpTeachersSalary.Padding = new Padding(4, 3, 4, 3);
            tpTeachersSalary.Size = new Size(658, 396);
            tpTeachersSalary.TabIndex = 0;
            tpTeachersSalary.UseVisualStyleBackColor = true;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(108, 370);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(24, 18);
            lblRecordCount.TabIndex = 134;
            lblRecordCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 368);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 133;
            label2.Text = "# Records:";
            // 
            // dgvPayroll
            // 
            dgvPayroll.AllowUserToAddRows = false;
            dgvPayroll.AllowUserToDeleteRows = false;
            dgvPayroll.AllowUserToResizeRows = false;
            dgvPayroll.BackgroundColor = Color.White;
            dgvPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayroll.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPayroll.Location = new Point(8, 39);
            dgvPayroll.Margin = new Padding(5, 6, 5, 6);
            dgvPayroll.MultiSelect = false;
            dgvPayroll.Name = "dgvPayroll";
            dgvPayroll.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPayroll.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayroll.Size = new Size(644, 323);
            dgvPayroll.TabIndex = 132;
            dgvPayroll.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 73);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 136;
            label4.Text = "Payroll as of";
            // 
            // dtpPayrollDate
            // 
            dtpPayrollDate.CustomFormat = "yyyy-mm";
            dtpPayrollDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPayrollDate.Format = DateTimePickerFormat.Custom;
            dtpPayrollDate.Location = new Point(154, 73);
            dtpPayrollDate.Margin = new Padding(4, 3, 4, 3);
            dtpPayrollDate.Name = "dtpPayrollDate";
            dtpPayrollDate.Size = new Size(128, 24);
            dtpPayrollDate.TabIndex = 142;
            dtpPayrollDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(543, 554);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(135, 27);
            button1.TabIndex = 143;
            button1.Text = "Pay for Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(193, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(296, 37);
            label3.TabIndex = 144;
            label3.Text = "Employees Payroll";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEmployeesPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(683, 589);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dtpPayrollDate);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEmployeesPayroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmployeesPayroll";
            Load += frmEmployeesPayroll_Load;
            groupBox1.ResumeLayout(false);
            tcEnrollHistory.ResumeLayout(false);
            tpTeachersSalary.ResumeLayout(false);
            tpTeachersSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPayrollDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tcEnrollHistory;
        private System.Windows.Forms.TabPage tpTeachersSalary;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label label3;
    }
}