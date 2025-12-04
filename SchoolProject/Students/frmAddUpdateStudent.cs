
using SchoolProject.Global;
using SchoolProject.Guardians;
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


namespace SchoolProject
{
    public partial class frmAddUpdateStudent : Form
    {
        // Add this property at the top
        public string FeeTypeContext { get; set; } = "Tuition"; // default if needed

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enrollMode { AddNew = 0, Update = 1 };
        private enrollMode enroll_Mode;
        private int _StudentID = -1;
        clsStudent _Student;
        clsEnrollment _Enrollment;
        private int GuardianID;
        private int _GuardianID = -1;
        private int _EnrollmentID = -1;
        clsGuardian _Guardian;
        clsPerson _Person;
        private DataTable _dtTerms;
        public frmAddUpdateStudent()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            enroll_Mode = enrollMode.AddNew;
        } 
        public frmAddUpdateStudent(int StudentID)
        {
            InitializeComponent();
            _StudentID = StudentID;
            _Mode = enMode.Update;
            enroll_Mode = enrollMode.Update;
        }
        private void CtrPersonCardWithFilter1_PersonSelected(object sender, int personID)
        {
            MessageBox.Show("This person is an employee and cannot be added as a student.",
                     "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ctrPersonCardWithFilter1.FilterFocus();
            btnNext.Enabled = false; // disable the Next button
        }
        // Normal selection logic
     private void CtrPersonCardWithFilter1_OnPersonSelected(int personID)
{
    if (clsEmployee.IsPersonEmployee(personID))
    {
        MessageBox.Show("This person is an employee and cannot be added as a student.", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ctrPersonCardWithFilter1.FilterFocus();
        btnNext.Enabled = false;
        return;
    }

    // Save the selected personID in the control
   
    btnNext.Enabled = true;
}

        private DataTable _dtGrades;
        private DataTable _dtClasses;

        private void _LoadGrades()
        {
            cbGrades.Items.Clear();
            _dtGrades = clsGrade.GetAllGrades();

            if (_dtGrades.Rows.Count == 0)
            {
                cbGrades.Items.Add("No items");
                cbGrades.SelectedIndex = 0;
                cbGrades.Enabled = false;
                cbClasses.Items.Add("No items");
                cbClasses.SelectedIndex = 0;
                cbClasses.Enabled = false;
                return;
            }

            foreach (DataRow row in _dtGrades.Rows)
            {
                cbGrades.Items.Add(row["GradeName"].ToString());
            }

            cbGrades.SelectedIndex = 0; // This will trigger SelectedIndexChanged and load classes for Grade 0
            cbGrades.Enabled = true;
            cbClasses.Enabled = true;
        }

        private void _LoadClassesByGradeID(int gradeID)
        {
            cbClasses.Items.Clear();
            _dtClasses = clsClass.GetClassesByGradeID(gradeID); // You must implement this in your class data layer

            if (_dtClasses.Rows.Count == 0)
            {
                cbClasses.Items.Add("No items");
                cbClasses.SelectedIndex = 0;
                cbClasses.Enabled = false;
                return;
            }

            foreach (DataRow row in _dtClasses.Rows)
            {
                cbClasses.Items.Add(row["ClassName"].ToString());
            }

            cbClasses.SelectedIndex = 0;
            cbClasses.Enabled = true;
        }
        private void _FillGradesInComoboBox()
        {
            DataTable dtGrades = clsGrade.GetAllGrades();
            foreach (DataRow row in dtGrades.Rows)
            {
                cbGrades.Items.Add(row["GradeName"]);
            }
            cbGrades.SelectedIndex = 0;
        }

        private void _FillClassesInComoboBox()
        {
            DataTable dtClasses = clsClass.GetAllClasses();

            foreach (DataRow row in dtClasses.Rows)
            {
                cbClasses.Items.Add(row["ClassName"]);
            }
            cbClasses.SelectedIndex = 0;
        }
        private void _ResetDefaultValues()
        {
            _LoadGrades();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Student";
                this.Text = "Add New Student";
                _Student = new clsStudent();
                _Enrollment = new clsEnrollment();

                tpRegisteredInfo.Enabled = false;
                ctrPersonCardWithFilter1.FilterFocus();

                checkBox1.Checked = false;
                checkBox2.Checked = false;

                // 🔹 For new students, just load current active terms
                _LoadTerms(0);
            }
            else
            {
                lblTitle.Text = "Update Student";
                this.Text = "Update Student";
                tpRegisteredInfo.Enabled = true;
                btnSave.Enabled = true;

                checkBox1.Checked = false;
                checkBox2.Checked = false;

                // 🔹 For existing students, load their enrollment term
                if (_Enrollment != null)
                {
                    _LoadTerms(_Enrollment.TermID);
                }
                else
                {
                    _LoadTerms(0);
                }
            }

            lblEnrollmentDate.Text = "[???]";
            lblRegisteredBy.Text = "[???]";
            lblStudentID.Text = "[???]";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void _LoadData()
        {
            _Student = clsStudent.FindStudentByID(_StudentID);
            ctrPersonCardWithFilter1.FilterEnabled = false;

            if (_Student == null)
            {
                MessageBox.Show("No student with ID:" + _StudentID, "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblStudentID.Text = _Student.StudentID.ToString();
             
            _Enrollment = clsEnrollment.FindByStudentID(_Student.StudentID);
            if (_Enrollment != null)
            {
                

                lblEnrollmentDate.Text = _Enrollment.EnrollmentDate.ToString();
                chkIsActive.Checked = _Enrollment.IsActive;
                var user = clsUser.FindByUserID(_Enrollment.CreatedByUserID);

                if (user == null)
                {
                    //MessageBox.Show("Registered by unknown user");
                }
                else
                {
                    lblRegisteredBy.Text = user.UserName;
                }

                // Load grade
                var grade = clsGrade.FindGradeByID(_Enrollment.GradeID);
                if (grade != null)
                {
                    _LoadGrades();
                    cbGrades.SelectedItem = grade.GradeName;

                    _LoadClassesByGradeID(grade.GradeID);

                    var cls = clsClass.FindClassByID(_Enrollment.ClassID);
                    if (cls != null)
                        cbClasses.SelectedItem = cls.ClassName;
                }

                // Load term
                var term = clsTerm.Find(_Enrollment.TermID);
                if (_Enrollment != null)
                {
                    _LoadTerms(_Enrollment.TermID);
                }
                else
                {
                    _LoadTerms(0); // fallback if no enrollment yet
                }

            }
            
            // ✅ Check if guardian exists for this student
            var dtGuardians = clsGuardianStudents.GetGuardiansForStudent(_Student.StudentID);
            checkBox1.Checked = (dtGuardians.Rows.Count > 0);


            // ✅ Check if student has at least one payment
            var dtPayments = clsTuitionPayment.GetPaymentsByEnrollmentID(_EnrollmentID);
            checkBox2.Checked = (dtPayments.Rows.Count > 0);

            llPaymentForm.Enabled = (_Student != null && _Student.StudentID != -1);

            ctrPersonCardWithFilter1.LoadPersonInfo(_Student.PersonID);
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            // Assign the check delegate for employees
            ctrPersonCardWithFilter1.PersonCannotBeSelectedCheck = (personID) => clsEmployee.IsPersonEmployee(personID);

            // Subscribe to the event that fires when selection is invalid
            ctrPersonCardWithFilter1.PersonSelectedIsEmp += CtrPersonCardWithFilter1_PersonSelected;

            // Subscribe to the normal person selected event to enable/disable btnNext
            ctrPersonCardWithFilter1.OnPersonSelected += CtrPersonCardWithFilter1_OnPersonSelected;

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpRegisteredInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpRegisteredInfo"];
                return;
            }




            if (ctrPersonCardWithFilter1.PersonID != -1)
            {

                if (clsStudent.DoStudentExists(ctrPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person is already a Registered Student, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpRegisteredInfo.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tpRegisteredInfo"];
                }

            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrPersonCardWithFilter1.FilterFocus();
            }


        }
        private void _LoadTerms(int enrollmentTermID)
        {
            cbTerms.Items.Clear();

            // 🔹 Load only terms for the current academic year
            int academicYearID = clsAcademicYear.GetCurrentAcademicYearID();
            DataTable dtTerms = clsTerm.GetAll(academicYearID);

            if (dtTerms == null || dtTerms.Rows.Count == 0)
            {
                cbTerms.Items.Add("No terms available");
                cbTerms.SelectedIndex = 0;
                cbTerms.Enabled = false;
                return;
            }

            // 🔹 If in Update mode (enrollmentTermID > 0), show that specific term
            if (enrollmentTermID > 0)
            {
                DataRow[] selectedTerm = dtTerms.Select($"TermID = {enrollmentTermID}");
                if (selectedTerm.Length > 0)
                {
                    string termName = selectedTerm[0]["TermName"].ToString();
                    cbTerms.Items.Add(termName);
                    cbTerms.SelectedIndex = 0;
                    cbTerms.Enabled = false; // cannot change term during update
                    return;
                }
            }

            // 🔹 Otherwise, show all terms for the current academic year
            foreach (DataRow row in dtTerms.Rows)
            {
                string termName = row["TermName"].ToString();
                cbTerms.Items.Add(termName);
            }

            cbTerms.SelectedIndex = 0;
            cbTerms.Enabled = true;
        }

        private void llGuardianForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Student == null || _Student.StudentID == -1)
            {
                MessageBox.Show("Save the student first before assigning a guardian.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dtGuardians = clsGuardianStudents.GetGuardiansForStudent(_Student.StudentID);

            // Ask the user what they want to do — always show this
            string msg;

            if (dtGuardians.Rows.Count > 0)
                msg = "This student already has a guardian.\nWhat would you like to do?";
            else
                msg = "This student has no guardian yet.\nWhat would you like to do?";

            var result = MessageBox.Show(
                msg + "\n\nYes = Edit Current\nNo = Select Existing Guardian\nCancel = Add New Guardian",
                "Guardian Options",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Edit existing guardian (if any)
                if (dtGuardians.Rows.Count == 0)
                {
                    MessageBox.Show("No guardian found to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _GuardianID = Convert.ToInt32(dtGuardians.Rows[0]["GuardianID"]);
                _Guardian = clsGuardian.FindGuardianByID(_GuardianID);
                _Person = clsPerson.Find(_Guardian.PersonID);

                frmAddUpdateGuardian frmEdit = new frmAddUpdateGuardian(_Guardian.GuardianID);
                frmEdit.DataBack += Frm_DataBack;
                checkBox1.Checked = true;
                frmEdit.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                // Select an existing guardian from list
                ShowGuardianListForm();
            }
            else if (result == DialogResult.Cancel)
            {
                // Add a completely new guardian
                frmAddUpdateGuardian frmNew = new frmAddUpdateGuardian();
                frmNew.DataBack += Frm_DataBack;
                frmNew.ShowDialog();

                // After creating a new guardian, you can link it automatically
                if (_Guardian != null)
                {
                    clsGuardianStudents.LinkGuardianToStudent(_Guardian.GuardianID, _Student.StudentID, clsGlobal.CurrentUser.UserID);
                    checkBox1.Checked = true;
                }
            }
        }
        // Extracted method to show guardian selection
        private void ShowGuardianListForm()
        {
            GuardianList frmList = new GuardianList();

            frmList.GuardianSelected += (s, guardianID) =>
            {
                _GuardianID = guardianID;
                _Guardian = clsGuardian.FindGuardianByID(guardianID);
                _Person = clsPerson.Find(_Guardian.PersonID);

                // Link guardian to student
                clsGuardianStudents.LinkGuardianToStudent(_GuardianID, _Student.StudentID, clsGlobal.CurrentUser.UserID);

                checkBox1.Checked = true;
            };

            frmList.ShowDialog();

        }
        // Extracted method to show guardian selection
        //private void ShowGuardianListForm()
        //{
        //    GuardianList frmList = new GuardianList();

        //    frmList.GuardianSelected += (s, guardianID) =>
        //    {
        //        _GuardianID = guardianID;
        //        _Guardian = clsGuardian.FindGuardianByID(guardianID);
        //        _Person = clsPerson.Find(_Guardian.PersonID);

        //        // Link guardian to student
        //        clsGuardianStudents.LinkGuardianToStudent(_GuardianID, _Student.StudentID, clsGlobal.CurrentUser.UserID);

        //        checkBox1.Checked = true;
        //    };

        //    frmList.ShowDialog();
        //}
        private void Frm_DataBack(object sender, int GuardianID)
        {
            _GuardianID = GuardianID;

            if (_Student != null && _Student.StudentID != -1)
            {
                // ✅ Link the guardian to the student in the database
                bool linked = clsGuardianStudents.LinkGuardianToStudent(
                    _GuardianID,
                    _Student.StudentID,
                    clsGlobal.CurrentUser.UserID
                );

                if (linked)
                {
                    _Student.GuardianID = _GuardianID;
                    checkBox1.Checked = true;
                }
                else
                {
                    MessageBox.Show("Failed to link guardian to student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Student must be saved first before linking a guardian.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        { 
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int currentUserID = clsGlobal.CurrentUser.UserID;
            string currentUserName = clsGlobal.CurrentUser.UserName;
            DateTime now = DateTime.Now;

            // --- Handle Student Data (Only for new students) ---
            if (_Mode == enMode.AddNew)
            {
                if (ctrPersonCardWithFilter1.PersonID <= 0)
                {
                    MessageBox.Show("Please select a person first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonCardWithFilter1.FilterFocus();
                    return;
                }

                // Initialize _Student if null
                if (_Student == null)
                    _Student = new clsStudent();

                _Student.PersonID = ctrPersonCardWithFilter1.PersonID;
                _Student.ModifiedBy = currentUserID;
                _Student.CreatedBy = currentUserID;

                // Save Student
                if (!_Student.Save())
                {
                    MessageBox.Show("Error: Student data could not be saved.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblStudentID.Text = _Student.StudentID.ToString();
                _Mode = enMode.Update;
            }

            // --- Handle Enrollment Data (Both Add and Update) ---
            if (_Enrollment == null)
                _Enrollment = new clsEnrollment();

            // Only set StudentID for new enrollments
            if (_Enrollment.StudentID == -1)
                _Enrollment.StudentID = _Student.StudentID;

            _Enrollment.GradeID = clsGrade.FindGradeByName(cbGrades.Text)?.GradeID ?? -1;
            _Enrollment.ClassID = clsClass.FindClassByName(cbClasses.Text)?.ClassID ?? -1;
            _Enrollment.IsActive = chkIsActive.Checked;
         //if (_Enrollment.AcademicYearI)
            _Enrollment.AcademicYearID = clsAcademicYear.GetCurrentAcademicYearID();

            var currentTerm = clsTerm.GetCurrentTerm();
            if (currentTerm == null)
            {
                MessageBox.Show("No active term found. Please add a term or adjust dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Enrollment.TermID = currentTerm.TermID;
            _Enrollment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            // Only set these for new enrollments
            if (_Enrollment.EnrollmentID == -1)
            {
                _Enrollment.EnrollmentDate = DateTime.Now;
                _Enrollment.CreatedByUserID = currentUserID;
                _Enrollment.CreatedAt = now;
            }

            _Enrollment.ModifiedByUser = currentUserName;
            _Enrollment.ModifiedAt = now;

            if (!_Enrollment.Save())
            {
                MessageBox.Show("Error: Enrollment data could not be saved.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Update UI ---
            lblEnrollmentDate.Text = _Enrollment.EnrollmentDate.ToString();
            lblRegisteredBy.Text = clsUser.FindByUserID(_Enrollment.CreatedByUserID)?.UserName ?? "Unknown";
            llPaymentForm.Enabled = true;
            btnSave.Enabled = false;
            MessageBox.Show("Enrollment saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
       

        }
        private void llPaymentForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTuitionPayment frm = new frmTuitionPayment(_Enrollment.EnrollmentID);




            frm.ShowDialog();
        }
        private void Frm_PaymentSaved(object sender, EventArgs e)
        {
            // Automatically check the checkbox when payment is saved
            checkBox2.Checked = true;
        }
        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtGrades == null || _dtGrades.Rows.Count == 0 || cbGrades.SelectedIndex == -1)
                return;

            int selectedGradeID = Convert.ToInt32(_dtGrades.Rows[cbGrades.SelectedIndex]["GradeID"]);
            _LoadClassesByGradeID(selectedGradeID);
        }
    }
    }
