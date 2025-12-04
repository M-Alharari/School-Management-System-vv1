namespace SchoolProject.Fees_and_Payments
{
    partial class frmInstallmnetRecord
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
            dgvInstallments = new DataGridView();
            lblTitle = new Label();
            label1 = new Label();
            lblFullName = new Label();
            lblRecordCount = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInstallments).BeginInit();
            SuspendLayout();
            // 
            // dgvInstallments
            // 
            dgvInstallments.AllowUserToAddRows = false;
            dgvInstallments.AllowUserToDeleteRows = false;
            dgvInstallments.BackgroundColor = Color.White;
            dgvInstallments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstallments.Location = new Point(5, 88);
            dgvInstallments.Margin = new Padding(4, 3, 4, 3);
            dgvInstallments.Name = "dgvInstallments";
            dgvInstallments.ReadOnly = true;
            dgvInstallments.Size = new Size(669, 337);
            dgvInstallments.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(44, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(590, 34);
            lblTitle.TabIndex = 243;
            lblTitle.Text = "Student Installment";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(13, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 244;
            label1.Text = "Student Name: ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 12F);
            lblFullName.Location = new Point(130, 65);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(36, 20);
            lblFullName.TabIndex = 245;
            lblFullName.Text = "???";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(62, 428);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 247;
            lblRecordCount.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 428);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 246;
            label2.Text = "Record:";
            // 
            // frmInstallmnetRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(681, 450);
            Controls.Add(lblRecordCount);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(dgvInstallments);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInstallmnetRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPaymentHistory";
            Load += frmPaymentHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstallments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstallments;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
    }
}