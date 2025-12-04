namespace SchoolProject.Subjects
{
    partial class frmSubjectsInGrade
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
            checkAll = new CheckBox();
            btnSave = new Button();
            lblTitle = new Label();
            lblRecordCount = new Label();
            label1 = new Label();
            cbGrades = new ComboBox();
            dgvSubjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // checkAll
            // 
            checkAll.AutoSize = true;
            checkAll.Location = new Point(505, 80);
            checkAll.Margin = new Padding(4, 3, 4, 3);
            checkAll.Name = "checkAll";
            checkAll.Size = new Size(76, 19);
            checkAll.TabIndex = 135;
            checkAll.Text = "Check All";
            checkAll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_177712768;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(500, 408);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 30);
            btnSave.TabIndex = 134;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(140, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 37);
            lblTitle.TabIndex = 133;
            lblTitle.Text = "Subjects in Grades";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(70, 408);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 132;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 408);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 131;
            label1.Text = "Record:";
            // 
            // cbGrades
            // 
            cbGrades.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGrades.FormattingEnabled = true;
            cbGrades.Location = new Point(13, 61);
            cbGrades.Margin = new Padding(4, 3, 4, 3);
            cbGrades.Name = "cbGrades";
            cbGrades.Size = new Size(158, 26);
            cbGrades.TabIndex = 130;
            // 
            // dgvSubjects
            // 
            dgvSubjects.BackgroundColor = Color.White;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(13, 105);
            dgvSubjects.Margin = new Padding(4, 3, 4, 3);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(568, 294);
            dgvSubjects.TabIndex = 129;
            // 
            // frmSubjectsInGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(589, 450);
            Controls.Add(checkAll);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(cbGrades);
            Controls.Add(dgvSubjects);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSubjectsInGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm";
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}