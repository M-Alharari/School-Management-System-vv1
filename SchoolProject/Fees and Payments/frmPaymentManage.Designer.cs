namespace SchoolProject.Fees_and_Payments
{
    partial class frmPaymentManage
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
            cmsEmployees = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            lblRecordCount = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvPayments = new DataGridView();
            pictureBox1 = new PictureBox();
            cbIsPaid = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label4 = new Label();
            cmsEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmsEmployees
            // 
            cmsEmployees.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2 });
            cmsEmployees.Name = "cmsEmployees";
            cmsEmployees.Size = new Size(186, 76);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(185, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Student Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(185, 22);
            editToolStripMenuItem.Text = "Pay installment";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(185, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(182, 6);
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(65, 560);
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
            label1.Location = new Point(6, 560);
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
            label3.Location = new Point(154, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(297, 37);
            label3.TabIndex = 39;
            label3.Text = "Manage Payments";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.ContextMenuStrip = cmsEmployees;
            dgvPayments.Location = new Point(6, 243);
            dgvPayments.Margin = new Padding(4, 3, 4, 3);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(592, 314);
            dgvPayments.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.payment;
            pictureBox1.Location = new Point(167, 11);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // cbIsPaid
            // 
            cbIsPaid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsPaid.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsPaid.FormattingEnabled = true;
            cbIsPaid.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsPaid.Location = new Point(250, 211);
            cbIsPaid.Margin = new Padding(4, 3, 4, 3);
            cbIsPaid.Name = "cbIsPaid";
            cbIsPaid.Size = new Size(133, 26);
            cbIsPaid.TabIndex = 126;
            cbIsPaid.Visible = false;
            cbIsPaid.SelectedIndexChanged += cbIsPaid_SelectedIndexChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Student ID", "Full Name", "Is Paid" });
            cbFilterBy.Location = new Point(80, 210);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(161, 26);
            cbFilterBy.TabIndex = 125;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(250, 212);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(214, 24);
            txtFilterValue.TabIndex = 124;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 123;
            label4.Text = "Filter By:";
            // 
            // frmPaymentManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(606, 581);
            Controls.Add(cbIsPaid);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvPayments);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPaymentManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTuitionPayment";
            Load += frmPaymentManagement_Load;
            cmsEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.ComboBox cbIsPaid;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label4;
    }
}