namespace SchoolProject.Behaviours
{
    partial class frmAddUpdateBehaviour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateBehaviour));
            txtDescription = new TextBox();
            label12 = new Label();
            cmbBehaviourType = new ComboBox();
            pictureBox10 = new PictureBox();
            lblPersonID = new Label();
            label22 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            lblTitle = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            cmbSeverity = new ComboBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            cmbAction = new ComboBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(193, 261);
            txtDescription.Margin = new Padding(5, 6, 5, 6);
            txtDescription.MaxLength = 50;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(458, 145);
            txtDescription.TabIndex = 100;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 262);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 101;
            label12.Text = "Description:";
            // 
            // cmbBehaviourType
            // 
            cmbBehaviourType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBehaviourType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBehaviourType.FormattingEnabled = true;
            cmbBehaviourType.Location = new Point(195, 135);
            cmbBehaviourType.Margin = new Padding(4, 3, 4, 3);
            cmbBehaviourType.Name = "cmbBehaviourType";
            cmbBehaviourType.Size = new Size(125, 28);
            cmbBehaviourType.TabIndex = 103;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Number_32;
            pictureBox10.Location = new Point(148, 80);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 126;
            pictureBox10.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(207, 85);
            lblPersonID.Margin = new Padding(5, 0, 5, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(38, 20);
            lblPersonID.TabIndex = 125;
            lblPersonID.Text = "N/A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(8, 85);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 124;
            label22.Text = "Person ID :";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(471, 418);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 32);
            btnClose.TabIndex = 128;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = Properties.Resources.save_177712761;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(566, 418);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 32);
            btnSave.TabIndex = 127;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(77, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(489, 42);
            lblTitle.TabIndex = 129;
            lblTitle.Text = "Add New Behaviour";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 139);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 130;
            label1.Text = "Behaviour Type:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PersonDetails_32;
            pictureBox1.Location = new Point(148, 134);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 131;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PersonDetails_32;
            pictureBox2.Location = new Point(148, 252);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 132;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.PersonDetails_32;
            pictureBox3.Location = new Point(148, 192);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 135;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 197);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 134;
            label2.Text = "Severity;";
            // 
            // cmbSeverity
            // 
            cmbSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeverity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSeverity.FormattingEnabled = true;
            cmbSeverity.Location = new Point(195, 193);
            cmbSeverity.Margin = new Padding(4, 3, 4, 3);
            cmbSeverity.Name = "cmbSeverity";
            cmbSeverity.Size = new Size(125, 28);
            cmbSeverity.TabIndex = 133;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PersonDetails_32;
            pictureBox4.Location = new Point(463, 192);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 138;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(343, 197);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 137;
            label3.Text = "Actions:";
            // 
            // cmbAction
            // 
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(526, 193);
            cmbAction.Margin = new Padding(4, 3, 4, 3);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(125, 28);
            cmbAction.TabIndex = 136;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.PersonDetails_32;
            pictureBox5.Location = new Point(463, 134);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 141;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 139);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 140;
            label4.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(526, 135);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(125, 28);
            cmbCategory.TabIndex = 139;
            // 
            // frmAddUpdateBehaviour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 459);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(cmbAction);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(cmbSeverity);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pictureBox10);
            Controls.Add(lblPersonID);
            Controls.Add(label22);
            Controls.Add(cmbBehaviourType);
            Controls.Add(txtDescription);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdateBehaviour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateBehaviour";
            Load += frmAddUpdateBehaviour_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBehaviourType;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}