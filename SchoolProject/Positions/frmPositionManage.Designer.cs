namespace SchoolProject.Positions
{
    partial class frmPositionManage
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
            dgvPosition = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnAddNewSubject = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPosition).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(72, 441);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 32;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 441);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 31;
            label1.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(137, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 37);
            label3.TabIndex = 29;
            label3.Text = "Positions list";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPosition
            // 
            dgvPosition.AllowUserToAddRows = false;
            dgvPosition.AllowUserToDeleteRows = false;
            dgvPosition.AllowUserToResizeColumns = false;
            dgvPosition.AllowUserToResizeRows = false;
            dgvPosition.BackgroundColor = Color.White;
            dgvPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosition.ContextMenuStrip = contextMenuStrip1;
            dgvPosition.Location = new Point(13, 168);
            dgvPosition.Margin = new Padding(4, 3, 4, 3);
            dgvPosition.Name = "dgvPosition";
            dgvPosition.ReadOnly = true;
            dgvPosition.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPosition.Size = new Size(438, 270);
            dgvPosition.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnAddNewSubject
            // 
            btnAddNewSubject.Image = Properties.Resources.add;
            btnAddNewSubject.Location = new Point(409, 122);
            btnAddNewSubject.Margin = new Padding(4, 3, 4, 3);
            btnAddNewSubject.Name = "btnAddNewSubject";
            btnAddNewSubject.Size = new Size(42, 37);
            btnAddNewSubject.TabIndex = 33;
            btnAddNewSubject.UseVisualStyleBackColor = true;
            btnAddNewSubject.Click += btnAddNewSubject_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_15698184;
            pictureBox1.Location = new Point(160, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // frmPositionManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 467);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddNewSubject);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvPosition);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPositionManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPositionManage";
            Load += frmPositionManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPosition).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewSubject;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}