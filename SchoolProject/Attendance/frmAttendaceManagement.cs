
using SchoolProject.People;
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

namespace SchoolProject.Attendance
{
    public partial class frmAttendaceManagement : Form
    {
        private string _personType = "Employees"; // default shown in grid

        private static DataTable _dtAllAttendance = clsEmployeeAttendance.GetAllAttendance();

        private DataTable _dtAttendance = _dtAllAttendance.DefaultView.ToTable(false,
          "AttendanceID", "PersonID", "FullName", "AttendanceDate", "IsPresent", "AbsenceReason");

        private void _RefreshAttendanceList()
        {
            DataTable dtAll = null;

            if (_personType == "Employees")
            {
                dtAll = clsEmployeeAttendance.GetAllAttendance();
                if (dtAll.Columns.Contains("EmployeeID") && !dtAll.Columns.Contains("PersonID"))
                    dtAll.Columns["EmployeeID"].ColumnName = "PersonID";

                lblTitle.Text = "Manage Employees Attendance"; // update title for employees
            }
            else if (_personType == "Students")
            {
                dtAll = clsStudentAttendance.GetAllAttendance();
                if (dtAll.Columns.Contains("StudentID") && !dtAll.Columns.Contains("PersonID"))
                    dtAll.Columns["StudentID"].ColumnName = "PersonID";

                lblTitle.Text = "Manage Students Attendance"; // update title for students
            }

            _dtAttendance = dtAll ?? new DataTable();
            dgvAttendance.DataSource = _dtAttendance;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecordCount.Text = dgvAttendance.Rows.Count.ToString();

            if (dgvAttendance.Rows.Count > 0)
            {
                dgvAttendance.Columns["AttendanceID"].HeaderText = "AttendID";

                if (dgvAttendance.Columns.Contains("FullName"))
                    dgvAttendance.Columns["FullName"].HeaderText = "Full Name";
                else
                    dgvAttendance.Columns["PersonID"].HeaderText = "PersonID";

                dgvAttendance.Columns["AttendanceDate"].HeaderText = "Date";
                dgvAttendance.Columns["IsPresent"].HeaderText = "Present?";
                dgvAttendance.Columns["AbsenceReason"].HeaderText = "Reason";
            }

            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public frmAttendaceManagement()
        {
            InitializeComponent();
        }

        private void frmAttendaceManagement_Load(object sender, EventArgs e)
        {    // Initialize mode ComboBox
            cbMode.Items.Clear();
            cbMode.Items.Add("Employees");
            cbMode.Items.Add("Students");
            cbMode.SelectedIndex = 0; // default Employees

            // Initialize filter ComboBox
            cbFilterBy.SelectedIndex = 0;

            // Load attendance for the default mode
            _RefreshAttendanceList();

            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAttendance == null || _dtAttendance.Rows.Count == 0)
                return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    filterColumn = "PersonID";   // always PersonID now (EmployeeID/StudentID was renamed earlier)
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Date":
                    filterColumn = "AttendanceDate";
                    break;
                case "Present?":
                    filterColumn = "IsPresent";
                    break;
                case "Reason":
                    filterColumn = "AbsenceReason";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            // Reset filter if empty
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtAttendance.DefaultView.RowFilter = "";
                lblRecordCount.Text = _dtAttendance.DefaultView.Count.ToString();
                return;
            }

            string filterText = txtFilterValue.Text.Trim().Replace("'", "''");

            if (filterColumn == "PersonID")
            {
                // Numeric ID exact match
                _dtAttendance.DefaultView.RowFilter = $"[{filterColumn}] = {filterText}";
            }
            else if (filterColumn == "IsPresent")
            {
                // Match boolean (true/false, yes/no)
                if (filterText.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                    filterText.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    _dtAttendance.DefaultView.RowFilter = $"[{filterColumn}] = true";
                }
                else if (filterText.Equals("no", StringComparison.OrdinalIgnoreCase) ||
                         filterText.Equals("false", StringComparison.OrdinalIgnoreCase))
                {
                    _dtAttendance.DefaultView.RowFilter = $"[{filterColumn}] = false";
                }
                else
                {
                    _dtAttendance.DefaultView.RowFilter = ""; // invalid input
                }
            }
            else if (filterColumn == "AttendanceDate")
            {
                if (DateTime.TryParse(filterText, out DateTime dateValue))
                {
                    // Compare by Date only (ignores time)
                    string dateString = dateValue.ToString("M/d/yyyy"); // same format DataGridView shows
                    _dtAttendance.DefaultView.RowFilter =
                        $"CONVERT([{filterColumn}], System.String) LIKE '%{dateString}%'";
                }
                else
                {
                    _dtAttendance.DefaultView.RowFilter =
                        $"CONVERT([{filterColumn}], System.String) LIKE '%{filterText}%'";
                }
            }


            else
            {
                // Textual filter (LIKE)
                _dtAttendance.DefaultView.RowFilter = $"[{filterColumn}] LIKE '{filterText}%'";
            }

            lblRecordCount.Text = _dtAttendance.DefaultView.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }
        private void OpenDailyAttendance(string personType)
        {
            frmDailyAttendance frmDailyAttendance = new frmDailyAttendance(personType);
            frmDailyAttendance.ShowDialog();

            // After closing the dialog, refresh the grid in main form
            _personType = personType; // store which type is currently displayed
            _RefreshAttendanceList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Pass the current grid type to frmDailyAttendance
            frmDailyAttendance frmDailyAttendance = new frmDailyAttendance(_personType);
            frmDailyAttendance.ShowDialog();

            // Refresh grid after closing form
            _RefreshAttendanceList();
        }

        private void cmMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedItem == null) return;

            // Update the current person type
            _personType = cbMode.SelectedItem.ToString();

            // Refresh grid based on new type
            _RefreshAttendanceList();
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedItem == null) return;

            // Update the current person type
            _personType = cbMode.SelectedItem.ToString();

            // Refresh grid based on new type
            _RefreshAttendanceList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frmShowPersonDetails = new frmShowPersonDetails((int)dgvAttendance.CurrentRow.Cells[1].Value);
            frmShowPersonDetails.ShowDialog();
        }
    }
}
