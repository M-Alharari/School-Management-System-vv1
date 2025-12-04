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

namespace SchoolProject.Terms
{
    public partial class frmTermslist : Form
    {
        private static DataTable _dtAllTerms;
        private DataTable _dtTerms;
        private void LoadTerms(int  academicYearID)
        {
            _dtTerms = (academicYearID == -1)
                ? clsTerm.GetAll()
                : clsTerm.GetAll(academicYearID);

            if (_dtTerms.Columns.Count == 0)
            {
                MessageBox.Show("No Terms found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTerms.DataSource = null;
                return;
            }

            dgvTerms.DataSource = _dtTerms;
            dgvTerms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecordCount.Text = dgvTerms.Rows.Count.ToString();
        }

        //private void LoadTerms()
        //{

        //    // Get all terms
        //    _dtTerms = clsTerm.GetAll() ?? new DataTable();

        //    if (_dtTerms.Columns.Count == 0)
        //    {
        //        MessageBox.Show("No Terms found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        dgvTerms.DataSource = null;
        //        return;
        //    }

        //    // Bind to DataGridView
        //    dgvTerms.DataSource = _dtTerms;

        //    // Make columns fill the grid
        //    dgvTerms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //    // Hide ID column
        //    if (_dtTerms.Columns.Contains("TermID"))
        //        //dgvTerms.Columns["TermID"].Visible = false;
        //    dgvTerms.Columns["TermID"].HeaderText = "Term ID";
        //    dgvTerms.Columns["TermID"].FillWeight = 120; // larger weight = more space
        //    // Set headers + relative sizes
        //    if (_dtTerms.Columns.Contains("TermName"))
        //    {
        //        dgvTerms.Columns["TermName"].HeaderText = "Term Name";
        //        dgvTerms.Columns["TermName"].FillWeight = 150; // larger weight = more space
        //    }

        //    if (_dtTerms.Columns.Contains("StartDate"))
        //    {
        //        dgvTerms.Columns["StartDate"].HeaderText = "Start Date";
        //        dgvTerms.Columns["StartDate"].FillWeight = 120;
        //    }

        //    if (_dtTerms.Columns.Contains("EndDate"))
        //    {
        //        dgvTerms.Columns["EndDate"].HeaderText = "End Date";
        //        dgvTerms.Columns["EndDate"].FillWeight = 120;
        //    }

        //    if (_dtTerms.Columns.Contains("IsActive"))
        //    {
        //        dgvTerms.Columns["IsActive"].HeaderText = "Active";
        //        dgvTerms.Columns["IsActive"].FillWeight = 70; // smaller column
        //    }

        //    // Show record count
        //    lblRecordCount.Text = dgvTerms.Rows.Count.ToString();
        //}

        private void _RefreshData()
        {
            LoadTerms(_AcademicYear);
            //dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private int _AcademicYear = -1;
        public frmTermslist()
        {
            InitializeComponent();
            _dtAllTerms = clsTerm.GetAll() ?? new DataTable();

            if (_dtAllTerms.Columns.Contains("TermID") && _dtAllTerms.Columns.Contains("TermName"))
                _dtTerms = _dtAllTerms.DefaultView.ToTable(false, "TermID", "TermName", "StartDate", "EndDate", "IsActive");
            else
                _dtTerms = new DataTable();
        }
        public frmTermslist(int AcademicYear)
        {
            InitializeComponent();
            _AcademicYear = AcademicYear;
            _dtAllTerms = clsTerm.GetAll(_AcademicYear) ?? new DataTable();

            if (_dtAllTerms.Columns.Contains("TermID") && _dtAllTerms.Columns.Contains("TermName"))
                _dtTerms = _dtAllTerms.DefaultView.ToTable(false, "TermID", "TermName", "StartDate", "EndDate", "IsActive");
            else
                _dtTerms = new DataTable();
        }

        private void frmTermslist_Load(object sender, EventArgs e)
        {
            LoadTerms(_AcademicYear);
        }

        private void btnAddNewTerm_Click(object sender, EventArgs e)
        {
            frmaddUpdateTerm frm = new frmaddUpdateTerm(); // Add mode
            frm.ShowDialog();
            _RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTerms.CurrentRow != null)
            {
                int termID = Convert.ToInt32(dgvTerms.CurrentRow.Cells["TermID"].Value);
                frmaddUpdateTerm frm = new frmaddUpdateTerm(termID); // Edit mode
                frm.ShowDialog();
                _RefreshData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTerms.CurrentRow == null) return;

            int termID = Convert.ToInt32(dgvTerms.CurrentRow.Cells["TermID"].Value);
            if (MessageBox.Show($"Are you sure you want to delete Term [{dgvTerms.CurrentRow.Cells["TermName"].Value}]?",
                "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var term = clsTerm.Find(termID);
                if (term != null && term.Delete())
                {
                    MessageBox.Show("Term deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshData();
                }
                else
                {
                    MessageBox.Show("Cannot delete this Term. It may have linked data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}