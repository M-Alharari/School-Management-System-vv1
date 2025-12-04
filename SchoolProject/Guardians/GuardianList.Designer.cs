namespace SchoolProject.Guardians
{
    partial class GuardianList
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
            cmsClasses = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            selectGuardianToolStripMenuItem = new ToolStripMenuItem();
            lblRecordCount = new Label();
            label1 = new Label();
            txtFilterValue = new TextBox();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            label3 = new Label();
            dgvGuardians = new DataGridView();
            pictureBox1 = new PictureBox();
            cmsClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuardians).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmsClasses
            // 
            cmsClasses.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, selectGuardianToolStripMenuItem });
            cmsClasses.Name = "cmsEmployees";
            cmsClasses.Size = new Size(191, 98);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(190, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Linked Studetns";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(190, 22);
            editToolStripMenuItem.Text = "Select Guardian ";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(190, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(187, 6);
            // 
            // selectGuardianToolStripMenuItem
            // 
            selectGuardianToolStripMenuItem.Name = "selectGuardianToolStripMenuItem";
            selectGuardianToolStripMenuItem.Size = new Size(190, 22);
            selectGuardianToolStripMenuItem.Text = "Select Guardian";
            selectGuardianToolStripMenuItem.Click += selectGuardianToolStripMenuItem_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(72, 550);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 195;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 550);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 194;
            label1.Text = "Record:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(228, 193);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(112, 21);
            txtFilterValue.TabIndex = 193;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 192;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Guardian ID", "Student Name\t\t\t\t\t" });
            cbFilterBy.Location = new Point(90, 192);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(131, 23);
            cbFilterBy.TabIndex = 191;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe Fluent Icons", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(201, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 29);
            label3.TabIndex = 190;
            label3.Text = "Manage Guardians";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvGuardians
            // 
            dgvGuardians.AllowUserToAddRows = false;
            dgvGuardians.AllowUserToDeleteRows = false;
            dgvGuardians.BackgroundColor = Color.White;
            dgvGuardians.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuardians.ContextMenuStrip = cmsClasses;
            dgvGuardians.Location = new Point(13, 218);
            dgvGuardians.Margin = new Padding(4, 3, 4, 3);
            dgvGuardians.Name = "dgvGuardians";
            dgvGuardians.ReadOnly = true;
            dgvGuardians.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuardians.Size = new Size(546, 329);
            dgvGuardians.TabIndex = 188;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.father_son_2969697;
            pictureBox1.Location = new Point(199, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 196;
            pictureBox1.TabStop = false;
            // 
            // GuardianList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(566, 575);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(dgvGuardians);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GuardianList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianList";
            Load += GuardianList_Load;
            cmsClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuardians).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsClasses;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvGuardians;
        private System.Windows.Forms.ToolStripMenuItem selectGuardianToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}