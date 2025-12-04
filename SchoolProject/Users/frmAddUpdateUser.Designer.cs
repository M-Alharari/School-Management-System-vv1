namespace SchoolProject.Users
{
    partial class frmAddUpdateUser
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ctrPersonCardWithFilter1 = new SchoolProject.People.Controls.ctrPersonCardWithFilter();
            btnNext = new Button();
            tpLoginInfo = new TabPage();
            pictureBox2 = new PictureBox();
            lblUserID = new Label();
            label4 = new Label();
            chkIsActive = new CheckBox();
            txtUserName = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            lblTitle = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_1777127610;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(574, 511);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(87, 29);
            btnSave.TabIndex = 123;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tpLoginInfo);
            tabControl1.Location = new Point(0, 59);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 447);
            tabControl1.TabIndex = 121;
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
            tabPage1.Size = new Size(664, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            // 
            // ctrPersonCardWithFilter1
            // 
            ctrPersonCardWithFilter1.BackColor = Color.White;
            ctrPersonCardWithFilter1.FilterEnabled = true;
            ctrPersonCardWithFilter1.Location = new Point(5, 3);
            ctrPersonCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctrPersonCardWithFilter1.ShowAddPerson = true;
            ctrPersonCardWithFilter1.Size = new Size(689, 373);
            ctrPersonCardWithFilter1.TabIndex = 3;
            // 
            // btnNext
            // 
            errorProvider1.SetIconAlignment(btnNext, ErrorIconAlignment.BottomLeft);
            btnNext.Image = Properties.Resources.right_arrow_157352881;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(570, 383);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.RightToLeft = RightToLeft.Yes;
            btnNext.Size = new Size(87, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.Controls.Add(pictureBox2);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(label4);
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Controls.Add(label3);
            tpLoginInfo.Controls.Add(label2);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(pictureBox1);
            tpLoginInfo.Controls.Add(pictureBox8);
            tpLoginInfo.Controls.Add(pictureBox3);
            tpLoginInfo.Location = new Point(4, 24);
            tpLoginInfo.Margin = new Padding(4, 3, 4, 3);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(4, 3, 4, 3);
            tpLoginInfo.Size = new Size(664, 419);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "LonginInfo";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(164, 13);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 143;
            pictureBox2.TabStop = false;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(214, 13);
            lblUserID.Margin = new Padding(5, 0, 5, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(39, 20);
            lblUserID.TabIndex = 142;
            lblUserID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 22);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 141;
            label4.Text = "UserID:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(208, 183);
            chkIsActive.Margin = new Padding(4, 3, 4, 3);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(88, 24);
            chkIsActive.TabIndex = 140;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(208, 57);
            txtUserName.Margin = new Padding(5, 6, 5, 6);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 29);
            txtUserName.TabIndex = 131;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(208, 140);
            txtConfirmPassword.Margin = new Padding(5, 6, 5, 6);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(220, 29);
            txtConfirmPassword.TabIndex = 137;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 133;
            label1.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 149);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 138;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 107);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 134;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(208, 98);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 29);
            txtPassword.TabIndex = 132;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Password_32;
            pictureBox1.Location = new Point(164, 140);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 139;
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(164, 55);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 136;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(164, 97);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 135;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(29, 11);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(594, 45);
            lblTitle.TabIndex = 122;
            lblTitle.Text = "Edit Application Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 547);
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateUser";
            Load += frmAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}