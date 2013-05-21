using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class Salary
    {
        public int CurrencyId { get; set; }
        public string HourRate { get; set; }
        public string MonthlySalary { get; set; }
        public string PaymentFreq { get; set; }
        public int SalaryGradeId { get; set; }
        public string WageTax { get; set; }
        public string SalaryEffectiveDate { get; set; }
        public string AccountNo { get; set; }
        public string IBAN { get; set; }
        public string BankName { get; set; }
        public string SwiftCode { get; set; }
        public string PaymentMethod { get; set; }
        public string Comments { get; set; }

        /* Allowance */

        public string MobileLimit { get; set; }
        public string Conveyance { get; set; }
        public string SpecialAllowance { get; set; }
        public string LunchAllowance { get; set; }
        public string HouseRentAllowance { get; set; }
        public bool IsRule { get; set; }
        public string RuleStartDate { get; set; }
        public string RuleEndDate { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public void SaveSalary(Salary objSalary, int EmployeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveEmpSalaryDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = EmployeeId;

                sqlCommand.Parameters.Add("@CurrencyId", SqlDbType.Int).Value = objSalary.CurrencyId;
                sqlCommand.Parameters.Add("@HourRate", SqlDbType.VarChar).Value = objSalary.HourRate;
                sqlCommand.Parameters.Add("@MonthlySalary", SqlDbType.VarChar).Value = objSalary.MonthlySalary;
                sqlCommand.Parameters.Add("@PaymentFreq", SqlDbType.VarChar).Value = objSalary.PaymentFreq;
                sqlCommand.Parameters.Add("@SalaryGrade", SqlDbType.Int).Value = objSalary.SalaryGradeId;
                sqlCommand.Parameters.Add("@WageTax", SqlDbType.VarChar).Value = objSalary.WageTax;
                sqlCommand.Parameters.Add("@SalaryEffectiveDate", SqlDbType.DateTime).Value = objSalary.SalaryEffectiveDate;
                sqlCommand.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = objSalary.AccountNo;
                sqlCommand.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = objSalary.IBAN;
                sqlCommand.Parameters.Add("@BankName", SqlDbType.VarChar).Value = objSalary.BankName;
                sqlCommand.Parameters.Add("@SwiftCode", SqlDbType.VarChar).Value = objSalary.SwiftCode;
                sqlCommand.Parameters.Add("@PaymentMethod", SqlDbType.VarChar).Value = objSalary.PaymentMethod;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = objSalary.Comments;

                sqlCommand.Parameters.Add("@IsRule", SqlDbType.Bit).Value = objSalary.IsRule;
                sqlCommand.Parameters.Add("@MobileLimit", SqlDbType.VarChar).Value = objSalary.MobileLimit;
                sqlCommand.Parameters.Add("@Conveyance", SqlDbType.VarChar).Value = objSalary.Conveyance;
                sqlCommand.Parameters.Add("@SpecialAllowance", SqlDbType.VarChar).Value = objSalary.SpecialAllowance;
                sqlCommand.Parameters.Add("@HouseRentAllowance", SqlDbType.VarChar).Value = objSalary.HouseRentAllowance;
                sqlCommand.Parameters.Add("@LunchAllowance", SqlDbType.VarChar).Value = objSalary.LunchAllowance;
                sqlCommand.Parameters.Add("@RuleStartDate", SqlDbType.DateTime).Value = objSalary.RuleStartDate;
                sqlCommand.Parameters.Add("@RuleEndDate", SqlDbType.DateTime).Value = objSalary.RuleEndDate;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
