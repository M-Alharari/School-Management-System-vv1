namespace SchoolProject.Assessment_and_Exams
{
    partial class EnterScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterScores));
            lblTitle = new Label();
            cbTerms = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnSave = new Button();
            dgvScores = new DataGridView();
            lblAverageTotal = new Label();
            lblRecordCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvScores).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(150, 151);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(286, 39);
            lblTitle.TabIndex = 125;
            lblTitle.Text = "Type Scores";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTerms
            // 
            cbTerms.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTerms.FormattingEnabled = true;
            cbTerms.Location = new Point(423, 196);
            cbTerms.Margin = new Padding(4, 3, 4, 3);
            cbTerms.Name = "cbTerms";
            cbTerms.Size = new Size(118, 26);
            cbTerms.TabIndex = 123;
            cbTerms.SelectedIndexChanged += cbTerms_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.exam_4619285;
            pictureBox1.Location = new Point(166, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 124;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(331, 490);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(106, 32);
            button1.TabIndex = 128;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(447, 490);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 127;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvScores
            // 
            dgvScores.AllowUserToAddRows = false;
            dgvScores.AllowUserToDeleteRows = false;
            dgvScores.BackgroundColor = Color.White;
            dgvScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScores.Location = new Point(12, 226);
            dgvScores.Margin = new Padding(4, 3, 4, 3);
            dgvScores.Name = "dgvScores";
            dgvScores.Size = new Size(528, 255);
            dgvScores.TabIndex = 126;
            dgvScores.CellValueChanged += dgvScores_CellValueChanged;
            dgvScores.EditingControlShowing += dgvScores_EditingControlShowing;
            // 
            // lblAverageTotal
            // 
            lblAverageTotal.AutoSize = true;
            lblAverageTotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageTotal.Location = new Point(423, 168);
            lblAverageTotal.Margin = new Padding(4, 0, 4, 0);
            lblAverageTotal.Name = "lblAverageTotal";
            lblAverageTotal.Size = new Size(95, 15);
            lblAverageTotal.TabIndex = 130;
            lblAverageTotal.Text = "Total Avg: N/A";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(90, 486);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(32, 18);
            lblRecordCount.TabIndex = 132;
            lblRecordCount.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 486);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 131;
            label1.Text = "Record:";
            // 
            // EnterScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 531);
            Controls.Add(lblRecordCount);
            Controls.Add(label1);
            Controls.Add(lblAverageTotal);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(dgvScores);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(cbTerms);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EnterScores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterScores";
            Load += EnterScores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvScores).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTerms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Label lblAverageTotal;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
    }
}