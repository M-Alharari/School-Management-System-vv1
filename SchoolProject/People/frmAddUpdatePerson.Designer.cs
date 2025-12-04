namespace SchoolProject.People
{
    partial class frmAddUpdatePerson
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
            llRemoveImage = new LinkLabel();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label5 = new Label();
            cbCountry = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            llSetImage = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            txtAddress = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            pictureBox9 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            dtpDateOfBirth = new DateTimePicker();
            btnClose = new Button();
            label15 = new Label();
            label12 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNationalNo = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            pbPersonImage = new PictureBox();
            btnSave = new Button();
            lblTitle = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblPersonID = new Label();
            label22 = new Label();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(652, 291);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(68, 20);
            llRemoveImage.TabIndex = 112;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(244, 162);
            rbFemale.Margin = new Padding(4, 3, 4, 3);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(71, 20);
            rbFemale.TabIndex = 8;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            rbFemale.Validating += ValidateEmptyTextBox;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(146, 162);
            rbMale.Margin = new Padding(4, 3, 4, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(55, 20);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 156);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 106;
            label5.Text = "Gender";
            // 
            // cbCountry
            // 
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(461, 202);
            cbCountry.Margin = new Padding(4, 3, 4, 3);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(143, 28);
            cbCountry.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(663, 39);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 103;
            label10.Text = "Last";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(504, 39);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 102;
            label9.Text = "Third";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 42);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 100;
            label7.Text = "First";
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(652, 265);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(83, 20);
            llSetImage.TabIndex = 13;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetIconAlignment(txtAddress, ErrorIconAlignment.BottomLeft);
            txtAddress.Location = new Point(145, 255);
            txtAddress.Margin = new Padding(5, 6, 5, 6);
            txtAddress.MaxLength = 50;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(459, 86);
            txtAddress.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(340, 42);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 101;
            label8.Text = "Second";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(btnSave);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 77);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(768, 406);
            groupBox1.TabIndex = 119;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Woman_32;
            pictureBox9.Location = new Point(202, 157);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(36, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 110;
            pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Man_32;
            pictureBox1.Location = new Point(97, 159);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 109;
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(98, 66);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 105;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Address_32;
            pictureBox7.Location = new Point(97, 255);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Country_32;
            pictureBox6.Location = new Point(413, 203);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 98;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(97, 207);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 97;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(412, 112);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 96;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(98, 111);
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
            pictureBox2.Location = new Point(412, 157);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/M/yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(460, 116);
            dtpDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(143, 26);
            dtpDateOfBirth.TabIndex = 6;
            dtpDateOfBirth.Value = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.delete_button_103788231;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(389, 353);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 30);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(318, 209);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 93;
            label15.Text = "Country:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(9, 257);
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
            txtEmail.Location = new Point(142, 207);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 26);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 205);
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
            txtPhone.Location = new Point(461, 152);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(143, 26);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(318, 167);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 90;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 115);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 89;
            label3.Text = "Birth Date:";
            // 
            // txtNationalNo
            // 
            txtNationalNo.BorderStyle = BorderStyle.FixedSingle;
            txtNationalNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNationalNo.Location = new Point(143, 111);
            txtNationalNo.Margin = new Padding(5, 6, 5, 6);
            txtNationalNo.MaxLength = 50;
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(143, 26);
            txtNationalNo.TabIndex = 5;
            txtNationalNo.Validating += txtNationalNo_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 115);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 88;
            label2.Text = "Natio. No:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(614, 70);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(143, 26);
            txtLastName.TabIndex = 4;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // txtThirdName
            // 
            txtThirdName.BorderStyle = BorderStyle.FixedSingle;
            txtThirdName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThirdName.Location = new Point(461, 70);
            txtThirdName.Margin = new Padding(5, 6, 5, 6);
            txtThirdName.MaxLength = 50;
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(143, 26);
            txtThirdName.TabIndex = 3;
            txtThirdName.Validating += ValidateEmptyTextBox;
            // 
            // txtSecondName
            // 
            txtSecondName.BorderStyle = BorderStyle.FixedSingle;
            txtSecondName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecondName.Location = new Point(304, 70);
            txtSecondName.Margin = new Padding(5, 6, 5, 6);
            txtSecondName.MaxLength = 50;
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(143, 26);
            txtSecondName.TabIndex = 2;
            txtSecondName.Validating += ValidateEmptyTextBox;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 87;
            label1.Text = "Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(143, 68);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(143, 26);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.Male_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(614, 116);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(143, 143);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 85;
            pbPersonImage.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_177712765;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(501, 353);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 30);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(118, 14);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(528, 42);
            lblTitle.TabIndex = 120;
            lblTitle.Text = "Add New Person";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(167, 56);
            lblPersonID.Margin = new Padding(5, 0, 5, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(38, 20);
            lblPersonID.TabIndex = 122;
            lblPersonID.Text = "N/A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(10, 56);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 121;
            label22.Text = "Person ID :";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Number_32;
            pictureBox10.Location = new Point(118, 51);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 123;
            pictureBox10.TabStop = false;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(775, 488);
            Controls.Add(pictureBox10);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblPersonID);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}