using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Interview
    {
        public string InterviewDate { get; set; }
        public string InterviewSource { get; set; }
        public string InterviewerName { get; set; }
        public string Comments { get; set; }

        public bool IsBKR { get; set; }
        public bool IsGoodConduct { get; set; }
        public bool IsMunicipalRecords { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public void SaveInterview(Interview Interview, int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveInterviewDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeId;

                sqlCommand.Parameters.Add("@InterviewDate", SqlDbType.DateTime).Value = Interview.InterviewDate;
                sqlCommand.Parameters.Add("@InterviewSource", SqlDbType.VarChar).Value = Interview.InterviewSource;
                sqlCommand.Parameters.Add("@InterviewerName", SqlDbType.VarChar).Value = Interview.InterviewerName;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Interview.Comments;
                sqlCommand.Parameters.Add("@IsBKR", SqlDbType.Bit).Value = Interview.IsBKR;
                sqlCommand.Parameters.Add("@IsGoodConduct", SqlDbType.Bit).Value = Interview.IsGoodConduct;
                sqlCommand.Parameters.Add("@IsMunicipalRecords", SqlDbType.Bit).Value = Interview.IsMunicipalRecords;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = Interview.UserId;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
