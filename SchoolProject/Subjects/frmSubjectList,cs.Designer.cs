namespace SchoolProject.Subjects
{
    partial class frmSubjectList_cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubjectList_cs));
            lblRecordCount = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvSubjects = new DataGridView();
            cmsSubjects = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            btnAddNewSubject = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            cmsSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblRecordCount.Location = new Point(73, 395);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(28, 16);
            lblRecordCount.TabIndex = 26;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(13, 395);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 25;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(83, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 31);
            label3.TabIndex = 23;
            label3.Text = "Subjects list";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AllowUserToOrderColumns = true;
            dgvSubjects.AllowUserToResizeColumns = false;
            dgvSubjects.AllowUserToResizeRows = false;
            dgvSubjects.BackgroundColor = Color.White;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.ContextMenuStrip = cmsSubjects;
            dgvSubjects.Location = new Point(13, 153);
            dgvSubjects.Margin = new Padding(4, 3, 4, 3);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.Size = new Size(318, 239);
            dgvSubjects.TabIndex = 22;
            // 
            // cmsSubjects
            // 
            cmsSubjects.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, toolStripMenuItem2 });
            cmsSubjects.Name = "cmsEmployees";
            cmsSubjects.Size = new Size(95, 32);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.edit_32;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(94, 22);
            showPersonDetailsToolStripMenuItem.Text = "Edit";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(91, 6);
            // 
            // btnAddNewSubject
            // 
            btnAddNewSubject.Image = (Image)resources.GetObject("btnAddNewSubject.Image");
            btnAddNewSubject.Location = new Point(299, 117);
            btnAddNewSubject.Margin = new Padding(4, 3, 4, 3);
            btnAddNewSubject.Name = "btnAddNewSubject";
            btnAddNewSubject.Size = new Size(32, 30);
            btnAddNewSubject.TabIndex = 27;
            btnAddNewSubject.UseVisualStyleBackColor = true;
            btnAddNewSubject.Click += btnAddNewSubject_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search_5318725;
            pictureBox2.Location = new Point(94, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 196;
            pictureBox2.TabStop = false;
            // 
            // frmSubjectList_cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 418);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddNewSubject);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvSubjects);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSubjectList_cs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSubjectList_cs";
            Load += frmSubjectList_cs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            cmsSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewSubject;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.ContextMenuStrip cmsSubjects;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}