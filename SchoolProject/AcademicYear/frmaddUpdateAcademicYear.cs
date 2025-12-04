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

namespace SchoolProject.AcademicYear
{
    public partial class frmaddUpdateAcademicYear : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        private int _AcademicYearID;
        private clsAcademicYear _AcademicYear;
        public frmaddUpdateAcademicYear()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmaddUpdateAcademicYear(int academicYearID)
        {
            InitializeComponent();
            _AcademicYearID = academicYearID;
            Mode = enMode.Update;
        }

        private void frmaddUpdateAcademicYear_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Academic Year";
                _AcademicYear = new clsAcademicYear();
            }
            else
            {
                lblTitle.Text = "Update Academic Year";
            }

            lblAcademicYearID.Text = "[????]";
            txtYearName.Text = "";
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            chkActive.Checked = false;
        }
        private void _CreateDefaultTermsForYear(int academicYearID, int createdBy)
        {
            DateTime yearStart = _AcademicYear.StartDate;
            DateTime yearEnd = _AcademicYear.EndDate;

            // Divide the year range into 3 terms (roughly)
            TimeSpan totalDuration = yearEnd - yearStart;
            double termLengthDays = totalDuration.TotalDays / 3;

            DateTime term1Start = yearStart;
            DateTime term1End = term1Start.AddDays(termLengthDays - 1);

            DateTime term2Start = term1End.AddDays(1);
            DateTime term2End = term2Start.AddDays(termLengthDays - 1);

            DateTime term3Start = term2End.AddDays(1);
            DateTime term3End = yearEnd;

            // Create three terms
            clsTerm term1 = new clsTerm
            {
                TermName = "Term 1",
                StartDate = term1Start,
                EndDate = term1End,
                IsFinal = false,
                IsActive = true,
                AcademicYearID = academicYearID,
                CreatedByUserID = createdBy
            };
            term1.Save();

            clsTerm term2 = new clsTerm
            {
                TermName = "Term 2",
                StartDate = term2Start,
                EndDate = term2End,
                IsFinal = false,
                IsActive = false,
                AcademicYearID = academicYearID,
                CreatedByUserID = createdBy
            };
            term2.Save();

            clsTerm term3 = new clsTerm
            {
                TermName = "Term 3 (Final)",
                StartDate = term3Start,
                EndDate = term3End,
                IsFinal = true, // final term
                IsActive = false,
                AcademicYearID = academicYearID,
                CreatedByUserID = createdBy
            };
            term3.Save();
        }

        private void _LoadData()
        {
            _AcademicYear = clsAcademicYear.Find(_AcademicYearID);
            if (_AcademicYear == null)
            {
                MessageBox.Show("No Academic Year found with ID: " + _AcademicYearID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAcademicYearID.Text = _AcademicYear.AcademicYearID.ToString();
            txtYearName.Text = _AcademicYear.YearName;
            dtpStart.Value = _AcademicYear.StartDate;
            dtpEnd.Value = _AcademicYear.EndDate;
            chkActive.Checked = _AcademicYear.IsCurrent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Please fix errors before saving.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _AcademicYear.YearName = txtYearName.Text.Trim();
            _AcademicYear.StartDate = dtpStart.Value.Date;
            _AcademicYear.EndDate = dtpEnd.Value.Date;
            _AcademicYear.IsCurrent = chkActive.Checked;
            _AcademicYear.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_AcademicYear.StartDate > _AcademicYear.EndDate)
            {
                MessageBox.Show("Start Date cannot be after End Date.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Mode == enMode.AddNew)
            {
                if (_AcademicYear.Save())
                {
                    lblAcademicYearID.Text = _AcademicYear.AcademicYearID.ToString();
                    Mode = enMode.Update;
                    lblTitle.Text = "Update Academic Year";
                    this.Text = "Update Academic Year";

                    // 🟢 Create 3 default terms automatically
                    _CreateDefaultTermsForYear(_AcademicYear.AcademicYearID, clsGlobal.CurrentUser.UserID);

                    MessageBox.Show("Academic Year saved successfully, and 3 default terms have been created.",
                        "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Academic Year not saved.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                if (_AcademicYear.Save())
                {
                    MessageBox.Show("Academic Year updated successfully.",
                        "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Academic Year not updated.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
