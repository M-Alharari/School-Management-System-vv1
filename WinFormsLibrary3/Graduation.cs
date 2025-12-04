using SchoolProject.Business;
using SchoolProjectData;
using System;
using System.Data;

namespace SchoolProjectBusiness
{
    public static class clsGraduation
    {
        public static decimal SafeDecimal(object value, decimal defaultValue = 0m)
        {
            return (value == null || value == DBNull.Value) ? defaultValue : Convert.ToDecimal(value);
        }

        public static DataTable GetStudentsWithPredictedGraduation(int termID)
        {
            DataTable dt = clsScoreDetailsPerTerm.GetTotalScoresByEnrollment(termID);

            if (dt == null) return null;

            if (!dt.Columns.Contains("PredictedLetterGrade"))
                dt.Columns.Add("PredictedLetterGrade", typeof(string));

            if (!dt.Columns.Contains("IsPredictedPassed"))
                dt.Columns.Add("IsPredictedPassed", typeof(bool));

            foreach (DataRow row in dt.Rows)
            {
                // ✅ Safe conversion: treat NULL as 0
                decimal percentage = row["Percentage"] == DBNull.Value
                    ? 0m
                    : Convert.ToDecimal(row["Percentage"]);

                row["PredictedLetterGrade"] = GetLetterGrade(percentage);
                row["IsPredictedPassed"] = percentage >= 50m;
            }

            return dt;
        }

        public static DataTable GetStudentsForGraduation(int termID)
        {
            return GraduationData.GetStudentTotalsForGraduation(termID);
        }
        //public static DataTable GetStudentsWithPredictedGraduation(int termID)
        //{
        //    DataTable dt = clsScoresDetails.GetTotalScoresByEnrollment();

        //    if (dt == null) return new DataTable();

        //    // Add columns for predicted graduation
        //    if (!dt.Columns.Contains("IsPredictedPassed"))
        //        dt.Columns.Add("IsPredictedPassed", typeof(bool));

        //    if (!dt.Columns.Contains("PredictedLetterGrade"))
        //        dt.Columns.Add("PredictedLetterGrade", typeof(string));

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        decimal percentage = Convert.ToDecimal(row["Percentage"]);
        //        bool passed = percentage >= 50m;

        //        row["IsPredictedPassed"] = passed;
        //        row["PredictedLetterGrade"] = GetLetterGrade(percentage);
        //    }

        //    return dt;
        //}
        public static bool IsAlreadyGraduated(int enrollmentID, int termID)
        {
            // ✅ Just call the Data Layer
            return GraduationData.IsAlreadyGraduated(enrollmentID, termID);
        }
        // eve
        // get the prev academic year and add the new one to the new enerollment here
        public static bool GraduateAndPromoteStudent(int enrollmentID, int termID, decimal finalAverage, int createdBy)
        {
            bool passed = finalAverage >= 50m;
            string letterGrade = GetLetterGrade(finalAverage);

            // 1️⃣ Save or update graduation record
            if (GraduationData.GraduationRecordExists(enrollmentID, termID))
            {
                if (!GraduationData.UpdateGraduationRecord(enrollmentID, termID, finalAverage, letterGrade, passed))
                    return false;
            }
            else
            {
                if (!GraduationData.AddGraduationRecord(enrollmentID, termID, finalAverage, letterGrade, passed, createdBy))
                    return false;
            }

            // 2️⃣ Get current enrollment
            DataRow currentEnrollmentRow = clsEnrollmentData.GetEnrollmentByID(enrollmentID);
            if (currentEnrollmentRow == null)
                return false;

            int studentID = Convert.ToInt32(currentEnrollmentRow["StudentID"]);
            int gradeID = Convert.ToInt32(currentEnrollmentRow["GradeID"]);
            int classID = Convert.ToInt32(currentEnrollmentRow["ClassID"]);
            int academicYearID = Convert.ToInt32(currentEnrollmentRow["AcademicYearID"]);

            // 3️⃣ Update or create enrollment history
            clsEnrollmentHistory currentHistory = clsEnrollmentHistory.Get(enrollmentID, termID);
            if (currentHistory != null)
            {
                if (currentHistory.IsGraduated != passed)
                {
                    currentHistory.IsGraduated = passed;
                    
                    currentHistory.Update();
                }
            }
            else
            {
                clsEnrollmentHistory newHistory = new clsEnrollmentHistory
                {
                    EnrollmentID = enrollmentID,
                    TermID = termID,
                    IsGraduated = passed
                };
                newHistory.Add();
            }

            // 4️⃣ Deactivate current enrollment
            if (!clsEnrollmentData.DeactivateEnrollment(enrollmentID))
                return false;

            // 5️⃣ Get next term (creates next academic year if needed)
            int nextTermID = clsTerm.GetNextTermID(termID,createdBy);
            if (nextTermID <= 0)
                return false;

            // 6️⃣ Get academic year of next term
            clsTerm nextTerm = clsTerm.Find(nextTermID);
            if (nextTerm == null)
                return false;

            // Example usage:
            int nextAcademicYearID = nextTerm.AcademicYearID;
            string termName = nextTerm.TermName;
            DateTime start = nextTerm.StartDate;

            // ✅ (optional fallback) if same year and next year should exist
            if (nextAcademicYearID == academicYearID)
            {
                int safeNextYearID = clsAcademicYear.GetNextAcademicYearID(academicYearID);
                if (safeNextYearID > 0)
                    nextAcademicYearID = safeNextYearID;
            }

            // 6️⃣.5 Deactivate the previous academic year
            clsAcademicYear.Deactivate(academicYearID);

            // 7️⃣ Determine next grade and class
            int nextGradeID = passed ? gradeID + 1 : gradeID;
            int nextClassID = passed
                ? GetFirstClassIDByGrade(nextGradeID)
                : classID;

            // 8️⃣ Prevent duplicate enrollment
            if (clsEnrollmentData.DoesEnrollmentExist(studentID, nextTermID))
                return true;

            // 9️⃣ Create new enrollment
            clsEnrollment newEnrollment = new clsEnrollment
            {
                StudentID = studentID,
                GradeID = nextGradeID,
                ClassID = nextClassID,
                TermID = nextTermID,
                AcademicYearID = nextAcademicYearID,
                EnrollmentDate = DateTime.Now,
                IsActive = true,
                CreatedByUserID = createdBy
            };

            if (!newEnrollment.Save())
                return false;

            // 🔟 Add history for the new enrollment
            clsEnrollmentHistory nextHistory = new clsEnrollmentHistory
            {
                EnrollmentID = newEnrollment.EnrollmentID,
                TermID = nextTermID,
                IsGraduated = false
            };
            nextHistory.Add();

            return true;
        }

        public static int GetFirstClassIDByGrade(int gradeID)
        {
            DataTable dtClasses = clsClassData.GetClassesByGradeID(gradeID);

            if (dtClasses.Rows.Count > 0)
            {
                return Convert.ToInt32(dtClasses.Rows[0]["ClassID"]);
            }

            return 0; // no class found
        }

        public static string GetLetterGrade(decimal score)
        {
            if (score >= 90m) return "A+";
            if (score >= 85m) return "A";
            if (score >= 80m) return "A-";
            if (score >= 75m) return "B+";
            if (score >= 70m) return "B";
            if (score >= 65m) return "B-";
            if (score >= 60m) return "C+";
            if (score >= 55m) return "C";
            if (score >= 50m) return "C-";
            return "F";
        }

        public static bool IsFinalTerm(int termID)
        {
            var term = clsTerm.Find(termID);
            return term != null && term.IsFinal;
        }
    }
}
