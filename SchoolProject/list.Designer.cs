namespace SchoolProject
{
    partial class list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            lblPageSize = new Label();
            btnPrevious = new Button();
            btnAddNewStudent = new Button();
            pictureBox1 = new PictureBox();
            behavioursToolStripMenuItem = new ToolStripMenuItem();
            typeScoresToolStripMenuItem = new ToolStripMenuItem();
            showHistoryToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            showDeatilsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnNext = new Button();
            txtFilterValue = new TextBox();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            lblRecordCount = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblPageSize
            // 
            lblPageSize.AutoSize = true;
            lblPageSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageSize.Location = new Point(454, 577);
            lblPageSize.Name = "lblPageSize";
            lblPageSize.Size = new Size(83, 15);
            lblPageSize.TabIndex = 133;
            lblPageSize.Text = "page 0 of 100";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(351, 571);
            btnPrevious.Margin = new Padding(4, 3, 4, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 27);
            btnPrevious.TabIndex = 132;
            btnPrevious.Text = "<<< Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnAddNewStudent
            // 
            btnAddNewStudent.Image = (Image)resources.GetObject("btnAddNewStudent.Image");
            btnAddNewStudent.Location = new Point(606, 189);
            btnAddNewStudent.Margin = new Padding(4, 3, 4, 3);
            btnAddNewStudent.Name = "btnAddNewStudent";
            btnAddNewStudent.Size = new Size(34, 32);
            btnAddNewStudent.TabIndex = 129;
            btnAddNewStudent.Text = " ";
            btnAddNewStudent.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students_540144__1_;
            pictureBox1.Location = new Point(239, 8);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 130;
            pictureBox1.TabStop = false;
            // 
            // behavioursToolStripMenuItem
            // 
            behavioursToolStripMenuItem.Image = Properties.Resources.user_engagement_9957176;
            behavioursToolStripMenuItem.Name = "behavioursToolStripMenuItem";
            behavioursToolStripMenuItem.Size = new Size(222, 24);
            behavioursToolStripMenuItem.Text = "Behaviours";
            // 
            // typeScoresToolStripMenuItem
            // 
            typeScoresToolStripMenuItem.Image = Properties.Resources.exam_4619285;
            typeScoresToolStripMenuItem.Name = "typeScoresToolStripMenuItem";
            typeScoresToolStripMenuItem.Size = new Size(222, 24);
            typeScoresToolStripMenuItem.Text = "Type Scores";
            // 
            // showHistoryToolStripMenuItem
            // 
            showHistoryToolStripMenuItem.Image = Properties.Resources.calendars_6172211;
            showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            showHistoryToolStripMenuItem.Size = new Size(222, 24);
            showHistoryToolStripMenuItem.Text = "Show Attendane Card";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(222, 24);
            sendEmailToolStripMenuItem.Text = "Show History";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(219, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(222, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(222, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(222, 24);
            addNewPersonToolStripMenuItem.Text = "Add New Student";
            // 
            // showDeatilsToolStripMenuItem
            // 
            showDeatilsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDeatilsToolStripMenuItem.Name = "showDeatilsToolStripMenuItem";
            showDeatilsToolStripMenuItem.Size = new Size(222, 24);
            showDeatilsToolStripMenuItem.Text = "Show Deatils";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDeatilsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, showHistoryToolStripMenuItem, typeScoresToolStripMenuItem, behavioursToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(223, 202);
            // 
            // btnNext
            // 
            btnNext.Location = new Point(560, 571);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 27);
            btnNext.TabIndex = 131;
            btnNext.Text = " Next >>>";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(269, 190);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(148, 24);
            txtFilterValue.TabIndex = 128;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 192);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 127;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Student ID", "Full Name", "Gender", "Country", "Grade", "Class" });
            cbFilterBy.Location = new Point(123, 189);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(138, 26);
            cbFilterBy.TabIndex = 126;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(114, 575);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 125;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 575);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 124;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(223, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(282, 37);
            label3.TabIndex = 123;
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
            dgvStudents.Location = new Point(54, 226);
            dgvStudents.Margin = new Padding(4, 3, 4, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(586, 342);
            dgvStudents.TabIndex = 122;
            // 
            // list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 610);
            Controls.Add(lblPageSize);
            Controls.Add(btnPrevious);
            Controls.Add(btnAddNewStudent);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvStudents);
            Name = "list";
            Text = "list";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageSize;
        private Button btnPrevious;
        private Button btnAddNewStudent;
        private PictureBox pictureBox1;
        private ToolStripMenuItem behavioursToolStripMenuItem;
        private ToolStripMenuItem typeScoresToolStripMenuItem;
        private ToolStripMenuItem showHistoryToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem showDeatilsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnNext;
        private TextBox txtFilterValue;
        private Label label2;
        private ComboBox cbFilterBy;
        private Label lblRecordCount;
        private Label label1;
        private Label label3;
        private DataGridView dgvStudents;
    }
}