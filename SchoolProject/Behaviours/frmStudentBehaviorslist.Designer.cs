namespace SchoolProject.Behaviours
{
    partial class frmStudentBehaviorslist
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
            dgvBehaviours = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbIsActive = new ComboBox();
            pictureBox1 = new PictureBox();
            btnAddBehaviour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBehaviours).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBehaviours
            // 
            dgvBehaviours.AllowUserToAddRows = false;
            dgvBehaviours.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBehaviours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBehaviours.ContextMenuStrip = contextMenuStrip1;
            dgvBehaviours.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBehaviours.Location = new Point(13, 232);
            dgvBehaviours.Margin = new Padding(4, 3, 4, 3);
            dgvBehaviours.Name = "dgvBehaviours";
            dgvBehaviours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBehaviours.Size = new Size(590, 302);
            dgvBehaviours.TabIndex = 126;
            dgvBehaviours.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, editToolStripMenuItem, toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 54);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(141, 22);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(141, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new Point(101, 198);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(131, 26);
            cbFilterBy.TabIndex = 131;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(243, 199);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(162, 24);
            txtFilterValue.TabIndex = 130;
            txtFilterValue.Visible = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(121, 541);
            lblRecordsCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(23, 16);
            lblRecordsCount.TabIndex = 129;
            lblRecordsCount.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 537);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 128;
            label3.Text = "# Records:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 127;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(208, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 125;
            label1.Text = "Behaviours List";
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(325, 199);
            cbIsActive.Margin = new Padding(4, 3, 4, 3);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(155, 26);
            cbIsActive.TabIndex = 132;
            cbIsActive.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_behavior_12448319;
            pictureBox1.Location = new Point(208, 11);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 124;
            pictureBox1.TabStop = false;
            // 
            // btnAddBehaviour
            // 
            btnAddBehaviour.Image = Properties.Resources.icons8_notes_24;
            btnAddBehaviour.Location = new Point(572, 196);
            btnAddBehaviour.Margin = new Padding(4, 3, 4, 3);
            btnAddBehaviour.Name = "btnAddBehaviour";
            btnAddBehaviour.Size = new Size(31, 32);
            btnAddBehaviour.TabIndex = 133;
            btnAddBehaviour.UseVisualStyleBackColor = true;
            btnAddBehaviour.Click += btnAddBehaviour_Click;
            // 
            // frmStudentBehaviorslist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 563);
            Controls.Add(pictureBox1);
            Controls.Add(dgvBehaviours);
            Controls.Add(btnAddBehaviour);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbIsActive);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStudentBehaviorslist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentBehaviorslist";
            Load += frmStudentBehaviorslist_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBehaviours).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBehaviours;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddBehaviour;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}