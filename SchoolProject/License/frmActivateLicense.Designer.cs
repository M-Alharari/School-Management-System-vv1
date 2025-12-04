namespace SchoolProject
{
    partial class frmActivateLicense
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
            BtnActivate = new Button();
            label2 = new Label();
            txtLicenseKey = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnActivate
            // 
            BtnActivate.Location = new Point(424, 211);
            BtnActivate.Margin = new Padding(4, 3, 4, 3);
            BtnActivate.Name = "BtnActivate";
            BtnActivate.Size = new Size(80, 23);
            BtnActivate.TabIndex = 9;
            BtnActivate.Text = "Activate";
            BtnActivate.UseVisualStyleBackColor = true;
            BtnActivate.Click += BtnActivate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(176, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 7;
            label2.Text = "Activate License";
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.BorderStyle = BorderStyle.FixedSingle;
            txtLicenseKey.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicenseKey.Location = new Point(13, 176);
            txtLicenseKey.Margin = new Padding(4, 3, 4, 3);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new Size(491, 26);
            txtLicenseKey.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 23);
            label1.TabIndex = 5;
            label1.Text = "Paste your license key below:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tap_4161814;
            pictureBox1.Location = new Point(144, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmActivateLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 241);
            Controls.Add(BtnActivate);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtLicenseKey);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmActivateLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmActivateLicense";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActivate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Label label1;
    }
}