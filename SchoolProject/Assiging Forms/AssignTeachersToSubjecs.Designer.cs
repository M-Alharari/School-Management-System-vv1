namespace SchoolProject.Assigning_Forms
{
    partial class AssignTeachersToSubjecs
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
            btnSave = new Button();
            lblTitle = new Label();
            lblRecordCount = new Label();
            label1 = new Label();
            cbTeachers = new ComboBox();
            dgvSubjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_177712762;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(494, 424);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 32);
            btnSave.TabIndex = 140;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(79, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(461, 37);
            lblTitle.TabIndex = 139;
            lblTitle.Text = "Assign Subjects To Teachers";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(78, 424);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 138;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 423);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 137;
            label1.Text = "Record:";
            // 
            // cbTeachers
            // 
            cbTeachers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeachers.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTeachers.FormattingEnabled = true;
            cbTeachers.Location = new Point(13, 63);
            cbTeachers.Margin = new Padding(4, 3, 4, 3);
            cbTeachers.Name = "cbTeachers";
            cbTeachers.Size = new Size(199, 26);
            cbTeachers.TabIndex = 136;
            cbTeachers.SelectedIndexChanged += cbTeachers_SelectedIndexChanged;
            // 
            // dgvSubjects
            // 
            dgvSubjects.BackgroundColor = Color.White;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(13, 100);
            dgvSubjects.Margin = new Padding(4, 3, 4, 3);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(566, 320);
            dgvSubjects.TabIndex = 135;
            // 
            // AssignTeachersToSubjecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(588, 471);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(cbTeachers);
            Controls.Add(dgvSubjects);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AssignTeachersToSubjecs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignTeachersToSubjecs";
            Load += AssignTeachersToSubjecs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeachers;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}