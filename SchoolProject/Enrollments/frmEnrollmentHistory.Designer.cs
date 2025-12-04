namespace SchoolProject.Enrollment_Management
{
    partial class frmEnrollmentHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ctrlStudentCard1 = new SchoolProject.Students.ctrlStudentCard();
            cmsbehaviourhistory = new ContextMenuStrip(components);
            InternationalLicenseHistorytoolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblBehaviourCount = new Label();
            label5 = new Label();
            dgvBehaviour = new DataGridView();
            tbStudentBehaviours = new TabPage();
            tcEnrollHistory = new TabControl();
            cmsLocalLicenseHistory = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tpStudentInfo = new TabPage();
            label1 = new Label();
            lblRecordCount = new Label();
            label2 = new Label();
            dgvHistory = new DataGridView();
            groupBox1 = new GroupBox();
            lblTitle = new Label();
            cmsbehaviourhistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBehaviour).BeginInit();
            tbStudentBehaviours.SuspendLayout();
            tcEnrollHistory.SuspendLayout();
            cmsLocalLicenseHistory.SuspendLayout();
            tpStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlStudentCard1
            // 
            ctrlStudentCard1.BackColor = Color.White;
            ctrlStudentCard1.Location = new Point(13, 46);
            ctrlStudentCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlStudentCard1.Name = "ctrlStudentCard1";
            ctrlStudentCard1.Size = new Size(701, 287);
            ctrlStudentCard1.TabIndex = 141;
            // 
            // cmsbehaviourhistory
            // 
            cmsbehaviourhistory.Items.AddRange(new ToolStripItem[] { InternationalLicenseHistorytoolStripMenuItem });
            cmsbehaviourhistory.Name = "cmsLocalLicenseHistory";
            cmsbehaviourhistory.Size = new Size(181, 48);
            cmsbehaviourhistory.Opening += cmsbehaviourhistory_Opening;
            // 
            // InternationalLicenseHistorytoolStripMenuItem
            // 
            InternationalLicenseHistorytoolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            InternationalLicenseHistorytoolStripMenuItem.Name = "InternationalLicenseHistorytoolStripMenuItem";
            InternationalLicenseHistorytoolStripMenuItem.Size = new Size(180, 22);
            InternationalLicenseHistorytoolStripMenuItem.Text = "Show Behaviour list";
            InternationalLicenseHistorytoolStripMenuItem.Click += InternationalLicenseHistorytoolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 20);
            label3.TabIndex = 139;
            label3.Text = "Student Behaviours History:";
            // 
            // lblBehaviourCount
            // 
            lblBehaviourCount.AutoSize = true;
            lblBehaviourCount.Location = new Point(126, 252);
            lblBehaviourCount.Margin = new Padding(4, 0, 4, 0);
            lblBehaviourCount.Name = "lblBehaviourCount";
            lblBehaviourCount.Size = new Size(17, 15);
            lblBehaviourCount.TabIndex = 138;
            lblBehaviourCount.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 252);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 137;
            label5.Text = "# Records:";
            // 
            // dgvBehaviour
            // 
            dgvBehaviour.AllowUserToAddRows = false;
            dgvBehaviour.AllowUserToDeleteRows = false;
            dgvBehaviour.AllowUserToResizeRows = false;
            dgvBehaviour.BackgroundColor = Color.White;
            dgvBehaviour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBehaviour.ContextMenuStrip = cmsbehaviourhistory;
            dgvBehaviour.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBehaviour.Location = new Point(16, 46);
            dgvBehaviour.Margin = new Padding(5, 6, 5, 6);
            dgvBehaviour.MultiSelect = false;
            dgvBehaviour.Name = "dgvBehaviour";
            dgvBehaviour.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBehaviour.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBehaviour.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBehaviour.Size = new Size(640, 168);
            dgvBehaviour.TabIndex = 136;
            dgvBehaviour.TabStop = false;
            dgvBehaviour.CellContentClick += dgvBehaviour_CellContentClick;
            // 
            // tbStudentBehaviours
            // 
            tbStudentBehaviours.Controls.Add(label3);
            tbStudentBehaviours.Controls.Add(lblBehaviourCount);
            tbStudentBehaviours.Controls.Add(label5);
            tbStudentBehaviours.Controls.Add(dgvBehaviour);
            tbStudentBehaviours.Location = new Point(4, 24);
            tbStudentBehaviours.Margin = new Padding(4, 3, 4, 3);
            tbStudentBehaviours.Name = "tbStudentBehaviours";
            tbStudentBehaviours.Padding = new Padding(4, 3, 4, 3);
            tbStudentBehaviours.Size = new Size(668, 243);
            tbStudentBehaviours.TabIndex = 1;
            tbStudentBehaviours.Text = "Behaviours";
            tbStudentBehaviours.UseVisualStyleBackColor = true;
            // 
            // tcEnrollHistory
            // 
            tcEnrollHistory.ContextMenuStrip = cmsLocalLicenseHistory;
            tcEnrollHistory.Controls.Add(tpStudentInfo);
            tcEnrollHistory.Controls.Add(tbStudentBehaviours);
            tcEnrollHistory.Location = new Point(8, 22);
            tcEnrollHistory.Margin = new Padding(4, 3, 4, 3);
            tcEnrollHistory.Name = "tcEnrollHistory";
            tcEnrollHistory.SelectedIndex = 0;
            tcEnrollHistory.Size = new Size(676, 271);
            tcEnrollHistory.TabIndex = 131;
            // 
            // cmsLocalLicenseHistory
            // 
            cmsLocalLicenseHistory.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmsLocalLicenseHistory.Name = "cmsLocalLicenseHistory";
            cmsLocalLicenseHistory.Size = new Size(191, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showLicenseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(190, 38);
            showLicenseInfoToolStripMenuItem.Text = "Show Enroll Details";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // tpStudentInfo
            // 
            tpStudentInfo.Controls.Add(label1);
            tpStudentInfo.Controls.Add(lblRecordCount);
            tpStudentInfo.Controls.Add(label2);
            tpStudentInfo.Controls.Add(dgvHistory);
            tpStudentInfo.Location = new Point(4, 24);
            tpStudentInfo.Margin = new Padding(4, 3, 4, 3);
            tpStudentInfo.Name = "tpStudentInfo";
            tpStudentInfo.Padding = new Padding(4, 3, 4, 3);
            tpStudentInfo.Size = new Size(668, 243);
            tpStudentInfo.TabIndex = 0;
            tpStudentInfo.Text = "StudentInfo";
            tpStudentInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 135;
            label1.Text = "Student History:";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(112, 219);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(24, 18);
            lblRecordCount.TabIndex = 134;
            lblRecordCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 133;
            label2.Text = "# Records:";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.ContextMenuStrip = cmsLocalLicenseHistory;
            dgvHistory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHistory.Location = new Point(8, 50);
            dgvHistory.Margin = new Padding(5, 6, 5, 6);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(651, 163);
            dgvHistory.TabIndex = 132;
            dgvHistory.TabStop = false;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tcEnrollHistory);
            groupBox1.Location = new Point(13, 339);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(697, 299);
            groupBox1.TabIndex = 140;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(97, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(537, 43);
            lblTitle.TabIndex = 139;
            lblTitle.Text = "Enrollment History";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEnrollmentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 650);
            Controls.Add(ctrlStudentCard1);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEnrollmentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEnrollmentHistorys";
            Load += frmEnrollmentHistorys_Load;
            cmsbehaviourhistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBehaviour).EndInit();
            tbStudentBehaviours.ResumeLayout(false);
            tbStudentBehaviours.PerformLayout();
            tcEnrollHistory.ResumeLayout(false);
            cmsLocalLicenseHistory.ResumeLayout(false);
            tpStudentInfo.ResumeLayout(false);
            tpStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Students.ctrlStudentCard ctrlStudentCard1;
        private System.Windows.Forms.ContextMenuStrip cmsbehaviourhistory;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseHistorytoolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBehaviourCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBehaviour;
        private System.Windows.Forms.TabPage tbStudentBehaviours;
        private System.Windows.Forms.TabControl tcEnrollHistory;
        private System.Windows.Forms.TabPage tpStudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}