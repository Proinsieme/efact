using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Sick
    {
        public int SickId { get; set; }
        public string SickRegistrationNo { get; set; }
        public string SickReportingDate { get; set; }
        public string SickReportingTime { get; set; }
        public string IllnessType { get; set; }
        public bool IsAccident { get; set; }
        public string AccidentType{ get; set; }
        public string ExpectedRecoveryDate { get; set; }
        public string ResumptionDate { get; set; }
        public string ResumptionPercentage { get; set; }
        public bool InformSupervisor { get; set; }
        public bool InsuranceBodies { get; set; }
        public bool Particularities { get; set; }
        public string Comments { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Sick> GetSickDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Sick> sickList = new List<Sick>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetSickDetails", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Sick status = new Sick
                    {
                        SickId = (Convert.ToInt32(sqlReader["SickId"])),
                        SickRegistrationNo = sqlReader["SickRegistrationNo"].ToString(),
                        SickReportingDate = sqlReader["SickReportingDate"].ToString(),
                        SickReportingTime = sqlReader["SickReportingTime"].ToString(),
                        IllnessType = sqlReader["IllnessType"].ToString(),
                        IsAccident = Convert.ToBoolean(sqlReader["IsAccident"].ToString()),
                        AccidentType = sqlReader["AccidentType"].ToString(),
                        ExpectedRecoveryDate = sqlReader["ExpectedRecoveryDate"].ToString(),
                        ResumptionDate = sqlReader["ResumptionDate"].ToString(),
                        ResumptionPercentage = sqlReader["ResumptionPercentage"].ToString(),
                        InformSupervisor = Convert.ToBoolean(sqlReader["InformSupervisor"].ToString()),
                        InsuranceBodies = Convert.ToBoolean(sqlReader["InsuranceBodies"].ToString()),
                        Particularities = Convert.ToBoolean(sqlReader["Particularities"].ToString()),
                        Comments = sqlReader["Comments"].ToString()
                    };
                    sickList.Add(status);
                }
                return sickList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string SaveSickDetails(Sick sick, int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            string SickRegistrationNo;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveSickDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@SickId", SqlDbType.Int).Value = SickId;
                sqlCommand.Parameters.Add("@SickReportingDate", SqlDbType.DateTime).Value = SickReportingDate;
                sqlCommand.Parameters.Add("@SickReportingTime", SqlDbType.Time).Value = SickReportingTime;
                sqlCommand.Parameters.Add("@IllnessType", SqlDbType.VarChar).Value = IllnessType;
                sqlCommand.Parameters.Add("@IsAccident", SqlDbType.Bit).Value = IsAccident;
                sqlCommand.Parameters.Add("@AccidentType", SqlDbType.VarChar).Value = AccidentType;
                sqlCommand.Parameters.Add("@ExpectedRecoveryDate", SqlDbType.DateTime).Value = ExpectedRecoveryDate;
                sqlCommand.Parameters.Add("@ResumptionDate", SqlDbType.DateTime).Value = ResumptionDate;
                sqlCommand.Parameters.Add("@ResumptionPercentage", SqlDbType.VarChar).Value = ResumptionPercentage;
                sqlCommand.Parameters.Add("@InformSupervisor", SqlDbType.Bit).Value = InformSupervisor;
                sqlCommand.Parameters.Add("@InsuranceBodies", SqlDbType.Bit).Value = InsuranceBodies;
                sqlCommand.Parameters.Add("@Particularities", SqlDbType.Bit).Value = Particularities;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Comments;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.VarChar).Value = 1;
                SickRegistrationNo = Convert.ToString(sqlCommand.ExecuteScalar());
                return SickRegistrationNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
