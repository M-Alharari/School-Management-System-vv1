namespace SchoolProject.Students
{
    partial class frmStudentDetail
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
            ctrlStudentCard1 = new ctrlStudentCard();
            ctrlStudentCard2 = new ctrlStudentCard();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // ctrlStudentCard1
            // 
            ctrlStudentCard1.BackColor = Color.White;
            ctrlStudentCard1.Location = new Point(3, 40);
            ctrlStudentCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlStudentCard1.Name = "ctrlStudentCard1";
            ctrlStudentCard1.Size = new Size(702, 289);
            ctrlStudentCard1.TabIndex = 0;
            // 
            // ctrlStudentCard2
            // 
            ctrlStudentCard2.BackColor = Color.White;
            ctrlStudentCard2.Location = new Point(527, 429);
            ctrlStudentCard2.Margin = new Padding(5, 3, 5, 3);
            ctrlStudentCard2.Name = "ctrlStudentCard2";
            ctrlStudentCard2.Size = new Size(9, 9);
            ctrlStudentCard2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(218, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 45);
            lblTitle.TabIndex = 92;
            lblTitle.Text = "Student Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 333);
            Controls.Add(lblTitle);
            Controls.Add(ctrlStudentCard2);
            Controls.Add(ctrlStudentCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStudentDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStudentDetail";
            ResumeLayout(false);

        }

        #endregion

        private ctrlStudentCard ctrlStudentCard1;
        private ctrlStudentCard ctrlStudentCard2;
        private System.Windows.Forms.Label lblTitle;
    }
}