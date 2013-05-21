using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;


namespace eFact.BLL
{
    public class Appraisal
    {
        public int AppraisalId { get; set; }
        public int AppraisalYear { get; set; }
        public string AppraisalPeriod { get; set; }
        public DateTime AppraisalDate { get; set; }
        public DateTime AppraisalCompleteDate { get; set; }
        public int AppraisedBy { get; set; }
        public int ReviewedBy { get; set; }
        public DateTime NextAppraisalDate { get; set; }
        public DateTime LastSalaryReviewDate { get; set; }
        public DateTime NextSalaryReviewDate { get; set; }

        public string JobRating { get; set; }
        public string ObjectiveRating { get; set; }
        public string CompentencyRating { get; set; }

        public string AppraisorComments { get; set; }
        public string AppraiseeComments { get; set; }

        /* Objectives */
        public int ObjectiveId { get; set; }
        public string Objectives { get; set; }
        public int ObjectiveWeight { get; set; }
        public int ObjectiveScore { get; set; }
        public string ObjectiveCategory { get; set; }
        public string ObjectiveComments { get; set; }

        /* Compentencies */
        public int CompentenciesId { get; set; }
        public string Compentencies { get; set; }
        public int CompentenciesWeight { get; set; }
        public string CompentenciesRating { get; set; }
        public string CompentenciesCategory { get; set; }
        public string CompentenciesComments { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public int SaveAppraisalDetails(EducationType educationType, int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveEducationDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@EducationTypeId", SqlDbType.Int).Value = AppraisalYear;
                sqlCommand.Parameters.Add("@DateOptained", SqlDbType.VarChar).Value = AppraisalPeriod;
                sqlCommand.Parameters.Add("@Institution", SqlDbType.DateTime).Value = AppraisalDate;
                sqlCommand.Parameters.Add("@QualificationName", SqlDbType.DateTime).Value = AppraisalCompleteDate;
                sqlCommand.Parameters.Add("@Grade", SqlDbType.Int).Value = AppraisedBy;
                sqlCommand.Parameters.Add("@Institution", SqlDbType.DateTime).Value = NextAppraisalDate;
                sqlCommand.Parameters.Add("@QualificationName", SqlDbType.DateTime).Value = LastSalaryReviewDate;
                sqlCommand.Parameters.Add("@Institution", SqlDbType.DateTime).Value = NextSalaryReviewDate;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveAppraisalObjectives(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveAppraisalObjectives", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = ObjectiveId;
                sqlCommand.Parameters.Add("@AppraisalId", SqlDbType.Int).Value = AppraisalId;
                sqlCommand.Parameters.Add("@Objectives", SqlDbType.VarChar).Value = Objectives;
                sqlCommand.Parameters.Add("@Weight", SqlDbType.Int).Value = ObjectiveWeight;
                sqlCommand.Parameters.Add("@Score", SqlDbType.Int).Value = ObjectiveScore;
                sqlCommand.Parameters.Add("@Category", SqlDbType.VarChar).Value = ObjectiveCategory;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = ObjectiveComments;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveAppraisalCompentencies(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveAppraisalCompentencies", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employeeId;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = CompentenciesId;
                sqlCommand.Parameters.Add("@AppraisalId", SqlDbType.VarChar).Value = AppraisalId;
                sqlCommand.Parameters.Add("@Compentencies", SqlDbType.VarChar).Value = Compentencies;
                sqlCommand.Parameters.Add("@CompentenciesRating", SqlDbType.VarChar).Value = CompentenciesRating;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = CompentenciesComments;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Appraisal> GetAppraisalObjectivesByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Appraisal> appraisalList = new List<Appraisal>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetAppraisalObjectivesByEmployeeId", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Appraisal appraisal = new Appraisal
                    {
                        ObjectiveId = (Convert.ToInt32(sqlReader["Id"])),
                        Objectives = sqlReader["Objectives"].ToString(),
                        ObjectiveWeight = (Convert.ToInt32(sqlReader["Weight"])),
                        ObjectiveScore = (Convert.ToInt32(sqlReader["Score"])),
                        ObjectiveCategory = sqlReader["Category"].ToString(),
                        ObjectiveComments = sqlReader["Comments"].ToString()
                    };
                    appraisalList.Add(appraisal);
                }
                return appraisalList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
