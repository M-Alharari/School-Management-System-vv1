namespace SchoolProject.People
{
    partial class frmFindPerson
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
            lblMode = new Label();
            ctrPersonCardWithFilter1 = new SchoolProject.People.Controls.ctrPersonCardWithFilter();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.ForeColor = Color.FromArgb(192, 0, 0);
            lblMode.Location = new Point(13, 0);
            lblMode.Margin = new Padding(4, 0, 4, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(591, 43);
            lblMode.TabIndex = 116;
            lblMode.Text = "Find Person";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrPersonCardWithFilter1
            // 
            ctrPersonCardWithFilter1.BackColor = Color.White;
            ctrPersonCardWithFilter1.FilterEnabled = true;
            ctrPersonCardWithFilter1.Location = new Point(1, 46);
            ctrPersonCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctrPersonCardWithFilter1.ShowAddPerson = true;
            ctrPersonCardWithFilter1.Size = new Size(659, 374);
            ctrPersonCardWithFilter1.TabIndex = 117;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = Properties.Resources.delete_button_103788232;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(567, 429);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 32);
            btnClose.TabIndex = 118;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(652, 468);
            Controls.Add(btnClose);
            Controls.Add(ctrPersonCardWithFilter1);
            Controls.Add(lblMode);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmFindPerson";
            Text = "frmFindPerson";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
    }
}