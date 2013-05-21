using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    class LeaveType
    {
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveDescription { get; set; }
        public int LeaveDays { get; set; }
        public int UserId { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public List<LeaveType> GetLeaveTypes()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<LeaveType> leaveTypeList = new List<LeaveType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetLeaveType", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    LeaveType leaveType = new LeaveType
                    {
                        LeaveTypeId = (Convert.ToInt32(sqlReader["LeaveTypeId"])),
                        LeaveTypeName = sqlReader["LeaveType"].ToString(),
                        LeaveDays = (Convert.ToInt32(sqlReader["Days"])),
                        LeaveDescription = sqlReader["LeaveDescription"].ToString()
                    };
                    leaveTypeList.Add(leaveType);
                }
                return leaveTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
