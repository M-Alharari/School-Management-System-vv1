namespace SchoolProject.Teachers
{
    partial class frmTeacherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherList));
            cmsTeachers = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            attendaceCardToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblRecordCount = new Label();
            label1 = new Label();
            dgvTeachers = new DataGridView();
            label2 = new Label();
            txtFilter = new TextBox();
            cbPeopleFilter = new ComboBox();
            pictureBox1 = new PictureBox();
            btnAddNewTeacher = new Button();
            cmsTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmsTeachers
            // 
            cmsTeachers.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, attendaceCardToolStripMenuItem });
            cmsTeachers.Name = "cmsEmployees";
            cmsTeachers.Size = new Size(185, 98);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(184, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Teacher Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(184, 22);
            editToolStripMenuItem.Text = "Edit ";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(184, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(181, 6);
            // 
            // attendaceCardToolStripMenuItem
            // 
            attendaceCardToolStripMenuItem.Name = "attendaceCardToolStripMenuItem";
            attendaceCardToolStripMenuItem.Size = new Size(184, 22);
            attendaceCardToolStripMenuItem.Text = "Attendace Card";
            attendaceCardToolStripMenuItem.Click += attendaceCardToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(194, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 31);
            label3.TabIndex = 28;
            label3.Text = "Manage Teachers";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(67, 535);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 26;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 535);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 25;
            label1.Text = "Record:";
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.AllowUserToResizeColumns = false;
            dgvTeachers.AllowUserToResizeRows = false;
            dgvTeachers.BackgroundColor = Color.White;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.ContextMenuStrip = cmsTeachers;
            dgvTeachers.Location = new Point(8, 225);
            dgvTeachers.Margin = new Padding(4, 3, 4, 3);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(570, 307);
            dgvTeachers.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 31;
            label2.Text = "Filter by:";
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(236, 190);
            txtFilter.Margin = new Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(151, 26);
            txtFilter.TabIndex = 30;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbPeopleFilter
            // 
            cbPeopleFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPeopleFilter.FormattingEnabled = true;
            cbPeopleFilter.Items.AddRange(new object[] { "None", "Teacher ID", "National No.", "Full Name", "Class Name" });
            cbPeopleFilter.Location = new Point(80, 188);
            cbPeopleFilter.Margin = new Padding(4, 3, 4, 3);
            cbPeopleFilter.Name = "cbPeopleFilter";
            cbPeopleFilter.Size = new Size(148, 28);
            cbPeopleFilter.TabIndex = 29;
            cbPeopleFilter.SelectedIndexChanged += cbPeopleFilter_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teaching_1546872__1_1;
            pictureBox1.Location = new Point(203, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 115;
            pictureBox1.TabStop = false;
            // 
            // btnAddNewTeacher
            // 
            btnAddNewTeacher.Image = (Image)resources.GetObject("btnAddNewTeacher.Image");
            btnAddNewTeacher.Location = new Point(536, 177);
            btnAddNewTeacher.Margin = new Padding(4, 3, 4, 3);
            btnAddNewTeacher.Name = "btnAddNewTeacher";
            btnAddNewTeacher.Size = new Size(42, 39);
            btnAddNewTeacher.TabIndex = 24;
            btnAddNewTeacher.UseVisualStyleBackColor = true;
            btnAddNewTeacher.Click += btnAddNewTeacher_Click;
            // 
            // frmTeacherList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(585, 560);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtFilter);
            Controls.Add(cbPeopleFilter);
            Controls.Add(label3);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(btnAddNewTeacher);
            Controls.Add(dgvTeachers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTeacherList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmTeacherList";
            Load += frmTeacherList_Load;
            cmsTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsTeachers;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewTeacher;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbPeopleFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem attendaceCardToolStripMenuItem;
    }
}