using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace eFact
{
    public class ClsDatabaseReader
    {

        public SqlDataReader ExecuteDBCommand(string command, string callByModule)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();
            command = command.Replace("\"", "\'"); //This is done because of conversion from access db to SQL

            SqlDataReader dr = null;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(command, conn);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (SqlException ex)
            {
                string str = "";
                str = "Source: " + callByModule + " - " + ex.Source;
                str += "\n" + "Message: " + ex.Message;
                str += "\n" + "\n";
                str += "\n" + "Stack Trace : " + ex.StackTrace;
                //throw ex;
                //MessageBox.Show(str, "Specific Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                return dr;
            }
        }
    }
}
