namespace SchoolProject.Audit_Log
{
    partial class frmAuditLog
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
            pictureBox1 = new PictureBox();
            btnAddBehaviour = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            lblRecordCount = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbIsActive = new ComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvAuditLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_11333048;
            pictureBox1.Location = new Point(186, 10);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 134;
            pictureBox1.TabStop = false;
            // 
            // btnAddBehaviour
            // 
            btnAddBehaviour.Image = Properties.Resources.icons8_notes_24;
            btnAddBehaviour.Location = new Point(514, 174);
            btnAddBehaviour.Margin = new Padding(4, 3, 4, 3);
            btnAddBehaviour.Name = "btnAddBehaviour";
            btnAddBehaviour.Size = new Size(30, 26);
            btnAddBehaviour.TabIndex = 143;
            btnAddBehaviour.UseVisualStyleBackColor = true;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new Point(101, 175);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(117, 26);
            cbFilterBy.TabIndex = 141;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(231, 174);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(136, 24);
            txtFilterValue.TabIndex = 140;
            txtFilterValue.Visible = false;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(121, 529);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(23, 16);
            lblRecordCount.TabIndex = 139;
            lblRecordCount.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 525);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 138;
            label3.Text = "# Records:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 137;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(231, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 135;
            label1.Text = "Audit Log";
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(325, 174);
            cbIsActive.Margin = new Padding(4, 3, 4, 3);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(90, 26);
            cbIsActive.TabIndex = 142;
            cbIsActive.Visible = false;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(141, 22);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 32);
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AllowUserToAddRows = false;
            dgvAuditLogs.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.ContextMenuStrip = contextMenuStrip1;
            dgvAuditLogs.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAuditLogs.Location = new Point(13, 207);
            dgvAuditLogs.Margin = new Padding(4, 3, 4, 3);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLogs.Size = new Size(531, 315);
            dgvAuditLogs.TabIndex = 136;
            dgvAuditLogs.TabStop = false;
            // 
            // frmAuditLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 555);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddBehaviour);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbIsActive);
            Controls.Add(dgvAuditLogs);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAuditLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAuditLog";
            Load += frmAuditLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBehaviour;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvAuditLogs;
    }
}