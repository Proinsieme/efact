using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Insurance
    {
        public int InsuranceId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string InsuranceCompanyDescription { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Insurance> GetInsuranceDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Insurance> insuranceList = new List<Insurance>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetInsuranceCompanyDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Insurance insurance = new Insurance
                    {
                        InsuranceId = (Convert.ToInt32(sqlReader["InsuranceId"])),
                        InsuranceCompanyName = sqlReader["InsuranceCompanyName"].ToString(),
                        InsuranceCompanyDescription = sqlReader["InsuranceComanpyDescription"].ToString()
                    };
                    insuranceList.Add(insurance);
                }
                return insuranceList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
