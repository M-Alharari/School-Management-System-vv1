namespace SchoolProject.Terms
{
    partial class frmaddUpdateTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddUpdateTerm));
            lblTermID = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTermName = new TextBox();
            lblTitle = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            chkFinal = new CheckBox();
            chkActive = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblTermID
            // 
            lblTermID.AutoSize = true;
            lblTermID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTermID.ForeColor = Color.Black;
            lblTermID.Location = new Point(140, 68);
            lblTermID.Margin = new Padding(4, 0, 4, 0);
            lblTermID.Name = "lblTermID";
            lblTermID.Size = new Size(48, 21);
            lblTermID.TabIndex = 202;
            lblTermID.Text = "[????]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 201;
            label2.Text = "Term ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 199;
            label1.Text = "Title:";
            // 
            // txtTermName
            // 
            txtTermName.BorderStyle = BorderStyle.FixedSingle;
            txtTermName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTermName.Location = new Point(140, 114);
            txtTermName.Margin = new Padding(4, 3, 4, 3);
            txtTermName.Name = "txtTermName";
            txtTermName.Size = new Size(190, 22);
            txtTermName.TabIndex = 197;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(76, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 37);
            lblTitle.TabIndex = 196;
            lblTitle.Text = "Add New Term";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 207;
            label3.Text = "Start:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 210;
            label4.Text = "End:";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = " ";
            dtpStart.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(140, 165);
            dtpStart.Margin = new Padding(4, 3, 4, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(190, 24);
            dtpStart.TabIndex = 211;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = " ";
            dtpEnd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(140, 219);
            dtpEnd.Margin = new Padding(4, 3, 4, 3);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(190, 24);
            dtpEnd.TabIndex = 212;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(97, 219);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 209;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Calendar_32;
            pictureBox3.Location = new Point(97, 165);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 206;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(97, 66);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 200;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.exam_8449262;
            pictureBox5.Location = new Point(97, 114);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 198;
            pictureBox5.TabStop = false;
            // 
            // chkFinal
            // 
            chkFinal.AutoSize = true;
            chkFinal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFinal.Location = new Point(170, 255);
            chkFinal.Margin = new Padding(4, 3, 4, 3);
            chkFinal.Name = "chkFinal";
            chkFinal.Size = new Size(68, 20);
            chkFinal.TabIndex = 213;
            chkFinal.Text = "Is Final";
            chkFinal.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActive.Location = new Point(97, 255);
            chkActive.Margin = new Padding(4, 3, 4, 3);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(76, 20);
            chkActive.TabIndex = 214;
            chkActive.Text = "Is Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(248, 281);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(76, 26);
            btnSave.TabIndex = 215;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(162, 281);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(76, 26);
            btnClose.TabIndex = 216;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmaddUpdateTerm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(337, 323);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(chkActive);
            Controls.Add(chkFinal);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(lblTermID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(txtTermName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmaddUpdateTerm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmaddUpdateTerm";
            Load += frmaddUpdateTerm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTermID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtTermName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.CheckBox chkFinal;
        private CheckBox chkActive;
        private Button btnSave;
        private Button btnClose;
    }
}