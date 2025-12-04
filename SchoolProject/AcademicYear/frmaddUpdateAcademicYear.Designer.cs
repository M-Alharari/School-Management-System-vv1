namespace SchoolProject.AcademicYear
{
    partial class frmaddUpdateAcademicYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddUpdateAcademicYear));
            chkActive = new CheckBox();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btnSave = new Button();
            lblAcademicYearID = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            txtYearName = new TextBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActive.Location = new Point(117, 265);
            chkActive.Margin = new Padding(4, 3, 4, 3);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(76, 20);
            chkActive.TabIndex = 230;
            chkActive.Text = "Is Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = " ";
            dtpEnd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(160, 229);
            dtpEnd.Margin = new Padding(4, 3, 4, 3);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(190, 24);
            dtpEnd.TabIndex = 228;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = " ";
            dtpStart.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(160, 175);
            dtpStart.Margin = new Padding(4, 3, 4, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(190, 24);
            dtpStart.TabIndex = 227;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 231);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 226;
            label4.Text = "End:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(117, 226);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 225;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 224;
            label3.Text = "Start:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Calendar_32;
            pictureBox3.Location = new Point(117, 172);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 223;
            pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(279, 276);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(71, 27);
            btnSave.TabIndex = 222;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblAcademicYearID
            // 
            lblAcademicYearID.AutoSize = true;
            lblAcademicYearID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcademicYearID.ForeColor = Color.Black;
            lblAcademicYearID.Location = new Point(160, 76);
            lblAcademicYearID.Margin = new Padding(4, 0, 4, 0);
            lblAcademicYearID.Name = "lblAcademicYearID";
            lblAcademicYearID.Size = new Size(48, 21);
            lblAcademicYearID.TabIndex = 221;
            lblAcademicYearID.Text = "[????]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 220;
            label2.Text = "Year ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(117, 71);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 219;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 218;
            label1.Text = "Year Name:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.exam_8449262;
            pictureBox5.Location = new Point(117, 118);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 217;
            pictureBox5.TabStop = false;
            // 
            // txtYearName
            // 
            txtYearName.BorderStyle = BorderStyle.FixedSingle;
            txtYearName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYearName.Location = new Point(171, 122);
            txtYearName.Margin = new Padding(4, 3, 4, 3);
            txtYearName.Name = "txtYearName";
            txtYearName.Size = new Size(179, 22);
            txtYearName.TabIndex = 216;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(39, 21);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 37);
            lblTitle.TabIndex = 215;
            lblTitle.Text = "Add New Academic Year";
            // 
            // frmaddUpdateAcademicYear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 316);
            Controls.Add(chkActive);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(btnSave);
            Controls.Add(lblAcademicYearID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(txtYearName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmaddUpdateAcademicYear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmaddUpdateAcademicYear";
            Load += frmaddUpdateAcademicYear_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkActive;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Button btnSave;
        private Label lblAcademicYearID;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox5;
        private TextBox txtYearName;
        private Label lblTitle;
    }
}