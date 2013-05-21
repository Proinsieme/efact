using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace eFact.BLL
{
    public class Employee
    {
        /* General Employee Information */
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string MartialStatus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RetirementDate { get; set; }
        public string Gender { get; set; }
        public int PrimaryLanguageId { get; set; }
        public int SecondaryLanguageId { get; set; }
        public string TownOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public int Nationality1Id { get; set; }
        public int Nationality2Id { get; set; }
        public string ProfileImagePath { get; set; }

        /* Employment Details */
        public int EmploymentStatusId { get; set; }
        public int EmploymentTypeId { get; set; }
        public int NoofContracts { get; set; }
        public bool IsdefinitiveContract { get; set; }
        public bool ReHire { get; set; }
        public string OriginalHireDate { get; set; }
        public string ProbationHireDate { get; set; }
        public string ContractEndDate { get; set; }
        public string RecruitmentCompany { get; set; }
        public string EducationInsitution { get; set; }
        public string EduStartDate { get; set; }
        public string EduEndDate { get; set; }
        public decimal FTEAllocation { get; set; }

        /* Working Hours */
        public string MonStartTime { get; set; }
        public string MonEndTime { get; set; }
        public string MonTotalTime { get; set; }
        public bool MonFlag { get; set; }
        public string TueStartTime { get; set; }
        public string TueEndTime { get; set; }
        public string TueTotalTime { get; set; }
        public bool TueFlag { get; set; }
        public string WedStartTime { get; set; }
        public string WedEndTime { get; set; }
        public string WedTotalTime { get; set; }
        public bool WedFlag { get; set; }
        public string ThurStartTime { get; set; }
        public string ThurEndTime { get; set; }
        public string ThurTotalTime { get; set; }
        public bool ThurFlag { get; set; }
        public string FriStartTime { get; set; }
        public string FriEndTime { get; set; }
        public string FriTotalTime { get; set; }
        public bool FriFlag { get; set; }
        public string SatStartTime { get; set; }
        public string SatEndTime { get; set; }
        public string SatTotalTime { get; set; }
        public bool SatFlag { get; set; }
        public string SunStartTime { get; set; }
        public string SunEndTime { get; set; }
        public string SunTotalTime { get; set; }
        public bool SunFlag { get; set; }

        /* Assignment */
        public int CompanyCostCentreId { get; set; }
        public int Department { get; set; }
        public int Location { get; set; }
        public int JobTitle { get; set; }
        public int Position { get; set; }
        public int Supervisor { get; set; }
        public int Mentor { get; set; }
        public int Grade { get; set; }
        
        /* Communication Details */
        public int PermDetailId { get; set; }
        public string PermAddress { get; set; }
        public string PermNo { get; set; }
        public string PermZipCode { get; set; }
        public string PermCity { get; set; }
        public string PermProvience { get; set; }
        public string PermCountry { get; set; }
        public string PermPhoneNo { get; set; }
        public string PermSinceDate { get; set; }

        public int TempDetailId { get; set; }
        public string TempAddress { get; set; }
        public string TempNo { get; set; }
        public string TempZipCode { get; set; }
        public string TempCity { get; set; }
        public string TempProvience { get; set; }
        public string TempCountry { get; set; }
        public string TempPhoneNo { get; set; }
        public string TempSinceDate { get; set; }

        public string PrivateMobile { get; set; }
        public string CompanyMobile { get; set; }
        public string PrivateEmail { get; set; }
        public string CompanyEmail { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }


        /* Emergency Contract */
        public int PriDetailId { get; set; }
        public string PriContractName { get; set; }
        public string PriContractRelation { get; set; }
        public string PriContractAddress { get; set; }
        public string PriContractHomePhone { get; set; }
        public string PriContractWorkPhone { get; set; }
        public string PriContractMobilePhone { get; set; }

        public int SecDetailId { get; set; }
        public string SecContractName { get; set; }
        public string SecContractRelation { get; set; }
        public string SecContractAddress { get; set; }
        public string SecContractHomePhone { get; set; }
        public string SecContractWorkPhone { get; set; }
        public string SecContractMobilePhone { get; set; }

        /* Medical Data */
        public string PhysicianName { get; set; }
        public string PhysicianPhone { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyPhone { get; set; }
        public string BloodGroup { get; set; }
        public int HealthInsuranceCompanyId { get; set; }
        public string HealthInsuranceNumber { get; set; }
        public bool IsCollectiveScheme { get; set; }
        public string MedicalComment { get; set; }

        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
        public string StatusName { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public int SaveEmployeeDetails(Employee employee)
        {
            int EmployeeId = 0;
            SqlConnection sqlConnection = new SqlConnection(connStr);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveEmployeeDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = this.EmployeeId;
                sqlCommand.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = this.EmployeeCode;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = this.FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = this.MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = this.LastName;
                sqlCommand.Parameters.Add("@Title", SqlDbType.VarChar).Value = this.Title;
                sqlCommand.Parameters.Add("@Prefix", SqlDbType.VarChar).Value = this.Prefix;
                sqlCommand.Parameters.Add("@Suffix", SqlDbType.VarChar).Value = this.Suffix;
                sqlCommand.Parameters.Add("@MartialStatus", SqlDbType.VarChar).Value = this.MartialStatus;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = this.Gender;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = this.DateOfBirth;
                sqlCommand.Parameters.Add("@RetirementDate", SqlDbType.DateTime).Value = this.RetirementDate;
                sqlCommand.Parameters.Add("@PrimaryLanguageId", SqlDbType.Int).Value = this.PrimaryLanguageId;
                sqlCommand.Parameters.Add("@SecondaryLanguageId", SqlDbType.Int).Value = this.SecondaryLanguageId;
                sqlCommand.Parameters.Add("@TownOfBirth", SqlDbType.VarChar).Value = this.TownOfBirth;
                sqlCommand.Parameters.Add("@CountryOfBirth", SqlDbType.VarChar).Value = this.CountryOfBirth;
                sqlCommand.Parameters.Add("@Nationality1Id", SqlDbType.Int).Value = this.Nationality1Id;
                sqlCommand.Parameters.Add("@Nationality2Id", SqlDbType.Int).Value = this.Nationality2Id;
                sqlCommand.Parameters.Add("@ProfileImagePath", SqlDbType.VarChar).Value = this.ProfileImagePath;

                /* Employment */
                sqlCommand.Parameters.Add("@EmploymentStatusId", SqlDbType.Int).Value = employee.EmploymentStatusId;
                sqlCommand.Parameters.Add("@EmploymentTypeId", SqlDbType.Int).Value = employee.EmploymentTypeId;
                sqlCommand.Parameters.Add("@NoofContracts", SqlDbType.Int).Value = this.NoofContracts;
                sqlCommand.Parameters.Add("@IsdefinitiveContract", SqlDbType.Bit).Value = employee.IsdefinitiveContract;
                sqlCommand.Parameters.Add("@OriginalHireDate", SqlDbType.DateTime).Value = OriginalHireDate == null ? null : employee.OriginalHireDate;
                sqlCommand.Parameters.Add("@ProbationHireDate", SqlDbType.DateTime).Value = ProbationHireDate == null ? null : employee.ProbationHireDate;
                sqlCommand.Parameters.Add("@ContractEndDate", SqlDbType.DateTime).Value = ContractEndDate == null ? null : employee.ContractEndDate;
                sqlCommand.Parameters.Add("@EduStartDate", SqlDbType.DateTime).Value = EduStartDate == null ? null : employee.EduStartDate;
                sqlCommand.Parameters.Add("@EduEndDate", SqlDbType.DateTime).Value = EduEndDate == null ? null : employee.EduEndDate;
                sqlCommand.Parameters.Add("@RecruitmentCompany", SqlDbType.VarChar).Value = this.RecruitmentCompany;
                sqlCommand.Parameters.Add("@EducationInsitution", SqlDbType.VarChar).Value = this.EducationInsitution;
                sqlCommand.Parameters.Add("@FTEAllocation", SqlDbType.Int).Value = 1;
                sqlCommand.Parameters.Add("@ReHire", SqlDbType.Bit).Value = employee.ReHire;

                /* Working Hours */
                sqlCommand.Parameters.Add("@MonStartTime", SqlDbType.Time).Value = this.MonStartTime;
                sqlCommand.Parameters.Add("@MonEndTime", SqlDbType.Time).Value = this.MonEndTime;
                sqlCommand.Parameters.Add("@MonFlag", SqlDbType.Bit).Value = this.MonFlag;

                sqlCommand.Parameters.Add("@TueStartTime", SqlDbType.Time).Value = this.TueStartTime;
                sqlCommand.Parameters.Add("@TueEndTime", SqlDbType.Time).Value = this.TueEndTime;
                sqlCommand.Parameters.Add("@TueFlag", SqlDbType.Bit).Value = this.TueFlag;

                sqlCommand.Parameters.Add("@WedStartTime", SqlDbType.Time).Value = this.WedStartTime;
                sqlCommand.Parameters.Add("@WedEndTime", SqlDbType.Time).Value = this.WedEndTime;
                sqlCommand.Parameters.Add("@WedFlag", SqlDbType.Bit).Value = this.WedFlag;

                sqlCommand.Parameters.Add("@ThurStartTime", SqlDbType.Time).Value = this.ThurStartTime;
                sqlCommand.Parameters.Add("@ThurEndTime", SqlDbType.Time).Value = this.ThurEndTime;
                sqlCommand.Parameters.Add("@ThurFlag", SqlDbType.Bit).Value = this.ThurFlag;

                sqlCommand.Parameters.Add("@FriStartTime", SqlDbType.Time).Value = this.FriStartTime;
                sqlCommand.Parameters.Add("@FriEndTime", SqlDbType.Time).Value = this.FriEndTime;
                sqlCommand.Parameters.Add("@FriFlag", SqlDbType.Bit).Value = this.FriFlag;

                sqlCommand.Parameters.Add("@SatStartTime", SqlDbType.Time).Value = this.SatStartTime;
                sqlCommand.Parameters.Add("@SatEndTime", SqlDbType.Time).Value = this.SatEndTime;
                sqlCommand.Parameters.Add("@SatFlag", SqlDbType.Bit).Value = this.SatFlag;

                sqlCommand.Parameters.Add("@SunStartTime", SqlDbType.Time).Value = this.SunStartTime;
                sqlCommand.Parameters.Add("@SunEndTime", SqlDbType.Time).Value = this.SunEndTime;
                sqlCommand.Parameters.Add("@SunFlag", SqlDbType.Bit).Value = this.SunFlag;

                /* Assignment */
                sqlCommand.Parameters.Add("@CompanyCostCentreId", SqlDbType.Int).Value = this.CompanyCostCentreId;
                sqlCommand.Parameters.Add("@Department", SqlDbType.Int).Value = this.Department;
                sqlCommand.Parameters.Add("@Location", SqlDbType.Int).Value = this.Location;
                sqlCommand.Parameters.Add("@JobTitle", SqlDbType.Int).Value = this.JobTitle;
                sqlCommand.Parameters.Add("@Position", SqlDbType.Int).Value = this.Position;
                sqlCommand.Parameters.Add("@Supervisor", SqlDbType.Int).Value = this.Supervisor;
                sqlCommand.Parameters.Add("@Mentor", SqlDbType.Int).Value = this.Mentor;
                sqlCommand.Parameters.Add("@Grade", SqlDbType.Int).Value = this.Grade;

                /* Communication Details */
                sqlCommand.Parameters.Add("@PermAddress", SqlDbType.VarChar).Value = this.PermAddress;
                sqlCommand.Parameters.Add("@PermNo", SqlDbType.VarChar).Value = this.PermNo;
                sqlCommand.Parameters.Add("@PermZipCode", SqlDbType.VarChar).Value = this.PermZipCode;
                sqlCommand.Parameters.Add("@PermCity", SqlDbType.VarChar).Value = this.PermCity;
                sqlCommand.Parameters.Add("@PermProvience", SqlDbType.VarChar).Value = this.PermProvience;
                sqlCommand.Parameters.Add("@PermCountry", SqlDbType.VarChar).Value = this.PermCountry;
                sqlCommand.Parameters.Add("@PermPhoneNo", SqlDbType.VarChar).Value = this.PermPhoneNo;
                sqlCommand.Parameters.Add("@PermSinceDate", SqlDbType.DateTime).Value = this.PermSinceDate;

                sqlCommand.Parameters.Add("@TempAddress", SqlDbType.VarChar).Value = this.TempAddress;
                sqlCommand.Parameters.Add("@TempNo", SqlDbType.VarChar).Value = this.TempNo;
                sqlCommand.Parameters.Add("@TempZipCode", SqlDbType.VarChar).Value = this.TempZipCode;
                sqlCommand.Parameters.Add("@TempCity", SqlDbType.VarChar).Value = this.TempCity;
                sqlCommand.Parameters.Add("@TempProvience", SqlDbType.VarChar).Value = this.TempProvience;
                sqlCommand.Parameters.Add("@TempCountry", SqlDbType.VarChar).Value = this.TempCountry;
                sqlCommand.Parameters.Add("@TempPhoneNo", SqlDbType.VarChar).Value = this.TempPhoneNo;
                sqlCommand.Parameters.Add("@TempSinceDate", SqlDbType.DateTime).Value = this.TempSinceDate;

                sqlCommand.Parameters.Add("@PrivateMobile", SqlDbType.VarChar).Value = this.PrivateMobile;
                sqlCommand.Parameters.Add("@PrivateEmail", SqlDbType.VarChar).Value = this.PrivateEmail;
                sqlCommand.Parameters.Add("@CompanyMobile", SqlDbType.VarChar).Value = this.CompanyMobile;
                sqlCommand.Parameters.Add("@CompanyEmail", SqlDbType.VarChar).Value = this.CompanyEmail;
                sqlCommand.Parameters.Add("@Twitter", SqlDbType.VarChar).Value = this.Twitter;
                sqlCommand.Parameters.Add("@LinkedIn", SqlDbType.VarChar).Value = this.LinkedIn;

                /* Emergency Contact */

                sqlCommand.Parameters.Add("@PriDetailId", SqlDbType.Int).Value = this.PriDetailId;
                sqlCommand.Parameters.Add("@PriContractName", SqlDbType.VarChar).Value = this.PriContractName;
                sqlCommand.Parameters.Add("@PriContractRelation", SqlDbType.VarChar).Value = this.PriContractRelation;
                sqlCommand.Parameters.Add("@PriContractAddress", SqlDbType.VarChar).Value = this.PriContractAddress;
                sqlCommand.Parameters.Add("@PriContractHomePhone", SqlDbType.VarChar).Value = this.PriContractHomePhone;
                sqlCommand.Parameters.Add("@PriContractWorkPhone", SqlDbType.VarChar).Value = this.PriContractWorkPhone;
                sqlCommand.Parameters.Add("@PriContractMobilePhone", SqlDbType.VarChar).Value = this.PriContractMobilePhone;

                sqlCommand.Parameters.Add("@SecDetailId", SqlDbType.Int).Value = this.SecDetailId;
                sqlCommand.Parameters.Add("@SecContractName", SqlDbType.VarChar).Value = this.SecContractName;
                sqlCommand.Parameters.Add("@SecContractRelation", SqlDbType.VarChar).Value = this.SecContractRelation;
                sqlCommand.Parameters.Add("@SecContractAddress", SqlDbType.VarChar).Value = this.SecContractAddress;
                sqlCommand.Parameters.Add("@SecContractHomePhone", SqlDbType.VarChar).Value = this.SecContractHomePhone;
                sqlCommand.Parameters.Add("@SecContractWorkPhone", SqlDbType.VarChar).Value = this.SecContractWorkPhone;
                sqlCommand.Parameters.Add("@SecContractMobilePhone", SqlDbType.VarChar).Value = this.SecContractMobilePhone;

                /* Medical Data */
                sqlCommand.Parameters.Add("@PhysicianName", SqlDbType.VarChar).Value = this.PhysicianName;
                sqlCommand.Parameters.Add("@PhysicianPhone", SqlDbType.VarChar).Value = this.PhysicianPhone;
                sqlCommand.Parameters.Add("@PharmacyName", SqlDbType.VarChar).Value = this.PharmacyName;
                sqlCommand.Parameters.Add("@PharmacyPhone", SqlDbType.VarChar).Value = this.PharmacyPhone;
                sqlCommand.Parameters.Add("@BloodGroup", SqlDbType.VarChar).Value = this.BloodGroup;
                sqlCommand.Parameters.Add("@HealthInsuranceNumber", SqlDbType.VarChar).Value = this.HealthInsuranceNumber;
                sqlCommand.Parameters.Add("@IsCollectiveScheme", SqlDbType.Bit).Value = this.IsCollectiveScheme;
                sqlCommand.Parameters.Add("@MedicalComment", SqlDbType.VarChar).Value = this.MedicalComment;
                sqlCommand.Parameters.Add("@HealthInsuranceCompanyId", SqlDbType.Int).Value = this.HealthInsuranceCompanyId;

                EmployeeId = (Int32)sqlCommand.ExecuteScalar();
                return EmployeeId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<Employee> GetEmployeeDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Employee> employeeList = new List<Employee>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEmployeeDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Employee employee = new Employee
                    {
                        EmployeeId = (Convert.ToInt32(sqlReader["EmployeeId"])),
                        EmployeeCode = sqlReader["EmployeeCode"].ToString(),
                        FirstName = sqlReader["EmpFirstName"].ToString(),
                        LastName = sqlReader["EmpLastName"].ToString(),
                        MiddleName = sqlReader["EmpLastName"].ToString(),
                        FullName = sqlReader["EMPFULLNAME"].ToString(),
                        DateOfBirth = Convert.ToDateTime(sqlReader["EmpDateOfBirth"]),
                        DepartmentName = sqlReader["dept"].ToString(),
                        StatusName = sqlReader["statusname"].ToString(),
                        LocationName = sqlReader["loc"].ToString()
                    };
                    employeeList.Add(employee);
                }
                return employeeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> GetEmployeeDetailsByEmployeeId(int employeeId, out List<Employee> emergencyContactList, out List<Interview> interviewList, out List<EmpPrinciples> empPrinciplesList, out List<Salary> salaryList, out List<Identification> identificationList, out List<Reference> referenceList)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            DataSet dataSet = new DataSet();
            List<Employee> employeeList = new List<Employee>();
            emergencyContactList = new List<Employee>();
            interviewList = new List<Interview>();
            empPrinciplesList = new List<EmpPrinciples>();
            salaryList = new List<Salary>();
            identificationList = new List<Identification>();
            referenceList = new List<Reference>();
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEmployeeDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataSet);

                if (dataSet != null && dataSet.Tables.Count != 0)
                {
                    foreach (DataRowView drvEmployee in dataSet.Tables[0].DefaultView)
                    {
                        Employee employee = new Employee
                        {
                            EmployeeId = (Convert.ToInt32(drvEmployee["EmployeeId"])),
                            EmployeeCode = drvEmployee["EmployeeCode"].ToString(),
                            FirstName = drvEmployee["EmpFirstName"].ToString(),
                            MiddleName = drvEmployee["EmpMiddleName"].ToString(),
                            LastName = drvEmployee["EmpLastName"].ToString(),
                            DateOfBirth = Convert.ToDateTime(drvEmployee["EmpDateOfBirth"]),
                            Title = drvEmployee["EmpTitle"].ToString(),
                            PrimaryLanguageId = (Convert.ToInt32(drvEmployee["EmpPrimaryLanguage"])),
                            SecondaryLanguageId = (Convert.ToInt32(drvEmployee["EmpSecondaryLanguage"])),
                            Prefix = drvEmployee["EmpPrefix"].ToString(),
                            Suffix = drvEmployee["EmpSuffix"].ToString(),
                            Gender = drvEmployee["EmpGender"].ToString(),
                            MartialStatus = drvEmployee["EmpMartialStatus"].ToString(),
                            TownOfBirth = drvEmployee["EmpTownOfBirth"].ToString(),
                            CountryOfBirth = drvEmployee["EmpCountryOfBirth"].ToString(),
                            Nationality1Id = (Convert.ToInt32(drvEmployee["Nationality1"])),
                            Nationality2Id = (Convert.ToInt32(drvEmployee["Nationality2"])),
                            RetirementDate = drvEmployee["EmpRetirementDate"].ToString(),
                            EmploymentTypeId = (Convert.ToInt32(drvEmployee["EmpType"])),
                            NoofContracts = (Convert.ToInt32(drvEmployee["EmpNoOfContracts"])),
                            OriginalHireDate = drvEmployee["EmpOriginalHireDate"].ToString(),
                            ProbationHireDate = drvEmployee["EmpProbationEndDate"].ToString(),
                            ContractEndDate = drvEmployee["EmpContractEndDate"].ToString(),
                            IsdefinitiveContract = (Convert.ToBoolean(drvEmployee["EmpDefiniteContract"])),
                            ReHire = (Convert.ToBoolean(drvEmployee["EmpReHire"])),
                            RecruitmentCompany = drvEmployee["EmpRecuitmentCompany"].ToString(),
                            EducationInsitution = drvEmployee["EmpEducationInsitution"].ToString(),
                            EduStartDate = drvEmployee["EmpEduStartDate"].ToString(),
                            EduEndDate = drvEmployee["EmpEduEndDate"].ToString(),
                            PermAddress = drvEmployee["EmpPermAddress"].ToString(),
                            PermNo = drvEmployee["EmpPermNo"].ToString(),
                            PermZipCode = drvEmployee["EmpPermZipCode"].ToString(),
                            PermCity = drvEmployee["EmpPermCity"].ToString(),
                            PermProvience = drvEmployee["EmpPermProvince"].ToString(),
                            PermCountry = drvEmployee["EmpPermCountry"].ToString(),
                            PermPhoneNo = drvEmployee["EmpPermTelephone"].ToString(),
                            PermSinceDate = drvEmployee["EmpPermSince"].ToString(),
                            TempNo = drvEmployee["EmpTempNo"].ToString(),
                            TempZipCode = drvEmployee["EmpTempZipCode"].ToString(),
                            TempCity = drvEmployee["EmpTempCity"].ToString(),
                            TempProvience = drvEmployee["EmpTempProvince"].ToString(),
                            TempCountry = drvEmployee["EmpTempCountry"].ToString(),
                            TempPhoneNo = drvEmployee["EmpTempTelephone"].ToString(),
                            TempSinceDate = drvEmployee["EmpTempSince"].ToString(),
                            TempAddress = drvEmployee["EmpTempAddress"].ToString(),
                            PrivateMobile = drvEmployee["EmpPrivateMobileNo"].ToString(),
                            CompanyMobile = drvEmployee["EmpCompanyMobileNo"].ToString(),
                            PrivateEmail = drvEmployee["EmpPrivateEmailId"].ToString(),
                            CompanyEmail = drvEmployee["EmpCompanyEmailId"].ToString(),
                            Twitter = drvEmployee["EmpTwitterId"].ToString(),
                            LinkedIn = drvEmployee["EmpLinkedIn"].ToString(),
                            FTEAllocation = (Convert.ToInt32(drvEmployee["EmpFTEAllocation"])),
                            EmploymentStatusId = (Convert.ToInt32(drvEmployee["EmpStatusId"])),
                            Department = (Convert.ToInt32(drvEmployee["EmpDepartmentId"])),
                            Location = (Convert.ToInt32(drvEmployee["EmpLocationId"])),
                            Position = (Convert.ToInt32(drvEmployee["EmpPositionId"])),
                            Grade = (Convert.ToInt32(drvEmployee["EmpGradeId"])),
                            JobTitle = (Convert.ToInt32(drvEmployee["EmpJobTitle"])),
                            Supervisor = (Convert.ToInt32(drvEmployee["EmpSupervisorId"])),
                            CompanyCostCentreId = (Convert.ToInt32(drvEmployee["EmpCompanyCostCentre"])),
                            Mentor = (Convert.ToInt32(drvEmployee["EmpMentorId"])),
                            MonStartTime = drvEmployee["MondayStart"].ToString(),
                            MonEndTime = drvEmployee["MondayEnd"].ToString(),
                            MonFlag = (Convert.ToBoolean(drvEmployee["MondayFlag"])),
                            TueStartTime = drvEmployee["TuesdayStart"].ToString(),
                            TueEndTime = drvEmployee["TuesdayEnd"].ToString(),
                            TueFlag = (Convert.ToBoolean(drvEmployee["TuesdayFlag"])),
                            WedStartTime = drvEmployee["WednesdayStart"].ToString(),
                            WedEndTime = drvEmployee["WednesdayEnd"].ToString(),
                            WedFlag = (Convert.ToBoolean(drvEmployee["WednesdayFlag"])),
                            ThurStartTime = drvEmployee["ThursdayStart"].ToString(),
                            ThurEndTime = drvEmployee["ThursdayEnd"].ToString(),
                            ThurFlag = (Convert.ToBoolean(drvEmployee["ThursdayFlag"])),
                            FriStartTime = drvEmployee["FridayStart"].ToString(),
                            FriEndTime = drvEmployee["FridayEnd"].ToString(),
                            FriFlag = (Convert.ToBoolean(drvEmployee["FridayFlag"])),
                            SatStartTime = drvEmployee["SaturdayStart"].ToString(),
                            SatEndTime = drvEmployee["SaturdayEnd"].ToString(),
                            SatFlag = (Convert.ToBoolean(drvEmployee["SaturdayFlag"])),
                            SunStartTime = drvEmployee["SundayStart"].ToString(),
                            SunEndTime = drvEmployee["SundayEnd"].ToString(),
                            SunFlag = (Convert.ToBoolean(drvEmployee["SundayFlag"])),
                            BloodGroup = drvEmployee["BloodGroup"].ToString(),
                            PhysicianName = drvEmployee["PhysicianName"].ToString(),
                            PhysicianPhone = drvEmployee["PhysicianContactNumber"].ToString(),
                            PharmacyName = drvEmployee["PharmacyName"].ToString(),
                            PharmacyPhone = drvEmployee["PharmacyContactNumber"].ToString(),
                            HealthInsuranceCompanyId = (Convert.ToInt32(drvEmployee["InsuranceCompanyId"])),
                            HealthInsuranceNumber = drvEmployee["InsuranceNumber"].ToString(),
                            IsCollectiveScheme = (Convert.ToBoolean(drvEmployee["CollectiveScheme"])),
                            MedicalComment = drvEmployee["MedicalComment"].ToString(),
                            ProfileImagePath = drvEmployee["ProfileImagePath"].ToString()
                        };
                        employeeList.Add(employee);
                    }
                    foreach (DataRowView drvEmergencyContact in dataSet.Tables[1].DefaultView)
                    {
                        Employee emergencyContact = new Employee
                        { 
                            PriDetailId = Convert.ToInt32(drvEmergencyContact["Id"]),
                            PriContractName = drvEmergencyContact["ContactName"].ToString(),
                            PriContractRelation = drvEmergencyContact["Relation"].ToString(),
                            PriContractAddress = drvEmergencyContact["Address"].ToString(),
                            PriContractHomePhone = drvEmergencyContact["HomePhone"].ToString(),
                            PriContractMobilePhone = drvEmergencyContact["MobilePhone"].ToString(),
                            PriContractWorkPhone = drvEmergencyContact["WorkPhone"].ToString(),
                        };
                        emergencyContactList.Add(emergencyContact);
                    }

                    foreach (DataRowView drvInterviewDetails in dataSet.Tables[0].DefaultView)
                    {
                        Interview interviewDetails = new Interview
                        {
                            InterviewDate = drvInterviewDetails["InterviewDate"].ToString(),
                            InterviewerName = drvInterviewDetails["InterviewerName"].ToString(),
                            InterviewSource = drvInterviewDetails["Source"].ToString(),
                            Comments = drvInterviewDetails["Comment"].ToString(),
                            IsBKR = (Convert.ToBoolean(drvInterviewDetails["BKR"])),
                            IsGoodConduct = (Convert.ToBoolean(drvInterviewDetails["GoodConduct"])),
                            IsMunicipalRecords = (Convert.ToBoolean(drvInterviewDetails["MunicipalRecord"]))
                        };
                        interviewList.Add(interviewDetails);
                    }

                    foreach (DataRowView drvPrincples in dataSet.Tables[0].DefaultView)
                    {
                        EmpPrinciples empPrincples = new EmpPrinciples
                        {
                            IsInsider = (Convert.ToBoolean(drvPrincples["Insider"])),
                            InsiderDepartmentId = (Convert.ToInt32(drvPrincples["DepartmentId"])),
                            RelavtiveName = drvPrincples["RelativesName"].ToString(),
                            RelavtiveDepartmentId = (Convert.ToInt32(drvPrincples["RelativeDepartmentId"])),
                            Relation = drvPrincples["Relation"].ToString()
                        };
                        empPrinciplesList.Add(empPrincples);
                    }

                    foreach (DataRowView drvSalary in dataSet.Tables[0].DefaultView)
                    {
                        Salary salaryDetails = new Salary
                        {
                            CurrencyId = (Convert.ToInt32(drvSalary["CurrencyId"])),
                            HourRate = drvSalary["HourlyRate"].ToString(),
                            MonthlySalary = drvSalary["MonthlySalary"].ToString(),
                            PaymentFreq = drvSalary["PaymentFreq"].ToString(),
                            SalaryEffectiveDate = drvSalary["SalaryEffectiveDate"].ToString(),
                            SalaryGradeId = (Convert.ToInt32(drvSalary["GradeId"])),
                            WageTax = drvSalary["WageTax"].ToString(),
                            AccountNo = drvSalary["AccountNo"].ToString(),
                            IBAN = drvSalary["IBAN"].ToString(),
                            BankName = drvSalary["BankName"].ToString(),
                            SwiftCode = drvSalary["SwiftCode"].ToString(),
                            PaymentMethod = drvSalary["PaymentMethod"].ToString(),
                            MobileLimit = drvSalary["MobileLimit"].ToString(),
                            Conveyance = drvSalary["Conveyance"].ToString(),
                            SpecialAllowance = drvSalary["SpecialAllowance"].ToString(),
                            LunchAllowance = drvSalary["LunchAllowance"].ToString(),
                            HouseRentAllowance = drvSalary["HouseRentAllowance"].ToString(),
                            IsRule = (Convert.ToBoolean(drvSalary["RuleApplicable"])),
                            RuleStartDate = drvSalary["RuleStartDate"].ToString(),
                            RuleEndDate = drvSalary["RuleEndDate"].ToString(),
                            Comments = drvSalary["Comments"].ToString(),
                        };
                        salaryList.Add(salaryDetails);
                    }

                    foreach (DataRowView drvIdentifation in dataSet.Tables[2].DefaultView)
                    {
                        Identification identification = new Identification
                        {
                            IdentificationId = (Convert.ToInt32(drvIdentifation["Id"])),
                            IdentificationNo = drvIdentifation["IdentificationNo"].ToString(),
                            IdentificationType = drvIdentifation["IdentificationType"].ToString(),
                            IssueDate = drvIdentifation["IssueDate"].ToString(),
                            ExpireDate = drvIdentifation["ExpireDate"].ToString()
                        };
                        identificationList.Add(identification);
                    }

                    foreach (DataRowView drvReference in dataSet.Tables[3].DefaultView)
                    {
                        Reference reference = new Reference
                        {
                            ReferenceId = (Convert.ToInt32(drvReference["ReferenceId"])),
                            ReferenceName = drvReference["ReferenceName"].ToString(),
                            ComapanyName = drvReference["CompanyName"].ToString(),
                            Position = drvReference["Position"].ToString(),
                            Email = drvReference["Email"].ToString(),
                            PhoneNo = drvReference["PhoneNumber"].ToString(),
                            Comments = drvReference["Comments"].ToString(),
                        };
                        referenceList.Add(reference);
                    }
                }
                return employeeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> GetEmployeeDetailsBySearchQuery(string SearchString)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<Employee> employeeList = new List<Employee>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetEmployeeDetailsBySearchQuery", sqlConnection);
                sqlCommand.Parameters.Add("@SearchQuery", SqlDbType.VarChar).Value = SearchString;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Employee employee = new Employee
                    {
                        EmployeeId = (Convert.ToInt32(sqlReader["EmployeeId"])),
                        EmployeeCode = sqlReader["EmployeeCode"].ToString(),
                        FirstName = sqlReader["EmpFirstName"].ToString(),
                        LastName = sqlReader["EmpLastName"].ToString(),
                        MiddleName = sqlReader["EmpLastName"].ToString(),
                        FullName = sqlReader["EMPFULLNAME"].ToString(),
                        DateOfBirth = Convert.ToDateTime(sqlReader["EmpDateOfBirth"]),
                        DepartmentName = sqlReader["dept"].ToString(),
                        StatusName = sqlReader["statusname"].ToString(),
                        LocationName = sqlReader["loc"].ToString()
                    };
                    employeeList.Add(employee);
                }
                return employeeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
