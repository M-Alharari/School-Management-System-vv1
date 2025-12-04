namespace SchoolProject.People
{
    partial class frmShowPersonDetails
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
            ctrlPersonCard1 = new SchoolProject.People.Controls.ctrlPersonCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(177, -1);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 45);
            lblTitle.TabIndex = 91;
            lblTitle.Text = "Person Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.White;
            ctrlPersonCard1.Location = new Point(-2, 35);
            ctrlPersonCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(651, 308);
            ctrlPersonCard1.TabIndex = 92;
            // 
            // frmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 343);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmShowPersonDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowPersonDetails";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlPersonCard ctrlPersonCard1;
    }
}