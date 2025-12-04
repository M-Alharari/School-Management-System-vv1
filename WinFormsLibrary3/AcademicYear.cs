using System;
using System.Data;
using SchoolProjectData;

namespace SchoolProjectBusiness
{
    public class clsAcademicYear
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int AcademicYearID { get; private set; }
        public string YearName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; private set; }

        public clsAcademicYear()
        {
            AcademicYearID = -1;
            YearName = "";
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
            IsCurrent = false;
            Mode = enMode.AddNew;
        }

        private clsAcademicYear(int id, string yearName, DateTime startDate, DateTime endDate, bool isCurrent, int createdByUserID, DateTime createdAt)
        {
            AcademicYearID = id;
            YearName = yearName;
            StartDate = startDate;
            EndDate = endDate;
            IsCurrent = isCurrent;
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            AcademicYearID = clsAcademicYearData.AddNewAcademicYear(YearName, StartDate, EndDate, IsCurrent, CreatedByUserID);
            return AcademicYearID != -1;
        }

        private bool _Update()
        {
            return clsAcademicYearData.UpdateAcademicYear(AcademicYearID, YearName, StartDate, EndDate, IsCurrent, CreatedByUserID);
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _Update();
            }
        }

        public static clsAcademicYear Find(int id)
        {
            string yearName = "";
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;
            bool isCurrent = false;
            int createdByUserID = -1;
            DateTime createdAt = DateTime.MinValue;

            bool found = clsAcademicYearData.GetAcademicYearByID(id, ref yearName, ref startDate, ref endDate, ref isCurrent, ref createdByUserID, ref createdAt);

            if (found)
                return new clsAcademicYear(id, yearName, startDate, endDate, isCurrent, createdByUserID, createdAt);
            else
                return null;
        }
        public static int GetNextAcademicYearID(int currentYearID)
        {
            DataRow nextYear = clsAcademicYearData.GetNextAcademicYear(currentYearID);
            if (nextYear == null)
                return -1;

            return Convert.ToInt32(nextYear["AcademicYearID"]);
        }
        public static DataTable GetAll()
        {
            return clsAcademicYearData.GetAllAcademicYears();
        }

        public static bool Delete(int id)
        {
            return clsAcademicYearData.DeleteAcademicYear(id);
        }

        public static int GetCurrentAcademicYearID()
        {
            return clsAcademicYearData.GetCurrentAcademicYearID();
        }
        public static int GetCurrentAcademicYearID2()
        {
            DateTime today = DateTime.Today;

            DataTable dtYears = GetAll();

            if (dtYears == null || dtYears.Rows.Count == 0)
            {
                MessageBox.Show("⚠️ No academic years found. Please create one first.",
                                "Missing Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            // Find where today is between StartDate and EndDate
            foreach (DataRow row in dtYears.Rows)
            {
                DateTime start = Convert.ToDateTime(row["StartDate"]);
                DateTime end = Convert.ToDateTime(row["EndDate"]);

                if (today >= start && today <= end)
                    return Convert.ToInt32(row["AcademicYearID"]);
            }

            // No active year found → return the latest one
            var lastYear = dtYears.AsEnumerable()
                .OrderByDescending(r => Convert.ToDateTime(r["EndDate"]))
                .FirstOrDefault();

            if (lastYear != null)
                return Convert.ToInt32(lastYear["AcademicYearID"]);

            return -1;
        }
        public static bool Deactivate(int academicYearID)
        {
            return clsAcademicYearData.DeactivateAcademicYear(academicYearID);
        }

    }
}
