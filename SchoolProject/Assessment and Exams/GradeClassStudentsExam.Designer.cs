namespace SchoolProject.Assessment_and_Exams
{
    partial class GradeClassStudentsExam
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
            label2 = new Label();
            lblTitle = new Label();
            dgvStudents = new DataGridView();
            cbClasses = new ComboBox();
            cbGrades = new ComboBox();
            cbSubjects = new ComboBox();
            cmsEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            lblRecordCount.Location = new Point(62, 506);
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
            label1.Location = new Point(5, 506);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 34;
            label1.Text = "Record:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-72, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 32;
            label2.Text = "Filter by";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(170, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 33);
            lblTitle.TabIndex = 30;
            lblTitle.Text = "Manage Exam Scores";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.ContextMenuStrip = cmsEmployees;
            dgvStudents.Location = new Point(5, 108);
            dgvStudents.Margin = new Padding(4, 3, 4, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(689, 395);
            dgvStudents.TabIndex = 28;
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(114, 72);
            cbClasses.Margin = new Padding(4, 3, 4, 3);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(101, 24);
            cbClasses.TabIndex = 36;
            cbClasses.SelectedIndexChanged += cbClasses_SelectedIndexChanged;
            // 
            // cbGrades
            // 
            cbGrades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrades.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbGrades.FormattingEnabled = true;
            cbGrades.Location = new Point(5, 72);
            cbGrades.Margin = new Padding(4, 3, 4, 3);
            cbGrades.Name = "cbGrades";
            cbGrades.Size = new Size(101, 24);
            cbGrades.TabIndex = 37;
            // 
            // cbSubjects
            // 
            cbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjects.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(233, 72);
            cbSubjects.Margin = new Padding(4, 3, 4, 3);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(101, 24);
            cbSubjects.TabIndex = 38;
            cbSubjects.SelectedIndexChanged += cbSubjects_SelectedIndexChanged;
            // 
            // GradeClassStudentsExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 529);
            Controls.Add(cbSubjects);
            Controls.Add(cbGrades);
            Controls.Add(cbClasses);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(dgvStudents);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GradeClassStudentsExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentMarksEntry";
            Load += frmStudentMarksEntry_Load;
            cmsEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.ComboBox cbSubjects;
    }
}