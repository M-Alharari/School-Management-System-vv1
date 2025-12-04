namespace SchoolProject
{
    partial class frmTuitionPayment
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
            btnSave = new Button();
            btnManage = new Button();
            errorProvider1 = new ErrorProvider(components);
            cmbPaymentMode = new ComboBox();
            lblFirstPaymentDate = new Label();
            lblIsFullyPaid = new Label();
            cmbInstallmentFrequencyID = new ComboBox();
            label14 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox12 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            txtTotalFees = new TextBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblTitle = new Label();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblFullName = new Label();
            lblPaidFees = new Label();
            btnrecept = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(538, 297);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 29);
            btnSave.TabIndex = 256;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(393, 297);
            btnManage.Margin = new Padding(4, 3, 4, 3);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(136, 29);
            btnManage.TabIndex = 263;
            btnManage.Text = "Manage Installment";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Location = new Point(190, 127);
            cmbPaymentMode.Margin = new Padding(4, 3, 4, 3);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(126, 23);
            cmbPaymentMode.TabIndex = 285;
            // 
            // lblFirstPaymentDate
            // 
            lblFirstPaymentDate.AutoSize = true;
            lblFirstPaymentDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblFirstPaymentDate.ForeColor = Color.FromArgb(192, 0, 0);
            lblFirstPaymentDate.Location = new Point(507, 245);
            lblFirstPaymentDate.Margin = new Padding(5, 0, 5, 0);
            lblFirstPaymentDate.Name = "lblFirstPaymentDate";
            lblFirstPaymentDate.Size = new Size(54, 18);
            lblFirstPaymentDate.TabIndex = 284;
            lblFirstPaymentDate.Text = "[????]";
            // 
            // lblIsFullyPaid
            // 
            lblIsFullyPaid.AutoSize = true;
            lblIsFullyPaid.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblIsFullyPaid.ForeColor = Color.FromArgb(192, 0, 0);
            lblIsFullyPaid.Location = new Point(183, 245);
            lblIsFullyPaid.Margin = new Padding(5, 0, 5, 0);
            lblIsFullyPaid.Name = "lblIsFullyPaid";
            lblIsFullyPaid.Size = new Size(54, 18);
            lblIsFullyPaid.TabIndex = 269;
            lblIsFullyPaid.Text = "[????]";
            // 
            // cmbInstallmentFrequencyID
            // 
            cmbInstallmentFrequencyID.FormattingEnabled = true;
            cmbInstallmentFrequencyID.Items.AddRange(new object[] { " None", " Monthly", " Quarterly", " SemiAnnual", " Yearly" });
            cmbInstallmentFrequencyID.Location = new Point(507, 127);
            cmbInstallmentFrequencyID.Margin = new Padding(4, 3, 4, 3);
            cmbInstallmentFrequencyID.Name = "cmbInstallmentFrequencyID";
            cmbInstallmentFrequencyID.Size = new Size(126, 23);
            cmbInstallmentFrequencyID.TabIndex = 286;
            cmbInstallmentFrequencyID.SelectedIndexChanged += cmbInstallmentFrequencyID_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label14.Location = new Point(9, 244);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 267;
            label14.Text = "Fully Paid:";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.money_32;
            pictureBox9.Location = new Point(138, 239);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(36, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 268;
            pictureBox9.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.money_32;
            pictureBox12.Location = new Point(464, 123);
            pictureBox12.Margin = new Padding(4, 3, 4, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(36, 30);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 288;
            pictureBox12.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(319, 128);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 287;
            label7.Text = "Install Frequency:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(319, 244);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 282;
            label6.Text = "1st Payment Date:";
            // 
            // txtTotalFees
            // 
            txtTotalFees.BorderStyle = BorderStyle.FixedSingle;
            txtTotalFees.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalFees.Location = new Point(190, 183);
            txtTotalFees.Margin = new Padding(4, 3, 4, 3);
            txtTotalFees.Name = "txtTotalFees";
            txtTotalFees.Size = new Size(126, 24);
            txtTotalFees.TabIndex = 278;
            txtTotalFees.TextChanged += txtTotalFees_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(9, 185);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 276;
            label3.Text = "Total Fees:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(464, 239);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 283;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(319, 185);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 279;
            label4.Text = "Fees Required:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(464, 180);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 280;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(138, 180);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 277;
            pictureBox3.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(49, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(594, 48);
            lblTitle.TabIndex = 273;
            lblTitle.Text = "Pay School Fees";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(141, 69);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 271;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(9, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 270;
            label1.Text = "Student Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money_32;
            pictureBox1.Location = new Point(141, 123);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 275;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(9, 128);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 274;
            label2.Text = "Payment Method:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(192, 0, 0);
            lblFullName.Location = new Point(183, 75);
            lblFullName.Margin = new Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(54, 18);
            lblFullName.TabIndex = 272;
            lblFullName.Text = "[????]";
            // 
            // lblPaidFees
            // 
            lblPaidFees.AutoSize = true;
            lblPaidFees.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblPaidFees.ForeColor = Color.FromArgb(192, 0, 0);
            lblPaidFees.Location = new Point(507, 186);
            lblPaidFees.Margin = new Padding(5, 0, 5, 0);
            lblPaidFees.Name = "lblPaidFees";
            lblPaidFees.Size = new Size(54, 18);
            lblPaidFees.TabIndex = 289;
            lblPaidFees.Text = "[????]";
            // 
            // btnrecept
            // 
            btnrecept.Location = new Point(295, 297);
            btnrecept.Margin = new Padding(4, 3, 4, 3);
            btnrecept.Name = "btnrecept";
            btnrecept.Size = new Size(90, 29);
            btnrecept.TabIndex = 290;
            btnrecept.Text = "Show Receipt";
            btnrecept.UseVisualStyleBackColor = true;
            btnrecept.Click += btnrecept_Click;
            // 
            // frmTuitionPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(712, 358);
            Controls.Add(btnrecept);
            Controls.Add(lblPaidFees);
            Controls.Add(cmbPaymentMode);
            Controls.Add(lblFirstPaymentDate);
            Controls.Add(lblIsFullyPaid);
            Controls.Add(cmbInstallmentFrequencyID);
            Controls.Add(label14);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtTotalFees);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox8);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(btnManage);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTuitionPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label lblFirstPaymentDate;
        private System.Windows.Forms.Label lblIsFullyPaid;
        private System.Windows.Forms.ComboBox cmbInstallmentFrequencyID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPaidFees;
        private System.Windows.Forms.Button btnrecept;
    }
}