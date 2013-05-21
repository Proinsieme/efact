using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Leave
    {
        public int LeaveId { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfHours { get; set; }
        public string LeaveDescription { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public string LeaveStartHour { get; set; }
        public string LeaveEndHour { get; set; }
        public string LeaveReason { get; set; }
        public string LeaveRegistrationNo { get; set; }
        public string HRComments { get; set; }
        public string LeaveRejectionReason { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime Date { get; set; }
        public string Link{get;set;}

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<Leave> GetLeaveType()
        {
            List<Leave> leaveList = new List<Leave>();
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("[usp_GetLeaveType]", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Leave leave = new Leave
                    {
                        LeaveTypeId = (Convert.ToInt32(sqlReader["LeaveTypeId"])),
                        LeaveType = sqlReader["LeaveType"].ToString(),
                        NoOfDays = (Convert.ToInt32(sqlReader["Days"])),
                        LeaveDescription = sqlReader["LeaveDescription"].ToString()
                    };
                    leaveList.Add(leave);
                }
                return leaveList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leave> GetLeaveDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            DataSet dataSet = new DataSet();
            SqlDataReader sqlReader;
            List<Leave> leaveList = new List<Leave>();
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetLEaveDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Leave leave = new Leave
                    {
                        LeaveTypeId = (Convert.ToInt32(sqlReader["LeaveTypeId"])),
                        LeaveType = sqlReader["LeaveType"].ToString(),
                        NoOfDays = (Convert.ToInt32(sqlReader["NoOfDays"])),
                        NoOfHours = (Convert.ToInt32(sqlReader["NoOfHours"])),
                        LeaveRegistrationNo = sqlReader["LeaveRegistrationNo"].ToString(),
                        LeaveStartDate = Convert.ToDateTime(sqlReader["LeaveStartDate"]),
                        LeaveEndDate = Convert.ToDateTime(sqlReader["LeaveEndDate"]),
                        LeaveReason = sqlReader["LeaveReason"].ToString(),
                        StatusName = sqlReader["StatusName"].ToString()
                    };
                    leaveList.Add(leave);
                }
                return leaveList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leave> GetLeaveDetailsCalendarByEmployeeId(string employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            DataSet dataSet = new DataSet();
            SqlDataReader sqlReader = null;
            List<Leave> leaveList = new List<Leave>();
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetLEaveDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Leave leave = new Leave
                    {
                        LeaveTypeId = (Convert.ToInt32(sqlReader["LeaveTypeId"])),
                        LeaveType = sqlReader["LeaveType"].ToString(),
                        NoOfDays = (Convert.ToInt32(sqlReader["NoOfDays"])),
                        NoOfHours = (Convert.ToInt32(sqlReader["NoOfHours"])),
                        LeaveRegistrationNo = sqlReader["LeaveRegistrationNo"].ToString(),
                        LeaveStartDate = Convert.ToDateTime(sqlReader["LeaveStartDate"]),
                        LeaveEndDate = Convert.ToDateTime(sqlReader["LeaveEndDate"]),
                        LeaveReason = sqlReader["LeaveReason"].ToString(),
                        StatusName = sqlReader["StatusName"].ToString()
                    };
                    leaveList.Add(leave);
                }
                return leaveList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlReader.Dispose();
            }
        }

        public List<Leave> GetBalanceLeaveDetailsByEmployeeId(int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            DataSet dataSet = new DataSet();
            List<Leave> leaveList = new List<Leave>();
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetLeaveBalanceByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = EmployeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataSet);
                if (dataSet != null && dataSet.Tables.Count != 0)
                {
                    foreach (DataRowView drvEmployee in dataSet.Tables[0].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["CassualLeave"]), LeaveType = "Cassual Leave" };
                        leaveList.Add(leave);
                    }

                    foreach (DataRowView drvEmployee in dataSet.Tables[1].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["SickLeave"]), LeaveType = "Sick Leave" };
                        leaveList.Add(leave);
                    }

                    foreach (DataRowView drvEmployee in dataSet.Tables[2].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["MaternityLeave"]), LeaveType = "Maternity Leave" };
                        leaveList.Add(leave);
                    }

                    foreach (DataRowView drvEmployee in dataSet.Tables[3].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["PaternityLeave"]), LeaveType = "Paternity Leave" };
                        leaveList.Add(leave);
                    }
                    foreach (DataRowView drvEmployee in dataSet.Tables[4].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["MarriageLeave"]), LeaveType = "Marriage Leave" };
                        leaveList.Add(leave);
                    }
                    foreach (DataRowView drvEmployee in dataSet.Tables[5].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["HouseMoveLeave"]), LeaveType = "House Move Leave" };
                        leaveList.Add(leave);
                    }
                    foreach (DataRowView drvEmployee in dataSet.Tables[6].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["MortalityLeave"]), LeaveType = "Mortality Leave" };
                        leaveList.Add(leave);
                    }
                    foreach (DataRowView drvEmployee in dataSet.Tables[7].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["SpecialLeave"]), LeaveType = "Special Leave" };
                        leaveList.Add(leave);
                    }
                    foreach (DataRowView drvEmployee in dataSet.Tables[8].DefaultView)
                    {
                        Leave leave = new Leave { NoOfDays = Convert.ToInt32(drvEmployee["StudyLeave"]), LeaveType = "Study Leave" };
                        leaveList.Add(leave);
                    }
                }
                return leaveList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string SaveLeaveDetails(Leave leave, int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            string LeaveRegistrationNo;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveLeaveDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@LeaveTypeId", SqlDbType.Int).Value = LeaveTypeId;
                sqlCommand.Parameters.Add("@LeaveStartDate", SqlDbType.DateTime).Value = LeaveStartDate;
                sqlCommand.Parameters.Add("@LeaveStartHour", SqlDbType.VarChar).Value = LeaveStartHour;
                sqlCommand.Parameters.Add("@LeaveEndDate", SqlDbType.DateTime).Value = LeaveEndDate;
                sqlCommand.Parameters.Add("@LeaveEndHour", SqlDbType.VarChar).Value = LeaveEndHour;
                sqlCommand.Parameters.Add("@NoOfDays", SqlDbType.Int).Value = NoOfDays;
                sqlCommand.Parameters.Add("@NoOfHours", SqlDbType.Int).Value = NoOfHours;
                sqlCommand.Parameters.Add("@LeaveReason", SqlDbType.VarChar).Value = LeaveReason;
                sqlCommand.Parameters.Add("@HRComments", SqlDbType.VarChar).Value = HRComments;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.VarChar).Value = 1;
                LeaveRegistrationNo = Convert.ToString(sqlCommand.ExecuteScalar());
                return LeaveRegistrationNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leave> GetAppliedLeaveDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Leave> leaveList = new List<Leave>();
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetAppliedLeaveDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Leave leave = new Leave
                    {
                        LeaveId = (Convert.ToInt32(sqlReader["LeaveId"])),
                        LeaveRegistrationNo = sqlReader["LeaveRegistrationNo"].ToString()
                    };
                    leaveList.Add(leave);
                }
                return leaveList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LeaveRejection(Leave leave, int employeeId, int supervisorId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output = 0;
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_LeaveRejection", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employeeId;
                sqlCommand.Parameters.Add("@SupervisorId", SqlDbType.Int).Value = supervisorId;
                sqlCommand.Parameters.Add("@LeaveId", SqlDbType.Int).Value = LeaveId;
                sqlCommand.Parameters.Add("@RegistrationNo", SqlDbType.VarChar).Value = LeaveRegistrationNo;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = LeaveRejectionReason;
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
