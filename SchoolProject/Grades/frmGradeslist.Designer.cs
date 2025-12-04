namespace SchoolProject
{
    partial class frmGradeslist
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
            dgvGrades = new DataGridView();
            pictureBox2 = new PictureBox();
            btnAddNewClass = new Button();
            cmsClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
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
            lblRecordCount.Location = new Point(65, 448);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 45;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 448);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 44;
            label1.Text = "Record:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(178, 158);
            txtFilterValue.Margin = new Padding(4, 3, 4, 3);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(112, 20);
            txtFilterValue.TabIndex = 43;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 42;
            label2.Text = "Filter by";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Grade ID", "Grade Name" });
            cbFilterBy.Location = new Point(64, 157);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(106, 21);
            cbFilterBy.TabIndex = 41;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(111, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 40;
            label3.Text = "Manage Grades";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.BackgroundColor = Color.White;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.ContextMenuStrip = cmsClasses;
            dgvGrades.Location = new Point(6, 184);
            dgvGrades.Margin = new Padding(4, 3, 4, 3);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(374, 261);
            dgvGrades.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lecture_17627123;
            pictureBox2.Location = new Point(107, 6);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 188;
            pictureBox2.TabStop = false;
            // 
            // btnAddNewClass
            // 
            btnAddNewClass.Image = Properties.Resources.add;
            btnAddNewClass.Location = new Point(349, 155);
            btnAddNewClass.Margin = new Padding(4, 3, 4, 3);
            btnAddNewClass.Name = "btnAddNewClass";
            btnAddNewClass.Size = new Size(31, 23);
            btnAddNewClass.TabIndex = 38;
            btnAddNewClass.UseVisualStyleBackColor = true;
            btnAddNewClass.Click += btnAddNewClass_Click;
            // 
            // frmGradeslist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(385, 472);
            Controls.Add(pictureBox2);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(btnAddNewClass);
            Controls.Add(dgvGrades);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGradeslist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGradeslist";
            Load += frmGradeslist_Load;
            cmsClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
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
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}