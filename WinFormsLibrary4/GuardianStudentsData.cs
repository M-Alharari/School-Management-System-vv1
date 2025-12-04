using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolProjectData
{
    public static class clsGuardianStudentsData
    {
        public static DataTable GetAllGuardianStudentLinks()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                gs.GuardianID,
                gs.StudentID,
                gs.Relationship
            FROM GuardianStudents gs;
        ";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetAllGuardiansSummary()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //                string query = @"
                //          SELECT 
                //    gs.GuardianID, 
                //    p.FirstName + ' ' + ISNULL(p.SecondName,'') + ' ' + ISNULL(p.ThirdName,'') + ' ' + ISNULL(p.LastName,'') AS GuardianName,

                //    STRING_AGG(gs.Relationship, ', ') AS Relationships,   -- ✅ from link table
                //    COUNT(gs.StudentID) AS StudentCount 
                //FROM GuardianStudents gs
                //INNER JOIN Guardians g ON gs.GuardianID = g.GuardianID
                //INNER JOIN People p ON g.PersonID = p.PersonID
                //GROUP BY gs.GuardianID, p.FirstName, p.SecondName, p.ThirdName, p.LastName
                //ORDER BY GuardianName;


                //";
                string query = @"
                SELECT
    gs.GuardianID, 
    p.FirstName + ' ' +
        ISNULL(p.SecondName, '') + ' ' +
        ISNULL(p.ThirdName, '') + ' ' +
        ISNULL(p.LastName, '') AS GuardianName,
    g.Relationship,
    COUNT(gs.StudentID) AS StudentCount
FROM GuardianStudents gs
INNER JOIN Guardians g ON gs.GuardianID = g.GuardianID
INNER JOIN People p ON g.PersonID = p.PersonID
GROUP BY
    gs.GuardianID, 
    p.FirstName, p.SecondName, p.ThirdName, p.LastName, 
    g.Relationship
ORDER BY GuardianName, g.Relationship;


                ";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetAllGuardiansSummary", ex);
                }
            }

            return dt;
        }




        // Returns GuardianStudentID by StudentID

        // Get GuardianStudent row by StudentID
        public static DataRow GetGuardianStudentByStudentID(int studentID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string sql = @"
                    SELECT TOP 1 *
                    FROM GuardianStudents
                    WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        public static DataTable GetStudentsByGuardian(int guardianId)
        {
            string query = @"
       SELECT 
    g.GuardianID,
    gp.FirstName + ' ' + 
        ISNULL(gp.SecondName, '') + ' ' + 
        ISNULL(gp.ThirdName, '') + ' ' + 
        ISNULL(gp.LastName, '') AS GuardianName,
    g.Relationship,
    s.StudentID,
    sp.FirstName + ' ' + 
        ISNULL(sp.SecondName, '') + ' ' + 
        ISNULL(sp.ThirdName, '') + ' ' + 
        ISNULL(sp.LastName, '') AS StudentName
FROM Guardians g
INNER JOIN People gp ON g.PersonID = gp.PersonID       -- Guardian details
INNER JOIN GuardianStudents gs ON g.GuardianID = gs.GuardianID
INNER JOIN Students s ON gs.StudentID = s.StudentID
INNER JOIN People sp ON s.PersonID = sp.PersonID       -- Student details
WHERE g.GuardianID = @GuardianID                       -- 👈 Filter by GuardianID
ORDER BY StudentName;

";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@GuardianID", guardianId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static bool LinkGuardianToStudent(int guardianID, int studentID, int createdByUserID)
        {
            string checkQuery = @"
        SELECT COUNT(*) 
        FROM GuardianStudents 
        WHERE GuardianID = @GuardianID AND StudentID = @StudentID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@GuardianID", guardianID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                conn.Open();
                int exists = (int)cmd.ExecuteScalar();

                if (exists > 0)
                {
                    // Already exists → don’t insert
                    return false;
                }
            }

            // Insert new link
            string insertQuery = @"
        INSERT INTO GuardianStudents (GuardianID, StudentID, CreatedBy)
        VALUES (@GuardianID, @StudentID, @CreatedBy)";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@GuardianID", guardianID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@CreatedBy", createdByUserID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }



        // Get all guardians for a given student
        public static DataTable GetGuardiansByStudentID(int studentID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT gs.GuardianStudentID, gs.GuardianID, g.PersonID, gs.Relationship " +
                                                   "FROM GuardianStudents gs " +
                                                   "INNER JOIN Guardians g ON gs.GuardianID = g.GuardianID " +
                                                   "WHERE gs.StudentID = @StudentID", conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        private static string connectionString = clsDataAccessSettings.ConnectionString;
        public static DataTable GetGuardianStudentLinks()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT GuardianID, StudentID
            FROM GuardianStudents;";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static int AddGuardianStudent(int guardianID, int studentID, string relationship, int createdBy)
        {
            int newID = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO GuardianStudents (GuardianID, StudentID, Relationship, CreatedBy, CreatedDate)
                    VALUES (@GuardianID, @StudentID, @Relationship, @CreatedBy, GETDATE());
                    SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianID", guardianID);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Relationship", relationship ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreatedBy", createdBy);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        newID = id;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in AddGuardianStudent", ex);
                }
            }

            return newID;
        }

        public static bool UpdateGuardianStudent(int guardianStudentID, int guardianID, int studentID, string relationship, int modifiedBy)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE GuardianStudents
                    SET GuardianID = @GuardianID,
                        StudentID = @StudentID,
                        Relationship = @Relationship,
                        ModifiedBy = @ModifiedBy,
                        ModifiedDate = GETDATE()
                    WHERE GuardianStudentID = @GuardianStudentID;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianStudentID", guardianStudentID);
                command.Parameters.AddWithValue("@GuardianID", guardianID);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Relationship", relationship ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in UpdateGuardianStudent", ex);
                }
            }

            return rowsAffected > 0;
        }

        public static bool DeleteGuardianStudent(int guardianStudentID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GuardianStudents WHERE GuardianStudentID = @GuardianStudentID;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianStudentID", guardianStudentID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DeleteGuardianStudent", ex);
                }
            }

            return rowsAffected > 0;
        }
        public static DataTable GetGuardianSummary(int guardianID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                gs.GuardianID,
                p.FirstName + ' ' + ISNULL(p.SecondName,'') + ' ' + ISNULL(p.ThirdName,'') + ' ' + ISNULL(p.LastName,'') AS GuardianName,
                COUNT(gs.StudentID) AS StudentCount
            FROM GuardianStudents gs
            INNER JOIN Guardians g ON gs.GuardianID = g.GuardianID
            INNER JOIN People p ON g.PersonID = p.PersonID
            WHERE gs.GuardianID = @GuardianID
            GROUP BY gs.GuardianID, p.FirstName, p.SecondName, p.ThirdName, p.LastName;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianID", guardianID);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetGuardianSummary", ex);
                }
            }

            return dt;
        }

        public static DataTable GetGuardianStudentsByGuardian(int guardianID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                  SELECT 
    gs.GuardianStudentID, 
    s.StudentID,
    e.EnrollmentID,   -- added
    p.FirstName + ' ' + ISNULL(p.SecondName,'') + ' ' 
        + ISNULL(p.ThirdName,'') + ' ' 
        + ISNULL(p.LastName,'') AS FullName,
    gs.Relationship
FROM GuardianStudents gs
INNER JOIN Students s ON gs.StudentID = s.StudentID
INNER JOIN People p ON s.PersonID = p.PersonID
LEFT JOIN Enrollments e ON s.StudentID = e.StudentID   -- join added
WHERE gs.GuardianID = @GuardianID;
";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianID", guardianID);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetGuardianStudentsByGuardian", ex);
                }
            }

            return dt;
        }

        public static bool GetGuardianStudentInfo(int guardianStudentID, ref int guardianID, ref int studentID, ref string relationship)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GuardianID, StudentID, Relationship FROM GuardianStudents WHERE GuardianStudentID = @GuardianStudentID;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuardianStudentID", guardianStudentID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        guardianID = (int)reader["GuardianID"];
                        studentID = (int)reader["StudentID"];
                        relationship = reader["Relationship"]?.ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetGuardianStudentInfo", ex);
                }
            }

            return isFound;
        }
    }
}
