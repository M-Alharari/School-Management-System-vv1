namespace SchoolProject.AcademicYear
{
    partial class frmAcademicYearList
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
            lblRecordCount = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvAcademicYears = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            relatedTermsToolStripMenuItem = new ToolStripMenuItem();
            btnAddAcademicYear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAcademicYears).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(74, 470);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 50;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 470);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 49;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(108, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(329, 37);
            label3.TabIndex = 47;
            label3.Text = "Academic Years List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAcademicYears
            // 
            dgvAcademicYears.AllowUserToAddRows = false;
            dgvAcademicYears.AllowUserToDeleteRows = false;
            dgvAcademicYears.AllowUserToResizeColumns = false;
            dgvAcademicYears.AllowUserToResizeRows = false;
            dgvAcademicYears.BackgroundColor = Color.White;
            dgvAcademicYears.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcademicYears.ContextMenuStrip = contextMenuStrip1;
            dgvAcademicYears.Location = new Point(13, 189);
            dgvAcademicYears.Margin = new Padding(4, 3, 4, 3);
            dgvAcademicYears.Name = "dgvAcademicYears";
            dgvAcademicYears.ReadOnly = true;
            dgvAcademicYears.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvAcademicYears.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcademicYears.Size = new Size(485, 274);
            dgvAcademicYears.TabIndex = 46;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, relatedTermsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // relatedTermsToolStripMenuItem
            // 
            relatedTermsToolStripMenuItem.Image = Properties.Resources.time_study_105462802;
            relatedTermsToolStripMenuItem.Name = "relatedTermsToolStripMenuItem";
            relatedTermsToolStripMenuItem.Size = new Size(147, 22);
            relatedTermsToolStripMenuItem.Text = "Related Terms";
            relatedTermsToolStripMenuItem.Click += relatedTermsToolStripMenuItem_Click;
            // 
            // btnAddAcademicYear
            // 
            btnAddAcademicYear.Image = Properties.Resources.add;
            btnAddAcademicYear.Location = new Point(460, 152);
            btnAddAcademicYear.Margin = new Padding(4, 3, 4, 3);
            btnAddAcademicYear.Name = "btnAddAcademicYear";
            btnAddAcademicYear.Size = new Size(38, 31);
            btnAddAcademicYear.TabIndex = 51;
            btnAddAcademicYear.UseVisualStyleBackColor = true;
            btnAddAcademicYear.Click += btnAddAcademicYear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.semester_4776016;
            pictureBox1.Location = new Point(145, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // frmAcademicYearList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 497);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvAcademicYears);
            Controls.Add(btnAddAcademicYear);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmAcademicYearList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAcademicYearList";
            Load += frmAcademicYearList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAcademicYears).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordCount;
        private Label label1;
        private Label label3;
        private DataGridView dgvAcademicYears;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button btnAddAcademicYear;
        private PictureBox pictureBox1;
        private ToolStripMenuItem relatedTermsToolStripMenuItem;
    }
}