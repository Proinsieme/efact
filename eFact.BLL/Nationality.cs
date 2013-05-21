using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public string NationalityDescription { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Nationality> GetNationality()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Nationality> nationalityList = new List<Nationality>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetNationality", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Nationality nationality = new Nationality
                    {
                        NationalityId = (Convert.ToInt32(sqlReader["NationalityId"])),
                        NationalityName = sqlReader["Nationality"].ToString(),
                        NationalityDescription = sqlReader["NationalityDescription"].ToString()
                    };
                    nationalityList.Add(nationality);
                }
                return nationalityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
