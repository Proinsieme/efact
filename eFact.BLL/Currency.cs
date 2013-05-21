using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyDescription { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Currency> GetCurrencyDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Currency> currencyList = new List<Currency>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetCurrencyDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Currency currency = new Currency
                    {
                        CurrencyId = (Convert.ToInt32(sqlReader["CurrencyId"])),
                        CurrencyName = sqlReader["CurrencyName"].ToString(),
                        CurrencyDescription = sqlReader["CurrencyDescription"].ToString()
                    };
                    currencyList.Add(currency);
                }
                return currencyList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
