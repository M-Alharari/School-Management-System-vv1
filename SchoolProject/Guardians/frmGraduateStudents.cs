using SchoolProject.Business;
using SchoolProject.Data;
using SchoolProject.Global;
using SchoolProjectBusiness;
using SchoolProjectData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;


namespace SchoolProject.Graduation
{
    public partial class frmGraduateStudents : Form
    {
        private bool _isFinalTerm; // Add this field
        private DataTable _dtGraduation;
        private int _currentTermID;
        public frmGraduateStudents()
        {
            InitializeComponent();
        }
        private bool AllEnrollmentsHaveScores(int termID)
        {
            // 1️⃣ Get all active enrollments for this term
            DataTable dtEnrollments = clsEnrollmentData.GetActiveEnrollmentsByTerm(termID);
            if (dtEnrollments.Rows.Count == 0)
                return false;

            // 2️⃣ Collect students missing scores
            List<string> missingScoreStudents = new List<string>();

            foreach (DataRow row in dtEnrollments.Rows)
            {
                int enrollmentID = Convert.ToInt32(row["EnrollmentID"]);
                DataTable dtScores = clsScoreDetailsPerTerm.GetScoresByEnrollmentAndTerm(enrollmentID, termID);

                if (dtScores.Rows.Count == 0)
                {
                    string studentName = row["FullName"]?.ToString() ?? "Unknown";
                    missingScoreStudents.Add(studentName);
                }
            }

            // 3️⃣ If any missing, show one message and return false
            if (missingScoreStudents.Count > 0)
            {
                string message = $"⚠️ {missingScoreStudents.Count} student(s) have no recorded scores in this term.\n\n";

                // Show up to 10 names
                int showCount = Math.Min(10, missingScoreStudents.Count);
                message += string.Join("\n", missingScoreStudents.Take(showCount));

                if (missingScoreStudents.Count > showCount)
                    message += $"\n... and {missingScoreStudents.Count - showCount} more.";

                MessageBox.Show(
                    message,
                    "Missing Scores Detected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            // ✅ All enrollments have scores
            return true;
        }

        private void frmGraduateStudents_Load(object sender, EventArgs e)
        {


            _currentTermID = clsTerm.GetCurrentTermIDSafe();
            if (_currentTermID <= 0)
            {
                MessageBox.Show("No active term. Cannot perform graduation.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGraduate.Enabled = false;
                return;
            }
            int _academicYearID = clsAcademicYear.GetCurrentAcademicYearID();
            if (_academicYearID <= 0)
            {
                MessageBox.Show("No active academic year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Check if all students are in the same term
            if (!clsEnrollment.AreAllStudentsInSameTerm(_academicYearID))
            {
                MessageBox.Show(
                    "Not all students are in the same term.\n" +
                    "Please ensure all active students are promoted to the same current term before continuing.",
                    "Term Mismatch Detected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                btnGraduate.Enabled = false;
                return;
            }
            // 🔹 Check if all students have scores before proceeding
            if (!AllEnrollmentsHaveScores(_currentTermID))
            {
                btnGraduate.Enabled = false;
                return;
            }
            


            // ✅ Determine if current term is final
            _isFinalTerm = clsTerm.IsFinalTerm(_currentTermID);

            if (_isFinalTerm)
            {
                lblTitle.Text = "FINAL GRADUATION";
                lblTitle.ForeColor = Color.Red;
                btnGraduate.Text = "Graduate Students";
            }
            else
            {
                lblTitle.Text = "PROMOTE TERM";
                lblTitle.ForeColor = Color.Blue;
                btnGraduate.Text = "Promote Students";
            }

            LoadPreviewGraduationGrid();
        }

        private void LoadPreviewGraduationGrid()
        {
            _dtGraduation = clsGraduation.GetStudentsWithPredictedGraduation(_currentTermID);

            dgvGraduates.DataSource = _dtGraduation;
            dgvGraduates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FormatGridColumns();
            UpdatePreviewStats();
        }
        private void UpdateStats(DataTable dt, string passedColumn = "IsPredictedPassed")
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblPassedCount.Text = "Passed: 0";
                lblFailedCount.Text = "Failed: 0";
                lblTotalCount.Text = "Total Students: 0";
                return;
            }

            int passed = dt.AsEnumerable().Count(r => r[passedColumn] != DBNull.Value && Convert.ToBoolean(r[passedColumn]));
            int failed = dt.Rows.Count - passed;

            lblPassedCount.Text = $"Passed: {passed}";
            lblFailedCount.Text = $"Failed: {failed}";
            lblTotalCount.Text = $"Total Students: {dt.Rows.Count}";
        }


        private void FormatGridColumns()
        {
            // Make sure the DataGridView exists
            if (dgvGraduates == null)
                return;

            // Make sure it has columns
            if (dgvGraduates.Columns == null || dgvGraduates.Columns.Count == 0)
                return;

            // Hide unnecessary columns
            if (dgvGraduates.Columns.Contains("EnrollmentID"))
                dgvGraduates.Columns["EnrollmentID"].Visible = false;

            if (dgvGraduates.Columns.Contains("PersonID"))
                dgvGraduates.Columns["PersonID"].Visible = false;

            if (dgvGraduates.Columns.Contains("StudentID"))
                dgvGraduates.Columns["StudentID"].Visible = false;

            // Configure visible columns
            if (dgvGraduates.Columns.Contains("FullName"))
            {
                dgvGraduates.Columns["FullName"].HeaderText = "Full Name";
                dgvGraduates.Columns["FullName"].Width = 100;
            }

            if (dgvGraduates.Columns.Contains("GradeName"))
            {
                dgvGraduates.Columns["GradeName"].HeaderText = "Grade";
                dgvGraduates.Columns["GradeName"].Width = 70;
            }

            if (dgvGraduates.Columns.Contains("ClassName"))
            {
                dgvGraduates.Columns["ClassName"].HeaderText = "Class";
                dgvGraduates.Columns["ClassName"].Width = 70;
            }

            if (dgvGraduates.Columns.Contains("TotalScore"))
            {
                dgvGraduates.Columns["TotalScore"].HeaderText = "Total Score";
                dgvGraduates.Columns["TotalScore"].Width = 70;
            }

            if (dgvGraduates.Columns.Contains("MaxTotalScore"))
            {
                dgvGraduates.Columns["MaxTotalScore"].HeaderText = "Max Total Score";
                dgvGraduates.Columns["MaxTotalScore"].Width = 70;
            }

            if (dgvGraduates.Columns.Contains("Percentage"))
            {
                dgvGraduates.Columns["Percentage"].HeaderText = "Percentage";
                dgvGraduates.Columns["Percentage"].Width = 70;
            }

            if (dgvGraduates.Columns.Contains("PredictedLetterGrade"))
            {
                dgvGraduates.Columns["PredictedLetterGrade"].HeaderText = "Predicted Grade";
                dgvGraduates.Columns["PredictedLetterGrade"].Width = 60;
            }

            if (dgvGraduates.Columns.Contains("IsPredictedPassed"))
            {
                dgvGraduates.Columns["IsPredictedPassed"].HeaderText = "Predicted Pass";
                dgvGraduates.Columns["IsPredictedPassed"].Width = 80;
                dgvGraduates.Columns["IsPredictedPassed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void UpdateFinalStats()
        {
            if (_dtGraduation == null || _dtGraduation.Rows.Count == 0)
            {
                lblPassedCount.Text = "Passed: 0";
                lblFailedCount.Text = "Failed: 0";
                lblTotalCount.Text = "Total Students: 0";
                return;
            }
            // Count students who passed (IsGraduated = true)
            int passed = _dtGraduation.AsEnumerable()
     .Count(r => r["Percentage"] != DBNull.Value && Convert.ToDecimal(r["Percentage"]) >= 50m);

            // Count failed as the remainder
            int failed = _dtGraduation.Rows.Count - passed;

            // Update labels
            lblPassedCount.Text = $"Passed: {passed}";
            lblFailedCount.Text = $"Failed: {failed}";
            lblTotalCount.Text = $"Total Students: {_dtGraduation.Rows.Count}";


        }

        private void LoadGraduationResultsFromDB()
        {
            //_dtGraduation = clsGraduation.GetGraduatedStudents(_currentTermID);

            dgvGraduates.DataSource = _dtGraduation;
            FormatGridColumns();
            UpdateFinalStats();
        }

        private void UpdatePreviewStats()
        {
            if (_dtGraduation == null || _dtGraduation.Rows.Count == 0)
            {
                lblPassedCount.Text = "Predicted Passed: 0";
                lblFailedCount.Text = "Predicted Failed: 0";
                lblTotalCount.Text = "Total Students: 0";
                return;
            }

            int passed = _dtGraduation.AsEnumerable()
                .Count(r => r["IsPredictedPassed"] != DBNull.Value && Convert.ToBoolean(r["IsPredictedPassed"]));

            int total = _dtGraduation.Rows.Count;
            int failed = total - passed;

            lblPassedCount.Text = $"Predicted Passed: {passed}";
            lblFailedCount.Text = $"Predicted Failed: {failed}";
            lblTotalCount.Text = $"Total Students: {total}";
        }

        private void UpdateGraduationStatsFromGrid()
        {
            if (dgvGraduates.Rows.Count == 0)
            {
                lblPassedCount.Text = "Predicted Passed: 0";
                lblFailedCount.Text = "Predicted Failed: 0";
                lblTotalCount.Text = "Total Students: 0";
                return;
            }

            int passed = 0;
            int failed = 0;
            int total = 0;

            foreach (DataGridViewRow row in dgvGraduates.Rows)
            {
                if (row.IsNewRow) continue;

                total++;

                bool isPassed = false;
                if (row.Cells["IsPredictedPassed"].Value != null)
                    isPassed = Convert.ToBoolean(row.Cells["IsPredictedPassed"].Value);

                if (isPassed) passed++;
                else failed++;
            }

            lblPassedCount.Text = $"Predicted Passed: {passed}";
            lblFailedCount.Text = $"Predicted Failed: {failed}";
            lblTotalCount.Text = $"Total Students: {total}";
        }

        private void UpdateGraduationStats()
        {
            if (_dtGraduation == null || _dtGraduation.Rows.Count == 0)
            {
                lblPassedCount.Text = "Passed Students: 0";
                lblFailedCount.Text = "Failed Students: 0";
                return;
            }

            int passed = 0;
            int failed = 0;

            foreach (DataRow row in _dtGraduation.Rows)
            {
                bool isPassed = Convert.ToBoolean(row["IsGraduated"]);
                if (isPassed) passed++;
                else failed++;
            }

            lblPassedCount.Text = $"Passed Students: {passed}";
            lblFailedCount.Text = $"Failed Students: {failed}";
        }

        private void UpdateGraduateStats()
        {
            DataTable dtTotals = clsScoresDetails.GetTotalScoresByEnrollment(_currentTermID);


            if (dtTotals == null || dtTotals.Rows.Count == 0)
            {
                lblPassedCount.Text = "Passed Students: 0";
                lblFailedCount.Text = "Failed Students: 0";
                return;
            }

            int passCount = 0;
            int failCount = 0;

            foreach (DataRow row in dtTotals.Rows)
            {
                decimal totalPercentage = Convert.ToDecimal(row["Percentage"]); // ✅ use Percentage, not MaxTotalScore

                if (totalPercentage >= 50m) passCount++;
                else failCount++;
            }

            lblPassedCount.Text = $"Passed Students: {passCount}";
            lblFailedCount.Text = $"Failed Students: {failCount}";
        }


        //private void GraduateStudentsByEnrollment()
        //{
        //    int termID = _currentTermID; // use the already loaded current term
        //    var currentTerm = clsTerm.Find(termID);

        //    if (currentTerm == null)
        //    {
        //        MessageBox.Show("Current term not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (!clsTerm.IsFinalTerm(termID))
        //    {
        //        MessageBox.Show("You cannot graduate students because the current term is not marked as final.",
        //                        "Final Term Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    int createdBy = clsGlobal.CurrentUser.UserID;
        //    DataTable dtEnrollments = clsScoreDetailsPerTerm.GetTotalScoresByEnrollment(termID); // ✅ filter by term

        //    if (dtEnrollments == null || dtEnrollments.Rows.Count == 0)
        //        return;

        //    int graduatedCount = 0, failedCount = 0, skippedCount = 0;

        //    foreach (DataRow row in dtEnrollments.Rows)
        //    {
        //        if (row["EnrollmentID"] == DBNull.Value) continue;

        //        int enrollmentID = Convert.ToInt32(row["EnrollmentID"]);
        //        decimal totalPercentage = clsGraduation.SafeDecimal(row["Percentage"]);
        //        bool passed = totalPercentage >= 50m;

        //        // skip if already graduated
        //        if (clsGraduation.IsAlreadyGraduated(enrollmentID, termID))
        //        {
        //            skippedCount++;
        //            continue;
        //        }

        //        bool success = clsGraduation.GraduateAndPromoteStudent(
        //            enrollmentID, termID, totalPercentage, createdBy
        //        );

        //        if (success)
        //        {
        //            if (passed) graduatedCount++;
        //            else failedCount++;
        //        }
        //    }

        //    lblPassedCount.Text = $"Passed Students: {graduatedCount}";
        //    lblFailedCount.Text = $"Failed Students: {failedCount}";
        //    // lblSkipped.Text = $"Already Graduated (Skipped): {skippedCount}";

        //    MessageBox.Show($"Graduation complete.\n" +
        //                    $"Passed: {graduatedCount}\n" +
        //                    $"Failed: {failedCount}\n" +
        //                    $"Skipped (already graduated): {skippedCount}",
        //                    "Graduation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    PreviewGraduationResults(); // refresh grid after commit
        //}
        private void GraduateStudentsByEnrollment()
        {
            int termID = _currentTermID;
            var currentTerm = clsTerm.Find(termID);

            if (currentTerm == null)
            {
                MessageBox.Show("Current term not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int createdBy = clsGlobal.CurrentUser.UserID;
            DataTable dtEnrollments = clsScoreDetailsPerTerm.GetTotalScoresByEnrollment(termID);

            if (dtEnrollments == null || dtEnrollments.Rows.Count == 0)
                return;

            int graduatedCount = 0, failedCount = 0, promotedCount = 0;

            foreach (DataRow row in dtEnrollments.Rows)
            {
                if (row["EnrollmentID"] == DBNull.Value) continue;

                int enrollmentID = Convert.ToInt32(row["EnrollmentID"]);
                decimal totalPercentage = clsGraduation.SafeDecimal(row["Percentage"]);
                bool passed = totalPercentage >= 50m;

                if (_isFinalTerm)
                {
                    // Final term - graduate students
                    bool success = clsGraduation.GraduateAndPromoteStudent(
                        enrollmentID, termID, totalPercentage, createdBy
                    );

                    if (success)
                    {
                        if (passed) graduatedCount++;
                        else failedCount++;
                    }
                }
                else
                {
                    // Non-final term - update current enrollment to next term
                    bool success = UpdateEnrollmentToNextTerm(enrollmentID, termID, createdBy);
                    if (success)
                    {
                        promotedCount++;
                    }
                }
            }

            // Update UI based on operation type
            if (_isFinalTerm)
            {
                lblPassedCount.Text = $"Passed Students: {graduatedCount}";
                lblFailedCount.Text = $"Failed Students: {failedCount}";

                MessageBox.Show($"Graduation complete.\nPassed: {graduatedCount}\nFailed: {failedCount}",
                                "Graduation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblPassedCount.Text = $"Promoted Students: {promotedCount}";

                MessageBox.Show($"Promotion complete.\nStudents promoted to next term: {promotedCount}",
                                "Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PreviewGraduationResults();
        }

        private bool UpdateEnrollmentToNextTerm(int enrollmentID, int currentTermID, int createdBy)
        {
            try
            {
                // 1️⃣ Get current enrollment record
                var enrollment = clsEnrollment.Find(enrollmentID);
                if (enrollment == null) return false;

                // 2️⃣ Get next term ID (creates terms if they don't exist)
                int nextTermID = clsTerm.GetNextTermID(currentTermID, createdBy);
                if (nextTermID <= 0) return false;

                // 3️⃣ Get current term info
                var currentTerm = clsTerm.Find(currentTermID);
                if (currentTerm == null) return false;

                // 4️⃣ Deactivate current term
                clsTermData.SetActiveState(currentTermID, false);

                // 5️⃣ Activate next term
                clsTermData.SetActiveState(nextTermID, true);

                // 6️⃣ If not final term → move enrollment to next term
                if (!currentTerm.IsFinal)
                {
                    enrollment.Mode = clsEnrollment.enMode.Update;
                    enrollment.TermID = nextTermID;
                    enrollment.ModifiedAt = DateTime.Now;

                    return enrollment.Save();
                }
                else
                {
                    // 7️⃣ If final → handled by GraduateAndPromoteStudent
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating enrollment: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PreviewGraduationResults()
        {
            // ✅ get only current term
            DataTable dtEnrollments = clsScoreDetailsPerTerm.GetTotalScoresByEnrollment(_currentTermID);

            if (dtEnrollments == null || dtEnrollments.Rows.Count == 0)
            {
                MessageBox.Show("No enrollment scores found for the current term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add extra columns for preview if missing
            if (!dtEnrollments.Columns.Contains("LetterGrade"))
                dtEnrollments.Columns.Add("LetterGrade", typeof(string));

            if (!dtEnrollments.Columns.Contains("IsPassed"))
                dtEnrollments.Columns.Add("IsPassed", typeof(bool));

            int passedCount = 0, failedCount = 0;

            foreach (DataRow row in dtEnrollments.Rows)
            {
                decimal totalPercentage = clsGraduation.SafeDecimal(row["Percentage"]);
                string letter = clsGraduation.GetLetterGrade(totalPercentage);
                bool passed = totalPercentage >= 50m;

                row["LetterGrade"] = letter;
                row["IsPassed"] = passed;

                if (passed) passedCount++;
                else failedCount++;
            }

            dgvGraduates.DataSource = dtEnrollments;
            lblPassedCount.Text = $"Passed Students: {passedCount}";
            lblFailedCount.Text = $"Failed Students: {failedCount}";
        }



        private void btnGraduate_Click(object sender, EventArgs e)
        {
            if (_dtGraduation == null || _dtGraduation.Rows.Count == 0)
            {
                MessageBox.Show("No students to process.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Use the unified method that handles both final and non-final terms
            GraduateStudentsByEnrollment();
        }

        private void LoadGraduationGrid()
        {
            // Get the students with predicted graduation
            _dtGraduation = clsGraduation.GetStudentsWithPredictedGraduation(_currentTermID);

            if (_dtGraduation == null)
                return;

            // Add IsGraduated column if it doesn't exist
            if (!_dtGraduation.Columns.Contains("IsGraduated"))
            {
                _dtGraduation.Columns.Add("IsGraduated", typeof(bool));
            }

            // Populate IsGraduated based on Percentage
            foreach (DataRow row in _dtGraduation.Rows)
            {
                if (row["Percentage"] != DBNull.Value)
                {
                    decimal percentage = clsGraduation.SafeDecimal(row["Percentage"]);

                    row["IsGraduated"] = percentage >= 50m; // mark as passed
                }
                else
                {
                    row["IsGraduated"] = false; // treat missing score as failed
                }
            }

            // Bind to DataGridView
            dgvGraduates.DataSource = _dtGraduation;
            FormatGridColumns();

            // Update graduation stats
            UpdateGraduationStatsFromGrid();
        }

    }
}


        //MessageBox.Show($"Graduation complete.\nPassed: {graduatedCount}\nFailed/Repeated: {repeatedCount}", "Graduation");

//// Refresh labels
//lblPassedCount.Text = $"Passed Students: {graduatedCount}";
//lblFailedCount.Text = $"Failed Students: {repeatedCount}";
