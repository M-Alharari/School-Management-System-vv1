namespace SchoolProject.Students
{
    partial class ctrlStudentCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox11 = new PictureBox();
            llEditStudentInfo = new LinkLabel();
            lblGrade = new Label();
            label21 = new Label();
            lblStudentID = new Label();
            label31 = new Label();
            pbPersonImage = new PictureBox();
            groupBox2 = new GroupBox();
            lblClass = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            lblRegistredDate = new Label();
            lblStatus = new Label();
            label8 = new Label();
            pictureBox12 = new PictureBox();
            label11 = new Label();
            lblCountry = new Label();
            lblDateOfBirth = new Label();
            lblGradeName = new Label();
            pictureBox14 = new PictureBox();
            lblFullName = new Label();
            pictureBox15 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox19 = new PictureBox();
            label26 = new Label();
            label30 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            SuspendLayout();
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Number_32;
            pictureBox11.Location = new Point(103, 46);
            pictureBox11.Margin = new Padding(4, 3, 4, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(36, 30);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 143;
            pictureBox11.TabStop = false;
            // 
            // llEditStudentInfo
            // 
            llEditStudentInfo.AutoSize = true;
            llEditStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llEditStudentInfo.Location = new Point(539, 81);
            llEditStudentInfo.Margin = new Padding(4, 0, 4, 0);
            llEditStudentInfo.Name = "llEditStudentInfo";
            llEditStudentInfo.Size = new Size(124, 21);
            llEditStudentInfo.TabIndex = 139;
            llEditStudentInfo.TabStop = true;
            llEditStudentInfo.Text = "Edit Student Info";
            llEditStudentInfo.LinkClicked += llEditStudentInfo_LinkClicked;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(5, 143);
            lblGrade.Margin = new Padding(5, 0, 5, 0);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(64, 20);
            lblGrade.TabIndex = 160;
            lblGrade.Text = "Grade:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(5, 56);
            label21.Margin = new Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Size = new Size(102, 20);
            label21.TabIndex = 113;
            label21.Text = "Student ID:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblStudentID.Location = new Point(148, 55);
            lblStudentID.Margin = new Padding(5, 0, 5, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(49, 20);
            lblStudentID.TabIndex = 127;
            lblStudentID.Text = "[????]";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(5, 95);
            label31.Margin = new Padding(5, 0, 5, 0);
            label31.Name = "label31";
            label31.Size = new Size(60, 20);
            label31.TabIndex = 114;
            label31.Text = "Name:";
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.Male_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(539, 107);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(147, 149);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 112;
            pbPersonImage.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblClass);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(lblRegistredDate);
            groupBox2.Controls.Add(pictureBox11);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(pictureBox12);
            groupBox2.Controls.Add(llEditStudentInfo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lblCountry);
            groupBox2.Controls.Add(lblDateOfBirth);
            groupBox2.Controls.Add(lblGradeName);
            groupBox2.Controls.Add(pictureBox14);
            groupBox2.Controls.Add(lblGrade);
            groupBox2.Controls.Add(lblFullName);
            groupBox2.Controls.Add(pictureBox15);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(lblStudentID);
            groupBox2.Controls.Add(pictureBox17);
            groupBox2.Controls.Add(pictureBox19);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(pbPersonImage);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 6);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(692, 279);
            groupBox2.TabIndex = 175;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Information";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblClass.Location = new Point(148, 185);
            lblClass.Margin = new Padding(5, 0, 5, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(49, 20);
            lblClass.TabIndex = 174;
            lblClass.Text = "[????]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.classroom;
            pictureBox1.Location = new Point(103, 180);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 173;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 190);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 172;
            label2.Text = "Class:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Person_32;
            pictureBox5.Location = new Point(407, 226);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 168;
            pictureBox5.TabStop = false;
            // 
            // lblRegistredDate
            // 
            lblRegistredDate.AutoSize = true;
            lblRegistredDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRegistredDate.Location = new Point(148, 233);
            lblRegistredDate.Margin = new Padding(5, 0, 5, 0);
            lblRegistredDate.Name = "lblRegistredDate";
            lblRegistredDate.Size = new Size(49, 20);
            lblRegistredDate.TabIndex = 171;
            lblRegistredDate.Text = "[????]";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(452, 233);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 21);
            lblStatus.TabIndex = 140;
            lblStatus.Text = "[????]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(331, 233);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 139;
            label8.Text = "Status:";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.Calendar_32;
            pictureBox12.Location = new Point(103, 226);
            pictureBox12.Margin = new Padding(4, 3, 4, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(36, 30);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 170;
            pictureBox12.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 235);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 169;
            label11.Text = "Enrolled in:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCountry.Location = new Point(452, 188);
            lblCountry.Margin = new Padding(5, 0, 5, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 21);
            lblCountry.TabIndex = 138;
            lblCountry.Text = "[????]";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(452, 144);
            lblDateOfBirth.Margin = new Padding(5, 0, 5, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(50, 21);
            lblDateOfBirth.TabIndex = 136;
            lblDateOfBirth.Text = "[????]";
            // 
            // lblGradeName
            // 
            lblGradeName.AutoSize = true;
            lblGradeName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblGradeName.Location = new Point(148, 142);
            lblGradeName.Margin = new Padding(5, 0, 5, 0);
            lblGradeName.Name = "lblGradeName";
            lblGradeName.Size = new Size(49, 20);
            lblGradeName.TabIndex = 162;
            lblGradeName.Text = "[????]";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.classroom;
            pictureBox14.Location = new Point(103, 137);
            pictureBox14.Margin = new Padding(4, 3, 4, 3);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(36, 30);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 161;
            pictureBox14.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(192, 0, 0);
            lblFullName.Location = new Point(148, 96);
            lblFullName.Margin = new Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(49, 20);
            lblFullName.TabIndex = 131;
            lblFullName.Text = "[????]";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.Calendar_32;
            pictureBox15.Location = new Point(407, 137);
            pictureBox15.Margin = new Padding(4, 3, 4, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(36, 30);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 123;
            pictureBox15.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.Person_32;
            pictureBox17.Location = new Point(103, 96);
            pictureBox17.Margin = new Padding(4, 3, 4, 3);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(36, 30);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 128;
            pictureBox17.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Properties.Resources.Country_32;
            pictureBox19.Location = new Point(407, 181);
            pictureBox19.Margin = new Padding(4, 3, 4, 3);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(36, 30);
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.TabIndex = 125;
            pictureBox19.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(331, 188);
            label26.Margin = new Padding(5, 0, 5, 0);
            label26.Name = "label26";
            label26.Size = new Size(76, 20);
            label26.TabIndex = 120;
            label26.Text = "Country:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(331, 144);
            label30.Margin = new Padding(5, 0, 5, 0);
            label30.Name = "label30";
            label30.Size = new Size(46, 20);
            label30.TabIndex = 116;
            label30.Text = "Age:";
            // 
            // ctrlStudentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlStudentCard";
            Size = new Size(702, 289);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.LinkLabel llEditStudentInfo;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblRegistredDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblGradeName;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
    }
}
