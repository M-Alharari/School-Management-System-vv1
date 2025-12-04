namespace SchoolProject
{
    partial class frmAddUpdateStudent
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
            errorProvider1 = new ErrorProvider(components);
            btnNext = new Button();
            tpRegisteredInfo = new TabPage();
            lblRegisteredBy = new Label();
            lblEnrollmentDate = new Label();
            gbStudent = new GroupBox();
            cbTerms = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            llPaymentForm = new LinkLabel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            chkIsActive = new CheckBox();
            llGuardianForm = new LinkLabel();
            cbClasses = new ComboBox();
            label8 = new Label();
            cbGrades = new ComboBox();
            label3 = new Label();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            label1 = new Label();
            lblStudentID = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabPage1 = new TabPage();
            ctrPersonCardWithFilter1 = new SchoolProject.People.Controls.ctrPersonCardWithFilter();
            btnSave = new Button();
            tabControl1 = new TabControl();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tpRegisteredInfo.SuspendLayout();
            gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            errorProvider1.SetIconAlignment(btnNext, ErrorIconAlignment.BottomLeft);
            btnNext.Image = Properties.Resources.right_arrow_15735288;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(571, 386);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.RightToLeft = RightToLeft.Yes;
            btnNext.Size = new Size(80, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tpRegisteredInfo
            // 
            tpRegisteredInfo.BackColor = Color.White;
            tpRegisteredInfo.Controls.Add(lblRegisteredBy);
            tpRegisteredInfo.Controls.Add(lblEnrollmentDate);
            tpRegisteredInfo.Controls.Add(gbStudent);
            tpRegisteredInfo.Controls.Add(label1);
            tpRegisteredInfo.Controls.Add(lblStudentID);
            tpRegisteredInfo.Controls.Add(label7);
            tpRegisteredInfo.Controls.Add(pictureBox4);
            tpRegisteredInfo.Controls.Add(label2);
            tpRegisteredInfo.Controls.Add(pictureBox8);
            tpRegisteredInfo.Controls.Add(pictureBox3);
            tpRegisteredInfo.Location = new Point(4, 24);
            tpRegisteredInfo.Margin = new Padding(4, 3, 4, 3);
            tpRegisteredInfo.Name = "tpRegisteredInfo";
            tpRegisteredInfo.Padding = new Padding(4, 3, 4, 3);
            tpRegisteredInfo.Size = new Size(657, 423);
            tpRegisteredInfo.TabIndex = 1;
            tpRegisteredInfo.Text = "RegisteredInfo";
            // 
            // lblRegisteredBy
            // 
            lblRegisteredBy.AutoSize = true;
            lblRegisteredBy.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblRegisteredBy.Location = new Point(170, 294);
            lblRegisteredBy.Margin = new Padding(5, 0, 5, 0);
            lblRegisteredBy.Name = "lblRegisteredBy";
            lblRegisteredBy.Size = new Size(41, 16);
            lblRegisteredBy.TabIndex = 167;
            lblRegisteredBy.Text = "[???]";
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblEnrollmentDate.Location = new Point(170, 251);
            lblEnrollmentDate.Margin = new Padding(5, 0, 5, 0);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(41, 16);
            lblEnrollmentDate.TabIndex = 166;
            lblEnrollmentDate.Text = "[???]";
            // 
            // gbStudent
            // 
            gbStudent.Controls.Add(cbTerms);
            gbStudent.Controls.Add(checkBox2);
            gbStudent.Controls.Add(checkBox1);
            gbStudent.Controls.Add(label4);
            gbStudent.Controls.Add(label5);
            gbStudent.Controls.Add(llPaymentForm);
            gbStudent.Controls.Add(pictureBox5);
            gbStudent.Controls.Add(label6);
            gbStudent.Controls.Add(chkIsActive);
            gbStudent.Controls.Add(llGuardianForm);
            gbStudent.Controls.Add(cbClasses);
            gbStudent.Controls.Add(label8);
            gbStudent.Controls.Add(cbGrades);
            gbStudent.Controls.Add(label3);
            gbStudent.Controls.Add(label9);
            gbStudent.Controls.Add(pictureBox6);
            gbStudent.Controls.Add(pictureBox7);
            gbStudent.Controls.Add(pictureBox1);
            gbStudent.Controls.Add(pictureBox9);
            gbStudent.Location = new Point(9, 6);
            gbStudent.Margin = new Padding(4, 3, 4, 3);
            gbStudent.Name = "gbStudent";
            gbStudent.Padding = new Padding(4, 3, 4, 3);
            gbStudent.Size = new Size(642, 175);
            gbStudent.TabIndex = 144;
            gbStudent.TabStop = false;
            gbStudent.Text = "Student Info:";
            // 
            // cbTerms
            // 
            cbTerms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTerms.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTerms.FormattingEnabled = true;
            cbTerms.Location = new Point(161, 129);
            cbTerms.Margin = new Padding(4, 3, 4, 3);
            cbTerms.Name = "cbTerms";
            cbTerms.Size = new Size(191, 26);
            cbTerms.TabIndex = 175;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Enabled = false;
            checkBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(616, 86);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 174;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(616, 35);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 173;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(361, 134);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 168;
            label4.Text = "Statue:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(361, 85);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 170;
            label5.Text = "Fees Info:";
            // 
            // llPaymentForm
            // 
            llPaymentForm.AutoSize = true;
            llPaymentForm.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            llPaymentForm.Location = new Point(506, 83);
            llPaymentForm.Margin = new Padding(4, 0, 4, 0);
            llPaymentForm.Name = "llPaymentForm";
            llPaymentForm.Size = new Size(106, 20);
            llPaymentForm.TabIndex = 169;
            llPaymentForm.TabStop = true;
            llPaymentForm.Text = "Payment form";
            llPaymentForm.LinkClicked += llPaymentForm_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.money_32;
            pictureBox5.Location = new Point(463, 77);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 171;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(361, 33);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 167;
            label6.Text = "Guardian Info:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            chkIsActive.Location = new Point(510, 132);
            chkIsActive.Margin = new Padding(4, 3, 4, 3);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(78, 21);
            chkIsActive.TabIndex = 140;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // llGuardianForm
            // 
            llGuardianForm.AutoSize = true;
            llGuardianForm.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            llGuardianForm.Location = new Point(506, 32);
            llGuardianForm.Margin = new Padding(4, 0, 4, 0);
            llGuardianForm.Name = "llGuardianForm";
            llGuardianForm.Size = new Size(109, 20);
            llGuardianForm.TabIndex = 166;
            llGuardianForm.TabStop = true;
            llGuardianForm.Text = "Gaurdian form";
            llGuardianForm.LinkClicked += llGuardianForm_LinkClicked;
            // 
            // cbClasses
            // 
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(162, 80);
            cbClasses.Margin = new Padding(4, 3, 4, 3);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(190, 26);
            cbClasses.TabIndex = 162;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(4, 85);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 17);
            label8.TabIndex = 160;
            label8.Text = "Assign to Class:";
            // 
            // cbGrades
            // 
            cbGrades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrades.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGrades.FormattingEnabled = true;
            cbGrades.Location = new Point(162, 31);
            cbGrades.Margin = new Padding(4, 3, 4, 3);
            cbGrades.Name = "cbGrades";
            cbGrades.Size = new Size(190, 26);
            cbGrades.TabIndex = 161;
            cbGrades.SelectedIndexChanged += cbGrades_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(4, 134);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 138;
            label3.Text = "Term Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(5, 33);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 17);
            label9.TabIndex = 158;
            label9.Text = "Assign to Grade:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.book;
            pictureBox6.Location = new Point(118, 29);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 159;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.classroom;
            pictureBox7.Location = new Point(118, 78);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 157;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Password_32;
            pictureBox1.Location = new Point(118, 127);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 139;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Person_32;
            pictureBox9.Location = new Point(463, 26);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 31);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 168;
            pictureBox9.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.Location = new Point(13, 255);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 16);
            label1.TabIndex = 133;
            label1.Text = "Enroll. Date:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblStudentID.Location = new Point(170, 204);
            lblStudentID.Margin = new Padding(5, 0, 5, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(41, 16);
            lblStudentID.TabIndex = 165;
            lblStudentID.Text = "[???]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.Location = new Point(13, 208);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 16);
            label7.TabIndex = 163;
            label7.Text = "Student ID: ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(127, 197);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 164;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(13, 298);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 16);
            label2.TabIndex = 134;
            label2.Text = "Registred by:";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Calendar_32;
            pictureBox8.Location = new Point(127, 241);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 136;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(127, 284);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 135;
            pictureBox3.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(ctrPersonCardWithFilter1);
            tabPage1.Controls.Add(btnNext);
            tabPage1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(657, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            // 
            // ctrPersonCardWithFilter1
            // 
            ctrPersonCardWithFilter1.BackColor = Color.White;
            ctrPersonCardWithFilter1.FilterEnabled = true;
            ctrPersonCardWithFilter1.Location = new Point(4, 3);
            ctrPersonCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctrPersonCardWithFilter1.ShowAddPerson = true;
            ctrPersonCardWithFilter1.Size = new Size(651, 380);
            ctrPersonCardWithFilter1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.save_177712767;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(579, 502);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 31);
            btnSave.TabIndex = 126;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpRegisteredInfo);
            tabControl1.Location = new Point(4, 46);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(665, 451);
            tabControl1.TabIndex = 124;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(43, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(582, 47);
            lblTitle.TabIndex = 125;
            lblTitle.Text = "Add New Student";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddUpdateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(670, 543);
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tpRegisteredInfo.ResumeLayout(false);
            tpRegisteredInfo.PerformLayout();
            gbStudent.ResumeLayout(false);
            gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpRegisteredInfo;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llPaymentForm;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llGuardianForm;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegisteredBy;
        private System.Windows.Forms.Label lblEnrollmentDate;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbTerms;
    }
}