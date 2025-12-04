namespace SchoolProject.Terms
{
    partial class frmTermslist
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
            dgvTerms = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            btnAddNewTerm = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTerms).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(73, 446);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 44;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 446);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 43;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(204, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 37);
            label3.TabIndex = 41;
            label3.Text = "Terms list";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTerms
            // 
            dgvTerms.AllowUserToAddRows = false;
            dgvTerms.AllowUserToDeleteRows = false;
            dgvTerms.AllowUserToResizeColumns = false;
            dgvTerms.AllowUserToResizeRows = false;
            dgvTerms.BackgroundColor = Color.White;
            dgvTerms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerms.ContextMenuStrip = contextMenuStrip1;
            dgvTerms.Location = new Point(13, 192);
            dgvTerms.Margin = new Padding(4, 3, 4, 3);
            dgvTerms.Name = "dgvTerms";
            dgvTerms.ReadOnly = true;
            dgvTerms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvTerms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTerms.Size = new Size(523, 251);
            dgvTerms.TabIndex = 40;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // btnAddNewTerm
            // 
            btnAddNewTerm.Image = Properties.Resources.add;
            btnAddNewTerm.Location = new Point(498, 155);
            btnAddNewTerm.Margin = new Padding(4, 3, 4, 3);
            btnAddNewTerm.Name = "btnAddNewTerm";
            btnAddNewTerm.Size = new Size(38, 31);
            btnAddNewTerm.TabIndex = 45;
            btnAddNewTerm.UseVisualStyleBackColor = true;
            btnAddNewTerm.Click += btnAddNewTerm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.time_study_105462801;
            pictureBox1.Location = new Point(157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // frmTermslist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(544, 470);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvTerms);
            Controls.Add(btnAddNewTerm);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTermslist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTermslist";
            Load += frmTermslist_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTerms).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTerms;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewTerm;
        private PictureBox pictureBox1;
    }
}