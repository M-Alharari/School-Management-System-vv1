namespace SchoolProject.Assigning_Forms.Assign_Subjects_to_Grades
{
    partial class frmAssignSubjectsToGrades
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
            dgvSubjects = new DataGridView();
            cbGrades = new ComboBox();
            lblRecordCount = new Label();
            label1 = new Label();
            lblTitle = new Label();
            btnSave = new Button();
            checkAll = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // dgvSubjects
            // 
            dgvSubjects.BackgroundColor = Color.White;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(14, 108);
            dgvSubjects.Margin = new Padding(4, 3, 4, 3);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(558, 364);
            dgvSubjects.TabIndex = 0;
            dgvSubjects.CellValueChanged += dgvSubjects_CellValueChanged;
            // 
            // cbGrades
            // 
            cbGrades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrades.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGrades.FormattingEnabled = true;
            cbGrades.Location = new Point(13, 76);
            cbGrades.Margin = new Padding(4, 3, 4, 3);
            cbGrades.Name = "cbGrades";
            cbGrades.Size = new Size(167, 26);
            cbGrades.TabIndex = 1;
            cbGrades.SelectedIndexChanged += cbGrades_SelectedIndexChanged;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(71, 481);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 24;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 481);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 23;
            label1.Text = "Record:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(80, 26);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 37);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Assign Subjects to Grades";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_17771276;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(486, 476);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 30);
            btnSave.TabIndex = 127;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // checkAll
            // 
            checkAll.AutoSize = true;
            checkAll.Location = new Point(496, 83);
            checkAll.Margin = new Padding(4, 3, 4, 3);
            checkAll.Name = "checkAll";
            checkAll.Size = new Size(76, 19);
            checkAll.TabIndex = 128;
            checkAll.Text = "Check All";
            checkAll.UseVisualStyleBackColor = true;
            checkAll.CheckedChanged += checkAll_CheckedChanged;
            // 
            // frmAssignSubjectsToGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 517);
            Controls.Add(checkAll);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(cbGrades);
            Controls.Add(dgvSubjects);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAssignSubjectsToGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAssignSubjectsToGrades";
            Load += frmAssignSubjectsToGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkAll;
    }
}