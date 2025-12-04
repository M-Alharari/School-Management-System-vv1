namespace SchoolProject.People
{
    partial class frmPeopleManage
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
            label3 = new Label();
            txtFilter = new TextBox();
            cbPeopleFilter = new ComboBox();
            lblRecord = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStripSeparator1 = new ToolStripSeparator();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDeatilsToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            callPhoneToolStripMenuItem = new ToolStripMenuItem();
            dgvPeople = new DataGridView();
            btnAddNewPerson = new Button();
            pictureBox1 = new PictureBox();
            enModeBindingSource = new BindingSource(components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enModeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 19;
            label3.Text = "Filter by";
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(282, 214);
            txtFilter.Margin = new Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(157, 26);
            txtFilter.TabIndex = 17;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbPeopleFilter
            // 
            cbPeopleFilter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPeopleFilter.FormattingEnabled = true;
            cbPeopleFilter.Items.AddRange(new object[] { "None", "Person ID", "National No.", "Full Name", "Nationality", "Gender", " " });
            cbPeopleFilter.Location = new Point(97, 217);
            cbPeopleFilter.Margin = new Padding(4, 3, 4, 3);
            cbPeopleFilter.Name = "cbPeopleFilter";
            cbPeopleFilter.Size = new Size(177, 24);
            cbPeopleFilter.TabIndex = 16;
            cbPeopleFilter.SelectedIndexChanged += cbPeopleFilter_SelectedIndexChanged;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecord.Location = new Point(72, 610);
            lblRecord.Margin = new Padding(4, 0, 4, 0);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(28, 16);
            lblRecord.TabIndex = 15;
            lblRecord.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(13, 610);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 16);
            label2.TabIndex = 14;
            label2.Text = "#Record:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(225, 166);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 13;
            label1.Text = "Manage People";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(184, 6);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDeatilsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, callPhoneToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(188, 154);
            // 
            // showDeatilsToolStripMenuItem
            // 
            showDeatilsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDeatilsToolStripMenuItem.Name = "showDeatilsToolStripMenuItem";
            showDeatilsToolStripMenuItem.Size = new Size(187, 24);
            showDeatilsToolStripMenuItem.Text = "Show Deatils";
            showDeatilsToolStripMenuItem.Click += showDeatilsToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(187, 24);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(187, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(187, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.Email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(187, 24);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // callPhoneToolStripMenuItem
            // 
            callPhoneToolStripMenuItem.Image = Properties.Resources.call_32;
            callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            callPhoneToolStripMenuItem.Size = new Size(187, 24);
            callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = contextMenuStrip1;
            dgvPeople.Location = new Point(13, 253);
            dgvPeople.Margin = new Padding(4, 3, 4, 3);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(584, 354);
            dgvPeople.TabIndex = 11;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Image = Properties.Resources.AddPerson_32;
            btnAddNewPerson.Location = new Point(567, 214);
            btnAddNewPerson.Margin = new Padding(4, 3, 4, 3);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(30, 32);
            btnAddNewPerson.TabIndex = 18;
            btnAddNewPerson.Text = " ";
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people_104415541;
            pictureBox1.Location = new Point(214, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // enModeBindingSource
            // 
            enModeBindingSource.AllowNew = true;
            // 
            // frmPeopleManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 635);
            Controls.Add(label3);
            Controls.Add(btnAddNewPerson);
            Controls.Add(txtFilter);
            Controls.Add(cbPeopleFilter);
            Controls.Add(lblRecord);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPeople);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPeopleManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPeopleManage";
            Load += frmPeopleManage_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enModeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource enModeBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbPeopleFilter;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeatilsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}