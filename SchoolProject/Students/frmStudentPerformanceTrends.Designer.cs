namespace SchoolProject.Comparisons.Trends
{
    partial class frmStudentPerformanceTrends
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
            chartTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label3 = new Label();
            cbEnrollments = new ComboBox();
            label2 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblAvgGrade = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblAvgAttendance = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            lblFullName = new Label();
            label10 = new Label();
            lblTuitionStatus = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label11 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chartTrends).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // chartTrends
            // 
            chartArea1.Name = "ChartArea1";
            chartTrends.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTrends.Legends.Add(legend1);
            chartTrends.Location = new Point(4, 32);
            chartTrends.Margin = new Padding(4, 3, 4, 3);
            chartTrends.Name = "chartTrends";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTrends.Series.Add(series1);
            chartTrends.Size = new Size(333, 177);
            chartTrends.TabIndex = 126;
            chartTrends.Text = "chart1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbEnrollments);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 44);
            panel1.TabIndex = 132;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 135;
            label3.Text = "Grade:";
            // 
            // cbEnrollments
            // 
            cbEnrollments.FormattingEnabled = true;
            cbEnrollments.Location = new Point(237, 12);
            cbEnrollments.Name = "cbEnrollments";
            cbEnrollments.Size = new Size(150, 23);
            cbEnrollments.TabIndex = 138;
            cbEnrollments.SelectedIndexChanged += cbEnrollments_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 18);
            label2.TabIndex = 138;
            label2.Text = "|";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(13, 13);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 18);
            lblTitle.TabIndex = 133;
            lblTitle.Text = "Student Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 133;
            label1.Text = "Avg. Grade";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblAvgGrade);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 100);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 63);
            panel2.TabIndex = 134;
            // 
            // lblAvgGrade
            // 
            lblAvgGrade.AutoSize = true;
            lblAvgGrade.Location = new Point(63, 29);
            lblAvgGrade.Margin = new Padding(4, 0, 4, 0);
            lblAvgGrade.Name = "lblAvgGrade";
            lblAvgGrade.Size = new Size(17, 15);
            lblAvgGrade.TabIndex = 134;
            lblAvgGrade.Text = "--";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(chartTrends);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(405, 50);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 218);
            panel4.TabIndex = 136;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 133;
            label6.Text = "Grades per subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 12);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 135;
            label5.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 133;
            label4.Text = "Avg. Attendace";
            // 
            // lblAvgAttendance
            // 
            lblAvgAttendance.AutoSize = true;
            lblAvgAttendance.Location = new Point(61, 29);
            lblAvgAttendance.Margin = new Padding(4, 0, 4, 0);
            lblAvgAttendance.Name = "lblAvgAttendance";
            lblAvgAttendance.Size = new Size(17, 15);
            lblAvgAttendance.TabIndex = 134;
            lblAvgAttendance.Text = "--";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblAvgAttendance);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(260, 100);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 63);
            panel3.TabIndex = 135;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(linkLabel1);
            panel5.Controls.Add(lblFullName);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(13, 50);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 38);
            panel5.TabIndex = 136;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(321, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(13, 18);
            label8.TabIndex = 135;
            label8.Text = "|";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(332, 14);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 15);
            linkLabel1.TabIndex = 137;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Details";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(95, 14);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(30, 15);
            lblFullName.TabIndex = 134;
            lblFullName.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 14);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 133;
            label10.Text = "Tuition Status";
            // 
            // lblTuitionStatus
            // 
            lblTuitionStatus.AutoSize = true;
            lblTuitionStatus.Location = new Point(53, 29);
            lblTuitionStatus.Margin = new Padding(4, 0, 4, 0);
            lblTuitionStatus.Name = "lblTuitionStatus";
            lblTuitionStatus.Size = new Size(17, 15);
            lblTuitionStatus.TabIndex = 134;
            lblTuitionStatus.Text = "--";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblTuitionStatus);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(13, 205);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(137, 63);
            panel6.TabIndex = 136;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(260, 205);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(137, 63);
            panel7.TabIndex = 137;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(56, 29);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 134;
            label11.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 14);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 133;
            label12.Text = "Tuition Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(545, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 139;
            // 
            // frmStudentPerformanceTrends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(759, 455);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStudentPerformanceTrends";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentPerformanceTrends";
            Load += frmStudentPerformanceTrends_Load;
            ((System.ComponentModel.ISupportInitialize)chartTrends).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvgAttendance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTuitionStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private ComboBox cbEnrollments;
        private Label label3;
        private ComboBox comboBox1;
    }
}