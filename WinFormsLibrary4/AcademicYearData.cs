using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SchoolProjectData
{
    public class clsAcademicYearData
    {
        public static bool DeactivateAcademicYear(int academicYearID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            UPDATE AcademicYears
            SET IsCurrent = 0
            WHERE AcademicYearID = @AcademicYearID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        // Optionally log ex.Message
                        return false;
                    }
                }
            }
        }

        public static DataRow GetNextAcademicYear(int currentAcademicYearID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT TOP 1 *
            FROM AcademicYears
            WHERE StartDate > (SELECT StartDate FROM AcademicYears WHERE AcademicYearID = @CurrentYearID)
            ORDER BY StartDate ASC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CurrentYearID", currentAcademicYearID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int AddNewAcademicYear(string yearName, DateTime startDate, DateTime endDate, bool isCurrent, int createdByUserID)
        {
            int newID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    INSERT INTO AcademicYears (YearName, StartDate, EndDate, IsCurrent, CreatedByUserID, CreatedAt)
                    VALUES (@YearName, @StartDate, @EndDate, @IsCurrent, @CreatedByUserID, GETDATE());
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@YearName", yearName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@IsCurrent", isCurrent);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        newID = Convert.ToInt32(result);
                }
                catch
                {
                    newID = -1;
                }
            }

            return newID;
        }

        public static bool UpdateAcademicYear(int academicYearID, string yearName, DateTime startDate, DateTime endDate, bool isCurrent, int modifiedByUserID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    UPDATE AcademicYears
                    SET YearName = @YearName,
                        StartDate = @StartDate,
                        EndDate = @EndDate,
                        IsCurrent = @IsCurrent,
                        ModifiedByUserID = @ModifiedByUserID,
                        ModifiedAt = GETDATE()
                    WHERE AcademicYearID = @AcademicYearID";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                cmd.Parameters.AddWithValue("@YearName", yearName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@IsCurrent", isCurrent);
                cmd.Parameters.AddWithValue("@ModifiedByUserID", modifiedByUserID);

                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool GetAcademicYearByID(int id, ref string yearName, ref DateTime startDate, ref DateTime endDate, ref bool isCurrent, ref int createdByUserID, ref DateTime createdAt)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM AcademicYears WHERE AcademicYearID = @ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        yearName = reader["YearName"].ToString();
                        startDate = Convert.ToDateTime(reader["StartDate"]);
                        endDate = Convert.ToDateTime(reader["EndDate"]);
                        isCurrent = reader["IsCurrent"] != DBNull.Value && Convert.ToBoolean(reader["IsCurrent"]);
                        createdByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
                        createdAt = reader["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedAt"]) : DateTime.MinValue;
                        isFound = true;
                    }

                    reader.Close();
                }
                catch
                {
                    isFound = false;
                }
            }

            return isFound;
        }

        public static DataTable GetAllAcademicYears()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select  AcademicYearID, YearName, StartDate, EndDate,IsCurrent from AcademicYears ORDER BY StartDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static bool DeleteAcademicYear(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM AcademicYears WHERE AcademicYearID = @ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static int GetCurrentAcademicYearID()
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT TOP 1 AcademicYearID FROM AcademicYears WHERE IsCurrent = 1";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch
                {
                    return -1;
                }
            }
        }
    }
}
