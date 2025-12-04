namespace SchoolProject.Fees_and_Payments
{
    partial class frmPayInstallment
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
            pictureBox13 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblInstallmentNumber = new Label();
            label11 = new Label();
            label3 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblFullName = new Label();
            lblAmount = new Label();
            lblTotalPaid = new Label();
            label111 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            lblDueDate = new Label();
            cbIsPaid = new CheckBox();
            lblPaidIn = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save_1777127610;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(474, 260);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 32);
            btnSave.TabIndex = 281;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.money_32;
            pictureBox13.Location = new Point(119, 125);
            pictureBox13.Margin = new Padding(5, 4, 5, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(39, 31);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 286;
            pictureBox13.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(119, 182);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 271;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(119, 68);
            pictureBox8.Margin = new Padding(5, 4, 5, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 265;
            pictureBox8.TabStop = false;
            // 
            // lblInstallmentNumber
            // 
            lblInstallmentNumber.AutoSize = true;
            lblInstallmentNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblInstallmentNumber.ForeColor = Color.FromArgb(192, 0, 0);
            lblInstallmentNumber.Location = new Point(169, 132);
            lblInstallmentNumber.Margin = new Padding(6, 0, 6, 0);
            lblInstallmentNumber.Name = "lblInstallmentNumber";
            lblInstallmentNumber.Size = new Size(49, 20);
            lblInstallmentNumber.TabIndex = 287;
            lblInstallmentNumber.Text = "[????]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(8, 132);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 17);
            label11.TabIndex = 285;
            label11.Text = "Install Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(8, 189);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 270;
            label3.Text = "Due Amount:";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(103, 9);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(379, 55);
            lblTitle.TabIndex = 267;
            lblTitle.Text = "Pay Tuition Installment";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(8, 75);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 264;
            label1.Text = "Student Name:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(192, 0, 0);
            lblFullName.Location = new Point(169, 75);
            lblFullName.Margin = new Padding(6, 0, 6, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(49, 20);
            lblFullName.TabIndex = 266;
            lblFullName.Text = "[????]";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(192, 0, 0);
            lblAmount.Location = new Point(169, 189);
            lblAmount.Margin = new Padding(6, 0, 6, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(49, 20);
            lblAmount.TabIndex = 289;
            lblAmount.Text = "[????]";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTotalPaid.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotalPaid.Location = new Point(450, 189);
            lblTotalPaid.Margin = new Padding(6, 0, 6, 0);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(49, 20);
            lblTotalPaid.TabIndex = 227;
            lblTotalPaid.Text = "[????]";
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label111.Location = new Point(319, 189);
            label111.Margin = new Padding(6, 0, 6, 0);
            label111.Name = "label111";
            label111.Size = new Size(78, 17);
            label111.TabIndex = 225;
            label111.Text = "Total Paid: ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.money_32;
            pictureBox6.Location = new Point(400, 182);
            pictureBox6.Margin = new Padding(5, 4, 5, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 226;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(319, 132);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 276;
            label6.Text = " Due Date";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(400, 125);
            pictureBox4.Margin = new Padding(5, 4, 5, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 277;
            pictureBox4.TabStop = false;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDueDate.ForeColor = Color.FromArgb(192, 0, 0);
            lblDueDate.Location = new Point(450, 132);
            lblDueDate.Margin = new Padding(6, 0, 6, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(49, 20);
            lblDueDate.TabIndex = 278;
            lblDueDate.Text = "[????]";
            // 
            // cbIsPaid
            // 
            cbIsPaid.AutoSize = true;
            cbIsPaid.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsPaid.Location = new Point(389, 230);
            cbIsPaid.Margin = new Padding(5, 4, 5, 4);
            cbIsPaid.Name = "cbIsPaid";
            cbIsPaid.Size = new Size(110, 22);
            cbIsPaid.TabIndex = 290;
            cbIsPaid.Text = "Install Status";
            cbIsPaid.UseVisualStyleBackColor = true;
            // 
            // lblPaidIn
            // 
            lblPaidIn.AutoSize = true;
            lblPaidIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPaidIn.ForeColor = Color.FromArgb(192, 0, 0);
            lblPaidIn.Location = new Point(169, 242);
            lblPaidIn.Margin = new Padding(6, 0, 6, 0);
            lblPaidIn.Name = "lblPaidIn";
            lblPaidIn.Size = new Size(49, 20);
            lblPaidIn.TabIndex = 293;
            lblPaidIn.Text = "[????]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(11, 242);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 291;
            label4.Text = "Paid In:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calendar_32;
            pictureBox1.Location = new Point(119, 235);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 294;
            pictureBox1.TabStop = false;
            // 
            // frmPayInstallment
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 305);
            Controls.Add(pictureBox1);
            Controls.Add(lblPaidIn);
            Controls.Add(label4);
            Controls.Add(cbIsPaid);
            Controls.Add(lblAmount);
            Controls.Add(btnSave);
            Controls.Add(lblTotalPaid);
            Controls.Add(pictureBox13);
            Controls.Add(label111);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox8);
            Controls.Add(lblInstallmentNumber);
            Controls.Add(label11);
            Controls.Add(lblDueDate);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(lblFullName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmPayInstallment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblInstallmentNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbIsPaid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPaidIn;
        private System.Windows.Forms.Label label4;
    }
}