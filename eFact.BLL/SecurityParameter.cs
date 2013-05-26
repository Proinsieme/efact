using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace eFact.BLL
{
    public class SecurityParameter
    {
        public int PasswordExpireDate { get; set; }
        public int MaxLoginLimit { get; set; }
        public bool FourEyePolicy { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public SecurityParameter SecurityParameterGet()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            SecurityParameter securityParameter = new SecurityParameter();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SecurityParameter_Get", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    securityParameter = new SecurityParameter
                    {
                        PasswordExpireDate = Convert.ToInt32(sqlReader["PasswordExpireDays"]),
                        MaxLoginLimit = Convert.ToInt32(sqlReader["NumberOfInvalidLoging"]),
                        FourEyePolicy = Convert.ToBoolean(sqlReader["FourEyePolicy"])
                    };
                }
                return securityParameter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
