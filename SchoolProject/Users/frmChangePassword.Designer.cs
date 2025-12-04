namespace SchoolProject.Users
{
    partial class frmChangePassword
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
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            pictureBox2 = new PictureBox();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNewPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ctrlUserCard1 = new ctrlUserCard();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_1777127610;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(550, 509);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 30);
            btnSave.TabIndex = 161;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 423);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 159;
            label1.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(216, 423);
            txtCurrentPassword.Margin = new Padding(5, 6, 5, 6);
            txtCurrentPassword.MaxLength = 50;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(220, 29);
            txtCurrentPassword.TabIndex = 152;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Password_32;
            pictureBox2.Location = new Point(171, 422);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 160;
            pictureBox2.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(216, 506);
            txtConfirmPassword.Margin = new Padding(5, 6, 5, 6);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(220, 29);
            txtConfirmPassword.TabIndex = 154;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 506);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 157;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 465);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 155;
            label2.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(216, 465);
            txtNewPassword.Margin = new Padding(5, 6, 5, 6);
            txtNewPassword.MaxLength = 50;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(220, 29);
            txtNewPassword.TabIndex = 153;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Password_32;
            pictureBox1.Location = new Point(171, 506);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 158;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(171, 463);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 156;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.BackColor = Color.White;
            ctrlUserCard1.Location = new Point(-1, 2);
            ctrlUserCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(691, 408);
            ctrlUserCard1.TabIndex = 163;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 550);
            Controls.Add(ctrlUserCard1);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtCurrentPassword);
            Controls.Add(pictureBox2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNewPassword);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlUserCard ctrlUserCard1;
    }
}