namespace SchoolProject
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            label7 = new Label();
            chkRememberMe = new CheckBox();
            btnLogin = new Button();
            txtUserName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(-1, -1);
            splitContainer1.Margin = new Padding(5, 6, 5, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(chkRememberMe);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(txtUserName);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(txtPassword);
            splitContainer1.Panel2.Controls.Add(pictureBox8);
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(597, 350);
            splitContainer1.SplitterDistance = 251;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(75, 278);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 136;
            label4.Text = "Version 1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 136;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Stencil", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(-5, 233);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(249, 38);
            label3.TabIndex = 2;
            label3.Text = "(SM )System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 189);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 44);
            label2.TabIndex = 1;
            label2.Text = "School Management ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 151);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcom To ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.closeBlack32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(290, 6);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 36);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 85);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(240, 25);
            label7.TabIndex = 135;
            label7.Text = "Login to your account";
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Checked = true;
            chkRememberMe.CheckState = CheckState.Checked;
            chkRememberMe.Location = new Point(150, 242);
            chkRememberMe.Margin = new Padding(4, 3, 4, 3);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(107, 19);
            chkRememberMe.TabIndex = 134;
            chkRememberMe.Text = "Remember Me.";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Image = Properties.Resources.enter_14497994;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(216, 270);
            btnLogin.Margin = new Padding(5, 6, 5, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(150, 149);
            txtUserName.Margin = new Padding(5, 6, 5, 6);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.Size = new Size(141, 26);
            txtUserName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.Location = new Point(19, 151);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 16);
            label5.TabIndex = 130;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(24, 213);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 16);
            label6.TabIndex = 131;
            label6.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(150, 207);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(141, 26);
            txtPassword.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(106, 146);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 133;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(106, 206);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 132;
            pictureBox3.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 354);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Label label7;
        private CheckBox chkRememberMe;
        private Button btnLogin;
        private TextBox txtUserName;
        private Label label5;
        private Label label6;
        private TextBox txtPassword;
        private PictureBox pictureBox8;
        private PictureBox pictureBox3;
    }
}
