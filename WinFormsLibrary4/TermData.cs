using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SchoolProjectData
{
    public static class clsTermData
    {
        public static int GetActiveTermIDForAcademicYear(int academicYearID)
        {
            int termID = -1;

            string query = @"
        SELECT TOP 1 TermID
        FROM Terms
        WHERE AcademicYearID = @AcademicYearID AND IsActive = 1
        ORDER BY StartDate;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        termID = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    // optional: log exception if you have a logger
                    // clsLogger.Log("GetActiveTermIDForAcademicYear", ex);
                }
            }

            return termID;
        }

        public static bool SetActiveState(int termID, bool isActive)
        {
            string sql = @"
        UPDATE Terms
        SET IsActive = @IsActive
        WHERE TermID = @TermID;

        -- Optionally deactivate others if setting active
        IF (@IsActive = 1)
            UPDATE Terms SET IsActive = 0 WHERE TermID <> @TermID;
    ";

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@TermID", termID);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static int AddNewTerm(string termName, DateTime startDate, DateTime endDate, bool isFinal, int createdBy, int academicYearID) // ✅ added param
        {
            string query = @"
                INSERT INTO Terms (TermName, StartDate, EndDate, IsFinal, CreatedByUserID, AcademicYearID) 
                OUTPUT INSERTED.TermID
                VALUES (@TermName, @StartDate, @EndDate, @IsFinal, @CreatedByUserID, @AcademicYearID)"; // ✅ added column

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TermName", termName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@IsFinal", isFinal);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdBy);
                cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID); // ✅ added

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static bool UpdateTermIsFinal(int termID, bool isFinal)
        {
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE Terms SET IsFinal = @IsFinal WHERE TermID = @TermID", con))
            {
                cmd.Parameters.AddWithValue("@IsFinal", isFinal);
                cmd.Parameters.AddWithValue("@TermID", termID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public static bool IsFinalTerm(int termID)
        {
            bool isFinal = false;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT IsFinal FROM Terms WHERE TermID = @TermID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TermID", termID);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    isFinal = Convert.ToBoolean(result);
            }

            return isFinal;
        }

        public static DataTable GetAllTerms()
        {
            string sql = @"SELECT TermID, TermName, StartDate, EndDate, IsActive, IsFinal--, AcademicYearID 
                           FROM Terms  
                           ORDER BY StartDate;"; // ✅ include AcademicYearID for completeness

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static DataTable GetAllTerms(int academicYearID) { string sql = @"SELECT TermID, TermName, StartDate, EndDate, IsActive, IsFinal FROM Terms WHERE AcademicYearID = @AcademicYearID ORDER BY StartDate;"; using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString)) using (SqlCommand cmd = new SqlCommand(sql, con)) using (SqlDataAdapter da = new SqlDataAdapter(cmd)) { cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID); DataTable dt = new DataTable(); da.Fill(dt); return dt; } }
        public static DataTable GetActiveTerm(int academicYearID)
        {
            string sql = @"SELECT TermID, TermName, StartDate, EndDate, IsActive, IsFinal   
                   FROM Terms
                   WHERE AcademicYearID = @AcademicYearID
                     AND IsActive = 1
                   ORDER BY StartDate;";

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public static bool Find(
       int termID,
       ref string termName,
       ref DateTime startDate,
       ref DateTime endDate,
       ref bool isFinal,
       ref bool isActive,
       ref int createdByUserID,
       ref DateTime? createdAt,
       ref int? modifiedByUserID,
       ref DateTime? modifiedAt,
       ref int academicYearID)  // ✅ added
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string sql = @"SELECT * FROM Terms WHERE TermID = @TermID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TermID", termID);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            termName = dr["TermName"].ToString();
                            startDate = Convert.ToDateTime(dr["StartDate"]);
                            endDate = Convert.ToDateTime(dr["EndDate"]);
                            isFinal = Convert.ToBoolean(dr["IsFinal"]);
                            isActive = Convert.ToBoolean(dr["IsActive"]);
                            createdByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
                            createdAt = dr["CreatedAt"] as DateTime?;
                            modifiedByUserID = dr["ModifiedByUserID"] as int?;
                            modifiedAt = dr["ModifiedAt"] as DateTime?;
                            academicYearID = dr["AcademicYearID"] != DBNull.Value
                                ? Convert.ToInt32(dr["AcademicYearID"])
                                : -1; // ✅ added
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static int InsertTerm(string termName, DateTime startDate, DateTime endDate,
                                     bool isFinal, bool isActive, int createdByUserID, int academicYearID) // ✅ added param
        {
            int newID = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    INSERT INTO Terms 
                    (TermName, StartDate, EndDate, IsFinal, IsActive, CreatedByUserID, CreatedAt, AcademicYearID)
                    OUTPUT INSERTED.TermID
                    VALUES 
                    (@TermName, @StartDate, @EndDate, @IsFinal, @IsActive, @CreatedByUserID, GETDATE(), @AcademicYearID);"; // ✅ added column

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TermName", termName);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@IsFinal", isFinal);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID); // ✅ added

                    conn.Open();
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return newID;
        }

        public static DataTable GetNextTermInfo(int currentTermID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    SELECT TOP 1 *
                    FROM Terms
                    WHERE TermID > @CurrentTermID
                    ORDER BY TermID ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CurrentTermID", currentTermID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static bool UpdateTerm(int termId, string termName, DateTime startDate, DateTime endDate,
                                      bool isFinal, bool isActive, int modifiedBy, int academicYearID) // ✅ added param
        {
            string sql = @"
                UPDATE Terms 
                SET TermName=@TermName, 
                    StartDate=@StartDate, 
                    EndDate=@EndDate, 
                    IsFinal=@IsFinal,
                    IsActive=@IsActive,
                     --AcademicYearID=@AcademicYearID, -- ✅ added
                    ModifiedByUserID=@ModifiedByUserID, 
                    ModifiedAt=GETDATE()
                WHERE TermID=@TermID";

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@TermID", termId);
                cmd.Parameters.AddWithValue("@TermName", termName);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@IsFinal", isFinal);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@ModifiedByUserID", modifiedBy);
                //cmd.Parameters.AddWithValue("@AcademicYearID", academicYearID); // ✅ added

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteTerm(int termId)
        {
            string sql = "DELETE FROM Terms WHERE TermID=@TermID";
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@TermID", termId);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
