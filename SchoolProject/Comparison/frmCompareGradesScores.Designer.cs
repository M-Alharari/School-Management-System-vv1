namespace SchoolProject.Comparisons
{
    partial class frmCompareGradesScores
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
            chartClasses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxGrade = new ComboBox();
            lblTitle = new Label();
            comboBoxTerm = new ComboBox();
            lblLowestGrade = new Label();
            lblHighestGrade = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)chartClasses).BeginInit();
            SuspendLayout();
            // 
            // chartClasses
            // 
            chartArea1.Name = "ChartArea1";
            chartClasses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartClasses.Legends.Add(legend1);
            chartClasses.Location = new Point(13, 99);
            chartClasses.Margin = new Padding(4, 3, 4, 3);
            chartClasses.Name = "chartClasses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartClasses.Series.Add(series1);
            chartClasses.Size = new Size(642, 299);
            chartClasses.TabIndex = 0;
            chartClasses.Text = "chart1";
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrade.FlatStyle = FlatStyle.System;
            comboBoxGrade.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Location = new Point(13, 60);
            comboBoxGrade.Margin = new Padding(4, 3, 4, 3);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(126, 24);
            comboBoxGrade.TabIndex = 1;
            comboBoxGrade.SelectedIndexChanged += comboBoxGrade_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(174, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 48);
            lblTitle.TabIndex = 121;
            lblTitle.Text = "Compare Grades";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.FlatStyle = FlatStyle.System;
            comboBoxTerm.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.Location = new Point(157, 61);
            comboBoxTerm.Margin = new Padding(4, 3, 4, 3);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(126, 24);
            comboBoxTerm.TabIndex = 122;
            comboBoxTerm.SelectedIndexChanged += comboBoxTerm_SelectedIndexChanged;
            // 
            // lblLowestGrade
            // 
            lblLowestGrade.AutoSize = true;
            lblLowestGrade.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowestGrade.Location = new Point(488, 67);
            lblLowestGrade.Margin = new Padding(4, 0, 4, 0);
            lblLowestGrade.Name = "lblLowestGrade";
            lblLowestGrade.Size = new Size(88, 18);
            lblLowestGrade.TabIndex = 124;
            lblLowestGrade.Text = "Lowest: N/A";
            // 
            // lblHighestGrade
            // 
            lblHighestGrade.AutoSize = true;
            lblHighestGrade.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHighestGrade.Location = new Point(488, 41);
            lblHighestGrade.Margin = new Padding(4, 0, 4, 0);
            lblHighestGrade.Name = "lblHighestGrade";
            lblHighestGrade.Size = new Size(90, 18);
            lblHighestGrade.TabIndex = 125;
            lblHighestGrade.Text = "Highest: N/A";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.letter_x_17158141;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(572, 407);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(83, 32);
            button2.TabIndex = 136;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmCompareGradesScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(665, 445);
            Controls.Add(button2);
            Controls.Add(lblHighestGrade);
            Controls.Add(lblLowestGrade);
            Controls.Add(comboBoxTerm);
            Controls.Add(lblTitle);
            Controls.Add(comboBoxGrade);
            Controls.Add(chartClasses);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCompareGradesScores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCompareGradesScores";
            Load += frmCompareGradesScores_Load;
            ((System.ComponentModel.ISupportInitialize)chartClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartClasses;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.Label lblLowestGrade;
        private System.Windows.Forms.Label lblHighestGrade;
        private Button button2;
    }
}