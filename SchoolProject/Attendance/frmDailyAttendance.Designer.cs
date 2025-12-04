namespace SchoolProject.Attendance
{
    partial class frmDailyAttendance
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
            dgvEmployees = new DataGridView();
            btnMarkAttendance = new Button();
            lblRecordCount = new Label();
            label1 = new Label();
            lblTitle = new Label();
            button1 = new Button();
            chkSelectAll = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(0, 89);
            dgvEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(707, 380);
            dgvEmployees.TabIndex = 0;
            // 
            // btnMarkAttendance
            // 
            btnMarkAttendance.Location = new Point(630, 475);
            btnMarkAttendance.Margin = new Padding(4, 3, 4, 3);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.Size = new Size(77, 30);
            btnMarkAttendance.TabIndex = 1;
            btnMarkAttendance.Text = "Save";
            btnMarkAttendance.UseVisualStyleBackColor = true;
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(73, 480);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 37;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 480);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 36;
            label1.Text = "Record:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(167, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 37);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Employees Attendance";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(470, 474);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 39;
            button1.Text = "Monthly Attendance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.Location = new Point(631, 64);
            chkSelectAll.Margin = new Padding(4, 3, 4, 3);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(76, 19);
            chkSelectAll.TabIndex = 40;
            chkSelectAll.Text = "Check All";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged_1;
            // 
            // frmDailyAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 512);
            Controls.Add(chkSelectAll);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(btnMarkAttendance);
            Controls.Add(dgvEmployees);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDailyAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDailyAttendance";
            Load += frmDailyAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnMarkAttendance;
        
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}