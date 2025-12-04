namespace SchoolProject.Comparison
{
    partial class waittt
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
            button1 = new Button();
            comboBoxTerm = new ComboBox();
            comboBoxClass = new ComboBox();
            comboBoxGrade = new ComboBox();
            lblTitle = new Label();
            chartStudents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartStudents).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.close_button_15600737__2_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(667, 419);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(97, 32);
            button1.TabIndex = 134;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.FlatStyle = FlatStyle.System;
            comboBoxTerm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.Location = new Point(387, 74);
            comboBoxTerm.Margin = new Padding(4, 3, 4, 3);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(143, 28);
            comboBoxTerm.TabIndex = 133;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.System;
            comboBoxClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(214, 74);
            comboBoxClass.Margin = new Padding(4, 3, 4, 3);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(143, 28);
            comboBoxClass.TabIndex = 132;
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrade.FlatStyle = FlatStyle.System;
            comboBoxGrade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Location = new Point(51, 74);
            comboBoxGrade.Margin = new Padding(4, 3, 4, 3);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(143, 28);
            comboBoxGrade.TabIndex = 131;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(113, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(556, 40);
            lblTitle.TabIndex = 130;
            lblTitle.Text = "Students Comparison";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartStudents
            // 
            chartArea1.Name = "ChartArea1";
            chartStudents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStudents.Legends.Add(legend1);
            chartStudents.Location = new Point(12, 110);
            chartStudents.Name = "chartStudents";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStudents.Series.Add(series1);
            chartStudents.Size = new Size(776, 300);
            chartStudents.TabIndex = 135;
            chartStudents.Text = "chart1";
            // 
            // waittt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(chartStudents);
            Controls.Add(button1);
            Controls.Add(comboBoxTerm);
            Controls.Add(comboBoxClass);
            Controls.Add(comboBoxGrade);
            Controls.Add(lblTitle);
            Name = "waittt";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboBoxTerm;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxGrade;
        private Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudents;
    }
}