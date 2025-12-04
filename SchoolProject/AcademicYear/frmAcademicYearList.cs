using SchoolProject.Terms;
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

namespace SchoolProject.AcademicYear
{
    public partial class frmAcademicYearList : Form
    {
        private static DataTable _dtAllAcademicYears;
        private DataTable _dtAcademicYears;

        private void LoadAcademicYears()
        {
            // Get all academic years
            _dtAcademicYears = clsAcademicYear.GetAll() ?? new DataTable();

            if (_dtAcademicYears.Columns.Count == 0)
            {
                MessageBox.Show("No Academic Years found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAcademicYears.DataSource = null;
                return;
            }

            // Bind data
            dgvAcademicYears.DataSource = _dtAcademicYears;
            dgvAcademicYears.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust column headers and visibility
            if (_dtAcademicYears.Columns.Contains("AcademicYearID"))
            {
                dgvAcademicYears.Columns["AcademicYearID"].HeaderText = "Year ID";
                dgvAcademicYears.Columns["AcademicYearID"].FillWeight = 100;
            }

            if (_dtAcademicYears.Columns.Contains("YearName"))
            {
                dgvAcademicYears.Columns["YearName"].HeaderText = "Academic Year";
                dgvAcademicYears.Columns["YearName"].FillWeight = 150;
            }

            if (_dtAcademicYears.Columns.Contains("StartDate"))
            {
                dgvAcademicYears.Columns["StartDate"].HeaderText = "Start";
                dgvAcademicYears.Columns["StartDate"].FillWeight = 120;
            }

            if (_dtAcademicYears.Columns.Contains("EndDate"))
            {
                dgvAcademicYears.Columns["EndDate"].HeaderText = "End";
                dgvAcademicYears.Columns["EndDate"].FillWeight = 120;
            }

            if (_dtAcademicYears.Columns.Contains("IsActive"))
            {
                dgvAcademicYears.Columns["IsActive"].HeaderText = "Active";
                dgvAcademicYears.Columns["IsActive"].FillWeight = 80;
            }

            // Record count
            lblRecordCount.Text = dgvAcademicYears.Rows.Count.ToString();
        }

        private void _RefreshData()
        {
            LoadAcademicYears();
        }


        public frmAcademicYearList()
        {
            InitializeComponent();
            _dtAllAcademicYears = clsAcademicYear.GetAll() ?? new DataTable();

            if (_dtAllAcademicYears.Columns.Contains("AcademicYearID") &&
                _dtAllAcademicYears.Columns.Contains("YearName"))
            {
                _dtAcademicYears = _dtAllAcademicYears.DefaultView
                    .ToTable(false, "AcademicYearID", "YearName", "StartDate", "EndDate", "IsCurrent");
            }
            else
            {
                _dtAcademicYears = new DataTable();
            }
        }

        private void frmAcademicYearList_Load(object sender, EventArgs e)
        {
            LoadAcademicYears();
        }

        private void btnAddAcademicYear_Click(object sender, EventArgs e)
        {
            frmaddUpdateAcademicYear frm = new frmaddUpdateAcademicYear(); // Add mode
            frm.ShowDialog();
            _RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddUpdateAcademicYear frm = new frmaddUpdateAcademicYear((int)dgvAcademicYears.CurrentRow.Cells[0].Value); // Add mode
            frm.ShowDialog();
            _RefreshData();
        }

        private void relatedTermsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTermslist frmTermslist = new frmTermslist((int)dgvAcademicYears.CurrentRow.Cells[0].Value);
            frmTermslist.ShowDialog();
        }
    }
}
