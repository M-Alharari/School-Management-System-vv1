namespace SchoolProject.Students
{
    partial class frmStudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentList));
            txtFilterValue = new TextBox();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            lblRecordCount = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvStudents = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDeatilsToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            showHistoryToolStripMenuItem = new ToolStripMenuItem();
            typeScoresToolStripMenuItem = new ToolStripMenuItem();
            behavioursToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnAddNewStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(228, 194);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(148, 24);
            txtFilterValue.TabIndex = 25;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 24;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Student ID", "Full Name", "Gender", "Country", "Grade", "Class" });
            cbFilterBy.Location = new Point(82, 193);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(138, 26);
            cbFilterBy.TabIndex = 23;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(73, 579);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 22;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 579);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 21;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(182, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(282, 37);
            label3.TabIndex = 20;
            label3.Text = "Manage Students";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.Fixed3D;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.ContextMenuStrip = contextMenuStrip1;
            dgvStudents.Location = new Point(13, 230);
            dgvStudents.Margin = new Padding(4, 3, 4, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(586, 342);
            dgvStudents.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDeatilsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, showHistoryToolStripMenuItem, typeScoresToolStripMenuItem, behavioursToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(223, 202);
            // 
            // showDeatilsToolStripMenuItem
            // 
            showDeatilsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDeatilsToolStripMenuItem.Name = "showDeatilsToolStripMenuItem";
            showDeatilsToolStripMenuItem.Size = new Size(222, 24);
            showDeatilsToolStripMenuItem.Text = "Show Deatils";
            showDeatilsToolStripMenuItem.Click += showDeatilsToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(222, 24);
            addNewPersonToolStripMenuItem.Text = "Add New Student";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(222, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(222, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(219, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(222, 24);
            sendEmailToolStripMenuItem.Text = "Show History";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // showHistoryToolStripMenuItem
            // 
            showHistoryToolStripMenuItem.Image = Properties.Resources.calendars_6172211;
            showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            showHistoryToolStripMenuItem.Size = new Size(222, 24);
            showHistoryToolStripMenuItem.Text = "Show Attendane Card";
            showHistoryToolStripMenuItem.Click += showHistoryToolStripMenuItem_Click;
            // 
            // typeScoresToolStripMenuItem
            // 
            typeScoresToolStripMenuItem.Image = Properties.Resources.exam_4619285;
            typeScoresToolStripMenuItem.Name = "typeScoresToolStripMenuItem";
            typeScoresToolStripMenuItem.Size = new Size(222, 24);
            typeScoresToolStripMenuItem.Text = "Type Scores";
            typeScoresToolStripMenuItem.Click += typeScoresToolStripMenuItem_Click;
            // 
            // behavioursToolStripMenuItem
            // 
            behavioursToolStripMenuItem.Image = Properties.Resources.user_engagement_9957176;
            behavioursToolStripMenuItem.Name = "behavioursToolStripMenuItem";
            behavioursToolStripMenuItem.Size = new Size(222, 24);
            behavioursToolStripMenuItem.Text = "Behaviours";
            behavioursToolStripMenuItem.Click += behavioursToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students_540144__1_;
            pictureBox1.Location = new Point(198, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 116;
            pictureBox1.TabStop = false;
            // 
            // btnAddNewStudent
            // 
            btnAddNewStudent.Image = (Image)resources.GetObject("btnAddNewStudent.Image");
            btnAddNewStudent.Location = new Point(565, 193);
            btnAddNewStudent.Margin = new Padding(4, 3, 4, 3);
            btnAddNewStudent.Name = "btnAddNewStudent";
            btnAddNewStudent.Size = new Size(34, 32);
            btnAddNewStudent.TabIndex = 26;
            btnAddNewStudent.Text = " ";
            btnAddNewStudent.UseVisualStyleBackColor = true;
            btnAddNewStudent.Click += btnAddNewStudent_Click;
            // 
            // frmStudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(607, 610);
            Controls.Add(btnAddNewStudent);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvStudents);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStudentList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStudentList";
            Load += frmStudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDeatilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem behavioursToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem showHistoryToolStripMenuItem;
        private ToolStripMenuItem typeScoresToolStripMenuItem;
    }
}