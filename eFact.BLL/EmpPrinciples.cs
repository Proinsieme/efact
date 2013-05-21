using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class EmpPrinciples
    {
        public bool IsInsider { get; set; }
        public int InsiderDepartmentId { get; set; }
        public string RelavtiveName { get; set; }
        public int RelavtiveDepartmentId { get; set; }
        public string Relation { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public void SaveEmpPrinciples(EmpPrinciples objEmpPrinciples, int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("[usp_SavePrincipleDetails]", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = EmployeeId;

                sqlCommand.Parameters.Add("@IsInsider", SqlDbType.Bit).Value = objEmpPrinciples.IsInsider;
                sqlCommand.Parameters.Add("@InsiderDepartmentId", SqlDbType.Int).Value = objEmpPrinciples.InsiderDepartmentId;
                sqlCommand.Parameters.Add("@RelavtiveName", SqlDbType.VarChar).Value = objEmpPrinciples.RelavtiveName;
                sqlCommand.Parameters.Add("@RelavtiveDepartmentId", SqlDbType.Int).Value = objEmpPrinciples.RelavtiveDepartmentId;
                sqlCommand.Parameters.Add("@Relation", SqlDbType.VarChar).Value = objEmpPrinciples.Relation;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = objEmpPrinciples.UserId;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
