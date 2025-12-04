namespace SchoolProject.Grades
{
    partial class frmAddUpdateGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateGrade));
            lblGradeID = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGradeName = new TextBox();
            lblTitle = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblGradeID
            // 
            lblGradeID.AutoSize = true;
            lblGradeID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeID.ForeColor = Color.Black;
            lblGradeID.Location = new Point(167, 68);
            lblGradeID.Margin = new Padding(4, 0, 4, 0);
            lblGradeID.Name = "lblGradeID";
            lblGradeID.Size = new Size(48, 18);
            lblGradeID.TabIndex = 193;
            lblGradeID.Text = "[????]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 192;
            label2.Text = "Grade ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 190;
            label1.Text = "Grade Name:";
            // 
            // txtGradeName
            // 
            txtGradeName.BorderStyle = BorderStyle.FixedSingle;
            txtGradeName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeName.Location = new Point(167, 117);
            txtGradeName.Margin = new Padding(4, 3, 4, 3);
            txtGradeName.Name = "txtGradeName";
            txtGradeName.Size = new Size(151, 24);
            txtGradeName.TabIndex = 188;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(64, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 29);
            lblTitle.TabIndex = 187;
            lblTitle.Text = "Add New Grade";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(235, 155);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(83, 28);
            btnSave.TabIndex = 194;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(124, 66);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 191;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.classroom;
            pictureBox5.Location = new Point(124, 115);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 189;
            pictureBox5.TabStop = false;
            // 
            // frmAddUpdateGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 195);
            Controls.Add(btnSave);
            Controls.Add(lblGradeID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(txtGradeName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateGrade";
            Load += frmAddUpdateGrade_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Label lblTitle;
    }
}