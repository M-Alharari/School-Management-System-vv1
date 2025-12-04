namespace SchoolProject.Attendance
{
    partial class MonthlyAttendanceView
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
            components = new System.ComponentModel.Container();
            dgvMonthData = new DataGridView();
            cmsAttemdamce = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cmbYears = new ComboBox();
            cmbMonths = new ComboBox();
            lblTitle = new Label();
            lblRecordCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonthData).BeginInit();
            cmsAttemdamce.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMonthData
            // 
            dgvMonthData.AllowUserToAddRows = false;
            dgvMonthData.AllowUserToDeleteRows = false;
            dgvMonthData.BackgroundColor = Color.White;
            dgvMonthData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthData.ContextMenuStrip = cmsAttemdamce;
            dgvMonthData.Location = new Point(7, 93);
            dgvMonthData.Margin = new Padding(4, 3, 4, 3);
            dgvMonthData.Name = "dgvMonthData";
            dgvMonthData.ReadOnly = true;
            dgvMonthData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthData.Size = new Size(723, 350);
            dgvMonthData.TabIndex = 0;
            // 
            // cmsAttemdamce
            // 
            cmsAttemdamce.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, editToolStripMenuItem, toolStripMenuItem2 });
            cmsAttemdamce.Name = "cmsEmployees";
            cmsAttemdamce.Size = new Size(175, 54);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(174, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Teacher Card";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(174, 22);
            editToolStripMenuItem.Text = "Edit ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(171, 6);
            // 
            // cmbYears
            // 
            cmbYears.FormattingEnabled = true;
            cmbYears.Location = new Point(155, 62);
            cmbYears.Margin = new Padding(4, 3, 4, 3);
            cmbYears.Name = "cmbYears";
            cmbYears.Size = new Size(140, 23);
            cmbYears.TabIndex = 1;
            cmbYears.SelectedIndexChanged += cmbYears_SelectedIndexChanged;
            // 
            // cmbMonths
            // 
            cmbMonths.FormattingEnabled = true;
            cmbMonths.Location = new Point(7, 62);
            cmbMonths.Margin = new Padding(4, 3, 4, 3);
            cmbMonths.Name = "cmbMonths";
            cmbMonths.Size = new Size(140, 23);
            cmbMonths.TabIndex = 2;
            cmbMonths.SelectedIndexChanged += cmbMonths_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(164, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 37);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Monthly Attendance View";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(89, 446);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 41;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 446);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 40;
            label1.Text = "Record:";
            // 
            // MonthlyAttendanceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 470);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cmbMonths);
            Controls.Add(cmbYears);
            Controls.Add(dgvMonthData);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MonthlyAttendanceView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonthlyAttendanceView";
            Load += MonthlyAttendanceView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonthData).EndInit();
            cmsAttemdamce.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonthData;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAttemdamce;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}