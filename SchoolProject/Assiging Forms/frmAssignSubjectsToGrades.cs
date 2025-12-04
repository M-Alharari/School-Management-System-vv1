using SchoolProject.People.Controls;
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

namespace SchoolProject.Assigning_Forms.Assign_Subjects_to_Grades
{
    public partial class frmAssignSubjectsToGrades : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        private DataTable _dtGrades;
        private int _GradeID;
        private DataTable _dtSubjects; // كل الموضوعات
        private DataTable _dtAssignedSubjects; // الموضوعات المعينة للدرجة المختارة
        public frmAssignSubjectsToGrades()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAssignSubjectsToGrades(int GradeID)
        {
            InitializeComponent();
            _GradeID = GradeID;
            Mode = enMode.Update;
        }
        private void _LoadGrades()
        {
            cbGrades.Items.Clear();
            _dtGrades = clsGrade.GetAllGrades();

            if (_dtGrades.Rows.Count == 0)
            {
                cbGrades.Items.Add("No items");
                cbGrades.SelectedIndex = 0;
                cbGrades.Enabled = false;

                return;
            }



            cbGrades.SelectedIndex = 0; // This will trigger SelectedIndexChanged and load classes for Grade 0
            cbGrades.Enabled = true;

        }




        private void frmAssignSubjectsToGrades_Load(object sender, EventArgs e)
        {
            LoadGrades();
            LoadAllSubjects();
            dgvSubjects.CellValueChanged += dgvSubjects_CellValueChanged;

            if (Mode == enMode.Update && _GradeID != 0)
            {
                SelectGradeByID(_GradeID);
                this.Text = "Update Assigned Subjects";
                btnSave.Text = "Update";
            }
            else
            {
                this.Text = "Assign Subjects to Grade";
                btnSave.Text = "Assign";
                if (_dtGrades.Rows.Count > 0)
                    cbGrades.SelectedIndex = 0;
            }
        }
        private void UpdateCheckAllState()
        {
            if (dgvSubjects.DataSource == null)
            {
                checkAll.Checked = false;
                return;
            }

            DataTable dt = (DataTable)dgvSubjects.DataSource;

            if (dt.Rows.Count == 0)
            {
                checkAll.Checked = false;
                return;
            }

            bool allChecked = dt.AsEnumerable().All(row => row.Field<bool>("Assigned"));
            bool noneChecked = dt.AsEnumerable().All(row => !row.Field<bool>("Assigned"));

            // This prevents triggering checkAll_CheckedChanged when updating it programmatically
            checkAll.CheckedChanged -= checkAll_CheckedChanged;
            checkAll.Checked = allChecked;
            checkAll.CheckedChanged += checkAll_CheckedChanged;
        }

        private void LoadGrades()
        {
            _dtGrades = clsGrade.GetAllGrades();
            cbGrades.Items.Clear();

            if (_dtGrades.Rows.Count == 0)
            {
                cbGrades.Items.Add("No grades available");
                cbGrades.Enabled = false;
                return;
            }

            foreach (DataRow row in _dtGrades.Rows)
            {
                cbGrades.Items.Add(row["GradeName"].ToString());
            }

            cbGrades.Enabled = true;
        }

        private void LoadAllSubjects()
        {
            _dtSubjects = clsSubject.GetAllSubjects();
            // _dtSubjects = data table of all subjects with columns like SubjectID, SubjectName
        }
        private void SelectGradeByID(int gradeID)
        {
            for (int i = 0; i < _dtGrades.Rows.Count; i++)
            {
                if ((int)_dtGrades.Rows[i]["GradeID"] == gradeID)
                {
                    cbGrades.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSubjects.EndEdit(); // ✅ Save pending checkbox edits before reloading

            if (cbGrades.SelectedIndex == -1 || _dtGrades == null || _dtGrades.Rows.Count == 0)
                return;

            _GradeID = (int)_dtGrades.Rows[cbGrades.SelectedIndex]["GradeID"];
            LoadAssignedSubjects(_GradeID);
        }
        private void LoadAssignedSubjects(int gradeID)
        {
            _dtAssignedSubjects = clsGradeSubject.GetSubjectsByGradeID(gradeID);

            this.BeginInvoke(new Action(() =>
            {
                BindSubjectsGrid();
                UpdateCheckAllState(); // ✅ Reflect correct checkbox state after reload
            }));


        }

        private void BindSubjectsGrid()
        {
            DataTable dtGrid = new DataTable();
            dtGrid.Columns.Add("SubjectID", typeof(int));
            dtGrid.Columns.Add("SubjectName", typeof(string));
            dtGrid.Columns.Add("Assigned", typeof(bool));

            foreach (DataRow subjectRow in _dtSubjects.Rows)
            {
                int subjectID = (int)subjectRow["SubjectID"];
                string subjectName = subjectRow["SubjectName"].ToString();

                bool assigned = false;
                if (_dtAssignedSubjects != null)
                {
                    foreach (DataRow assignedRow in _dtAssignedSubjects.Rows)
                    {
                        if ((int)assignedRow["SubjectID"] == subjectID)
                        {
                            assigned = true;
                            break;
                        }
                    }
                }

                dtGrid.Rows.Add(subjectID, subjectName, assigned);
            }

            dgvSubjects.DataSource = dtGrid;

            // تأكد أن عمود Assigned هو CheckBox
            if (dgvSubjects.Columns["Assigned"] != null)
            {
                dgvSubjects.Columns["Assigned"].ReadOnly = false;
                dgvSubjects.Columns["Assigned"].HeaderText = "Assigned";
                dgvSubjects.Columns["Assigned"].Width = 80;
            }

            // أخفي عمود SubjectID لو تريد
            dgvSubjects.Columns["SubjectID"].Visible = false;

            dgvSubjects.Columns["SubjectName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSubjects.AllowUserToAddRows = false; // منع إضافة صفوف جديدة
            UpdateCheckAllState();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_GradeID == 0)
            {
                MessageBox.Show("Please select a grade first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure all changes are committed before reading from DataGridView
            dgvSubjects.EndEdit();

            if (dgvSubjects.DataSource == null)
            {
                MessageBox.Show("No subjects loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtGrid = (DataTable)dgvSubjects.DataSource;
            List<int> selectedSubjectIDs = new List<int>();

            foreach (DataRow row in dtGrid.Rows)
            {
                if (row.Field<bool>("Assigned"))
                    selectedSubjectIDs.Add(row.Field<int>("SubjectID"));
            }

            // Confirm action if user deselected all subjects
            if (selectedSubjectIDs.Count == 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "No subjects selected. This will remove all subjects from the grade.\n\nContinue?",
                    "Confirm Remove All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;
            }

            // Perform assignment
            string errorMessage;
            bool success = clsGradeSubject.AssignSubjectsToGrade(_GradeID, selectedSubjectIDs, out errorMessage);

            if (success)
            {
                MessageBox.Show("✅ Subjects updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid to show updated data
                LoadAssignedSubjects(_GradeID);
            }
            else
            {
                MessageBox.Show("❌ Failed to update subjects:\n" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvSubjects.DataSource == null) return;

            dgvSubjects.EndEdit(); // تأكد من إغلاق التحرير الحالي

            DataTable dt = (DataTable)dgvSubjects.DataSource;

            bool chkAll = checkAll.Checked;

            foreach (DataRow row in dt.Rows)
            {
                row["Assigned"] = chkAll;
            }

            dt.AcceptChanges();

            dgvSubjects.Refresh();
        }

        private void dgvSubjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvSubjects.Columns[e.ColumnIndex].Name == "Assigned")
            {
                UpdateCheckAllState();
            }
        }
    }
}