using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageDescription { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Language> GetLanguage()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Language> languageList = new List<Language>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_Language", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Language language = new Language
                    {
                        LanguageId = (Convert.ToInt32(sqlReader["LanguageId"])),
                        LanguageName = sqlReader["LanguageName"].ToString(),
                        LanguageDescription = sqlReader["LanguageDescription"].ToString()
                    };
                    languageList.Add(language);
                }
                return languageList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
