namespace SchoolProject.Users
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblIsActive = new Label();
            label2 = new Label();
            lblUserName = new Label();
            lblUserID = new Label();
            label4 = new Label();
            label1 = new Label();
            personcard1 = new SchoolProject.People.Controls.ctrlPersonCard();
            ctrPersonCardWithFilter1 = new SchoolProject.People.Controls.ctrPersonCardWithFilter();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 311);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(646, 91);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Information";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblIsActive.Location = new Point(552, 41);
            lblIsActive.Margin = new Padding(5, 0, 5, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(30, 20);
            lblIsActive.TabIndex = 140;
            lblIsActive.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(480, 41);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 139;
            label2.Text = "Is Active : ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblUserName.Location = new Point(329, 41);
            lblUserName.Margin = new Padding(5, 0, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(30, 20);
            lblUserName.TabIndex = 138;
            lblUserName.Text = "???";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblUserID.Location = new Point(80, 41);
            lblUserID.Margin = new Padding(5, 0, 5, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(30, 20);
            lblUserID.TabIndex = 137;
            lblUserID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(9, 41);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 136;
            label4.Text = "User ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(247, 41);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 130;
            label1.Text = "Username:";
            // 
            // personcard1
            // 
            personcard1.BackColor = Color.White;
            personcard1.Location = new Point(0, 3);
            personcard1.Margin = new Padding(5, 3, 5, 3);
            personcard1.Name = "personcard1";
            personcard1.Size = new Size(650, 313);
            personcard1.TabIndex = 4;
            // 
            // ctrPersonCardWithFilter1
            // 
            ctrPersonCardWithFilter1.BackColor = Color.White;
            ctrPersonCardWithFilter1.FilterEnabled = true;
            ctrPersonCardWithFilter1.Location = new Point(568, 217);
            ctrPersonCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctrPersonCardWithFilter1.ShowAddPerson = true;
            ctrPersonCardWithFilter1.Size = new Size(9, 9);
            ctrPersonCardWithFilter1.TabIndex = 5;
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ctrPersonCardWithFilter1);
            Controls.Add(personcard1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlUserCard";
            Size = new Size(655, 410);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private People.Controls.ctrlPersonCard personcard1;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
    }
}
