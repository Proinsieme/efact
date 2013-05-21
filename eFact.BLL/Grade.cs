using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string GradeDescription { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Grade> GetEmpGrade()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Grade> gradeList = new List<Grade>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetGrade", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Grade grade = new Grade
                    {
                        GradeId = (Convert.ToInt32(sqlReader["GradeId"])),
                        GradeName = sqlReader["Grade"].ToString(),
                        GradeDescription = sqlReader["GradeDescription"].ToString()
                    };
                    gradeList.Add(grade);
                }
                return gradeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
