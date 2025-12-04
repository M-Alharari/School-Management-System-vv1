using System;
using System.Data;
using SchoolProjectData;

namespace SchoolProjectBusiness
{
    public class clsGuardianStudents
    {
        public int GuardianStudentID { get; set; }
        public int GuardianID { get; set; }
        public int StudentID { get; set; }
        public string Relationship { get; set; } // <-- now string
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; private set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; private set; }
        public clsPerson PersonInfo;
        public clsGuardianStudents() { }

        public bool Save(int userName)
        {
            if (GuardianStudentID == 0) // Add
            {
                GuardianStudentID = clsGuardianStudentsData.AddGuardianStudent(GuardianID, StudentID, Relationship, userName);
                if (GuardianStudentID > 0)
                {
                    string newValue = $"GuardianID={GuardianID}, EnrollmentID={StudentID}, Relationship={Relationship}";
                    clsAuditLog.AddLog("GuardianStudents", GuardianStudentID, "INSERT", null, newValue, userName);
                    return true;
                }
                return false;
            }
            else // Update
            {
                // old values
                int oldGuardianID = -1, oldStudentID = -1;
                string oldRelationship = "";
                clsGuardianStudentsData.GetGuardianStudentInfo(GuardianStudentID, ref oldGuardianID, ref oldStudentID, ref oldRelationship);
                string oldValue = $"GuardianID={oldGuardianID}, EnrollmentID={oldStudentID}, Relationship={oldRelationship}";
                string newValue = $"GuardianID={GuardianID}, EnrollmentID={StudentID}, Relationship={Relationship}";

                bool updated = clsGuardianStudentsData.UpdateGuardianStudent(GuardianStudentID, GuardianID, StudentID, Relationship, userName);
                if (updated)
                {
                    clsAuditLog.AddLog("GuardianStudents", GuardianStudentID, "UPDATE", oldValue, newValue, userName);
                }
                return updated;
            }
        }
        /// <summary>
        /// Get summary for a specific guardian
        /// Returns DataTable with columns: GuardianID, GuardianName, StudentCount
        /// </summary>
        public static DataTable GetSummaryByGuardian(int guardianID)
        {
            return clsGuardianStudentsData.GetGuardianSummary(guardianID);
        }
        public static bool Delete(int guardianStudentID, int userName)
        {
            // old values before delete
            int oldGuardianID = -1, oldStudentID = -1;
            string oldRelationship = "";
            clsGuardianStudentsData.GetGuardianStudentInfo(guardianStudentID, ref oldGuardianID, ref oldStudentID, ref oldRelationship);
            string oldValue = $"GuardianID={oldGuardianID}, EnrollmentID={oldStudentID}, Relationship={oldRelationship}";

            bool deleted = clsGuardianStudentsData.DeleteGuardianStudent(guardianStudentID);
            if (deleted)
            {
                clsAuditLog.AddLog("GuardianStudents", guardianStudentID, "DELETE", oldValue, null, userName);
            }
            return deleted;
        }
        public static DataTable GetAllGuardiansSummary()
        {
            return clsGuardianStudentsData.GetAllGuardiansSummary();
        }
        public static bool LinkGuardianToStudent(int guardianID, int studentID, int createdByUserID)
        {
            return clsGuardianStudentsData.LinkGuardianToStudent(guardianID, studentID, createdByUserID);
        }

        public static DataTable GetAllLinks()
        {
            return clsGuardianStudentsData.GetAllGuardianStudentLinks();
        }


        public static DataTable GetStudentsForGuardian(int guardianID)
        {
            return clsGuardianStudentsData.GetGuardianStudentsByGuardian(guardianID);
        }
        // Get all guardians for a student
        public static DataTable GetGuardiansForStudent(int studentID)
        {
            return clsGuardianStudentsData.GetGuardiansByStudentID(studentID);
        }
        public static DataTable GetGuardianStudents(int guardianId)
        {
            return clsGuardianStudentsData.GetStudentsByGuardian(guardianId);
        }




        // Get GuardianStudent by StudentID
        public static clsGuardianStudents GetGuardianByStudentID(int studentID)
        {
            var row = clsGuardianStudentsData.GetGuardianStudentByStudentID(studentID);
            if (row == null) return null;

            clsGuardianStudents gs = new clsGuardianStudents
            {
                GuardianStudentID = Convert.ToInt32(row["GuardianStudentID"]),
                GuardianID = Convert.ToInt32(row["GuardianID"]),
                StudentID = Convert.ToInt32(row["StudentID"]),
                Relationship = row["Relationship"]?.ToString(),
                CreatedBy = Convert.ToInt32(row["CreatedBy"]),
                CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                ModifiedBy = row["ModifiedBy"] != DBNull.Value ? Convert.ToInt32(row["ModifiedBy"]) : 0,
                ModifiedDate = row["ModifiedDate"] != DBNull.Value ? Convert.ToDateTime(row["ModifiedDate"]) : DateTime.MinValue
            };
            clsGuardian guardian = clsGuardian.FindGuardianByID(gs.GuardianID);
            // Populate PersonInfo safely
         
            gs.PersonInfo = clsPerson.Find(guardian.PersonID); // <-- fetch the Person for the guardian
                                                                       // or use: gs.PersonInfo = clsPerson.FindByID(gs.GuardianID) if GuardianID = PersonID

            return gs;
        }







    }
}
