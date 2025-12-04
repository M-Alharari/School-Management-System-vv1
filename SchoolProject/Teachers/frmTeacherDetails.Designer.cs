namespace SchoolProject.Teachers
{
    partial class frmTeacherDetails
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
            lblTitle = new Label();
            ctrlTeacherCard1 = new ctrlTeacherCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(13, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(619, 42);
            lblTitle.TabIndex = 160;
            lblTitle.Text = "Teacher Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlTeacherCard1
            // 
            ctrlTeacherCard1.BackColor = Color.White;
            ctrlTeacherCard1.Location = new Point(1, 52);
            ctrlTeacherCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            ctrlTeacherCard1.Size = new Size(659, 312);
            ctrlTeacherCard1.TabIndex = 161;
            // 
            // frmTeacherDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(658, 365);
            Controls.Add(ctrlTeacherCard1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTeacherDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTeacherDetails";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlTeacherCard ctrlTeacherCard1;
    }
}