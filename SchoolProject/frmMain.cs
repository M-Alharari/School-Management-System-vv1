using SchoolProject.AcademicYear;
using SchoolProject.Assessment_and_Exams;
using SchoolProject.Assessment_and_Exams;
using SchoolProject.Assigning_Forms;
using SchoolProject.Assigning_Forms.Assign_Subjects_to_Grades;
using SchoolProject.Attendance;
using SchoolProject.Audit_Log;
using SchoolProject.Behaviours;
using SchoolProject.Classes;
using SchoolProject.Comparison;
using SchoolProject.Comparisons;
using SchoolProject.Comparisons.Trends;
using SchoolProject.Employees;
using SchoolProject.Enrollment_Management;
using SchoolProject.Fees_and_Payments;
using SchoolProject.Global;
using SchoolProject.Graduation;
using SchoolProject.Guardians;
using SchoolProject.People;
using SchoolProject.Positions;
using SchoolProject.Receipts;
using SchoolProject.Salary_Deduction;
using SchoolProject.School_Info;
using SchoolProject.Students;
using SchoolProject.Subjects;
using SchoolProject.Teachers;
using SchoolProject.Terms;
using SchoolProject.Users;
using SchoolProjectBusiness;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class frmMain : Form
    {

      
        private System.Windows.Forms.Timer _dueCheckTimer;
        private bool _notificationShown = false;

        private System.Windows.Forms.Timer _termCheckTimer;
        private Icon _appIcon; // keep reference so it’s not disposed

        frmLogin _frmLogin;
        //private Timer notificationTimer;
        private bool notificationShown = false;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent(); _frmLogin = frmLogin; 
            _frmLogin = frmLogin;

            // --- Load runtime PNG as form icon ---
            try
            {
                string pngPath = @"C:\Users\Dell\Downloads\Half-Completed-Core-main\SchoolProject\3986707-building-education-school-school-icon_112987.png";
                Bitmap bmp = new Bitmap(pngPath); // do NOT put in using
                IntPtr hIcon = bmp.GetHicon();
                _appIcon = Icon.FromHandle(hIcon); // store in field
                this.Icon = _appIcon;
                // Do NOT call DestroyIcon here; dispose in FormClosing
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load app icon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // --- Timers setup ---
            _dueCheckTimer = new System.Windows.Forms.Timer();
            _dueCheckTimer.Interval = 5 * 60 * 1000; // 5 minutes
            _dueCheckTimer.Tick += CheckForDueInstallments;

            //_termCheckTimer = new System.Windows.Forms.Timer();
            //_termCheckTimer.Interval = 50000; // 50 seconds (example)
            //_termCheckTimer.Tick += (s, e) => CheckTermStatus();
        }

        // Import to clean up icon handle
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);
        public static bool PromoteAllStudentsToNextTerm()
        {
            try
            {
                var currentTerm = clsTerm.GetCurrentTerm_();
                if (currentTerm == null)
                {
                    MessageBox.Show("No current term found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Get or create the next term
                int nextTermID = clsTerm.GetNextTermID(currentTerm.TermID, clsGlobal.CurrentUser?.UserID ?? 1);
                if (nextTermID == -1)
                {
                    MessageBox.Show("Could not determine next term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var nextTerm = clsTerm.Find(nextTermID);
                if (nextTerm == null)
                {
                    MessageBox.Show("Next term not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Get all active enrollments for current term
                DataTable enrollments = clsEnrollment.GetActiveEnrollments(currentTerm.TermID);
                if (enrollments == null || enrollments.Rows.Count == 0)
                {
                    MessageBox.Show("No active enrollments found for current term.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                int successCount = 0;
                int totalCount = enrollments.Rows.Count;

                foreach (DataRow row in enrollments.Rows)
                {
                    try
                    {
                        int studentID = Convert.ToInt32(row["StudentID"]);
                        int gradeID = Convert.ToInt32(row["GradeID"]);
                        int classID = Convert.ToInt32(row["ClassID"]);

                        // Promote student to next term (keep same grade and class)
                        if (clsEnrollment.PromoteStudentToNextTerm(studentID, nextTerm.TermID, gradeID, classID))
                        {
                            successCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error but continue with other students
                        continue;
                    }
                }

                // Mark current term as completed
                currentTerm.IsActive = false;
                currentTerm.Save();

                MessageBox.Show($"Successfully promoted {successCount} out of {totalCount} students to {nextTerm.TermName}.",
                    "Promotion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return successCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error promoting students to next term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void CheckTermStatus()
        {
            try
            {
                // Get the term that today falls within
                var currentTerm = clsTerm.GetTermByDate(DateTime.Today);

                if (currentTerm == null)
                {
                    // No active term for today - check if we need to promote to next term
                    CheckForTermPromotion();
                    return;
                }

                DateTime endDate = Convert.ToDateTime(currentTerm.EndDate);

                // ✅ If today is after the term's end date
                if (DateTime.Today > endDate)
                {
                    // Ask the user if they want to promote all students
                    var result = MessageBox.Show(
                        $"The current term ({currentTerm.TermName}) has ended on {endDate:d}.\n" +
                        "Do you want to promote all students to the next term?",
                        "Term Ended",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (clsTerm.PromoteAllStudentsToNextTerm())
                        {
                            MessageBox.Show("✅ All students have been successfully promoted to the next term!",
                                            "Promotion Complete",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Could not promote students. Please check term settings or data.",
                                            "Promotion Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking term status: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CheckForTermPromotion()
        {
            try
            {
                // Get the most recent term that ended
                var lastTerm = clsTerm.GetLastEndedTerm();

                if (lastTerm != null)
                {
                    DateTime endDate = Convert.ToDateTime(lastTerm.EndDate);

                    // If last term ended recently (within the last 30 days)
                    if ((DateTime.Today - endDate).TotalDays <= 30)
                    {
                        var result = MessageBox.Show(
                            $"The term ({lastTerm.TermName}) ended on {endDate:d} and no new term is active.\n" +
                            "Do you want to promote all students to the next term?",
                            "Term Promotion Needed",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (clsTerm.PromoteAllStudentsToNextTerm())
                            {
                                MessageBox.Show("✅ All students have been successfully promoted to the next term!",
                                                "Promotion Complete",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but don't show message to user for this secondary check
            }
        }
        private void peopleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPeopleManage frmPeopleManage = new frmPeopleManage();
            frmPeopleManage.ShowDialog();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployeelist frmEmp = new frmEmployeelist();
            frmEmp.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int currentuser = clsGlobal.CurrentUser.UserID;
            frmUserInfo frmUserInfo = new frmUserInfo(currentuser);
            frmUserInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int currentuser = clsGlobal.CurrentUser.UserID;
            frmChangePassword frmChangePassword = new frmChangePassword(currentuser);
            frmChangePassword.ShowDialog();
        }

        private void changeSchoolInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchoolInfo frm = new frmSchoolInfo();
            frm.ShowDialog();
        }

        private void auditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditLog frmAuditLog = new frmAuditLog();
            frmAuditLog.ShowDialog();
        }

        private void teachersLsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherList frm = new frmTeacherList();
            frm.ShowDialog();
        }

        private void studentsListToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmStudentList frmStudentList = new frmStudentList();
            frmStudentList.ShowDialog();
        }

        private void guardianListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardianList guardianList = new GuardianList();
            guardianList.ShowDialog();
        }

        private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeelist frmEmployeelist = new frmEmployeelist();
            frmEmployeelist.ShowDialog();
        }

        private void positionsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPositionManage frmPositionManage = new frmPositionManage();
            frmPositionManage.ShowDialog();
        }

        private void peopleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleManage frmPeopleManage = new frmPeopleManage();
            frmPeopleManage.ShowDialog();
        }

        private void gradesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradeslist frmGradeslist = new frmGradeslist();
            frmGradeslist.ShowDialog();
        }

        private void assignSubjectsToClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignSubjectsToGrades frm = new frmAssignSubjectsToGrades();
            frm.ShowDialog();
        }

        private void classesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClasseslist frmClasseslist = new frmClasseslist();
            frmClasseslist.ShowDialog();
        }

        private void subjectsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectList_cs frmSubjectList = new frmSubjectList_cs();
            frmSubjectList.ShowDialog();
        }

        private void oNewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendaceManagement frmAttendaceManagement = new frmAttendaceManagement();
            frmAttendaceManagement.ShowDialog();
        }

        private void ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalaryDeductionSummary frmSalaryDeductionSummary = new frmSalaryDeductionSummary();
            frmSalaryDeductionSummary.ShowDialog();
        }

        private void ManageDetainedLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPaymentManage frmPaymentManage = new frmPaymentManage();
            frmPaymentManage.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeesPayroll frmEmployeesPayroll = new frmEmployeesPayroll();
            frmEmployeesPayroll.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfinancialdashboard frmfinancialdashboard = new frmfinancialdashboard();
            frmfinancialdashboard.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTermslist frmTermslist = new frmTermslist();
            frmTermslist.ShowDialog();
        }

        private void studentResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeClassStudentsExam gradeClassStudentsExam = new GradeClassStudentsExam();
            gradeClassStudentsExam.ShowDialog();
        }

        private void graduateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraduateStudents frmGraduateStudents = new frmGraduateStudents();
            frmGraduateStudents.ShowDialog();
        }

        private void feeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompareGradesScores frmCompare = new frmCompareGradesScores();
            frmCompare.ShowDialog();
        }

        private void compareClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompareStudentsInAClass frmCompareStudents = new frmCompareStudentsInAClass();
            frmCompareStudents.ShowDialog();
        }

        private void behavioursListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentBehaviorslist frmStudentBehaviorslist = new frmStudentBehaviorslist();
            frmStudentBehaviorslist.ShowDialog();
        }

        private void enrollmnetsDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollmnetsDashboard enrollmnetsDashboard = new EnrollmnetsDashboard();
            enrollmnetsDashboard.ShowDialog();
        }

        private void monthlyEmployeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyAttendanceView month = new MonthlyAttendanceView("Employees");
            month.ShowDialog();
        }

        private void monthlyStudentsAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyAttendanceView month = new MonthlyAttendanceView("Students");
            month.ShowDialog();
        }

        private void timeTableGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeTableGenerator timeTableGenerator = new TimeTableGenerator();
            timeTableGenerator.ShowDialog();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waittt form1 = new waittt();
            form1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void frmStudentPerformanceTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmStudentPerformanceTrends frmStudentPerformanceTrends = new frmStudentPerformanceTrends();
            //frmStudentPerformanceTrends.ShowDialog();
        }

        private void assignClassesToTeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssignClassesToTeachers assignClassesToTeachers = new AssignClassesToTeachers();
            assignClassesToTeachers.ShowDialog();
        }

        private void assignSubjectsToTeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssignTeachersToSubjecs assignTeachersToSubjecs = new AssignTeachersToSubjecs();
            assignTeachersToSubjecs.ShowDialog();
        }
        private void _dueCheckTimer_Tick(object sender, EventArgs e)
        {
            CheckDueInstallments();
        }

        private void CheckDueInstallments()
        {
            // Your logic here (e.g. show reminder, refresh grid, etc.)
            Console.WriteLine("Checking due installments at " + DateTime.Now);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // ✅ Start both timers
            _dueCheckTimer.Start();
            //_termCheckTimer.Start();

            // ✅ Run both checks immediately on startup
            CheckForDueInstallments(null, EventArgs.Empty);
            //CheckTermStatus();
        }

        private void CheckForDueInstallments(object sender, EventArgs e)
        {
            try
            {
                // Alternative: Check if there are any active students
                DataTable dtStudents = clsStudent.GetAllStudents();
                if (dtStudents == null || dtStudents.Rows.Count == 0)
                {
                    // No students exist, so no need to check for fees
                    return;
                }

                // Get all tuition fee IDs
                DataTable dtTuitionFees = clsTuitionPayment.GetAllTuition();

                if (dtTuitionFees == null || dtTuitionFees.Rows.Count == 0)
                    return;

                List<int> dueList = new List<int>();

                // Check which TuitionFeeIDs have due installments
                foreach (DataRow row in dtTuitionFees.Rows)
                {
                    int tuitionFeeID = Convert.ToInt32(row["TuitionID"]);
                    DataTable dtInstallments = clsInstallment.GetInstallmentSummaryByTuitionFeeID(tuitionFeeID);

                    bool hasDue = dtInstallments.AsEnumerable()
                        .Any(r => !Convert.ToBoolean(r["IsPaid"]) &&
                                  Convert.ToDateTime(r["DueDate"]) <= DateTime.Today);

                    if (hasDue)
                        dueList.Add(tuitionFeeID);
                }

                // If there are due installments, show the notification form
                if (dueList.Count > 0 && !_notificationShown)
                {
                    _notificationShown = true;
                    var notificationForm = new SchoolProject.Fees_and_Payments.FeesTimeUp(dueList);
                    notificationForm.ShowDialog();
                    _notificationShown = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking due installments:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _dueCheckTimer?.Stop();
            _dueCheckTimer?.Dispose();

            _appIcon?.Dispose(); // safely dispose icon here
            base.OnFormClosing(e);
        }

        private void frmAcademicYearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademicYearList frmAcademicYearList = new frmAcademicYearList();
            frmAcademicYearList.ShowDialog();
        }
    }
    //public class frmNotification : Form
    //{
    //    private FlowLayoutPanel panel;
    //    private List<int> _tuitionFeeIDs;
    //    private Button btnClose;

    //    public frmNotification(List<int> tuitionFeeIDs)
    //    {
    //        _tuitionFeeIDs = tuitionFeeIDs;

    //        Text = "Installments Due Notification";
    //        Size = new Size(700, 450);
    //        StartPosition = FormStartPosition.CenterScreen;
    //        FormBorderStyle = FormBorderStyle.FixedToolWindow;
    //        BackColor = Color.White;
    //        KeyPreview = true; // Enable keyboard shortcuts

    //        panel = new FlowLayoutPanel
    //        {
    //            Dock = DockStyle.Top,
    //            AutoScroll = true,
    //            Padding = new Padding(10),
    //            WrapContents = false,
    //            FlowDirection = FlowDirection.TopDown,
    //            Height = 350
    //        };

    //        btnClose = new Button
    //        {
    //            Text = "Close",
    //            AutoSize = true,
    //            Anchor = AnchorStyles.Right,
    //            DialogResult = DialogResult.OK
    //        };
    //        btnClose.Click += (s, e) => this.Close();
    //        btnClose.TabIndex = 0;

    //        Controls.Add(panel);
    //        Controls.Add(btnClose);

    //        // Place close button correctly after panel
    //        btnClose.Top = panel.Bottom + 10;
    //        btnClose.Left = this.ClientSize.Width - btnClose.Width - 20;
    //    }

    //    // Load data after form is fully shown
    //    protected override void OnShown(EventArgs e)
    //    {
    //        base.OnShown(e);
    //        LoadDueInstallments();
    //    }

    //    private void LoadDueInstallments()
    //    {
    //        panel.Controls.Clear();

    //        foreach (int tuitionFeeID in _tuitionFeeIDs)
    //        {
    //            DataTable dt = clsInstallment.GetInstallmentSummaryByTuitionFeeID(tuitionFeeID);

    //            // Use LINQ to filter due and unpaid rows
    //            var dueRows = dt.AsEnumerable()
    //                            .Where(r => !Convert.ToBoolean(r["IsPaid"]) &&
    //                                        Convert.ToDateTime(r["DueDate"]) <= DateTime.Today)
    //                            .ToList();

    //            foreach (var row in dueRows)
    //            {
    //                int installmentID = Convert.ToInt32(row["InstallmentID"]);
    //                int installmentNumber = Convert.ToInt32(row["InstallmentNumber"]);
    //                DateTime dueDate = Convert.ToDateTime(row["DueDate"]);
    //                decimal amount = Convert.ToDecimal(row["Amount"]);
    //                string fullName = row["FullName"].ToString();

    //                FlowLayoutPanel container = new FlowLayoutPanel
    //                {
    //                    AutoSize = true,
    //                    FlowDirection = FlowDirection.LeftToRight,
    //                    Margin = new Padding(5)
    //                };

    //                Button btnPay = new Button
    //                {
    //                    Text = "Pay",
    //                    Tag = installmentID,
    //                    AutoSize = true
    //                };
    //                btnPay.Click += BtnPay_Click;

    //                Label lbl = new Label
    //                {
    //                    Text = $"Student: {fullName} | TuitionFeeID: {tuitionFeeID} | " +
    //                           $"Installment #{installmentNumber} | Due: {dueDate:dd/MM/yyyy} | Amount: {amount:0.00}",
    //                    AutoSize = true,
    //                    Padding = new Padding(5, 8, 5, 5)
    //                };

    //                container.Controls.Add(btnPay);
    //                container.Controls.Add(lbl);

    //                panel.Controls.Add(container);
    //            }
    //        }

    //        // Debug if panel is empty
    //        if (panel.Controls.Count == 0)
    //            MessageBox.Show("No due installments found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }

    //    private void BtnPay_Click(object sender, EventArgs e)
    //    {
    //        if (sender is Button btn)
    //        {
    //            int installmentID = (int)btn.Tag;
    //            var payForm = new frmPayInstallment(installmentID);
    //            var result = payForm.ShowDialog();

    //            if (result == DialogResult.OK)
    //            {
    //                MessageBox.Show("Payment completed successfully.");
    //                LoadDueInstallments(); // Refresh the list after payment
    //            }
    //        }
    //    }

    //    // Allow Esc to close
    //    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    //    {
    //        if (keyData == Keys.Escape)
    //        {
    //            Close();
    //            return true;
    //        }
    //        return base.ProcessCmdKey(ref msg, keyData);
    //    }
    //}


}
