using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public int LocationStatusId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Location> GetLocation()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Location> locationList = new List<Location>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetLocation", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Location location = new Location
                    {
                        LocationId = (Convert.ToInt32(sqlReader["LOCATIONID"])),
                        LocationName = sqlReader["LOCATION"].ToString(),
                        LocationDescription = sqlReader["LOCATIONDESCRIPTION"].ToString()
                    };
                    locationList.Add(location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
