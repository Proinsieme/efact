using eFact.BLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace efact
{
    public partial class Home : System.Web.UI.Page
    {

        int EmployeeId;
        int CasualLeave = 0;
        int SickLeave = 0;
        int MaternityLeave = 0;
        int PaternityLeave = 0;
        int MarriageLeave = 0;
        int HouseMoveLeave = 0;
        int MortalityLeave = 0;
        int SpecialLeave = 0;
        int StudyLeave = 0;

        string profileImagePath = ConfigurationManager.AppSettings["ProfilePath"].ToString();
        List<Leave> calendarDayList = null;
        public class ClsTitle
        {
            public string TitleName { get; set; }
        }

        class ClsGender
        {
            public string Gender { get; set; }
        }

        class ClsMaritalStatus
        {
            public string MaritalStatus { get; set; }
        }

        class ClsJobTitle
        {
            public int JobTitleId { get; set; }
            public string JobTitleName { get; set; }
        }

        class ClsCompanyCost
        {
            public int CompanyCostId { get; set; }
            public string CompanyCostName { get; set; }
        }

        class ClsPosition
        {
            public int PositionId { get; set; }
            public string PositionName { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
            LoadDefaultValues();
        }

        protected void RadTreeViewHumanResource_NodeClick(object sender, RadTreeNodeEventArgs e)
        {
            if (e.Node.Text == "Staff")
            {
                LoadEmployeeDetails();
                panelEmployeeDetails.Visible = false;
                panelStaff.Visible = true;
            }
            else if (e.Node.Text == "Employment Details")
            {
                panelStaff.Visible = false;
                panelEmployeeDetails.Visible = true;
                divEmployeeDetails.Visible = true;
                divEmployeeLeaveDetails.Visible = false;
            }
            else if (e.Node.Text == "Employee Assessment")
            {
                panelStaff.Visible = false;
                panelEmployeeDetails.Visible = true;
                divEmployeeDetails.Visible = false;
                divEmployeeLeaveDetails.Visible = false;
            }
            else if (e.Node.Text == "Employee Leaves")
            {
                panelStaff.Visible = false;
                panelEmployeeDetails.Visible = true;
                divEmployeeLeaveDetails.Visible = true;
                divEmployeeDetails.Visible = false;
            }
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                Employee objEmployee = new Employee();
                List<Employee> employeeList = new List<Employee>();
                employeeList = objEmployee.GetEmployeeDetails();
                if (employeeList != null && employeeList.Count != 0)
                {
                    EmployeeSearchListDataGrid.DataSource = employeeList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadDefaultValues()
        {
            try
            {
                LoadTitle();
                LoadGender();
                LoadMartialStatus();
                LoadLanguage();
                LoadEmployeeStatus();
                LoadEmploymentType();
                LoadNationality();
                LoadDepartment();
                LoadLocation();
                LoadGrade();
                LoadMentor();
                LoadEducationType();
                LoadDocumentType();
                LoadInsuranceCompany();
                LoadPosition();
                LoadJobTitle();
                LoadCompanyCost();
                LoadCurrency();
                //LoadLeaveTypes();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message +"')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadCompanyCost()
        {
            ObservableCollection<ClsCompanyCost> companyCostObsColl = new ObservableCollection<ClsCompanyCost>();
            try
            {
                companyCostObsColl.Add(new ClsCompanyCost { CompanyCostId = 1, CompanyCostName = "Company Cost 1" });
                companyCostObsColl.Add(new ClsCompanyCost { CompanyCostId = 2, CompanyCostName = "Company Cost 2" });
                cbxCompanyCostCentre.DataSource = companyCostObsColl;
                cbxCompanyCostCentre.DataTextField = "CompanyCostName";
                cbxCompanyCostCentre.DataValueField = "CompanyCostId";
                cbxCompanyCostCentre.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadJobTitle()
        {
            ObservableCollection<ClsJobTitle> jobTitleObsColl = new ObservableCollection<ClsJobTitle>();
            try
            {
                jobTitleObsColl.Add(new ClsJobTitle { JobTitleId = 1, JobTitleName = "Title 1" });
                jobTitleObsColl.Add(new ClsJobTitle { JobTitleId = 2, JobTitleName = "Title 2" });
                cbxAssignmentJobTitle.DataSource = jobTitleObsColl;
                cbxAssignmentJobTitle.DataTextField = "JobTitleName";
                cbxAssignmentJobTitle.DataValueField = "JobTitleId";
                cbxAssignmentJobTitle.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadPosition()
        {
            ObservableCollection<ClsPosition> positionObsColl = new ObservableCollection<ClsPosition>();
            try
            {
                positionObsColl.Add(new ClsPosition { PositionId = 1, PositionName = "Position 1" });
                positionObsColl.Add(new ClsPosition { PositionId = 2, PositionName = "Position 2" });
                cbxAssignmentPosition.DataSource = positionObsColl;
                cbxAssignmentPosition.DataTextField = "PositionName";
                cbxAssignmentPosition.DataValueField = "PositionId";
                cbxAssignmentPosition.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadCurrency()
        {
            Currency objCurrency = new Currency();
            List<Currency> currencyList = new List<Currency>();
            try
            {
                currencyList = objCurrency.GetCurrencyDetails();

                if (currencyList != null && currencyList.Count != 0)
                {
                    cbxCurrency.DataSource = currencyList;
                    cbxCurrency.DataTextField = "CurrencyName";
                    cbxCurrency.DataValueField = "CurrencyId";
                    cbxCurrency.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadInsuranceCompany()
        {
            Insurance objInsurance = new Insurance();
            List<Insurance> insuranceList = new List<Insurance>();
            try
            {
                insuranceList = objInsurance.GetInsuranceDetails();

                if (insuranceList != null && insuranceList.Count != 0)
                {
                    cbxInsuranceCompany.DataSource = insuranceList;
                    cbxInsuranceCompany.DataTextField = "InsuranceCompanyName";
                    cbxInsuranceCompany.DataValueField = "InsuranceId";
                    cbxInsuranceCompany.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadDocumentType()
        {
            DocumentType objDocumentType = new DocumentType();
            List<DocumentType> documentTypeList = new List<DocumentType>();
            try
            {
                documentTypeList = objDocumentType.GetDocumentType();

                if (documentTypeList != null && documentTypeList.Count != 0)
                {
                    cbxDocumentType.DataSource = documentTypeList;
                    cbxDocumentType.DataTextField = "DocumentTypeName";
                    cbxDocumentType.DataValueField = "DocumentTypeId";
                    cbxDocumentType.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadEducationType()
        {
            EducationType objEducationType = new EducationType();
            List<EducationType> educationTypeList = new List<EducationType>();
            try
            {
                educationTypeList = objEducationType.GetEducationType();

                if (educationTypeList != null && educationTypeList.Count != 0)
                {
                    cbxEducationType.DataSource = educationTypeList;
                    cbxEducationType.DataTextField = "EducationTypeName";
                    cbxEducationType.DataValueField = "EducationTypeId";
                    cbxEducationType.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadMentor()
        {
            Employee objEmployee = new Employee();
            List<Employee> employeeList = new List<Employee>();
            try
            {
                employeeList = objEmployee.GetEmployeeDetails();

                cbxAssignmentMentor.DataSource = employeeList;
                cbxAssignmentMentor.DataTextField = "FullName";
                cbxAssignmentMentor.DataValueField = "EmployeeId";
                cbxAssignmentMentor.DataBind();

                cbxAssignmentSupervisor.DataSource = employeeList;
                cbxAssignmentSupervisor.DataTextField = "FullName";
                cbxAssignmentSupervisor.DataValueField = "EmployeeId";
                cbxAssignmentSupervisor.DataBind();

                /* Add for leave registration 
                cboEmpSupervisor.DataSource = employeeList;
                cboEmpSupervisor.DisplayMemberPath = "FullName";   

                cbxAppraisedBy.DataSource = employeeList;
                cbxAppraisedBy.DisplayMemberPath = "FullName";

                cbxReviewedBy.DataSource = employeeList;
                cbxReviewedBy.DisplayMemberPath = "FullName";    */
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadGrade()
        {
            Grade objGrade = new Grade();
            List<Grade> gradeList = new List<Grade>();
            try
            {
                gradeList = objGrade.GetEmpGrade();

                if (gradeList != null && gradeList.Count != 0)
                {
                    cbxAssignmentGrade.DataSource = gradeList;
                    cbxAssignmentGrade.DataTextField = "GradeName";
                    cbxAssignmentGrade.DataValueField = "GradeId";
                    cbxAssignmentGrade.DataBind();

                    cbxSalaryGrade.DataSource = gradeList;
                    cbxSalaryGrade.DataTextField = "GradeName";
                    cbxSalaryGrade.DataValueField = "GradeId";
                    cbxSalaryGrade.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadLocation()
        {
            Location objLocation = new Location();
            List<Location> locationList = new List<Location>();
            try
            {
                locationList = objLocation.GetLocation();

                if (locationList != null && locationList.Count != 0)
                {
                    cbxAssignmentLocation.DataSource = locationList;
                    cbxAssignmentLocation.DataTextField = "LocationName";
                    cbxAssignmentLocation.DataValueField = "LocationId";
                    cbxAssignmentLocation.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadDepartment()
        {
            Department objDepartment = new Department();
            List<Department> departmentList = new List<Department>();
            try
            {
                departmentList = objDepartment.GetDepartment();

                if (departmentList != null && departmentList.Count != 0)
                {
                    cbxAssignmentDepartmentName.DataSource = departmentList;
                    cbxPrincipleDepartment.DataSource = departmentList;
                    cbxPrincipleRelationDepartment.DataSource = departmentList;
                    cbxPrincipleRelationDepartment.DataBind();

                    cbxAssignmentDepartmentName.DataTextField = "DepartmentName";
                    cbxPrincipleDepartment.DataTextField = "DepartmentName";
                    cbxPrincipleRelationDepartment.DataTextField = "DepartmentName";
                    cbxPrincipleRelationDepartment.DataBind();

                    cbxAssignmentDepartmentName.DataValueField = "DepartmentId";
                    cbxPrincipleDepartment.DataValueField = "DepartmentId";
                    cbxPrincipleRelationDepartment.DataValueField = "DepartmentId";
                    cbxPrincipleRelationDepartment.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadNationality()
        {
            Nationality objNationality = new Nationality();
            List<Nationality> nationalityList = new List<Nationality>();
            try
            {
                nationalityList = objNationality.GetNationality();
                if (nationalityList != null & nationalityList.Count != 0)
                {
                    cbxNationality1.DataSource = nationalityList;
                    cbxNationality2.DataSource = nationalityList;

                    cbxNationality1.DataTextField = "NationalityName";
                    cbxNationality2.DataTextField = "NationalityName";

                    cbxNationality1.DataValueField = "NationalityId";
                    cbxNationality2.DataValueField = "NationalityId";

                    cbxNationality1.DataBind();
                    cbxNationality2.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadEmploymentType()
        {
            EmploymentType objEmploymentType = new EmploymentType();
            List<EmploymentType> employmentTypeList = new List<EmploymentType>();
            try
            {
                employmentTypeList = objEmploymentType.GetEmploymentType();

                if (employmentTypeList != null && employmentTypeList.Count != 0)
                {
                    cbxEmploymentType.DataSource = employmentTypeList;
                    cbxEmploymentType.DataTextField = "EmploymentTypeName";
                    cbxEmploymentType.DataValueField = "EmploymentTypeId";
                    cbxEmploymentType.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadEmployeeStatus()
        {
            Status objStatus = new Status();
            List<Status> statusList = new List<Status>();
            try
            {
                statusList = objStatus.GetEmployeeStatus();

                if (statusList != null && statusList.Count != 0)
                {
                    cbxEmploymentStatus.DataSource = statusList;
                    cbxEmploymentStatus.DataTextField = "StatusName";
                    cbxEmploymentStatus.DataValueField = "StatusId";
                    cbxEmploymentStatus.DataBind();
                }
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadLanguage()
        {
            eFact.BLL.Language objLanguage = new eFact.BLL.Language();
            List<Language> languageList = new List<Language>();
            ObservableCollection<Language> languageObsColl = new ObservableCollection<Language>();
            try
            {
                languageList = objLanguage.GetLanguage();

                if (languageList != null && languageList.Count != 0)
                {
                    foreach (var item in languageList)
                    {
                        languageObsColl.Add(item);
                    }
                    cbxPrimaryLanguage.DataSource = languageObsColl;
                    cbxPrimaryLanguage.DataTextField = "LanguageName";
                    cbxPrimaryLanguage.DataValueField = "LanguageId";
                    cbxPrimaryLanguage.DataBind();

                    cbxSecondaryLanguage.DataSource = languageObsColl;
                    cbxSecondaryLanguage.DataTextField = "LanguageName";
                    cbxSecondaryLanguage.DataValueField = "LanguageId";
                    cbxSecondaryLanguage.DataBind();
                }

            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadGender()
        {
            ObservableCollection<ClsGender> genderObsColl = new ObservableCollection<ClsGender>();
            try
            {
                genderObsColl.Add(new ClsGender { Gender = "Male" });
                genderObsColl.Add(new ClsGender { Gender = "Female" });
                cbxGender.DataSource = genderObsColl;
                cbxGender.DataTextField = "Gender";
                cbxGender.DataValueField = "Gender";
                cbxGender.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadMartialStatus()
        {
            ObservableCollection<ClsMaritalStatus> maritalStatusObsColl = new ObservableCollection<ClsMaritalStatus>();
            try
            {
                maritalStatusObsColl.Add(new ClsMaritalStatus { MaritalStatus = "Married" });
                maritalStatusObsColl.Add(new ClsMaritalStatus { MaritalStatus = "Single" });
                cbxMartialStatus.DataSource = maritalStatusObsColl;
                cbxMartialStatus.DataTextField = "MaritalStatus";
                cbxMartialStatus.DataValueField = "MaritalStatus";
                cbxMartialStatus.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        private void LoadTitle()
        {
            ObservableCollection<ClsTitle> titleObsColl = new ObservableCollection<ClsTitle>();
            try
            {
                titleObsColl.Add(new ClsTitle { TitleName = "Mr" });
                titleObsColl.Add(new ClsTitle { TitleName = "Mrs" });
                titleObsColl.Add(new ClsTitle { TitleName = "Madam" });
                titleObsColl.Add(new ClsTitle { TitleName = "Lady" });
                cbxTitle.DataSource = titleObsColl;
                cbxTitle.DataTextField = "TitleName";
                cbxTitle.DataValueField = "TitleName";
                cbxTitle.DataBind();
            }
            catch (Exception ex)
            {
                string strException = "alert('Exception : " + ex.Message + "')";
                ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
            }
        }

        //private void LoadLeaveTypes()
        //{
        //    Leave objLeave = new Leave();
        //    List<Leave> leaveList = new List<Leave>();
        //    try
        //    {
        //        leaveList = objLeave.GetLeaveType();

        //        if (leaveList != null && leaveList.Count != 0)
        //        {
        //            cbxLeaveType.ItemsSource = leaveList;
        //            cbxLeaveType.DisplayMemberPath = "LeaveType";

        //            foreach (Leave item in leaveList)
        //            {
        //                if (item.LeaveType.Trim() == "Cassual Leave")
        //                {
        //                    CasualLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Sick Leave")
        //                {
        //                    SickLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Maternity Leave")
        //                {
        //                    MaternityLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Paternity Leave")
        //                {
        //                    PaternityLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Marriage Leave")
        //                {
        //                    MarriageLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "House Move Leave")
        //                {
        //                    HouseMoveLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Mortality Leave")
        //                {
        //                    MortalityLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Special Leave")
        //                {
        //                    SpecialLeave = item.NoOfDays;
        //                }
        //                else if (item.LeaveType.Trim() == "Study Leave")
        //                {
        //                    StudyLeave = item.NoOfDays;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string strException = "alert('Exception : " + ex.Message + "')";
        //        ScriptManager.RegisterStartupScript(this, GetType(), "script", strException, true);
        //    }
        //}

        protected void EmployeeSearchListDataGrid_ItemCommand(object sender, GridCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                if (e.Item is GridDataItem)
                {
                    GridDataItem dataItem = e.Item as GridDataItem;
                    int selectedEmployeeId = Convert.ToInt32(dataItem["EmployeeId"].Text);
                    string selectedEmployeeCode = dataItem["EmployeeCode"].Text;
                    Session["EmployeeId"] = selectedEmployeeId;
                    //EmployeeSearchListDataGrid.Visible = false;
                    panelStaff.Visible = false;
                    panelEmployeeDetails.Visible = true;
                    divEmployeeDetails.Visible = true;
                    divEmployeeLeaveDetails.Visible = false;
                    LoadEmployeeDetailsByEmployeeId(selectedEmployeeId);
                }
            }
        }

        private void LoadEmployeeDetailsByEmployeeId(int selectedEmployeeId)
        {
            int employeeId;
            try
            {
                employeeId = selectedEmployeeId;
                EmployeeId = selectedEmployeeId;
                txbEmployeeId.Text = employeeId.ToString();
                Employee objEmployee = new Employee();
                List<Employee> employeeList = new List<Employee>();
                List<Employee> emergencyContactList = new List<Employee>();
                List<Interview> interviewList = new List<Interview>();
                List<EmpPrinciples> principleList = new List<EmpPrinciples>();
                List<Salary> salaryList = new List<Salary>();
                List<Identification> identificationList = new List<Identification>();
                List<Reference> referenceList = new List<Reference>();
                employeeList = objEmployee.GetEmployeeDetailsByEmployeeId(employeeId, out emergencyContactList, out interviewList, out principleList, out salaryList, out identificationList, out referenceList);
                if (employeeList != null && employeeList.Count != 0)
                {
                    txtEmployeeCode.Text = employeeList[0].EmployeeCode.ToString();
                    txtFirstName.Text = employeeList[0].FirstName.Trim();
                    txtMiddleName.Text = employeeList[0].MiddleName.Trim();
                    txtLastName.Text = employeeList[0].LastName.Trim();
                    cbxPrefix.Text = employeeList[0].Prefix.Trim();
                    cbxSuffix.Text = employeeList[0].Suffix.Trim();
                    cbxMartialStatus.Text = employeeList[0].MartialStatus.Trim();
                    cbxGender.Text = employeeList[0].Gender.Trim();
                    cbxTitle.Text = employeeList[0].Title.Trim();
                    dpBirthDate.SelectedDate = Convert.ToDateTime(employeeList[0].DateOfBirth);
                    //dpBirthDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    dpRetirementDate.SelectedDate = Convert.ToDateTime(employeeList[0].RetirementDate);
                    //dpRetirementDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    txtCountryofBirth.Text = employeeList[0].CountryOfBirth.Trim();
                    txtTownofBirth.Text = employeeList[0].TownOfBirth.Trim();
                    cbxPrimaryLanguage.SelectedValue = Convert.ToString(employeeList[0].PrimaryLanguageId);
                    cbxSecondaryLanguage.SelectedValue = Convert.ToString(employeeList[0].SecondaryLanguageId);
                    cbxNationality1.SelectedValue = Convert.ToString(employeeList[0].Nationality1Id);
                    cbxNationality2.SelectedValue = Convert.ToString(employeeList[0].Nationality2Id);
                    if (dpBirthDate.SelectedDate != null)
                    {
                        txtAge.Text = AgeCalculation(Convert.ToDateTime(employeeList[0].DateOfBirth));
                        txtRetireDue.Text = RetirementCalculation(dpRetirementDate.SelectedDate.Value);
                    }

                    /* Employment Details */
                    //cbxEmploymentStatus.SelectedItem = ((List<Status>)cbxEmploymentStatus.DataSource).FirstOrDefault(item => item.StatusId == employeeList[0].EmploymentStatusId);
                    cbxEmploymentType.SelectedValue = Convert.ToString(employeeList[0].EmploymentTypeId);
                    txtNoofContracts.Text = employeeList[0].NoofContracts.ToString();
                    if (employeeList[0].IsdefinitiveContract == true)
                    {
                        chkIsdefinitiveContract.Checked = true;
                    }
                    else
                    {
                        chkIsdefinitiveContract.Checked = false;
                    }
                    if (employeeList[0].ReHire == true)
                    {
                        chkRehire.Checked = true;
                    }
                    else
                    {
                        chkRehire.Checked = false;
                    }
                    if (employeeList[0].OriginalHireDate != null && employeeList[0].OriginalHireDate != "")
                    {
                        dpOriginalHireDate.SelectedDate = Convert.ToDateTime(employeeList[0].OriginalHireDate);
                    }
                    else
                    {
                        dpOriginalHireDate.SelectedDate = null;
                    }
                    //dpOriginalHireDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    if (employeeList[0].ProbationHireDate != null && employeeList[0].ProbationHireDate != "")
                    {
                        if (employeeList[0].ProbationHireDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpProbationEndDate.SelectedDate = Convert.ToDateTime(employeeList[0].ProbationHireDate);
                        }
                        else
                        {
                            dpProbationEndDate.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpProbationEndDate.SelectedDate = null;
                    }
                    //dpProbationEndDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    if (employeeList[0].ContractEndDate != null && employeeList[0].ContractEndDate != "")
                    {
                        if (employeeList[0].ContractEndDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpContractEndDate.SelectedDate = Convert.ToDateTime(employeeList[0].ContractEndDate);
                        }
                        else
                        {
                            dpContractEndDate.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpContractEndDate.SelectedDate = null;
                    }
                    //dpContractEndDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    txtRecruitmentCompany.Text = employeeList[0].RecruitmentCompany;
                    txtEducationInstitution.Text = employeeList[0].EducationInsitution;
                    if (employeeList[0].EduStartDate != null && employeeList[0].EduStartDate != "")
                    {
                        if (employeeList[0].EduStartDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpEducationStartDate.SelectedDate = Convert.ToDateTime(employeeList[0].EduStartDate);
                        }
                        else
                        {
                            dpEducationStartDate.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpEducationStartDate.SelectedDate = null;
                    }
                    //dpEduStartDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    if (employeeList[0].EduEndDate != null && employeeList[0].EduEndDate != "")
                    {
                        if (employeeList[0].EduEndDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpEducationEndDate.SelectedDate = Convert.ToDateTime(employeeList[0].EduEndDate);
                        }
                        else
                        {
                            dpEducationEndDate.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpEducationEndDate.SelectedDate = null;
                    }
                    //dpEduEndDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    if (File.Exists(employeeList[0].ProfileImagePath))
                    {
                        if (employeeList[0].ProfileImagePath != "")
                        {
                            imgProfileImage.ImageUrl = employeeList[0].ProfileImagePath;
                            txbProfileImagePath.Text = employeeList[0].ProfileImagePath;
                        }
                    }
                    else
                    {
                        imgProfileImage.ImageUrl = profileImagePath + "\\default.jpg";
                    }

                    /* Working Hours */
                    txtMonStartTime.Text = employeeList[0].MonStartTime;
                    txtMonEndTime.Text = employeeList[0].MonEndTime;
                    if (employeeList[0].MonFlag == true)
                    {
                        chkIsMonday.Checked = true;
                    }
                    else
                    {
                        chkIsMonday.Checked = false;
                    }
                    txtTuesStartTime.Text = employeeList[0].TueStartTime;
                    txtTuesEndTime.Text = employeeList[0].TueEndTime;
                    if (employeeList[0].TueFlag == true)
                    {
                        chkIsTuesday.Checked = true;
                    }
                    else
                    {
                        chkIsTuesday.Checked = false;
                    }
                    txtWedStartTime.Text = employeeList[0].WedStartTime;
                    txtWedEndTime.Text = employeeList[0].WedEndTime;
                    if (employeeList[0].WedFlag == true)
                    {
                        chkIsWednesday.Checked = true;
                    }
                    else
                    {
                        chkIsWednesday.Checked = false;
                    }
                    txtThurStartTime.Text = employeeList[0].ThurEndTime;
                    txtThursEndtime.Text = employeeList[0].ThurEndTime;
                    if (employeeList[0].MonFlag == true)
                    {
                        chkIsThursday.Checked = true;
                    }
                    else
                    {
                        chkIsThursday.Checked = false;
                    }
                    txtFidayStartTime.Text = employeeList[0].FriStartTime;
                    txtFridayEndTime.Text = employeeList[0].FriEndTime;
                    if (employeeList[0].FriFlag == true)
                    {
                        chkIsFriday.Checked = true;
                    }
                    else
                    {
                        chkIsFriday.Checked = false;
                    }
                    txtSatStartTime.Text = employeeList[0].SatStartTime;
                    txtSatEndTime.Text = employeeList[0].SatEndTime;
                    if (employeeList[0].SatFlag == true)
                    {
                        chkIsSaturday.Checked = true;
                    }
                    else
                    {
                        chkIsSaturday.Checked = false;
                    }
                    txtSunStartTime.Text = employeeList[0].SunStartTime;
                    txtSunEndTime.Text = employeeList[0].SunEndTime;
                    if (employeeList[0].SunFlag == true)
                    {
                        chkIsSunday.Checked = true;
                    }
                    else
                    {
                        chkIsSunday.Checked = false;
                    }

                    /* Assignment */

                    cbxCompanyCostCentre.SelectedValue = Convert.ToString(employeeList[0].CompanyCostCentreId);
                    cbxAssignmentDepartmentName.SelectedValue = Convert.ToString(employeeList[0].Department);
                    cbxAssignmentLocation.SelectedValue = Convert.ToString(employeeList[0].Location);
                    cbxAssignmentJobTitle.SelectedValue = Convert.ToString(employeeList[0].JobTitle);
                    cbxAssignmentPosition.SelectedValue = Convert.ToString(employeeList[0].Position);
                    cbxAssignmentSupervisor.SelectedValue = Convert.ToString(employeeList[0].Supervisor);
                    cbxAssignmentMentor.SelectedValue = Convert.ToString(employeeList[0].Mentor);
                    cbxAssignmentGrade.SelectedValue = Convert.ToString(employeeList[0].Grade);

                    /* Communication */

                    txtPermAddress.Text = employeeList[0].PermAddress.Trim();
                    txtPermNo.Text = employeeList[0].PermNo.ToString();
                    txtPermZipCode.Text = employeeList[0].PermZipCode.ToString();
                    txtPermCity.Text = employeeList[0].PermCity.Trim();
                    txtPermProvince.Text = employeeList[0].PermProvience.Trim();
                    txtPermCountry.Text = employeeList[0].PermCountry.Trim();
                    txtPermTelephone.Text = employeeList[0].PermPhoneNo.Trim();
                    if (employeeList[0].PermSinceDate != null && employeeList[0].PermSinceDate != "")
                    {
                        if (employeeList[0].PermSinceDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpPermSince.SelectedDate = Convert.ToDateTime(employeeList[0].PermSinceDate);
                        }
                        else
                        {
                            dpPermSince.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpPermSince.SelectedDate = null;
                    }
                    //dpPermSince.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    txtTempAddress.Text = employeeList[0].TempAddress.Trim();
                    txtTempNo.Text = employeeList[0].TempNo.ToString();
                    txtTempZipCode.Text = employeeList[0].TempZipCode.ToString();
                    txtTempCity.Text = employeeList[0].TempCity.Trim();
                    txtTempProvince.Text = employeeList[0].TempProvience.Trim();
                    txtTempCountry.Text = employeeList[0].TempCountry.Trim();
                    txtTempTelephone.Text = employeeList[0].TempPhoneNo.Trim();
                    if (employeeList[0].TempSinceDate != null && employeeList[0].TempSinceDate != "")
                    {
                        if (employeeList[0].TempSinceDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpTempSince.SelectedDate = Convert.ToDateTime(employeeList[0].TempSinceDate);
                        }
                        else
                        {
                            dpTempSince.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpTempSince.SelectedDate = null;
                    }
                    //dpTempSince.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    txtMobilePrivate.Text = employeeList[0].PrivateMobile.Trim();
                    txtEmailPrivate.Text = employeeList[0].PrivateEmail.Trim();
                    txtMobileCompany.Text = employeeList[0].CompanyMobile.Trim();
                    txtEmailCompany.Text = employeeList[0].CompanyEmail.Trim();
                    txtTwitter.Text = employeeList[0].Twitter.Trim();
                    txtLinkedInProfile.Text = employeeList[0].LinkedIn.Trim();

                    /* Medical Details */
                    txtBloodGroup.Text = employeeList[0].BloodGroup.Trim();
                    txtMedPhysicalName.Text = employeeList[0].PhysicianName.Trim();
                    txtMedPhysicianPhoneNo.Text = employeeList[0].PhysicianPhone.Trim();
                    txtMedPharmacyName.Text = employeeList[0].PharmacyName.Trim();
                    txtMedPharmacyPhoneNo.Text = employeeList[0].PharmacyPhone.Trim();
                    cbxInsuranceCompany.SelectedValue = Convert.ToString(employeeList[0].HealthInsuranceCompanyId);
                    txtMedInsuranceNumber.Text = employeeList[0].HealthInsuranceNumber.Trim();
                    if (employeeList[0].IsCollectiveScheme == true)
                    {
                        chkCollectiveScheme.Checked = true;
                    }
                    else
                    {
                        chkCollectiveScheme.Checked = false;
                    }
                    txtMedicalDataNotes.Text = employeeList[0].MedicalComment;
                    /* Emergency Contact */

                    if (emergencyContactList.Count == 1 || emergencyContactList.Count == 2)
                    {
                        txtPriDetailId.Text = emergencyContactList[0].PriDetailId.ToString();
                        txtPriContactName.Text = emergencyContactList[0].PriContractName;
                        txtPriRelation.Text = emergencyContactList[0].PriContractRelation;
                        txtPriAddress.Text = emergencyContactList[0].PriContractAddress;
                        txtPriHomePhoneNo.Text = emergencyContactList[0].PriContractHomePhone;
                        txtPriWorkPhone.Text = emergencyContactList[0].PriContractWorkPhone;
                        txtPriMobile.Text = emergencyContactList[0].PriContractMobilePhone;
                    }
                    if (emergencyContactList.Count == 2)
                    {
                        txtSecDetailId.Text = emergencyContactList[1].PriDetailId.ToString();
                        txtSecContactName.Text = emergencyContactList[1].PriContractName;
                        txtSecRelation.Text = emergencyContactList[1].PriContractRelation;
                        txtSecAddress.Text = emergencyContactList[1].PriContractAddress;
                        txtSecHomePhoneNo.Text = emergencyContactList[1].PriContractHomePhone;
                        txtSecWorkPhone.Text = emergencyContactList[1].PriContractWorkPhone;
                        txtSecMobile.Text = emergencyContactList[1].PriContractMobilePhone;
                    }

                    /* Interview Details */
                    if (interviewList[0].InterviewDate != null && interviewList[0].InterviewDate != "")
                    {
                        if (interviewList[0].InterviewDate.ToString() != "1/1/1900 12:00:00 AM")
                        {
                            dpInterviewDate.SelectedDate = Convert.ToDateTime(interviewList[0].InterviewDate);
                        }
                        else
                        {
                            dpInterviewDate.SelectedDate = null;
                        }
                    }
                    else
                    {
                        dpInterviewDate.SelectedDate = null;
                    }

                    //dpInterviewDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    txtInterviewSource.Text = interviewList[0].InterviewSource;
                    txtInterviewerName.Text = interviewList[0].InterviewerName;
                    txtInterviewComments.Text = interviewList[0].Comments;
                    if (interviewList[0].IsBKR == true)
                    {
                        chkBKR.Checked = true;
                    }
                    else
                    {
                        chkBKR.Checked = false;
                    }
                    if (interviewList[0].IsGoodConduct == true)
                    {
                        chkGoodConduct.Checked = true;
                    }
                    else
                    {
                        chkGoodConduct.Checked = false;
                    }
                    if (interviewList[0].IsMunicipalRecords == true)
                    {
                        chkMunicipalRecords.Checked = true;
                    }
                    else
                    {
                        chkMunicipalRecords.Checked = false;
                    }

                    /* Principle Details */
                    if (principleList[0].IsInsider == true)
                    {
                        chkInsider.Checked = true;
                    }
                    else
                    {
                        chkInsider.Checked = false;
                    }
                    cbxPrincipleDepartment.SelectedValue = Convert.ToString(principleList[0].InsiderDepartmentId);
                    cbxPrincipleRelationDepartment.SelectedValue = Convert.ToString(principleList[0].RelavtiveDepartmentId);
                    //txtPrincipleRelation.Text = principleList[0].Relation;
                    //txtPrincipleRelationName.Text = principleList[0].RelavtiveName;

                    ///* Salary Details */
                    //cbxCurrency.SelectedValue = ((List<Currency>)cbxCurrency.ItemsSource).FirstOrDefault(item => item.CurrencyId == salaryList[0].CurrencyId);
                    //txtHourRate.Text = salaryList[0].HourRate;
                    //txtMonthlySalary.Text = salaryList[0].MonthlySalary;
                    //cbxPaymentFreq.Text = salaryList[0].PaymentFreq;
                    //cbxPaymentMethod.Text = salaryList[0].PaymentMethod;
                    //cbxSalaryGrade.SelectedItem = ((List<Grade>)cbxSalaryGrade.ItemsSource).FirstOrDefault(item => item.GradeId == salaryList[0].SalaryGradeId);
                    //txtWageTax.Text = salaryList[0].WageTax;
                    //txtAccountNo.Text = salaryList[0].AccountNo;
                    //txtIBAN.Text = salaryList[0].IBAN;
                    //txtBankName.Text = salaryList[0].BankName;
                    //txtSwiftCode.Text = salaryList[0].SwiftCode;
                    //if (salaryList[0].SalaryEffectiveDate != null && salaryList[0].SalaryEffectiveDate != "")
                    //{
                    //    if (salaryList[0].SalaryEffectiveDate.ToString() != "1/1/1900 12:00:00 AM")
                    //    {
                    //        dpSalaryEfectiveDate.SelectedDate = Convert.ToDateTime(salaryList[0].SalaryEffectiveDate);
                    //    }
                    //    else
                    //    {
                    //        dpSalaryEfectiveDate.SelectedDate = null;
                    //    }
                    //}
                    //else
                    //{
                    //    dpSalaryEfectiveDate.SelectedDate = null;
                    //}
                    //dpSalaryEfectiveDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };

                    //txtMobileLimit.Text = salaryList[0].MobileLimit;
                    //txtMonthlyConveyance.Text = salaryList[0].Conveyance;
                    //txtSpecialAllowance.Text = salaryList[0].SpecialAllowance;
                    //txtLunchAllowance.Text = salaryList[0].LunchAllowance;
                    //txtHouseRentAllowance.Text = salaryList[0].HouseRentAllowance;

                    //if (salaryList[0].IsRule == true)
                    //{
                    //    rbxRuleYes.Checked = true;
                    //    if (salaryList[0].RuleStartDate != null && salaryList[0].RuleStartDate != "")
                    //    {
                    //        dpRuleStartDate.SelectedDate = Convert.ToDateTime(salaryList[0].RuleStartDate);
                    //    }
                    //    if (salaryList[0].RuleEndDate != null && salaryList[0].RuleEndDate != "")
                    //    {
                    //        dpRuleEndDate.SelectedDate = Convert.ToDateTime(salaryList[0].RuleEndDate);
                    //    }
                    //    dpRuleStartDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //    dpRuleEndDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //}

                    //else
                    //{
                    //    rbxRuleNo.Checked = true;
                    //    dpRuleStartDate.SelectedDate = null;
                    //    dpRuleEndDate.SelectedDate = null;
                    //}

                    ///* Identification Details */

                    //if (identificationList.Count == 1 || identificationList.Count == 3)
                    //{
                    //    txtIdentificationId1.Text = identificationList[0].IdentificationId.ToString();
                    //    cbxNat1IdentificationType.Text = identificationList[0].IdentificationType;
                    //    txtNat1IdentificationNo.Text = identificationList[0].IdentificationNo;
                    //    if (identificationList[0].IssueDate != null && identificationList[0].IssueDate != "")
                    //    {
                    //        if (identificationList[0].IssueDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpNat1IdentificationIssueDate.SelectedDate = Convert.ToDateTime(identificationList[0].IssueDate);
                    //        }
                    //        else
                    //        {
                    //            dpNat1IdentificationIssueDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpNat1IdentificationIssueDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //    if (identificationList[0].IssueDate != null && identificationList[0].IssueDate != "")
                    //    {
                    //        if (identificationList[0].ExpireDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpNat1IdentificationExpireDate.SelectedDate = Convert.ToDateTime(identificationList[0].ExpireDate);
                    //        }
                    //        else
                    //        {
                    //            dpNat1IdentificationExpireDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpNat1IdentificationExpireDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //}
                    //if (identificationList.Count == 2 || identificationList.Count == 3)
                    //{
                    //    txtIdentificationId2.Text = identificationList[1].IdentificationId.ToString();
                    //    cbxNat2IdentificationType.Text = identificationList[1].IdentificationType;
                    //    txtNat2IdentificationNo.Text = identificationList[1].IdentificationNo;
                    //    if (identificationList[1].IssueDate != null && identificationList[1].IssueDate != "")
                    //    {
                    //        if (identificationList[1].IssueDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpNat2IdentificationIssueDate.SelectedDate = Convert.ToDateTime(identificationList[1].IssueDate);
                    //        }
                    //        else
                    //        {
                    //            dpNat2IdentificationIssueDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpNat2IdentificationIssueDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //    if (identificationList[1].ExpireDate != null && identificationList[1].ExpireDate != "")
                    //    {
                    //        if (identificationList[1].ExpireDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpNat2IdentificationExpireDate.SelectedDate = Convert.ToDateTime(identificationList[1].ExpireDate);
                    //        }
                    //        else
                    //        {
                    //            dpNat2IdentificationExpireDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpNat2IdentificationExpireDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //}
                    //if (identificationList.Count == 3)
                    //{
                    //    txtIdentificationId3.Text = identificationList[2].IdentificationId.ToString();
                    //    txtCategoryType.Text = identificationList[2].IdentificationType;
                    //    txtLicenceNo.Text = identificationList[2].IdentificationNo;
                    //    if (identificationList[2].IssueDate != null && identificationList[2].IssueDate != "")
                    //    {
                    //        if (identificationList[2].IssueDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpLicenceIssueDate.SelectedDate = Convert.ToDateTime(identificationList[2].IssueDate);
                    //        }
                    //        else
                    //        {
                    //            dpLicenceIssueDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpLicenceIssueDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //    if (identificationList[2].ExpireDate != null && identificationList[2].ExpireDate != "")
                    //    {
                    //        if (identificationList[2].ExpireDate.ToString() != "1/1/1900 12:00:00 AM")
                    //        {
                    //            dpLicenceExpireDate.SelectedDate = Convert.ToDateTime(identificationList[2].ExpireDate);
                    //        }
                    //        else
                    //        {
                    //            dpLicenceExpireDate.SelectedDate = null;
                    //        }
                    //    }
                    //    dpLicenceExpireDate.Culture = new CultureInfo("en-US") { DateTimeFormat = new DateTimeFormatInfo { ShortDatePattern = "dd-MMM-yyyy" } };
                    //}

                    ///* Reference Details */

                    //if (referenceList.Count == 1 || referenceList.Count == 3)
                    //{
                    //    txt1stReferenceId.Text = referenceList[0].ReferenceId.ToString();
                    //    txt1stCompanyName.Text = referenceList[0].ComapanyName.Trim();
                    //    txt1stposition.Text = referenceList[0].Position.Trim();
                    //    txt1stEmail.Text = referenceList[0].Email.Trim();
                    //    txt1stPhoneNo.Text = referenceList[0].PhoneNo.Trim();
                    //}
                    //if (referenceList.Count == 2 || referenceList.Count == 3)
                    //{
                    //    txt2ndReferenceId.Text = referenceList[1].ReferenceId.ToString();
                    //    txt2ndCompanyName.Text = referenceList[1].ComapanyName.Trim();
                    //    txt2ndposition.Text = referenceList[1].Position.Trim();
                    //    txt2ndEmail.Text = referenceList[1].Email.Trim();
                    //    txt2ndPhoneNo.Text = referenceList[1].PhoneNo.Trim();
                    //}
                    //if (referenceList.Count == 3)
                    //{
                    //    txt3rdReferenceId.Text = referenceList[2].ReferenceId.ToString();
                    //    txt3rdCompanyName.Text = referenceList[2].ComapanyName.Trim();
                    //    txt3rdposition.Text = referenceList[2].Position.Trim();
                    //    txt3rdEmail.Text = referenceList[2].Email.Trim();
                    //    txt3rdPhoneNo.Text = referenceList[2].PhoneNo.Trim();
                    //}
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception : " + ex.Message, "Error");
            }
        }

        private string RetirementCalculation(DateTime birthday)
        {
            string retirementAge;
            try
            {
                DateTime Now = birthday;
                int Years = new DateTime(birthday.Subtract(DateTime.Now).Ticks).Year - 1;
                DateTime dtPastYearDate = DateTime.Now.AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (dtPastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (dtPastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                int Days = Now.Subtract(dtPastYearDate.AddMonths(Months)).Days;
                int Hours = Now.Subtract(dtPastYearDate).Hours;
                int Minutes = Now.Subtract(dtPastYearDate).Minutes;
                int Seconds = Now.Subtract(dtPastYearDate).Seconds;
                retirementAge = string.Format(Years + " yrs and " + Months + " Months");
                return retirementAge;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string AgeCalculation(DateTime birthday)
        {
            try
            {

                DateTime Now = DateTime.Now;
                //Get Years  
                int Years = new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year - 1;
                //Get Past Year to calculate months, days and time  
                DateTime dtPastYearDate = birthday.AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (dtPastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (dtPastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                int Days = Now.Subtract(dtPastYearDate.AddMonths(Months)).Days;
                int Hours = Now.Subtract(dtPastYearDate).Hours;
                int Minutes = Now.Subtract(dtPastYearDate).Minutes;
                int Seconds = Now.Subtract(dtPastYearDate).Seconds;
                string CurrentAge = string.Format(Years + " yrs and " + Months + " Months");
                return CurrentAge;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}