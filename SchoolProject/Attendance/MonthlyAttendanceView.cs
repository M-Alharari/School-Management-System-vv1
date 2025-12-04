using SchoolProject.Employees;
using SchoolProjectBusiness;
using System;
using SchoolProject.Students;
using SchoolProject.Employees;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.Attendance
{
    public partial class MonthlyAttendanceView : Form
    {
        private string _personType; // "Employees" or "Students"


        private void LoadMonths()
        {
            var monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMonths.Items.Clear();

            for (int i = 0; i < 12; i++)
                cmbMonths.Items.Add(new ComboBoxItem { Text = monthNames[i], Value = i + 1 });

            cmbMonths.SelectedIndex = DateTime.Now.Month - 1;
        }
        public MonthlyAttendanceView(string personType)
        {
            InitializeComponent();
            _personType = personType;
            lblTitle.Text = _personType == "Employees" ? "Employees Monthly Attendance" : "Students Monthly Attendance";
        }

        private void LoadYears()
        {
            int currentYear = DateTime.Now.Year;
            cmbYears.Items.Clear();

            for (int y = currentYear - 5; y <= currentYear + 1; y++)
                cmbYears.Items.Add(new ComboBoxItem { Text = y.ToString(), Value = y });

            cmbYears.SelectedIndex = 5; // current year
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString() => Text;
        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceIfReady();
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceIfReady();
        }

        private void LoadAttendanceIfReady()
        {
            if (cmbMonths.SelectedItem is ComboBoxItem selectedMonth &&
                cmbYears.SelectedItem is ComboBoxItem selectedYear)
            {
                LoadMonthlyData(selectedMonth.Value, selectedYear.Value);
            }
        }

        private void LoadMonthlyData(int month, int year)
        {
            DataTable dt;

            if (_personType == "Employees")
                dt = clsEmployeeAttendance.GetAttendanceByMonth(month, year);
            else
                dt = clsStudentAttendance.GetAttendanceByMonth(month, year);

            dgvMonthData.DataSource = dt;
            dgvMonthData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MonthlyAttendanceView_Load(object sender, EventArgs e)
        {
            LoadMonths();
            LoadYears();
            LoadAttendanceIfReady(); // load fresh data on open
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMonthData.CurrentRow != null && dgvMonthData.CurrentRow.Index >= 0)
            {
                if (_personType == "Students")
                {
                    int studentID = Convert.ToInt32(dgvMonthData.CurrentRow.Cells["EnrollmentID"].Value);
                    frmStudentDetail frmStudentDetails = new frmStudentDetail(studentID);
                    frmStudentDetails.ShowDialog();
                }
                else if (_personType == "Employees")
                {
                    int employeeID = Convert.ToInt32(dgvMonthData.CurrentRow.Cells["EmployeeID"].Value);
                    frmShowEmployee frmEmployeeDetails = new frmShowEmployee(employeeID);
                    frmEmployeeDetails.ShowDialog();
                }
            }
        }
    }

}