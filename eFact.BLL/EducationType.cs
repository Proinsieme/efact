using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class EducationType
    {
        public int EducationId { get; set; }
        public int EducationTypeId { get; set; }
        public string EducationTypeName { get; set; }
        public string EducationDescription { get; set; }
        public string Institutuion { get; set; }
        public string QualificationName { get; set; }
        public string Grade { get; set; }
        public string DateOptained { get; set; }
        public string Comments { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<EducationType> GetEducationType()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<EducationType> educationTypeList = new List<EducationType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEducationType", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    EducationType educationType = new EducationType
                    {
                        EducationTypeId = (Convert.ToInt32(sqlReader["EducationTypeId"])),
                        EducationTypeName = sqlReader["EducationType"].ToString(),
                        EducationDescription = sqlReader["EducationDescription"].ToString()
                    };
                    educationTypeList.Add(educationType);
                }
                return educationTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveEducationDetails(EducationType educationType, int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveEducationDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@EducationId", SqlDbType.VarChar).Value = EducationId;
                sqlCommand.Parameters.Add("@EducationTypeId", SqlDbType.VarChar).Value = EducationTypeId;
                sqlCommand.Parameters.Add("@DateOptained", SqlDbType.DateTime).Value = DateOptained;
                sqlCommand.Parameters.Add("@Institution", SqlDbType.VarChar).Value = Institutuion;
                sqlCommand.Parameters.Add("@QualificationName", SqlDbType.VarChar).Value = QualificationName;
                sqlCommand.Parameters.Add("@Grade", SqlDbType.VarChar).Value = Grade;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Comments;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EducationType> GetEducationDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<EducationType> educationTypeList = new List<EducationType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEducationDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    EducationType educationType = new EducationType
                    {
                        EducationId = (Convert.ToInt32(sqlReader["EducationId"])),
                        EducationTypeId = (Convert.ToInt32(sqlReader["EducationTypeId"])),
                        EducationTypeName = sqlReader["EducationType"].ToString(),
                        Institutuion = sqlReader["Institution"].ToString(),
                        QualificationName = sqlReader["QualificationName"].ToString(),
                        Grade = sqlReader["Grade"].ToString(),
                        DateOptained = sqlReader["DateOptained"].ToString(),
                        Comments = sqlReader["Comments"].ToString()
                    };
                    educationTypeList.Add(educationType);
                }
                return educationTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteEducationDetailsByEducationId(int employeeId, int educationId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output = 0;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_DeleteEducationDetailsByEducationId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@EducationId", SqlDbType.VarChar).Value = educationId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
