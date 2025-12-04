namespace SchoolProject.Employees
{
    partial class frmAddUpdateEmployee
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateEmployee));
            gbEmployee = new GroupBox();
            btnSave = new Button();
            cbEmployeeStatus = new CheckBox();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            txtMonthlySalary = new TextBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            lblEmployeeID = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblHiredDate = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cbPosition = new ComboBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            ctrPersonCardWithFilter1 = new SchoolProject.People.Controls.ctrPersonCardWithFilter();
            gbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbEmployee
            // 
            gbEmployee.Controls.Add(btnSave);
            gbEmployee.Controls.Add(cbEmployeeStatus);
            gbEmployee.Controls.Add(pictureBox5);
            gbEmployee.Controls.Add(label7);
            gbEmployee.Controls.Add(txtMonthlySalary);
            gbEmployee.Controls.Add(pictureBox4);
            gbEmployee.Controls.Add(label6);
            gbEmployee.Controls.Add(lblEmployeeID);
            gbEmployee.Controls.Add(pictureBox3);
            gbEmployee.Controls.Add(label5);
            gbEmployee.Controls.Add(lblHiredDate);
            gbEmployee.Controls.Add(pictureBox1);
            gbEmployee.Controls.Add(label2);
            gbEmployee.Controls.Add(cbPosition);
            gbEmployee.Controls.Add(pictureBox2);
            gbEmployee.Controls.Add(label1);
            gbEmployee.Location = new Point(4, 428);
            gbEmployee.Margin = new Padding(4, 3, 4, 3);
            gbEmployee.Name = "gbEmployee";
            gbEmployee.Padding = new Padding(4, 3, 4, 3);
            gbEmployee.Size = new Size(648, 171);
            gbEmployee.TabIndex = 1;
            gbEmployee.TabStop = false;
            gbEmployee.Text = "Employee Info:";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(541, 125);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 170;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbEmployeeStatus
            // 
            cbEmployeeStatus.AutoSize = true;
            cbEmployeeStatus.Location = new Point(505, 24);
            cbEmployeeStatus.Margin = new Padding(4, 3, 4, 3);
            cbEmployeeStatus.Name = "cbEmployeeStatus";
            cbEmployeeStatus.Size = new Size(59, 19);
            cbEmployeeStatus.TabIndex = 169;
            cbEmployeeStatus.Text = "Avtive";
            cbEmployeeStatus.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.immigration;
            pictureBox5.Location = new Point(460, 18);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 168;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(359, 21);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 167;
            label7.Text = "Status:";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlySalary.CharacterCasing = CharacterCasing.Lower;
            txtMonthlySalary.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonthlySalary.Location = new Point(183, 128);
            txtMonthlySalary.Margin = new Padding(4, 3, 4, 3);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(168, 24);
            txtMonthlySalary.TabIndex = 161;
            txtMonthlySalary.KeyPress += txtMonthlySalary_KeyPress;
            txtMonthlySalary.Validating += txtMonthlySalary_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(134, 125);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 166;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 130);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 165;
            label6.Text = "Monthly Salary:";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(178, 23);
            lblEmployeeID.Margin = new Padding(5, 0, 5, 0);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(47, 20);
            lblEmployeeID.TabIndex = 164;
            lblEmployeeID.Text = "[????]";
            lblEmployeeID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(134, 18);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 163;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 23);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 162;
            label5.Text = "Employee ID:";
            // 
            // lblHiredDate
            // 
            lblHiredDate.AutoSize = true;
            lblHiredDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHiredDate.Location = new Point(505, 68);
            lblHiredDate.Margin = new Padding(5, 0, 5, 0);
            lblHiredDate.Name = "lblHiredDate";
            lblHiredDate.Size = new Size(47, 20);
            lblHiredDate.TabIndex = 161;
            lblHiredDate.Text = "[????]";
            lblHiredDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calendar_32;
            pictureBox1.Location = new Point(460, 63);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 160;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(359, 68);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 159;
            label2.Text = "Hired Date:";
            // 
            // cbPosition
            // 
            cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosition.FlatStyle = FlatStyle.System;
            cbPosition.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(183, 65);
            cbPosition.Margin = new Padding(4, 3, 4, 3);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(167, 26);
            cbPosition.TabIndex = 158;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.briefcase;
            pictureBox2.Location = new Point(134, 63);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 157;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 68);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 156;
            label1.Text = "Job Title:";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(64, 3);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(532, 43);
            lblTitle.TabIndex = 160;
            lblTitle.Text = "Add New Employee";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrPersonCardWithFilter1
            // 
            ctrPersonCardWithFilter1.BackColor = Color.White;
            ctrPersonCardWithFilter1.FilterEnabled = true;
            ctrPersonCardWithFilter1.Location = new Point(4, 49);
            ctrPersonCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = null;
            ctrPersonCardWithFilter1.ShowAddPerson = true;
            ctrPersonCardWithFilter1.Size = new Size(653, 373);
            ctrPersonCardWithFilter1.TabIndex = 161;
            // 
            // frmAddUpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(657, 604);
            Controls.Add(ctrPersonCardWithFilter1);
            Controls.Add(lblTitle);
            Controls.Add(gbEmployee);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateEmployee";
            Load += frmAddUpdateEmployee_Load;
            gbEmployee.ResumeLayout(false);
            gbEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHiredDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.CheckBox cbEmployeeStatus;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
    }
}