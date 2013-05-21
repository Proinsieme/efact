using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Department> GetDepartment()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Department> departmentList = new List<Department>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetDepartment", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Department departmentType = new Department
                    {
                        DepartmentId = (Convert.ToInt32(sqlReader["DeptId"])),
                        DepartmentName = sqlReader["DeptName"].ToString(),
                        DepartmentDescription = sqlReader["DeptDescription"].ToString()
                    };
                    departmentList.Add(departmentType);
                }
                return departmentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
