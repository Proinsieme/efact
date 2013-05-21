using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class EmploymentType
    {
        public int EmploymentTypeId { get; set; }
        public string EmploymentTypeName { get; set; }
        public string EmploymentDescription { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<EmploymentType> GetEmploymentType()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<EmploymentType> employmentTypeList = new List<EmploymentType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEmploymentType", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    EmploymentType employmentType = new EmploymentType
                    {
                        EmploymentTypeId = (Convert.ToInt32(sqlReader["EmpTypeId"])),
                        EmploymentTypeName = sqlReader["EmpType"].ToString(),
                        EmploymentDescription = sqlReader["EmpTypeDescription"].ToString()
                    };
                    employmentTypeList.Add(employmentType);
                }
                return employmentTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
