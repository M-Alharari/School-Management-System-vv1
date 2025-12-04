namespace SchoolProject.Users
{
    partial class frmManageUsers
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
            cbIsActive = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            callPhoneToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            dgvUsers = new DataGridView();
            btnAddPerson = new Button();
            pictureBox1 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(220, 217);
            cbIsActive.Margin = new Padding(4, 3, 4, 3);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(140, 26);
            cbIsActive.TabIndex = 122;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new Point(84, 218);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(129, 26);
            cbFilterBy.TabIndex = 121;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(220, 217);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(298, 24);
            txtFilterValue.TabIndex = 120;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(117, 561);
            lblRecordsCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(23, 16);
            lblRecordsCount.TabIndex = 119;
            lblRecordsCount.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 558);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 118;
            label3.Text = "# Records:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 224);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 117;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(220, 165);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 115;
            label1.Text = "Manage Users";
            // 
            // callPhoneToolStripMenuItem
            // 
            callPhoneToolStripMenuItem.Image = Properties.Resources.call_32;
            callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            callPhoneToolStripMenuItem.Size = new Size(180, 22);
            callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = Properties.Resources.edit_32;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Change Password";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(180, 22);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(180, 22);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewUserToolStripMenuItem, toolStripMenuItem3, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, toolStripMenuItem2, callPhoneToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 186);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.Email_32;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Send Email";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new Point(9, 250);
            dgvUsers.Margin = new Padding(4, 3, 4, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(580, 305);
            dgvUsers.TabIndex = 116;
            dgvUsers.TabStop = false;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Image = Properties.Resources.AddPerson_32;
            btnAddPerson.Location = new Point(546, 209);
            btnAddPerson.Margin = new Padding(4, 3, 4, 3);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(43, 35);
            btnAddPerson.TabIndex = 123;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.users_167124;
            pictureBox1.Location = new Point(198, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 114;
            pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(593, 583);
            Controls.Add(btnAddPerson);
            Controls.Add(cbIsActive);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUsers);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmManageUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmManageUsers";
            Load += frmManageUsers_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}