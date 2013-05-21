using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Status> GetEmployeeStatus()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Status> statusList = new List<Status>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEmpStatus", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Status status = new Status
                    {
                        StatusId = (Convert.ToInt32(sqlReader["StatusId"])),
                        StatusName = sqlReader["StatusName"].ToString(),
                        StatusDescription = sqlReader["StatusDescription"].ToString()
                    };
                    statusList.Add(status);
                }
                return statusList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
