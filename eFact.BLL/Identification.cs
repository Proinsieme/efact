using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Identification
    {
        public int IdentificationId { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public string IssueDate { get; set; }
        public string ExpireDate { get; set; }
        public int UserId { get; set; }
        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public void SaveIdentification(Identification Identification1, Identification Identification2, Identification Identification3, int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveIdentificationDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = EmployeeId;

                sqlCommand.Parameters.Add("@IdentificationId", SqlDbType.Int).Value = Identification1.IdentificationId;
                sqlCommand.Parameters.Add("@IdentificationType", SqlDbType.VarChar).Value = Identification1.IdentificationType;
                sqlCommand.Parameters.Add("@IdentificationNo", SqlDbType.VarChar).Value = Identification1.IdentificationNo;
                sqlCommand.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = Identification1.IssueDate;
                sqlCommand.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = Identification1.ExpireDate;

                sqlCommand.Parameters.Add("@IdentificationId1", SqlDbType.Int).Value = Identification2.IdentificationId;
                sqlCommand.Parameters.Add("@IdentificationType1", SqlDbType.VarChar).Value = Identification2.IdentificationType;
                sqlCommand.Parameters.Add("@IdentificationNo1", SqlDbType.VarChar).Value = Identification2.IdentificationNo;
                sqlCommand.Parameters.Add("@IssueDate1", SqlDbType.DateTime).Value = Identification2.IssueDate;
                sqlCommand.Parameters.Add("@ExpireDate1", SqlDbType.DateTime).Value = Identification2.ExpireDate;

                sqlCommand.Parameters.Add("@IdentificationId2", SqlDbType.Int).Value = Identification3.IdentificationId;
                sqlCommand.Parameters.Add("@IdentificationType2", SqlDbType.VarChar).Value = Identification3.IdentificationType;
                sqlCommand.Parameters.Add("@IdentificationNo2", SqlDbType.VarChar).Value = Identification3.IdentificationNo;
                sqlCommand.Parameters.Add("@IssueDate2", SqlDbType.DateTime).Value = Identification3.IssueDate;
                sqlCommand.Parameters.Add("@ExpireDate2", SqlDbType.DateTime).Value = Identification3.ExpireDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = Identification1.UserId;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
