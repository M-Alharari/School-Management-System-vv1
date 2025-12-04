namespace SchoolProject.Attendance
{
    partial class frmAttendaceManagement
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
            cmsEmployees = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            lblRecordCount = new Label();
            label1 = new Label();
            txtFilterValue = new TextBox();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            lblTitle = new Label();
            dgvAttendance = new DataGridView();
            pictureBox1 = new PictureBox();
            btnAddEmployee = new Button();
            label4 = new Label();
            cbMode = new ComboBox();
            cmsEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmsEmployees
            // 
            cmsEmployees.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, toolStripMenuItem2 });
            cmsEmployees.Name = "cmsEmployees";
            cmsEmployees.Size = new Size(181, 32);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(180, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(94, 595);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 35;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 595);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 34;
            label1.Text = "Record:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(288, 201);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(213, 22);
            txtFilterValue.TabIndex = 33;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 32;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "Full Name", "Date", "Present?", "Reason" });
            cbFilterBy.Location = new Point(94, 198);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(186, 24);
            cbFilterBy.TabIndex = 31;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(85, 148);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(453, 33);
            lblTitle.TabIndex = 30;
            lblTitle.Text = "Manage Employees Attendance";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.ContextMenuStrip = cmsEmployees;
            dgvAttendance.Location = new Point(14, 233);
            dgvAttendance.Margin = new Padding(4, 3, 4, 3);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(608, 359);
            dgvAttendance.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.immigration1;
            pictureBox1.Location = new Point(223, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Image = Properties.Resources.AddPerson_32;
            btnAddEmployee.Location = new Point(576, 192);
            btnAddEmployee.Margin = new Padding(4, 3, 4, 3);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(46, 34);
            btnAddEmployee.TabIndex = 29;
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 16);
            label4.TabIndex = 38;
            label4.Text = "View Attendance:";
            // 
            // cbMode
            // 
            cbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMode.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMode.FormattingEnabled = true;
            cbMode.Items.AddRange(new object[] { "Full Name", "Gender" });
            cbMode.Location = new Point(444, 121);
            cbMode.Margin = new Padding(4, 3, 4, 3);
            cbMode.Name = "cbMode";
            cbMode.Size = new Size(178, 24);
            cbMode.TabIndex = 39;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;
            // 
            // frmAttendaceManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(636, 618);
            Controls.Add(cbMode);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(lblTitle);
            Controls.Add(btnAddEmployee);
            Controls.Add(dgvAttendance);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAttendaceManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAttendaceManagement";
            Load += frmAttendaceManagement_Load;
            cmsEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMode;
    }
}