using SchoolProjectBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.Comparisons.Trends
{
    public partial class frmStudentPerformanceTrends : Form
    {
        private int _StudentID;
        clsEnrollment _Enrollment ;
        public frmStudentPerformanceTrends(int studentID)
        {
            InitializeComponent(); 
            _StudentID = studentID;
            _Enrollment = clsEnrollment.FindByStudentID(studentID);
        }

        private void frmStudentPerformanceTrends_Load(object sender, EventArgs e)
        {
            _Enrollment = clsEnrollment.FindByStudentID(_StudentID);
            LoadEnrollments(_StudentID);
        }
        // 🧠 Step 1: Load all enrollments (grades/year) for this student
      

        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)

        {
            // When user changes grade manually, reload classes and students
            //LoadClassesAndStudents();
        }

        //private void LoadStudentInfo(int studentID)
        //{
        //    // Get student info including full name and tuition status
        //    DataRow studentRow = clsStudent.GetStudentInfoWithTuition(studentID);
        //    if (studentRow != null)
        //    {
        //        lblFullName.Text = studentRow["FullName"].ToString();
        //        lblTuitionStatus.Text = studentRow["TuitionStatus"].ToString();
        //    }

        //    // Get average grade
        //    double avgGrade = clsTrends.GetStudentAverageGrade(studentID);
        //    lblAvgGrade.Text = avgGrade.ToString("F2");

        //    // Get average attendance
        //    double avgAttendance = clsTrends.GetStudentAverageAttendance(studentID);
        //    lblAvgAttendance.Text = avgAttendance.ToString("F2") + "%";
        //}

        private void LoadStudentChart(int enrollmentID, int termID = 0)
        {
            // Clear previous chart data
            chartTrends.Series.Clear();

            var chartArea = chartTrends.ChartAreas[0];
            chartArea.AxisX.Title = "Term";
            chartArea.AxisY.Title = "Average Score";
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Interval = 1;

            // Get scores from business layer
            DataTable dtScores;

            if (termID > 0)
            {
                // Scores for a specific term
                dtScores = clsTrends.GetStudentScoresByEnrollment(_Enrollment.EnrollmentID);
            }
            else
            {
                // Scores for all terms in this enrollment
                dtScores = clsTrends.GetStudentScoresByEnrollment(enrollmentID);
            }

            if (dtScores == null || dtScores.Rows.Count == 0)
                return; // Nothing to display

            // Create series
            var series = chartTrends.Series.Add("Average Score");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            series.BorderWidth = 2;

            // Populate series
            foreach (DataRow row in dtScores.Rows)
            {
                string termName = row["TermName"].ToString();
                double score = Convert.ToDouble(row["AvgScore"]);
                series.Points.AddXY(termName, score);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbTerms_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbEnrollments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnrollments.SelectedValue == null || cbEnrollments.SelectedValue is DataRowView)
                return;

            int enrollmentID = _Enrollment.EnrollmentID;
            LoadPerformanceForEnrollment(enrollmentID);
        }
        // 🧠 Step 3: Load all performance (chart + payments) for an enrollment
        private void LoadPerformanceForEnrollment(int enrollmentID)
        {
            DataRow enrollment = clsEnrollment.GetEnrollmentByID(enrollmentID);
            if (enrollment == null)
                return;

            //lblCurrentGrade.Text = enrollment["GradeName"].ToString();

            LoadStudentChart(enrollmentID);
            //LoadPaymentSummary(enrollmentID);
        }
        // 🧠 Step 1: Load all enrollments (grades + academic year) for this student
        private void LoadEnrollments(int studentID)
        {
            DataTable dt = clsEnrollment.GetEnrollmentsByStudentID(studentID);

            if (dt == null || dt.Rows.Count == 0)
            {
                cbEnrollments.DataSource = null;
                MessageBox.Show("This student has no enrollment records.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!dt.Columns.Contains("DisplayText"))
                dt.Columns.Add("DisplayText", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                string gradeName = row["GradeName"].ToString();
                string startYear = Convert.ToDateTime(row["StartDate"]).Year.ToString();
                string endYear = Convert.ToDateTime(row["EndDate"]).Year.ToString();
                row["DisplayText"] = $"{gradeName} ({startYear}–{endYear})";
            }



            cbEnrollments.DataSource = dt;
            cbEnrollments.DisplayMember = "DisplayText";
            cbEnrollments.ValueMember = "EnrollmentID";

            cbEnrollments.SelectedIndexChanged -= cbEnrollments_SelectedIndexChanged;
            cbEnrollments.SelectedIndexChanged += cbEnrollments_SelectedIndexChanged;

            cbEnrollments.SelectedIndex = 0;
            int firstEnrollmentID = Convert.ToInt32(cbEnrollments.SelectedValue);
            LoadPerformanceForEnrollment(firstEnrollmentID);
        }
        // 🧠 Step 4: Draw the student’s scores chart
        private void LoadStudentChart(int enrollmentID)
        {
            chartTrends.Series.Clear();
            chartTrends.ChartAreas[0].AxisX.Title = "Term";
            chartTrends.ChartAreas[0].AxisY.Title = "Average Score";
            chartTrends.ChartAreas[0].AxisY.Minimum = 0;
            chartTrends.ChartAreas[0].AxisY.Maximum = 100;

            DataTable dtScores = clsTrends.GetStudentScoresByEnrollment(enrollmentID);
            if (dtScores == null || dtScores.Rows.Count == 0)
                return;

            var series = chartTrends.Series.Add("Average Score");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            series.BorderWidth = 2;

            foreach (DataRow row in dtScores.Rows)
            {
                string termName = row["TermName"].ToString();
                double score = Convert.ToDouble(row["AvgScore"]);
                series.Points.AddXY(termName, score);
            }

            chartTrends.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartTrends.ChartAreas[0].AxisX.Interval = 1;
        }

        // 🧠 Step 5: Payment summary (optional)
        //private void LoadPaymentSummary(int enrollmentID)
        //{
        //    DataRow paymentInfo = clsTrends.GetPaymentSummaryByEnrollmentID(enrollmentID);
        //    if (paymentInfo == null)
        //    {
        //        lblTotalPaid.Text = "0";
        //        lblOutstanding.Text = "0";
        //        return;
        //    }

        //    lblTotalPaid.Text = paymentInfo["TotalPaid"].ToString();
        //    lblOutstanding.Text = paymentInfo["Outstanding"].ToString();
        //}

        // 🧠 Step 6: Basic student info (fixed)
        private void LoadStudentInfo(int studentID)
        {
            DataRow studentRow = clsStudent.GetStudentInfoWithTuition(studentID);
            if (studentRow != null)
            {
                lblFullName.Text = studentRow["FullName"].ToString();
                lblTuitionStatus.Text = studentRow["TuitionStatus"].ToString();
            }

            double avgGrade = clsTrends.GetStudentAverageGrade(studentID);
            lblAvgGrade.Text = avgGrade.ToString("F2");

            double avgAttendance = clsTrends.GetStudentAverageAttendance(studentID);
            lblAvgAttendance.Text = avgAttendance.ToString("F2") + "%";
        }
    }
}
 