namespace SchoolProject.Guardians
{
    partial class frmAddUpdateGuardian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateGuardian));
            gbGuardian = new GroupBox();
            label1 = new Label();
            txtRelationship = new TextBox();
            btnSave = new Button();
            lblGuardianID = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblTitle = new Label();
            ctGuardianCardWithFilter1 = new ctGuardianCardWithFilter();
            gbGuardian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // gbGuardian
            // 
            gbGuardian.Controls.Add(label1);
            gbGuardian.Controls.Add(txtRelationship);
            gbGuardian.Controls.Add(btnSave);
            gbGuardian.Controls.Add(lblGuardianID);
            gbGuardian.Controls.Add(pictureBox3);
            gbGuardian.Controls.Add(label5);
            gbGuardian.Location = new Point(13, 412);
            gbGuardian.Margin = new Padding(4, 3, 4, 3);
            gbGuardian.Name = "gbGuardian";
            gbGuardian.Padding = new Padding(4, 3, 4, 3);
            gbGuardian.Size = new Size(641, 70);
            gbGuardian.TabIndex = 2;
            gbGuardian.TabStop = false;
            gbGuardian.Text = "Guardian Box";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 172;
            label1.Text = "Relationship:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtRelationship
            // 
            txtRelationship.BorderStyle = BorderStyle.FixedSingle;
            txtRelationship.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRelationship.Location = new Point(353, 26);
            txtRelationship.Margin = new Padding(4, 3, 4, 3);
            txtRelationship.Name = "txtRelationship";
            txtRelationship.Size = new Size(138, 24);
            txtRelationship.TabIndex = 171;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(528, 22);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(90, 26);
            btnSave.TabIndex = 170;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblGuardianID
            // 
            lblGuardianID.AutoSize = true;
            lblGuardianID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuardianID.Location = new Point(156, 30);
            lblGuardianID.Margin = new Padding(5, 0, 5, 0);
            lblGuardianID.Name = "lblGuardianID";
            lblGuardianID.Size = new Size(49, 16);
            lblGuardianID.TabIndex = 164;
            lblGuardianID.Text = "[????]";
            lblGuardianID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(111, 24);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 163;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 30);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 16);
            label5.TabIndex = 162;
            label5.Text = "Guardian ID:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(103, -3);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(487, 45);
            lblTitle.TabIndex = 131;
            lblTitle.Text = "Add New Guardian";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctGuardianCardWithFilter1
            // 
            ctGuardianCardWithFilter1.BackColor = Color.White;
            ctGuardianCardWithFilter1.FilterEnabled = true;
            ctGuardianCardWithFilter1.Location = new Point(2, 34);
            ctGuardianCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctGuardianCardWithFilter1.Name = "ctGuardianCardWithFilter1";
            ctGuardianCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctGuardianCardWithFilter1.ShowAddPerson = true;
            ctGuardianCardWithFilter1.Size = new Size(693, 380);
            ctGuardianCardWithFilter1.TabIndex = 132;
            // 
            // frmAddUpdateGuardian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 487);
            Controls.Add(ctGuardianCardWithFilter1);
            Controls.Add(lblTitle);
            Controls.Add(gbGuardian);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateGuardian";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateGuardian";
            Load += frmAddUpdateGuardian_Load;
            gbGuardian.ResumeLayout(false);
            gbGuardian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGuardian;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGuardianID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelationship;
        private ctGuardianCardWithFilter ctGuardianCardWithFilter1;
    }
}