using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SchoolProjectData
{
    public class clsEnrollmentData
    {
        public static bool AreAllStudentsInSameTerm(int academicYearID)
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string sql = @"
            SELECT DISTINCT TermID
            FROM Enrollments
            WHERE AcademicYearID = @AcademicYearID AND IsActive = 1;
        ";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                    con.Open();

                    List<int> termIDs = new List<int>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            termIDs.Add(Convert.ToInt32(reader["TermID"]));
                        }
                    }

                    // ✅ If all students share one term, return true
                    return termIDs.Count == 1;
                }
            }
        }

        public static DataTable GetActiveEnrollmentsByTerm(int termID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
        SELECT 
            e.EnrollmentID,
            e.StudentID,
            e.TermID,
            e.AcademicYearID,
            e.ClassID,
            e.GradeID,
            e.IsActive,
            -- 👇 Add full name from linked person
            (p.FirstName + ' ' + 
             ISNULL(p.SecondName, '') + ' ' + 
             ISNULL(p.ThirdName, '') + ' ' + 
             ISNULL(p.LastName, '')) AS FullName
        FROM Enrollments e
        INNER JOIN Students s ON e.StudentID = s.StudentID
        INNER JOIN People p ON s.PersonID = p.PersonID
        WHERE e.TermID = @TermID AND e.IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TermID", termID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static int GetEnrollmentIDInTerm(int studentID, int termID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            try
            {
                string query = @"SELECT EnrollmentID 
                        FROM Enrollments 
                        WHERE StudentID = @StudentID 
                        AND TermID = @TermID 
                        AND IsActive = 1";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@TermID", termID);

                connection.Open();
                object result = command.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                // Log error if needed
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
       
        
        public static bool PromoteStudentToNextTerm(int studentID, int nextTermID, int gradeID, int classID)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                INSERT INTO Enrollments (StudentID, GradeID, ClassID, TermID, EnrollmentDate, IsActive)
                VALUES (@StudentID, @GradeID, @ClassID, @TermID, GETDATE(), 1);
            ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@GradeID", gradeID);
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@TermID", nextTermID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isSuccess = (rowsAffected > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error promoting student: " + ex.Message);
            }

            return isSuccess;
        }

        public static DataTable GetActiveEnrollments(int termID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                SELECT 
                    EnrollmentID,
                    StudentID,
                    GradeID,
                    ClassID,
                    TermID,
                    IsActive
                FROM Enrollments
                WHERE TermID = @TermID AND IsActive = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TermID", termID);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error (optional)
                Console.WriteLine("Error getting active enrollments: " + ex.Message);
            }

            return dt;
        }



        // 🧠 2️⃣ Get a single enrollment by ID
        public static DataRow GetEnrollmentByID2(int enrollmentID)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    e.EnrollmentID,
                    e.StudentID,
                    e.GradeID,
                    g.GradeName,
                    e.StartDate,
                    e.EndDate,
                    e.CreatedAt
                FROM Enrollments e
                INNER JOIN Grades g ON e.GradeID = g.GradeID
                WHERE e.EnrollmentID = @EnrollmentID;
            ";

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetEnrollmentByID: " + ex.Message);
                }
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }
        public static bool DoesEnrollmentExist(int studentID, int termID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM Enrollments 
                    WHERE StudentID = @StudentID AND TermID = @TermID AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@TermID", termID);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static bool GetEnrollmentByEnrollmentID(int enrollmentID,
    ref int studentID, ref int classID, ref int gradeID,
    ref int termID, ref DateTime enrollmentDate, ref bool isActive,
    ref int createdByUserID, ref int academicYear, ref DateTime createdAt, ref string modifiedByUser, ref DateTime modifiedAt)
        {
            bool found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT * FROM Enrollments 
            WHERE EnrollmentID = @EnrollmentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                                studentID = Convert.ToInt32(reader["StudentID"]);
                                classID = Convert.ToInt32(reader["ClassID"]);
                                gradeID = Convert.ToInt32(reader["GradeID"]);
                                termID = Convert.ToInt32(reader["TermID"]);
                                enrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]);
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                                academicYear = Convert.ToInt32(reader["AcademicYearID"]);
                                createdAt = Convert.ToDateTime(reader["CreatedAt"]);

                                if (!reader.IsDBNull(reader.GetOrdinal("ModifiedByUser")))
                                    modifiedByUser = reader["ModifiedByUser"].ToString();
                                if (!reader.IsDBNull(reader.GetOrdinal("ModifiedAt")))
                                    modifiedAt = Convert.ToDateTime(reader["ModifiedAt"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error
                    }
                }
            }

            return found;
        }

        public static bool MarkAsCompleted(int enrollmentID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Enrollments
                                 SET IsActive = 0, CompletedDate = GETDATE()
                                 WHERE EnrollmentID = @EnrollmentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                conn.Open();
                int affected = cmd.ExecuteNonQuery();
                return affected > 0;
            }
        }
        public static int AddNewEnrollment(int studentID, int classID, int gradeID, int termID,
                                DateTime enrollmentDate, bool isActive,
                                int createdByUserID, int academicYearID, DateTime createdAt)
        {
            int newID = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                conn.Open();

                // Step 1: Get the next AttemptNo for this Student + Grade
                SqlCommand getAttemptCmd = new SqlCommand(@"
            SELECT ISNULL(MAX(AttemptNo), 0) + 1
            FROM Enrollments
            WHERE StudentID = @StudentID AND GradeID = @GradeID;", conn);

                getAttemptCmd.Parameters.AddWithValue("@StudentID", studentID);
                getAttemptCmd.Parameters.AddWithValue("@GradeID", gradeID);

                int nextAttemptNo = (int)getAttemptCmd.ExecuteScalar();

                // Step 2: Insert enrollment
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Enrollments
            (StudentID, ClassID, GradeID, TermID, EnrollmentDate, IsActive, CreatedByUserID, AcademicYearID, CreatedAt, AttemptNo)
            VALUES (@StudentID, @ClassID, @GradeID,@TermID, @EnrollmentDate, @IsActive, @CreatedByUserID, @AcademicYearID, @CreatedAt, @AttemptNo);
            SELECT SCOPE_IDENTITY();", conn);

                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@ClassID", classID);
                cmd.Parameters.AddWithValue("@GradeID", gradeID);
                cmd.Parameters.AddWithValue("@TermID", termID);
                cmd.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                cmd.Parameters.AddWithValue("@CreatedAt", createdAt);
                cmd.Parameters.AddWithValue("@AttemptNo", nextAttemptNo);

                newID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return newID;
        }

        public static bool DeactivateEnrollment(int enrollmentID)
        {
            string query = @"UPDATE Enrollments
                     SET IsActive = 0
                     WHERE EnrollmentID = @EnrollmentID AND IsActive = 1"; // only deactivate if active

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0; // returns true only if actually deactivated
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool UpdateEnrollment(
       int enrollmentID,
       int studentID,
       int classID,
       int gradeID,
       int termID,
       int academicYearID,
       bool isActive
   )
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            UPDATE Enrollments SET
                StudentID = @StudentID,
                ClassID = @ClassID,
                GradeID = @GradeID,
                TermID = @TermID,
                AcademicYearID = @AcademicYearID,   -- ✅ fixed
                IsActive = @IsActive
            WHERE EnrollmentID = @EnrollmentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@ClassID", classID);
                    cmd.Parameters.AddWithValue("@GradeID", gradeID);
                    cmd.Parameters.AddWithValue("@TermID", termID);
                    cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating enrollment: " + ex.Message);
                    }
                }
            }

            return rowsAffected > 0;
        }

        public static bool GetEnrollmentByStudentID(int studentID,
        ref int enrollmentID, ref int classID, ref int gradeID,
        ref int termID, ref DateTime enrollmentDate, ref bool isActive,
        ref int createdByUserID, ref DateTime createdAt,
        ref string modifiedByUser, ref DateTime modifiedAt)
        {
            bool found = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT TOP 1 * 
            FROM Enrollments 
            WHERE StudentID = @StudentID
            ORDER BY CreatedAt DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;

                                // Safely handle potential NULLs
                                enrollmentID = reader["EnrollmentID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EnrollmentID"]);
                                classID = reader["ClassID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ClassID"]);
                                gradeID = reader["GradeID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["GradeID"]);
                                termID = reader["TermID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TermID"]);
                                enrollmentDate = reader["EnrollmentDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["EnrollmentDate"]);
                                isActive = reader["IsActive"] == DBNull.Value ? false : Convert.ToBoolean(reader["IsActive"]);
                                createdByUserID = reader["CreatedByUserID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["CreatedByUserID"]);
                                createdAt = reader["CreatedAt"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["CreatedAt"]);

                                modifiedByUser = reader["ModifiedByUser"] == DBNull.Value ? null : reader["ModifiedByUser"].ToString();
                                modifiedAt = reader["ModifiedAt"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["ModifiedAt"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // TODO: log or handle the error properly
                        Console.WriteLine("Error in GetEnrollmentByStudentID: " + ex.Message);
                    }
                }
            }

            return found;
        }

        public static DataTable GetAllEnrollments()
        {
            DataTable dt = new DataTable();

            string query = @"
           SELECT 
    S.StudentID,   
    P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
    P.Gender,
    CASE WHEN P.Gender = 0 THEN 'Male' ELSE 'Female' END AS GenderCaption,
    C.CountryName,
    G.GradeName,
    Cls.ClassName,
    E.EnrollmentDate,
	E.IsActive,
    E.AttemptNo   -- ✅ Added AttemptNo
FROM Enrollments E
INNER JOIN Students S ON E.StudentID = S.StudentID
INNER JOIN People P ON S.PersonID = P.PersonID
INNER JOIN Countries C ON P.NationalityCountryID = C.CountryID
LEFT JOIN Grades G ON E.GradeID = G.GradeID
LEFT JOIN Classes Cls ON E.ClassID = Cls.ClassID
-- LEFT JOIN Graduation Gt ON E.EnrollmentID = Gt.EnrollmentID  -- ❌ Removed since IsGraduated is not needed
WHERE E.IsActive = 1
ORDER BY E.EnrollmentDate;



";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dt.Load(reader);
                    }
                    catch (Exception)
                    {
                        // Log error
                    }
                }
            }

            return dt;
        }
        public static bool DeactivateEnrollment(int StudentID, int modifiedBy)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
        UPDATE Enrollments
        SET IsActive = 0,
            ModifiedByUser = @ModifiedByUser,
            ModifiedAt = GETDATE()
        WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.Parameters.AddWithValue("@ModifiedByUser", modifiedBy);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteEnrollment(int StudentID)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM Enrollments WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                    }
                }
            }

            return rowsAffected > 0;
        }

        public static bool EnrollmentExists(int enrollmentID)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Enrollments WHERE EnrollmentID = @EnrollmentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                    try
                    {
                        conn.Open();
                        exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                    }
                }
            }

            return exists;
        }

        public static DataTable GetScoresByEnrollmentID(int enrollmentID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM ExamScores WHERE EnrollmentID = @EnrollmentID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                    }
                }
            }

            return dt;
        }

        public static int? GetActiveEnrollmentIDByStudentID(int studentID)
        {
            int? enrollmentID = null;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                  SELECT   EnrollmentID
FROM Enrollments
WHERE EnrollmentID = EnrollmentID
  AND IsActive = 1
ORDER BY EnrollmentDate DESC;
";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentID", studentID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            enrollmentID = Convert.ToInt32(result);
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                    }
                }
            }

            return enrollmentID;
        }
        public static DataRow GetEnrollmentByID(int enrollmentID)
        {
            string query = "SELECT * FROM Enrollments WHERE EnrollmentID = @EnrollmentID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];

                return null;
            }
        }
        // Get all enrollments for a student
        public static System.Data.DataTable GetEnrollmentsByStudentID(int studentID)
        {
            using (var conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (var cmd = new SqlCommand("SELECT * FROM Enrollments WHERE StudentID=@StudentID ORDER BY CreatedAt DESC", conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                var dt = new System.Data.DataTable();
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }
        public static DataTable GetEnrollmentsByStudentID2(int studentID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
SELECT 
    e.EnrollmentID,
    e.GradeID,
    g.GradeName,
    MIN(t.StartDate) AS StartDate,
    MAX(t.EndDate) AS EndDate
FROM Enrollments e
INNER JOIN Grades g ON e.GradeID = g.GradeID
INNER JOIN Terms t ON @EnrollmentID = e.EnrollmentID
GROUP BY e.EnrollmentID, e.GradeID, g.GradeName
ORDER BY MIN(t.StartDate) DESC;
";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EnrollmentID", studentID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // Get total enrollments
        public static int GetTotalEnrollments()
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Enrollments", con))
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Get converted enrollments (students who have paid)
        public static int GetConvertedEnrollments()
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TuitionPayments WHERE TuitionFeeID IS NOT NULL", con))
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }




        // ✅ New function: Enrollment by Gender
        public static DataTable GetEnrollmentByGender()
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT 
            CASE p.Gender
                WHEN 0 THEN 'Male'
                WHEN 1 THEN 'Female'
                ELSE 'Other'
            END AS Gender,
            COUNT(e.EnrollmentID) AS Total
        FROM Enrollments e
        INNER JOIN Students s ON e.StudentID = s.StudentID
        INNER JOIN People p ON s.PersonID = p.PersonID
        GROUP BY p.Gender;", con))
            {
                DataTable dt = new DataTable();
                con.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }


        // ✅ Yearly Enrollment Trend
        public static DataTable GetYearlyEnrollmentTrend()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT 
                YEAR(EnrollmentDate) AS Year,
                COUNT(*) AS Total
            FROM Enrollments
            GROUP BY YEAR(EnrollmentDate)
            ORDER BY Year;";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }



        // ✅ Grade distribution with repeaters
        public static DataTable GetGradeDistributionWithRepeaters()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Grade", typeof(string));
            dt.Columns.Add("Total", typeof(int));
            dt.Columns.Add("Repeaters", typeof(int));

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                conn.Open();

                // Query to get total enrollments and repeaters per grade
                string query = @"
                    SELECT g.GradeName AS Grade,
                           COUNT(e.EnrollmentID) AS Total,
                           SUM(CASE 
                                   WHEN gr.IsGraduated = 0 THEN 1 
                                   ELSE 0 
                               END) AS Repeaters
                    FROM Enrollments e
                    INNER JOIN Grades g ON e.GradeID = g.GradeID
                    LEFT JOIN Graduation gr ON e.EnrollmentID = gr.EnrollmentID
                    GROUP BY g.GradeName
                    ORDER BY g.GradeName
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }











}


