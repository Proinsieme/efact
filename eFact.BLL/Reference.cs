using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Reference
    {
        public int ReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public string ComapanyName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Comments { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public void SaveReference(Reference Reference1, Reference Reference2, Reference Reference3, int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveEmpReferenceDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = EmployeeId;

                sqlCommand.Parameters.Add("@ReferenceId1", SqlDbType.Int).Value = Reference1.ReferenceId;
                sqlCommand.Parameters.Add("@ReferenceName1", SqlDbType.VarChar).Value = Reference1.ReferenceName;
                sqlCommand.Parameters.Add("@ComapanyName1", SqlDbType.VarChar).Value = Reference1.ComapanyName;
                sqlCommand.Parameters.Add("@Position1", SqlDbType.VarChar).Value = Reference1.Position;
                sqlCommand.Parameters.Add("@Email1", SqlDbType.VarChar).Value = Reference1.Email;
                sqlCommand.Parameters.Add("@PhoneNo1", SqlDbType.VarChar).Value = Reference1.PhoneNo;
                sqlCommand.Parameters.Add("@Comments1", SqlDbType.VarChar).Value = Reference1.Comments;

                sqlCommand.Parameters.Add("@ReferenceId2", SqlDbType.Int).Value = Reference2.ReferenceId;
                sqlCommand.Parameters.Add("@ReferenceName2", SqlDbType.VarChar).Value = Reference2.ReferenceName;
                sqlCommand.Parameters.Add("@ComapanyName2", SqlDbType.VarChar).Value = Reference2.ComapanyName;
                sqlCommand.Parameters.Add("@Position2", SqlDbType.VarChar).Value = Reference2.Position;
                sqlCommand.Parameters.Add("@Email2", SqlDbType.VarChar).Value = Reference2.Email;
                sqlCommand.Parameters.Add("@PhoneNo2", SqlDbType.VarChar).Value = Reference2.PhoneNo;
                sqlCommand.Parameters.Add("@Comments2", SqlDbType.VarChar).Value = Reference2.Comments;

                sqlCommand.Parameters.Add("@ReferenceId3", SqlDbType.Int).Value = Reference3.ReferenceId;
                sqlCommand.Parameters.Add("@ReferenceName3", SqlDbType.VarChar).Value = Reference3.ReferenceName;
                sqlCommand.Parameters.Add("@ComapanyName3", SqlDbType.VarChar).Value = Reference3.ComapanyName;
                sqlCommand.Parameters.Add("@Position3", SqlDbType.VarChar).Value = Reference3.Position;
                sqlCommand.Parameters.Add("@Email3", SqlDbType.VarChar).Value = Reference3.Email;
                sqlCommand.Parameters.Add("@PhoneNo3", SqlDbType.VarChar).Value = Reference3.PhoneNo;
                sqlCommand.Parameters.Add("@Comments3", SqlDbType.VarChar).Value = Reference3.Comments;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
