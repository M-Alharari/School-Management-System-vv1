namespace SchoolProject.Comparisons
{
    partial class frmCompareStudentsInAClass
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartStudents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTitle = new Label();
            comboBoxClass = new ComboBox();
            comboBoxGrade = new ComboBox();
            comboBoxTerm = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chartStudents).BeginInit();
            SuspendLayout();
            // 
            // chartStudents
            // 
            chartArea1.Name = "ChartArea1";
            chartStudents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStudents.Legends.Add(legend1);
            chartStudents.Location = new Point(4, 95);
            chartStudents.Margin = new Padding(4, 3, 4, 3);
            chartStudents.Name = "chartStudents";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStudents.Series.Add(series1);
            chartStudents.Size = new Size(925, 366);
            chartStudents.TabIndex = 0;
            chartStudents.Text = "chart1";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(203, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(522, 39);
            lblTitle.TabIndex = 122;
            lblTitle.Text = "Students Comparison";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(161, 65);
            comboBoxClass.Margin = new Padding(4, 3, 4, 3);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(147, 24);
            comboBoxClass.TabIndex = 124;
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Location = new Point(6, 65);
            comboBoxGrade.Margin = new Padding(4, 3, 4, 3);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(147, 24);
            comboBoxGrade.TabIndex = 123;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.Location = new Point(316, 65);
            comboBoxTerm.Margin = new Padding(4, 3, 4, 3);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(147, 24);
            comboBoxTerm.TabIndex = 125;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.letter_x_17158141;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(834, 470);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(85, 32);
            button1.TabIndex = 135;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCompareStudentsInAClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 507);
            Controls.Add(button1);
            Controls.Add(comboBoxTerm);
            Controls.Add(comboBoxClass);
            Controls.Add(comboBoxGrade);
            Controls.Add(lblTitle);
            Controls.Add(chartStudents);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCompareStudentsInAClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCompareStudentsInAClass";
            Load += frmCompareStudentsInAClass_Load;
            ((System.ComponentModel.ISupportInitialize)chartStudents).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudents;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private Button button1;
    }
}