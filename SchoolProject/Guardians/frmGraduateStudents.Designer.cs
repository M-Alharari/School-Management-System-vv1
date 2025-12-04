namespace SchoolProject.Graduation
{
    partial class frmGraduateStudents
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
            btnGraduate = new Button();
            behavioursToolStripMenuItem = new ToolStripMenuItem();
            callPhoneToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            showDeatilsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            cbFilterBy = new ComboBox();
            lblTotalCount = new Label();
            lblTitle = new Label();
            dgvGraduates = new DataGridView();
            lblPassedCount = new Label();
            lblFailedCount = new Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGraduates).BeginInit();
            SuspendLayout();
            // 
            // btnGraduate
            // 
            btnGraduate.Location = new Point(513, 502);
            btnGraduate.Margin = new Padding(4, 3, 4, 3);
            btnGraduate.Name = "btnGraduate";
            btnGraduate.Size = new Size(112, 27);
            btnGraduate.TabIndex = 1;
            btnGraduate.Text = "Graduate";
            btnGraduate.UseVisualStyleBackColor = true;
            btnGraduate.Click += btnGraduate_Click;
            // 
            // behavioursToolStripMenuItem
            // 
            behavioursToolStripMenuItem.Name = "behavioursToolStripMenuItem";
            behavioursToolStripMenuItem.Size = new Size(195, 24);
            behavioursToolStripMenuItem.Text = "Behaviours";
            // 
            // callPhoneToolStripMenuItem
            // 
            callPhoneToolStripMenuItem.Image = Properties.Resources.call_32;
            callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            callPhoneToolStripMenuItem.Size = new Size(195, 24);
            callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.Email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(195, 24);
            sendEmailToolStripMenuItem.Text = "Show History";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(195, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(195, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(195, 24);
            addNewPersonToolStripMenuItem.Text = "Add New Student";
            // 
            // showDeatilsToolStripMenuItem
            // 
            showDeatilsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDeatilsToolStripMenuItem.Name = "showDeatilsToolStripMenuItem";
            showDeatilsToolStripMenuItem.Size = new Size(195, 24);
            showDeatilsToolStripMenuItem.Text = "Show Deatils";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDeatilsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, callPhoneToolStripMenuItem, behavioursToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(196, 178);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students_540144__1_;
            pictureBox1.Location = new Point(201, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 125;
            pictureBox1.TabStop = false;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cbFilterBy.Location = new Point(19, 195);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(254, 26);
            cbFilterBy.TabIndex = 121;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(13, 499);
            lblTotalCount.Margin = new Padding(4, 0, 4, 0);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(119, 18);
            lblTotalCount.TabIndex = 120;
            lblTotalCount.Text = "Total Students: 0";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(201, 140);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 37);
            lblTitle.TabIndex = 118;
            lblTitle.Text = "Graduation List";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvGraduates
            // 
            dgvGraduates.AllowUserToAddRows = false;
            dgvGraduates.AllowUserToDeleteRows = false;
            dgvGraduates.BackgroundColor = Color.White;
            dgvGraduates.BorderStyle = BorderStyle.Fixed3D;
            dgvGraduates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGraduates.ContextMenuStrip = contextMenuStrip1;
            dgvGraduates.Location = new Point(13, 232);
            dgvGraduates.Margin = new Padding(4, 3, 4, 3);
            dgvGraduates.Name = "dgvGraduates";
            dgvGraduates.ReadOnly = true;
            dgvGraduates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGraduates.Size = new Size(612, 264);
            dgvGraduates.TabIndex = 117;
            // 
            // lblPassedCount
            // 
            lblPassedCount.AutoSize = true;
            lblPassedCount.Location = new Point(513, 172);
            lblPassedCount.Margin = new Padding(4, 0, 4, 0);
            lblPassedCount.Name = "lblPassedCount";
            lblPassedCount.Size = new Size(90, 15);
            lblPassedCount.TabIndex = 126;
            lblPassedCount.Text = "Num of Passed:";
            // 
            // lblFailedCount
            // 
            lblFailedCount.AutoSize = true;
            lblFailedCount.Location = new Point(513, 201);
            lblFailedCount.Margin = new Padding(4, 0, 4, 0);
            lblFailedCount.Name = "lblFailedCount";
            lblFailedCount.Size = new Size(85, 15);
            lblFailedCount.TabIndex = 127;
            lblFailedCount.Text = "Num of Failed:";
            // 
            // frmGraduateStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 542);
            Controls.Add(lblFailedCount);
            Controls.Add(lblPassedCount);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilterBy);
            Controls.Add(lblTotalCount);
            Controls.Add(lblTitle);
            Controls.Add(dgvGraduates);
            Controls.Add(btnGraduate);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGraduateStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                 ";
            Load += frmGraduateStudents_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGraduates).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGraduate;
        private System.Windows.Forms.ToolStripMenuItem behavioursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeatilsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvGraduates;
        private System.Windows.Forms.Label lblPassedCount;
        private System.Windows.Forms.Label lblFailedCount;
    }
}