using SchoolProject.Assessment_and_Exams;
using SchoolProject.Attendance;
using SchoolProject.Behaviours;
using SchoolProject.Comparisons.Trends;
using SchoolProject.Enrollment_Management;
using SchoolProject.Global;
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

namespace SchoolProject.Students
{
    public partial class frmStudentList : Form
    {
        private DataTable _dtAllEnrollments;
        private int _pageSize = 5;       // 20 records per page
        private int _currentPage = 1;     // current page number
        private int _totalPages = 2;

        private DataTable _dtAllStudents;
        private DataTable _dtStudents;
        //private void DisplayPage(int pageNumber)
        //{
        //    if (_dtStudents == null || _dtStudents.Rows.Count == 0)
        //    {
        //        dgvStudents.DataSource = null;
        //        lblRecordCount.Text = "0";
        //        return;
        //    }

        //    _totalPages = (int)Math.Ceiling((double)_dtStudents.Rows.Count / _pageSize);
        //    _currentPage = Math.Max(1, Math.Min(pageNumber, _totalPages));

        //    int startIndex = (_currentPage - 1) * _pageSize;
        //    int endIndex = Math.Min(startIndex + _pageSize, _dtStudents.Rows.Count);

        //    DataTable pageTable = _dtStudents.Clone();
        //    for (int i = startIndex; i < endIndex; i++)
        //        pageTable.ImportRow(_dtStudents.Rows[i]);

        //    dgvStudents.DataSource = pageTable;
        //    lblPageSize.Text = $"Page {_currentPage} of {_totalPages}";

        //    // Optional: disable buttons when not usable
        //    btnPrevious.Enabled = _currentPage > 1;
        //    btnNext.Enabled = _currentPage < _totalPages;
        //}
        //private void _RefreshStudentList()
        //{
        //    _dtAllStudents = clsStudent.GetAllStudents() ?? new DataTable();

        //    if (_dtAllStudents.Columns.Contains("StudentID") &&
        //        _dtAllStudents.Columns.Contains("FullName"))
        //    {
        //        _dtStudents = _dtAllStudents.DefaultView.ToTable(false,
        //           "EnrollmentID", "StudentID", "FullName", "GenderCaption", "CountryName", "GradeName", "ClassName");
        //    }
        //    else
        //    {
        //        _dtStudents = new DataTable();
        //    }

        //    DisplayPage(1); // ✅ show first page
        //}

        private void _RefreshStudentList()
        {
            _dtAllStudents = clsStudent.GetAllStudents() ?? new DataTable();

            // Only create _dtStudents if required columns exist
            if (_dtAllStudents.Columns.Contains("StudentID") &&
                _dtAllStudents.Columns.Contains("FullName"))
            {
                _dtStudents = _dtAllStudents.DefaultView.ToTable(false,
                   "EnrollmentID", "StudentID", "FullName", "GenderCaption", "CountryName", "GradeName", "ClassName");
            }
            else
            {
                _dtStudents = new DataTable();
            }

            dgvStudents.DataSource = _dtStudents;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecordCount.Text = _dtStudents.Rows.Count.ToString();
        }

        private void FormatGridColumns()
        {
            dgvStudents.Columns[0].HeaderText = "EnrollmentID";
            dgvStudents.Columns[0].Width = 80;

            dgvStudents.Columns[1].HeaderText = "StudentID";  // ✅ new column
            dgvStudents.Columns[1].Width = 80;

            dgvStudents.Columns[2].HeaderText = "Full Name";
            dgvStudents.Columns[2].Width = 120;

            dgvStudents.Columns[3].HeaderText = "Gender";
            dgvStudents.Columns[3].Width = 90;

            dgvStudents.Columns[4].HeaderText = "Country";
            dgvStudents.Columns[4].Width = 90;

            dgvStudents.Columns[5].HeaderText = "Grade";
            dgvStudents.Columns[5].Width = 90;

            dgvStudents.Columns[6].HeaderText = "Class";
            dgvStudents.Columns[6].Width = 90;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            _RefreshStudentList();

            cbFilterBy.SelectedIndex = 0;

            dgvStudents.DataSource = _dtStudents;
            lblRecordCount.Text = _dtStudents.Rows.Count.ToString();

            if (_dtStudents.Rows.Count > 0)
                FormatGridColumns();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent();
            frm.ShowDialog();
            _RefreshStudentList();

        }

        private void showDeatilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail frm = new frmStudentDetail((int)dgvStudents.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent();
            frm.ShowDialog();
            _RefreshStudentList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent((int)dgvStudents.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshStudentList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "Are you sure you want to delete Student [" + dgvStudents.CurrentRow.Cells[0].Value + "]",
        "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int currentUser = clsGlobal.CurrentUser.UserID;

                // Perform Delete and refresh
                if (clsEnrollment.DeactivateEnrollment((int)dgvStudents.CurrentRow.Cells[0].Value, currentUser))
                {
                    MessageBox.Show("Student Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshStudentList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEnrollmentHistory frmEnrollmentHistorys = new frmEnrollmentHistory((int)dgvStudents.CurrentRow.Cells[1].Value);
            frmEnrollmentHistorys.ShowDialog();
        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterScores frmEnrollmentHistorys = new EnterScores((int)dgvStudents.CurrentRow.Cells[0].Value);
            frmEnrollmentHistorys.ShowDialog();
        }

        private void behavioursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentBehaviorslist frmStudentBehaviorslist = new frmStudentBehaviorslist((int)dgvStudents.CurrentRow.Cells[0].Value);
            frmStudentBehaviorslist.ShowDialog();
        }

        private void behavioursLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentBehaviorslist frmStudentBehaviorslist = new frmStudentBehaviorslist((int)dgvStudents.CurrentRow.Cells[0].Value);
            frmStudentBehaviorslist.ShowDialog();

        }

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceCard attendanceCard = new AttendanceCard((int)dgvStudents.CurrentRow.Cells[0].Value, true);
            attendanceCard.ShowDialog();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtStudents == null || _dtStudents.Rows.Count == 0)
                return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Student ID":
                    filterColumn = "StudentID";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Gender":
                    filterColumn = "GenderCaption";
                    break;
                case "Country":
                    filterColumn = "CountryName";
                    break;
                case "Grade":
                    filterColumn = "GradeName";
                    break;
                case "Class":
                    filterColumn = "ClassName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            // Reset filter if no input
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtStudents.DefaultView.RowFilter = "";
                lblRecordCount.Text = _dtStudents.DefaultView.Count.ToString();
                return;
            }

            string filterText = txtFilterValue.Text.Trim().Replace("'", "''");

            if (filterColumn == "StudentID")
            {
                // Exact numeric match
                _dtStudents.DefaultView.RowFilter = $"[{filterColumn}] = {filterText}";
            }
            else
            {
                // LIKE search for text columns
                _dtStudents.DefaultView.RowFilter = $"[{filterColumn}] LIKE '{filterText}%'";
            }

            lblRecordCount.Text = _dtStudents.DefaultView.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Student ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
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

        private void typeScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterScores frmEnrollmentHistorys = new EnterScores((int)dgvStudents.CurrentRow.Cells[0].Value);
            frmEnrollmentHistorys.ShowDialog();
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentPerformanceTrends frmStudentPerformanceTrends = new frmStudentPerformanceTrends((int)dgvStudents.CurrentRow.Cells[1].Value);
            frmStudentPerformanceTrends.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if (_currentPage < _totalPages)
            //    DisplayPage(_currentPage + 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //if (_currentPage > 1)
            //    DisplayPage(_currentPage - 1);
        }
    }
}
