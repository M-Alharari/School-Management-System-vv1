namespace SchoolProject.School_Info
{
    partial class frmSchoolInfo
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
            pictureBox10 = new PictureBox();
            lblPersonID = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            llRemoveLogo = new LinkLabel();
            pictureBox8 = new PictureBox();
            llSetImage = new LinkLabel();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            txtAddress = new TextBox();
            label12 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtNationalNo = new TextBox();
            txtWebsite = new Label();
            label1 = new Label();
            txtSchoolName = new TextBox();
            pbLogo = new PictureBox();
            btnSave = new Button();
            lblTitle = new Label();
            label22 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Number_32;
            pictureBox10.Location = new Point(99, 53);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 128;
            pictureBox10.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(144, 58);
            lblPersonID.Margin = new Padding(5, 0, 5, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(38, 20);
            lblPersonID.TabIndex = 127;
            lblPersonID.Text = "N/A";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llRemoveLogo);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(txtWebsite);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSchoolName);
            groupBox1.Controls.Add(pbLogo);
            groupBox1.Controls.Add(btnSave);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(2, 82);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(628, 361);
            groupBox1.TabIndex = 124;
            groupBox1.TabStop = false;
            // 
            // llRemoveLogo
            // 
            llRemoveLogo.AutoSize = true;
            llRemoveLogo.Location = new Point(528, 292);
            llRemoveLogo.Margin = new Padding(4, 0, 4, 0);
            llRemoveLogo.Name = "llRemoveLogo";
            llRemoveLogo.Size = new Size(68, 20);
            llRemoveLogo.TabIndex = 112;
            llRemoveLogo.TabStop = true;
            llRemoveLogo.Text = "Remove";
            llRemoveLogo.LinkClicked += llRemoveLogo_LinkClicked_1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(113, 53);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 105;
            pictureBox8.TabStop = false;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(512, 249);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 13;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Address_32;
            pictureBox7.Location = new Point(114, 216);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(113, 156);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 97;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(114, 104);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 95;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Phone_32;
            pictureBox2.Location = new Point(404, 56);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Image = Properties.Resources.delete_button_103788233;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(254, 322);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 32);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetIconAlignment(txtAddress, ErrorIconAlignment.BottomLeft);
            txtAddress.Location = new Point(162, 216);
            txtAddress.Margin = new Padding(5, 6, 5, 6);
            txtAddress.MaxLength = 50;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(302, 94);
            txtAddress.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 223);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 92;
            label12.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(157, 156);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 26);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 163);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 91;
            label6.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(462, 56);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 26);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 58);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 90;
            label4.Text = "Phone:";
            // 
            // txtNationalNo
            // 
            txtNationalNo.BorderStyle = BorderStyle.FixedSingle;
            txtNationalNo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNationalNo.Location = new Point(158, 104);
            txtNationalNo.Margin = new Padding(5, 6, 5, 6);
            txtNationalNo.MaxLength = 50;
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(154, 29);
            txtNationalNo.TabIndex = 5;
            // 
            // txtWebsite
            // 
            txtWebsite.AutoSize = true;
            txtWebsite.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWebsite.Location = new Point(8, 104);
            txtWebsite.Margin = new Padding(5, 0, 5, 0);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(107, 20);
            txtWebsite.TabIndex = 88;
            txtWebsite.Text = "National No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 56);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 87;
            label1.Text = "sch. Name:";
            // 
            // txtSchoolName
            // 
            txtSchoolName.BorderStyle = BorderStyle.FixedSingle;
            txtSchoolName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolName.Location = new Point(157, 56);
            txtSchoolName.Margin = new Padding(5, 6, 5, 6);
            txtSchoolName.MaxLength = 50;
            txtSchoolName.Name = "txtSchoolName";
            txtSchoolName.Size = new Size(155, 26);
            txtSchoolName.TabIndex = 1;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Image = Properties.Resources.Male_512;
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(477, 104);
            pbLogo.Margin = new Padding(5, 6, 5, 6);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(139, 139);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 85;
            pbLogo.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save_177712766;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(358, 322);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 32);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(126, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(459, 41);
            lblTitle.TabIndex = 125;
            lblTitle.Text = "Update School Information";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(16, 58);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new Size(81, 20);
            label22.TabIndex = 126;
            label22.Text = "User ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSchoolInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 450);
            Controls.Add(pictureBox10);
            Controls.Add(lblPersonID);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSchoolInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSchoolInfo";
            Load += frmSchoolInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llRemoveLogo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label txtWebsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSave;
    }
}