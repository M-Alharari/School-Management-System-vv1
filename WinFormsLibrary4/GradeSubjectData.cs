using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SchoolProjectData
{
    public class clsGradeSubjectData
    {
        // جلب جميع المواد المرتبطة بصف معين (GradeID)
        public static DataTable GetSubjectsByGradeID(int gradeID)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT gs.SubjectID, s.SubjectName
                FROM GradeSubjects gs
                INNER JOIN Subjects s ON gs.SubjectID = s.SubjectID
                WHERE gs.GradeID = @GradeID
                ORDER BY s.SubjectName";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@GradeID", gradeID);

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
                    throw new Exception("Error fetching subjects by GradeID: " + ex.Message);
                }
            }

            return dt;
        }
        public static bool AddGradeSubject(int gradeID, int subjectID, out string errorMessage)
        {
            errorMessage = "";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO GradeSubjects (GradeID, SubjectID) VALUES (@GradeID, @SubjectID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GradeID", gradeID);
                cmd.Parameters.AddWithValue("@SubjectID", subjectID);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }


        // إضافة ربط مادة جديدة مع صف معين
        public static bool AddGradeSubject(int gradeID, int subjectID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO GradeSubjects (GradeID, SubjectID) VALUES (@GradeID, @SubjectID)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GradeID", gradeID);
            cmd.Parameters.AddWithValue("@SubjectID", subjectID);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return (rowsAffected > 0);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool UpdateGradeSubject(int oldGradeID, int oldSubjectID, int newGradeID, int newSubjectID)
        {
            string query = @"
        UPDATE GradeSubjects
        SET GradeID = @GradeID,
            SubjectID = @SubjectID
        WHERE GradeID = @GradeID AND SubjectID = @SubjectID;
    ";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewGradeID", newGradeID);
                cmd.Parameters.AddWithValue("@NewSubjectID", newSubjectID);
                cmd.Parameters.AddWithValue("@GradeID", oldGradeID);
                cmd.Parameters.AddWithValue("@SubjectID", oldSubjectID);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
                catch (SqlException ex)
                {
                    // Log or show error if needed
                    // MessageBox.Show("SQL Error: " + ex.Message);
                    return false;
                }
            }
        }
        public static bool UpdateGradeSubjects(int gradeID, List<int> newSubjectIDs, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Get existing subjects for this grade
                    List<int> existingSubjectIDs = new List<int>();
                    string selectQuery = "SELECT SubjectID FROM GradeSubjects WHERE GradeID = @GradeID";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn, transaction))
                    {
                        selectCmd.Parameters.AddWithValue("@GradeID", gradeID);
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                                existingSubjectIDs.Add(reader.GetInt32(0));
                        }
                    }

                    // 2️⃣ Find which subjects to ADD (new but not existing)
                    var toAdd = newSubjectIDs.Except(existingSubjectIDs).ToList();

                    // 3️⃣ Find which subjects to DELETE (existing but not new)
                    var toDelete = existingSubjectIDs.Except(newSubjectIDs).ToList();

                    // 4️⃣ Delete removed subjects
                    if (toDelete.Count > 0)
                    {
                        string deleteQuery = "DELETE FROM GradeSubjects WHERE GradeID = @GradeID AND SubjectID = @SubjectID";
                        foreach (int subjectID in toDelete)
                        {
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@GradeID", gradeID);
                                deleteCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                                deleteCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 5️⃣ Insert newly added subjects
                    if (toAdd.Count > 0)
                    {
                        string insertQuery = "INSERT INTO GradeSubjects (GradeID, SubjectID) VALUES (@GradeID, @SubjectID)";
                        foreach (int subjectID in toAdd)
                        {
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@GradeID", gradeID);
                                insertCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 6️⃣ Commit all changes
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }


        // حذف ربط مادة مع صف معين
        public static bool DeleteGradeSubject(int gradeID, int subjectID)
        {
            string query = "DELETE FROM GradeSubjects WHERE GradeID = @GradeID AND SubjectID = @SubjectID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@GradeID", gradeID);
                cmd.Parameters.AddWithValue("@SubjectID", subjectID);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        // حذف كل المواد المرتبطة بصف معين (مثلاً عند حذف الصف أو إعادة تعيين المواد)
        public static bool DeleteAllSubjectsByGradeID(int gradeID)
        {
            string query = "DELETE FROM GradeSubjects WHERE GradeID = @GradeID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@GradeID", gradeID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
