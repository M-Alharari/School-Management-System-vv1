namespace SchoolProject.Classes
{
    partial class frmAddUdateClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUdateClass));
            lblClassID = new Label();
            label2 = new Label();
            label1 = new Label();
            txtClassName = new TextBox();
            lblTitle = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblClassID
            // 
            lblClassID.AutoSize = true;
            lblClassID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassID.ForeColor = Color.Black;
            lblClassID.Location = new Point(162, 69);
            lblClassID.Margin = new Padding(4, 0, 4, 0);
            lblClassID.Name = "lblClassID";
            lblClassID.Size = new Size(48, 18);
            lblClassID.TabIndex = 184;
            lblClassID.Text = "[????]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 183;
            label2.Text = "Class ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 181;
            label1.Text = "Class Name:";
            // 
            // txtClassName
            // 
            txtClassName.BorderStyle = BorderStyle.FixedSingle;
            txtClassName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClassName.Location = new Point(162, 117);
            txtClassName.Margin = new Padding(4, 3, 4, 3);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(134, 24);
            txtClassName.TabIndex = 179;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(63, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(191, 29);
            lblTitle.TabIndex = 178;
            lblTitle.Text = "Add New Class";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(212, 156);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(84, 30);
            btnSave.TabIndex = 185;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(118, 66);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 182;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.classroom;
            pictureBox5.Location = new Point(118, 115);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 180;
            pictureBox5.TabStop = false;
            // 
            // frmAddUdateClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 195);
            Controls.Add(btnSave);
            Controls.Add(lblClassID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(txtClassName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUdateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUdateClass";
            Load += frmAddUdateClass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblTitle;
    }
}