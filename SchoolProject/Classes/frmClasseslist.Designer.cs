namespace SchoolProject.Classes
{
    partial class frmClasseslist
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
            lblRecordCount = new Label();
            label1 = new Label();
            txtFilterValue = new TextBox();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            label3 = new Label();
            dgvClasses = new DataGridView();
            cbGrades = new ComboBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnAddNewClass = new Button();
            cmsClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmsClasses
            // 
            cmsClasses.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2 });
            cmsClasses.Name = "cmsEmployees";
            cmsClasses.Size = new Size(181, 76);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(180, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit ";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(62, 482);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 36;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 482);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 35;
            label1.Text = "Record:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(216, 194);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(112, 21);
            txtFilterValue.TabIndex = 34;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 33;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Class ID", "Class Name" });
            cbFilterBy.Location = new Point(77, 192);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(131, 23);
            cbFilterBy.TabIndex = 32;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(108, 131);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 31;
            label3.Text = "Manage Classes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvClasses
            // 
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.ContextMenuStrip = cmsClasses;
            dgvClasses.Location = new Point(4, 225);
            dgvClasses.Margin = new Padding(4, 3, 4, 3);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(414, 254);
            dgvClasses.TabIndex = 28;
            // 
            // cbGrades
            // 
            cbGrades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrades.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGrades.FormattingEnabled = true;
            cbGrades.Items.AddRange(new object[] { "None", "Class ID", "Class Name" });
            cbGrades.Location = new Point(77, 159);
            cbGrades.Margin = new Padding(4, 3, 4, 3);
            cbGrades.Name = "cbGrades";
            cbGrades.Size = new Size(131, 23);
            cbGrades.TabIndex = 37;
            cbGrades.SelectedIndexChanged += cbGrades_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 38;
            label4.Text = "Grade:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pc_13367789;
            pictureBox2.Location = new Point(112, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 187;
            pictureBox2.TabStop = false;
            // 
            // btnAddNewClass
            // 
            btnAddNewClass.Image = Properties.Resources.plus_5169213__4_;
            btnAddNewClass.Location = new Point(381, 187);
            btnAddNewClass.Margin = new Padding(4, 3, 4, 3);
            btnAddNewClass.Name = "btnAddNewClass";
            btnAddNewClass.Size = new Size(36, 32);
            btnAddNewClass.TabIndex = 29;
            btnAddNewClass.UseVisualStyleBackColor = true;
            btnAddNewClass.Click += btnAddNewClass_Click;
            // 
            // frmClasseslist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 506);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(cbGrades);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(btnAddNewClass);
            Controls.Add(dgvClasses);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmClasseslist";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmClassList";
            Load += frmClasseslist_Load;
            cmsClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.Button btnAddNewClass;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}