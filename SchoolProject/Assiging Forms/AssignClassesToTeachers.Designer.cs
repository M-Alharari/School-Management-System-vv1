namespace SchoolProject.Assigning_Forms
{
    partial class AssignClassesToTeachers
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
            dgvClasses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_177712763;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(530, 454);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 28);
            btnSave.TabIndex = 134;
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
            lblTitle.Location = new Point(87, 24);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(451, 37);
            lblTitle.TabIndex = 133;
            lblTitle.Text = "Assign Classes To Teachers";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(66, 457);
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
            label1.Location = new Point(6, 457);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 131;
            label1.Text = "Record:";
            // 
            // cbTeachers
            // 
            cbTeachers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeachers.FlatStyle = FlatStyle.System;
            cbTeachers.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTeachers.FormattingEnabled = true;
            cbTeachers.Location = new Point(6, 78);
            cbTeachers.Margin = new Padding(4, 3, 4, 3);
            cbTeachers.Name = "cbTeachers";
            cbTeachers.Size = new Size(218, 26);
            cbTeachers.TabIndex = 130;
            cbTeachers.SelectedIndexChanged += cbTeachers_SelectedIndexChanged;
            // 
            // dgvClasses
            // 
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Location = new Point(6, 110);
            dgvClasses.Margin = new Padding(4, 3, 4, 3);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.Size = new Size(609, 341);
            dgvClasses.TabIndex = 129;
            // 
            // AssignClassesToTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 500);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(cbTeachers);
            Controls.Add(dgvClasses);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AssignClassesToTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignClassesToTeachers";
            Load += AssignClassesToTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeachers;
        private System.Windows.Forms.DataGridView dgvClasses;
    }
}