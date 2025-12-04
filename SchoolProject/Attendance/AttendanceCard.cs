using SchoolProject.Employees;
using SchoolProject.People;
using SchoolProject.Students;
using SchoolProject.Teachers;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SchoolProject.Attendance
{
    public partial class AttendanceCard : Form
    {
        private int _EmployeeID = -1;
        private int _EnrolledID = -1;
        private string _PersonType = ""; // "Employee" or "Student"

        public AttendanceCard(int   employeeID)
        {
            InitializeComponent();
            _EmployeeID = employeeID;
            _PersonType = "Employee";
        }
        // Constructor for Student
        public AttendanceCard(int enrolledID, bool isStudent)
        {
            InitializeComponent();
            _EnrolledID = enrolledID;
            _PersonType = "Student";
            llTeacherInfoCard.Text = "Student Info Card";
        }

        // ✅ Employee Attendance Summary
        private void LoadEmployeeAttendanceSummary(int employeeID, int month, int year)
        {
            if (employeeID <= 0)
            {
                ClearLabels();
                MessageBox.Show("Invalid Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = clsAttendanceRecord.GetSummaryForTeacher(employeeID);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblFullName.Text = row["FullName"].ToString();
                lblTotalDays.Text = row["TotalDays"].ToString();
                lblPresentDays.Text = row["DaysPresent"].ToString();
                lblLastDayPresent.Text = row["LastDayPresent"].ToString();
                lblAttendancePercentage.Text = string.Format("{0:0.00} %", Convert.ToDouble(row["AttendancePercentage"]));
                lblTopAbsenceReason.Text = row["TopAbsenceReason"].ToString();
                int totalDays = Convert.ToInt32(row["TotalDays"]);
                int presentDays = Convert.ToInt32(row["DaysPresent"]);

                LoadAttendanceChart(totalDays, presentDays);
            }
            else
            {
                ClearLabels();
                MessageBox.Show("No attendance data found for this employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Shared chart builder
        private void LoadAttendanceChart(int totalDays, int daysPresent)
        {
            int daysAbsent = totalDays - daysPresent;
            if (daysAbsent < 0) daysAbsent = 0;

            chartAttendance.Series.Clear();
            chartAttendance.Titles.Clear();

            Series series = new Series("Attendance");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Present", daysPresent);
            series.Points.AddXY("Absent", daysAbsent);

            series.Points[0].Color = Color.FromArgb(76, 175, 80);
            series.Points[1].Color = Color.FromArgb(244, 67, 54);

            series.Points[0].Label = $"Present: {daysPresent}";
            series.Points[1].Label = $"Absent: {daysAbsent}";

            chartAttendance.Series.Add(series);
            chartAttendance.Titles.Add("Attendance Breakdown");
        }

        // ✅ Student Attendance Summary
        private void LoadStudentAttendanceSummary(int studentID, int month, int year)
        {
            if (studentID <= 0)
            {
                ClearLabels();
                MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = clsStudentAttendance.GetStudentAttendanceSummary(studentID);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblFullName.Text = row["FullName"].ToString();
                lblTotalDays.Text = row["TotalDays"].ToString();
                lblPresentDays.Text = row["DaysPresent"].ToString();
                lblLastDayPresent.Text = row["LastDayPresent"].ToString();
                lblAttendancePercentage.Text = string.Format("{0:0.00} %", Convert.ToDouble(row["AttendancePercentage"]));
                lblTopAbsenceReason.Text = row["TopAbsenceReason"].ToString();
                int totalDays = Convert.ToInt32(row["TotalDays"]);
                int presentDays = Convert.ToInt32(row["DaysPresent"]);

                LoadAttendanceChart(totalDays, presentDays);

            }
            else
            {
                ClearLabels();
                MessageBox.Show("No attendance data found for this student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearLabels()
        {
            lblFullName.Text = "-";
            lblTotalDays.Text = "-";
            lblPresentDays.Text = "-";
            lblLastDayPresent.Text = "-";
            lblAttendancePercentage.Text = "-";
        }
    
        private void AttendanceCard_Load(object sender, EventArgs e)
        {
            if (_PersonType == "Employee")
                LoadEmployeeAttendanceSummary(_EmployeeID, DateTime.Now.Month, DateTime.Now.Year);
            else if (_PersonType == "Student")
                LoadStudentAttendanceSummary(_EnrolledID, DateTime.Now.Month, DateTime.Now.Year);
        }

        private void llTeacherInfoCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonType == "Employee")
            {
                clsEmployee Emp = clsEmployee.FindByEmployeeID(_EmployeeID);
                if (Emp == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frmShowEmployee frmTeacherDetails = new frmShowEmployee(_EmployeeID);
                frmTeacherDetails.ShowDialog();

            } else
            {
                llTeacherInfoCard.Text = "Student Info Card";
                clsEnrollment Enrolled = clsEnrollment.FindByID(_EnrolledID);
                if (Enrolled == null)
                {
                    MessageBox.Show("student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
                frmStudentDetail frmStudentDetail = new frmStudentDetail(Enrolled.StudentID);
                frmStudentDetail.ShowDialog();
            }


        }
    }
}
