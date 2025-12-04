using SchoolProjectData;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolProjectBusiness
{
    public class clsTerm
    {
        public int TermID { get; set; }
        public string TermName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public int AcademicYearID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ModifiedByUserID { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsFinal { get; set; } // <-- added property
        
        public enum enMode { AddNew, Update }
        public enMode Mode { get; set; } = enMode.AddNew;

        // Get all terms
        public static DataTable GetAll()
        {
            return clsTermData.GetAllTerms();
        }
        public static DataTable GetAll(int AcademicYearr)
        {
            return clsTermData.GetAllTerms(AcademicYearr);
        }
        public static DataTable GetActiveTerm(int AcademicYearr)
        {
            return clsTermData.GetActiveTerm(AcademicYearr);
        }

        // Insert new term
        private bool Add()
        {
            int newID = clsTermData.InsertTerm(TermName, StartDate, EndDate, IsFinal, IsActive,  CreatedByUserID, AcademicYearID);

            if (newID > 0)
            {
                this.TermID = newID;
                this.CreatedAt = DateTime.Now; // set locally (DB already has it)
                this.Mode = enMode.Update;
                return true;
            }
            return false;
        }

        // Update existing term
        private bool Update()
        {
            if (TermID <= 0) throw new Exception("Invalid Term ID");

            bool isUpdated = clsTermData.UpdateTerm(
                TermID, TermName, StartDate, EndDate,IsFinal,IsActive,  ModifiedByUserID ?? 0, AcademicYearID
            );

            if (isUpdated)
                this.ModifiedAt = DateTime.Now;
            this.IsFinal = IsFinal;
            return isUpdated;
        }

        // Save (Add or Update depending on mode)
        public bool Save()
        {
            if (this.Mode == enMode.AddNew)
                return  Add();
            else
                return Update();
        }

        // Delete term
        public bool Delete()
        {
            if (TermID <= 0) throw new Exception("Invalid Term ID");
            return clsTermData.DeleteTerm(TermID);
        }

        // Find term
        public static clsTerm Find(int termID)
        {
            string name = "";
            DateTime start = DateTime.MinValue;
            DateTime end = DateTime.MinValue;
            int createdBy = 0, academicYearID = -1;
            DateTime? createdAt = null;
            int? modifiedBy = null;
            DateTime? modifiedAt = null;
            bool isFinal = false, isActive = false;

            bool found = clsTermData.Find(termID,
                ref name, ref start, ref end, ref isFinal, ref isActive,
                ref createdBy, ref createdAt,
                ref modifiedBy, ref modifiedAt,
                ref academicYearID);

            if (!found)
                return null;

            return new clsTerm
            {
                TermID = termID,
                TermName = name,
                StartDate = start,
                EndDate = end,
                IsFinal = isFinal,
                IsActive = isActive,
                CreatedByUserID = createdBy,
                CreatedAt = createdAt ?? DateTime.MinValue,
                ModifiedByUserID = modifiedBy,
                ModifiedAt = modifiedAt,
                AcademicYearID = academicYearID,
                Mode = enMode.Update
            };
        }

        // Return the final term if exists, else term containing today, else null
        //public static clsTerm GetCurrentTerm()
        //{
        //    DataTable dtTerms = clsTerm.GetAll();

        //    // 1️⃣ Try to find the final term first
        //    foreach (DataRow row in dtTerms.Rows)
        //    {
        //        if (Convert.ToBoolean(row["IsFinal"]))
        //            return clsTerm.Find(Convert.ToInt32(row["TermID"]));
        //    }

        //    // 2️⃣ Fallback: term containing today
        //    DateTime today = DateTime.Today;
        //    foreach (DataRow row in dtTerms.Rows)
        //    {
        //        DateTime start = Convert.ToDateTime(row["StartDate"]);
        //        DateTime end = Convert.ToDateTime(row["EndDate"]);
        //        if (today >= start && today <= end)
        //            return clsTerm.Find(Convert.ToInt32(row["TermID"]));
        //    }

        //    // 3️⃣ Nothing found
        //    return null;
        //}
        public static clsAcademicYear GetCurrentAcademicYear()
        {
            DateTime today = DateTime.Today;

            // Get all academic years
            DataTable dtYears = GetAll();

            if (dtYears == null || dtYears.Rows.Count == 0)
            {
                MessageBox.Show("⚠️ No academic years found. Please create one first.",
                                "Missing Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Find the year where today is between StartDate and EndDate
            foreach (DataRow row in dtYears.Rows)
            {
                DateTime start = Convert.ToDateTime(row["StartDate"]);
                DateTime end = Convert.ToDateTime(row["EndDate"]);

                if (today >= start && today <= end)
                {
                    return clsAcademicYear.Find(Convert.ToInt32(row["AcademicYearID"]));
                }
            }

            // If no active year found, return the most recent one (the latest ended)
            var lastYear = dtYears.AsEnumerable()
                .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
                .FirstOrDefault();

            if (lastYear != null)
            {
                return clsAcademicYear.Find(Convert.ToInt32(lastYear["AcademicYearID"]));
            }

            return null;
        }
        public static clsTerm GetCurrentTerm()
        {
            int academicYearID = clsAcademicYear.GetCurrentAcademicYearID();
            if (academicYearID == -1)
                return null;

            DataTable dtTerms = clsTerm.GetActiveTerm(academicYearID);
            if (dtTerms.Rows.Count == 0)
                return null;

            DateTime today = DateTime.Today;
            clsTerm fallback = null;
            TimeSpan gracePeriod = TimeSpan.FromDays(14); // 2 weeks grace after term end

            foreach (DataRow row in dtTerms.Rows)
            {
                bool isActive = Convert.ToBoolean(row["IsActive"]);
                DateTime start = Convert.ToDateTime(row["StartDate"]);
                DateTime end = Convert.ToDateTime(row["EndDate"]);
                int termID = Convert.ToInt32(row["TermID"]);

                // 1️⃣ Prefer manually active term
                if (isActive)
                    return clsTerm.Find(termID);

                // 2️⃣ Current or grace-period term
                if (today >= start && today <= end + gracePeriod)
                    fallback = clsTerm.Find(termID);
            }

            // 3️⃣ If none matched, return the latest ended term
            if (fallback == null)
            {
                DataRow latest = dtTerms.AsEnumerable()
                    .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
                    .FirstOrDefault();

                if (latest != null)
                    fallback = clsTerm.Find(Convert.ToInt32(latest["TermID"]));
            }

            return fallback;
        }

        public static bool PromoteAllStudentsToNextTerm()
        {
            try
            {
                var currentTerm = GetCurrentTerm();
                if (currentTerm == null)
                {
                    MessageBox.Show("No current term found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                }

                // Get or create the next term using your existing logic
                int nextTermID = GetNextTermID(currentTerm.TermID, 1);
                if (nextTermID == -1)
                {
                    MessageBox.Show("Could not determine next term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var nextTerm = Find(nextTermID);
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
                    return true; // No students to promote is not an error
                }

                int successCount = 0;
                int totalCount = enrollments.Rows.Count;

                foreach (DataRow row in enrollments.Rows)
                {
                    try
                    {
                        int studentID = Convert.ToInt32(row["StudentID"]);
                        int currentGradeID = Convert.ToInt32(row["GradeID"]);
                        int currentClassID = Convert.ToInt32(row["ClassID"]);

                        // Promote student to next term (keep same grade and class)
                        if (clsEnrollment.PromoteStudentToNextTerm(studentID, nextTerm.TermID, currentGradeID, currentClassID))
                        {
                            successCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        //clsErrorLogger.LogError($"Error promoting student: {ex.Message}");
                        continue; // Continue with next student
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
                //clsErrorLogger.LogError($"Error in PromoteAllStudentsToNextTerm: {ex.Message}");
                MessageBox.Show("Error promoting students to next term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ترجع الـ TermID الحالي أو -1 إذا لم يوجد
        public static int GetCurrentTermIDSafe()
        {
            try
            {
                var term = clsTerm.GetCurrentTerm(); // original method
                if (term == null)
                {
                    MessageBox.Show("There is no active term currently.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
                return term.TermID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the current term: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        // يمكن إضافة نسخة آمنة لأي دالة أخرى تحتاج TermID

        // In clsTerm
        public static int GetCurrentTermID()
        {
            clsTerm currentTerm = GetCurrentTerm(); // gets the active term object
            if (currentTerm == null)
                throw new Exception("No active term found.");

            return currentTerm.TermID; // now returns the ID as int
        }
        // Get next term object after a given TermID
        public static clsTerm GetNextTerm(int currentTermID)
        {
            DataTable dt = clsTermData.GetNextTermInfo(currentTermID);
            if (dt.Rows.Count == 0)
                return null; // or return current term if you prefer

            DataRow row = dt.Rows[0];
            return new clsTerm
            {
                TermID = Convert.ToInt32(row["TermID"]),
                TermName = row["TermName"].ToString(),
                StartDate = Convert.ToDateTime(row["StartDate"]),
                EndDate = Convert.ToDateTime(row["EndDate"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedByUserID = Convert.ToInt32(row["CreatedByUserID"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                IsFinal = Convert.ToBoolean(row["IsFinal"]),
                Mode = enMode.Update
            };
        }

        // Get next term ID

        // Call this AFTER adding a term
        //public static void SetFinalTermAutomatically()
        //{
        //    DataTable terms = clsTermData.GetAllTerms(); // get all terms from DB

        //    if (terms.Rows.Count == 2) // only mark final if there are exactly 2 terms
        //    {
        //        // 1️⃣ Mark all terms as not final
        //        foreach (DataRow row in terms.Rows)
        //        {
        //            int termID = Convert.ToInt32(row["TermID"]);
        //            clsTermData.UpdateTermIsFinal(termID, false);
        //        }

        //        // 2️⃣ Mark the second term as final
        //        int secondTermID = Convert.ToInt32(terms.Rows[1]["TermID"]);
        //        clsTermData.UpdateTermIsFinal(secondTermID, true);
        //    }
        //}

        // Get the term that is marked as final
        public static clsTerm GetFinalTerm()
        {
            DataTable dt = clsTermData.GetAllTerms();
            DataRow finalRow = dt.AsEnumerable().FirstOrDefault(r => Convert.ToBoolean(r["IsFinal"]));

            if (finalRow == null) return null;

            return new clsTerm
            {
                TermID = Convert.ToInt32(finalRow["TermID"]),
                TermName = finalRow["TermName"].ToString(),
                StartDate = Convert.ToDateTime(finalRow["StartDate"]),
                EndDate = Convert.ToDateTime(finalRow["EndDate"]),
                IsActive = Convert.ToBoolean(finalRow["IsActive"]),
                IsFinal = true
            };
        }
        public static clsTerm GetTermByDate(DateTime date)
        {
            DataTable dtTerms = GetAll();
            if (dtTerms == null || dtTerms.Rows.Count == 0)
                return null;

            var termRow = dtTerms.AsEnumerable()
                .FirstOrDefault(r => date >= Convert.ToDateTime(r["StartDate"]) &&
                                    date <= Convert.ToDateTime(r["EndDate"]));

            if (termRow != null)
                return Find(Convert.ToInt32(termRow["TermID"]));

            return null;
        }

        public static clsTerm GetLastEndedTerm()
        {
            DataTable dtTerms = GetAll();
            if (dtTerms == null || dtTerms.Rows.Count == 0)
                return null;

            var lastTermRow = dtTerms.AsEnumerable()
                .Where(r => Convert.ToDateTime(r["EndDate"]) < DateTime.Today)
                .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
                .FirstOrDefault();

            if (lastTermRow != null)
                return Find(Convert.ToInt32(lastTermRow["TermID"]));

            return null;
        }

        public static clsTerm GetCurrentTerm_()
        {
            return GetTermByDate(DateTime.Today);
        }
        //public static int CreateFirstTermOfNextYear()
        //{
        //    try
        //    {
        //        // Get the most recent term
        //        var lastTerm = GetAll().AsEnumerable()
        //            .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
        //            .FirstOrDefault(); // Use FirstOrDefault instead of CopyToDataTable

        //        if (lastTerm == null)
        //        {
        //            // No existing terms - create first term for current year
        //            return CreateFirstTermForCurrentYear();
        //        }

        //        DateTime lastTermEnd = Convert.ToDateTime(lastTerm["EndDate"]);
        //        int nextYear = lastTermEnd.Year;

        //        // If last term is Term 2, next year is actually current year + 1
        //        string lastTermName = lastTerm["TermName"].ToString();
        //        if (lastTermName.Contains("Term 2"))
        //        {
        //            nextYear++;
        //        }

        //        // Deactivate current active term before creating new one
        //        DeactivateAllTerms();

        //        // Calculate realistic dates (adjust based on your academic calendar)
        //        clsTerm newTerm = new clsTerm
        //        {
        //            TermName = $"Term 1 {nextYear}",
        //            StartDate = CalculateTerm1StartDate(nextYear),
        //            EndDate = CalculateTerm1EndDate(nextYear),
        //            IsActive = true,
        //            IsFinal = false
        //        };

        //        return newTerm.Save() ? newTerm.TermID : -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log error
        //        Console.WriteLine($"Error creating first term: {ex.Message}");
        //        return -1;
        //    }
        //}

        // Helper methods for date calculation
        private static DateTime CalculateTerm1StartDate(int year)
        {
            // Example: First Monday of February
            return new DateTime(year, 1, 15); // Adjust based on your academic calendar
        }

        private static DateTime CalculateTerm1EndDate(int year)
        {
            // Example: End of first semester
            return new DateTime(year, 4, 15); // Adjust based on your academic calendar
        }
        public static int GetActiveTermIDForAcademicYear(int academicYearID)
        {
            return clsTermData.GetActiveTermIDForAcademicYear(academicYearID);
        }

        private static void DeactivateAllTerms()
        {
            // Deactivate all currently active terms
            var activeTerms = GetAll().AsEnumerable()
                .Where(r => Convert.ToBoolean(r["IsActive"]));

            foreach (var termRow in activeTerms)
            {
                clsTerm term = new clsTerm();
                // Load term data from termRow
                term.IsActive = false;
                term.Save();
            }
        }

        private static int CreateFirstTermForCurrentYear()
        {
            int currentYear = DateTime.Now.Year;

            clsTerm newTerm = new clsTerm
            {
                TermName = $"Term 1 {currentYear}",
                StartDate = new DateTime(currentYear, 1, 15),
                EndDate = new DateTime(currentYear, 4, 15),
                IsActive = true,
                IsFinal = false
            };

            return newTerm.Save() ? newTerm.TermID : -1;
        }
        public static int CreateFirstTermOfNextYear()
        {
            // 1️⃣ Get all terms
            var allTerms = GetAll()?.AsEnumerable();
            if (allTerms == null || !allTerms.Any()) return -1;

            // 2️⃣ Find the most recent term (latest EndDate)
            var lastTerm = allTerms
                .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
                .First();

            DateTime lastEnd = Convert.ToDateTime(lastTerm["EndDate"]);

            // 3️⃣ Determine next year's first term period
            int nextYear = lastEnd.Year + 1;

            // Example logic: 2 weeks break + 3 months term
            DateTime nextStart = lastEnd.AddDays(14);
            DateTime nextEnd = nextStart.AddMonths(3);

            // 4️⃣ Create the new term object
            clsTerm newTerm = new clsTerm
            {
                TermName = $"Term 1 {nextYear}",
                StartDate = nextStart,
                EndDate = nextEnd,
                IsActive = true,
                IsFinal = false,
            };

            // 5️⃣ Save and return TermID
            if (newTerm.Save())
                return newTerm.TermID;

            return -1;
        }
        public static int GetNextTermID(int currentTermID, int createdBy)
        {
            DataTable dtTerms = clsTerm.GetAll();
            if (dtTerms.Rows.Count == 0)
                return -1;

            // 🔹 Find current term
            var currentRow = dtTerms.AsEnumerable()
                .FirstOrDefault(r => Convert.ToInt32(r["TermID"]) == currentTermID);
            if (currentRow == null)
                return -1;

            // 🔹 Try to find next existing term
            var nextRow = dtTerms.AsEnumerable()
                .Where(r => Convert.ToInt32(r["TermID"]) > currentTermID)
                .OrderBy(r => Convert.ToInt32(r["TermID"]))
                .FirstOrDefault();

            if (nextRow != null)
                return Convert.ToInt32(nextRow["TermID"]);

            // 🔹 No next term found → Create new academic year + its terms
            string currentTermName = currentRow["TermName"]?.ToString() ?? "Unknown";
            DateTime startDate = currentRow["StartDate"] == DBNull.Value
                ? DateTime.Today
                : Convert.ToDateTime(currentRow["StartDate"]);

            int nextAcademicYearStart = startDate.Year + 1;
            int nextAcademicYearEnd = nextAcademicYearStart + 1;

            // 🔹 1️⃣ Create new Academic Year first
            int newAcademicYearID = clsAcademicYearData.AddNewAcademicYear(
                $"AY {nextAcademicYearStart}-{nextAcademicYearEnd}",
                new DateTime(nextAcademicYearStart, 9, 1),
                new DateTime(nextAcademicYearEnd, 8, 31),
                true,
                createdBy
            );

            if (newAcademicYearID <= 0)
                return -1; // failed

            // 🔹 2️⃣ Create three terms for this new academic year
            int term1ID = clsTermData.InsertTerm(
                "Term 1",
                new DateTime(nextAcademicYearStart, 9, 1),
                new DateTime(nextAcademicYearStart, 12, 31),
                false,  // Not final
                true,   // Active
                createdBy,
                newAcademicYearID
            );

            clsTermData.InsertTerm(
                "Term 2",
                new DateTime(nextAcademicYearEnd, 1, 1),
                new DateTime(nextAcademicYearEnd, 3, 31),
                false,
                true,
                createdBy,
                newAcademicYearID
            );

            clsTermData.InsertTerm(
                "Term 3",
                new DateTime(nextAcademicYearEnd, 4, 1),
                new DateTime(nextAcademicYearEnd, 6, 30),
                true,   // Final term
                true,   // Active
                createdBy,
                newAcademicYearID
            );

            // 🔹 Return first term ID to continue promotion
            return term1ID;
        }

        public static clsTerm GetFirstTermOfNextYear()
        {
            DataTable dtTerms = clsTerm.GetAll();
            if (dtTerms.Rows.Count == 0)
                return null;

            DateTime today = DateTime.Today;
            int currentYear = today.Year;

            // Find the first term whose StartDate is in the NEXT year
            var nextYearTermRow = dtTerms.AsEnumerable()
                .Where(r => Convert.ToDateTime(r["StartDate"]).Year == currentYear + 1)
                .OrderBy(r => Convert.ToDateTime(r["StartDate"]))
                .FirstOrDefault();

            if (nextYearTermRow != null)
            {
                int nextTermID = Convert.ToInt32(nextYearTermRow["TermID"]);
                return clsTerm.Find(nextTermID);
            }

            return null; // no term found for next year
        }

        // Example method: check if given term is final
        public static bool IsFinalTerm(int termID)
        {
            // call Data Layer
            return clsTermData.IsFinalTerm(termID);
        }


    }
}
