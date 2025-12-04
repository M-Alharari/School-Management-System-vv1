using SchoolProjectData;
using System;
using System.Collections.Generic;
using System.Data;

namespace SchoolProjectBusiness
{
    public class clsGradeSubject
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int GradeID { get; set; }
        public int SubjectID { get; set; }

        public clsGradeSubject()
        {
            GradeID = -1;
            SubjectID = -1;
            Mode = enMode.AddNew;
        }

        private clsGradeSubject(int gradeID, int subjectID)
        {
            GradeID = gradeID;
            SubjectID = subjectID;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            return clsGradeSubjectData.AddGradeSubject(GradeID, SubjectID);
        }

        private bool _Delete()
        {
            return clsGradeSubjectData.DeleteGradeSubject(GradeID, SubjectID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNew();

                case enMode.Update:
                    return false; // No direct update
                default:
                    return false;
            }
        }

        public static DataTable GetSubjectsByGradeID(int gradeID)
        {
            return clsGradeSubjectData.GetSubjectsByGradeID(gradeID);
        }

        public static bool DeleteAllByGradeID(int gradeID)
        {
            return clsGradeSubjectData.DeleteAllSubjectsByGradeID(gradeID);
        }

        // ✅ Optimized method: only adds/removes changes
        public static bool AssignSubjectsToGrade(int gradeID, List<int> subjectIDs, out string errorMessage)
        {
            return clsGradeSubjectData.UpdateGradeSubjects(gradeID, subjectIDs, out errorMessage);
        }
    }
}
