namespace SchoolProject.Employees
{
    partial class frmShowEmployee
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
            ctrlEmployeeCard1 = new ctrlEmployeeCard();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // ctrlEmployeeCard1
            // 
            ctrlEmployeeCard1.BackColor = Color.White;
            ctrlEmployeeCard1.BackgroundImageLayout = ImageLayout.Center;
            ctrlEmployeeCard1.Location = new Point(0, 47);
            ctrlEmployeeCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlEmployeeCard1.Name = "ctrlEmployeeCard1";
            ctrlEmployeeCard1.Size = new Size(750, 302);
            ctrlEmployeeCard1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(192, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 45);
            lblTitle.TabIndex = 92;
            lblTitle.Text = "Employee Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmShowEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 349);
            Controls.Add(lblTitle);
            Controls.Add(ctrlEmployeeCard1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmShowEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowEmployee";
            ResumeLayout(false);

        }

        #endregion

        private ctrlEmployeeCard ctrlEmployeeCard1;
        private System.Windows.Forms.Label lblTitle;
    }
}