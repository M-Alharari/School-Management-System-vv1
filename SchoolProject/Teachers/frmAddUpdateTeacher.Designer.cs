namespace SchoolProject.Teachers
{
    partial class frmAddUpdateTeacher
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
            errorProvider3 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            btnSave = new Button();
            lblTitle = new Label();
            lblTeacherID = new Label();
            label3 = new Label();
            openFileDialog2 = new OpenFileDialog();
            gbTeacher = new GroupBox();
            chkHasSubjects = new CheckBox();
            chkHasClasses = new CheckBox();
            llAssigntoSubjects = new LinkLabel();
            llAssigntoClasses = new LinkLabel();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ctrlEmployeeCardWithFilter1 = new SchoolProject.Employees.ctrlEmployeeCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            gbTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.save_177712769;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(623, 58);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(105, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(81, 4);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(598, 43);
            lblTitle.TabIndex = 159;
            lblTitle.Text = "Add New Teacher";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherID
            // 
            lblTeacherID.AutoSize = true;
            lblTeacherID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherID.Location = new Point(177, 29);
            lblTeacherID.Margin = new Padding(5, 0, 5, 0);
            lblTeacherID.Name = "lblTeacherID";
            lblTeacherID.Size = new Size(49, 20);
            lblTeacherID.TabIndex = 150;
            lblTeacherID.Text = "[???]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 29);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 148;
            label3.Text = "Teacher ID: ";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            // 
            // gbTeacher
            // 
            gbTeacher.Controls.Add(chkHasSubjects);
            gbTeacher.Controls.Add(chkHasClasses);
            gbTeacher.Controls.Add(llAssigntoSubjects);
            gbTeacher.Controls.Add(btnSave);
            gbTeacher.Controls.Add(llAssigntoClasses);
            gbTeacher.Controls.Add(lblTeacherID);
            gbTeacher.Controls.Add(label3);
            gbTeacher.Controls.Add(pictureBox3);
            gbTeacher.Location = new Point(13, 414);
            gbTeacher.Margin = new Padding(4, 3, 4, 3);
            gbTeacher.Name = "gbTeacher";
            gbTeacher.Padding = new Padding(4, 3, 4, 3);
            gbTeacher.Size = new Size(736, 101);
            gbTeacher.TabIndex = 160;
            gbTeacher.TabStop = false;
            gbTeacher.Text = "Teacher Details";
            // 
            // chkHasSubjects
            // 
            chkHasSubjects.AutoSize = true;
            chkHasSubjects.Enabled = false;
            chkHasSubjects.Location = new Point(326, 71);
            chkHasSubjects.Margin = new Padding(4, 3, 4, 3);
            chkHasSubjects.Name = "chkHasSubjects";
            chkHasSubjects.Size = new Size(15, 14);
            chkHasSubjects.TabIndex = 154;
            chkHasSubjects.UseVisualStyleBackColor = true;
            // 
            // chkHasClasses
            // 
            chkHasClasses.AutoSize = true;
            chkHasClasses.Enabled = false;
            chkHasClasses.Location = new Point(154, 72);
            chkHasClasses.Margin = new Padding(4, 3, 4, 3);
            chkHasClasses.Name = "chkHasClasses";
            chkHasClasses.Size = new Size(15, 14);
            chkHasClasses.TabIndex = 153;
            chkHasClasses.TextImageRelation = TextImageRelation.TextBeforeImage;
            chkHasClasses.UseVisualStyleBackColor = true;
            // 
            // llAssigntoSubjects
            // 
            llAssigntoSubjects.AutoSize = true;
            llAssigntoSubjects.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llAssigntoSubjects.Location = new Point(177, 66);
            llAssigntoSubjects.Margin = new Padding(4, 0, 4, 0);
            llAssigntoSubjects.Name = "llAssigntoSubjects";
            llAssigntoSubjects.Size = new Size(141, 20);
            llAssigntoSubjects.TabIndex = 152;
            llAssigntoSubjects.TabStop = true;
            llAssigntoSubjects.Text = "Assign to Subjects";
            llAssigntoSubjects.LinkClicked += llAssigntoSubjects_LinkClicked;
            // 
            // llAssigntoClasses
            // 
            llAssigntoClasses.AutoSize = true;
            llAssigntoClasses.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llAssigntoClasses.Location = new Point(11, 67);
            llAssigntoClasses.Margin = new Padding(4, 0, 4, 0);
            llAssigntoClasses.Name = "llAssigntoClasses";
            llAssigntoClasses.Size = new Size(135, 20);
            llAssigntoClasses.TabIndex = 151;
            llAssigntoClasses.TabStop = true;
            llAssigntoClasses.Text = "Assign to Classes";
            llAssigntoClasses.LinkClicked += llAssigntoClasses_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(132, 24);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 149;
            pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlEmployeeCardWithFilter1
            // 
            ctrlEmployeeCardWithFilter1.BackColor = Color.White;
            ctrlEmployeeCardWithFilter1.FilterEnabled = true;
            ctrlEmployeeCardWithFilter1.Location = new Point(4, 44);
            ctrlEmployeeCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            ctrlEmployeeCardWithFilter1.Name = "ctrlEmployeeCardWithFilter1";
            ctrlEmployeeCardWithFilter1.ShowAddEmploye = true;
            ctrlEmployeeCardWithFilter1.Size = new Size(752, 364);
            ctrlEmployeeCardWithFilter1.TabIndex = 161;
            ctrlEmployeeCardWithFilter1.Load += ctrlEmployeeCardWithFilter1_Load;
            // 
            // frmAddUpdateTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(754, 521);
            Controls.Add(ctrlEmployeeCardWithFilter1);
            Controls.Add(lblTitle);
            Controls.Add(gbTeacher);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateTeacher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateTeacher";
            Load += frmAddUpdateTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            gbTeacher.ResumeLayout(false);
            gbTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Employees.ctrlEmployeeCardWithFilter ctrlEmployeeCardWithFilter1;
        private System.Windows.Forms.CheckBox chkHasSubjects;
        private System.Windows.Forms.CheckBox chkHasClasses;
        private System.Windows.Forms.LinkLabel llAssigntoSubjects;
        private System.Windows.Forms.LinkLabel llAssigntoClasses;
    }
}