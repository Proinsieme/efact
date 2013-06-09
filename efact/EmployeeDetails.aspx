<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.Master" AutoEventWireup="true"
    CodeBehind="EmployeeDetails.aspx.cs" Inherits="efact.EmployeeDetails" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <span>
        <img src="Images/efact-HR.png" />
    </span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hrContentContainer">
        <%-- <div class="hrContentBlock">
            <div id="emmployeedetails">
                <div style="text-align: left">
                    <telerik:RadToolBar ID="RadToolBar1" runat="server">
                        <Items>
                            <telerik:RadToolBarButton runat="server" ImageUrl="~/Images/Icons/New.png" Text="New">
                            </telerik:RadToolBarButton>
                            <telerik:RadToolBarButton runat="server" ImageUrl="~/Images/Icons/Save.png" Text="Save">
                            </telerik:RadToolBarButton>
                            <telerik:RadToolBarSplitButton runat="server">
                            </telerik:RadToolBarSplitButton>
                            <telerik:RadToolBarButton runat="server" ImageUrl="~/Images/Icons/About.png" Text="About">
                            </telerik:RadToolBarButton>
                        </Items>
                    </telerik:RadToolBar>
                    <br />
                    <br />
                    <div style="text-align: left; margin-left: 100px;">
                        <p>Employee details content will come here.... </p>
                        <p>| Page is under development.... |</p>
                    </div>
                </div>
                <br />
            </div>
        </div>--%>
        <div style="width: 100px;float:left">
            <fieldset style="width: 975px;">
                <legend>General Employee Info</legend>
                <div style="float: left; width: 750px;">
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblUserName" Text="Last Name" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtUserName" Width="200px" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblEmployeeCode" Text="Employee Code" />
                        </div>
                        <div class="rightPanel2">
                            <asp:TextBox runat="server" ID="txtEmployeeCode" Width="150px" />
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblMiddle" Text="Middle" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtMiddleName" Width="150px" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblPrimaryLanguage" Text="Primary Language" />
                        </div>
                        <div class="rightPanel2">
                            <telerik:RadComboBox ID="cbxPrimaryLanguage" runat="server" Width="153px">
                            </telerik:RadComboBox>
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblFirstName" Text="First Name" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtFirstName" Width="200px" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblSecondaryLanguage" Text="Secondary Language" />
                        </div>
                        <div class="rightPanel2">
                            <telerik:RadComboBox ID="cbxSecondaryLanguage" runat="server" Width="153px">
                            </telerik:RadComboBox>
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblTitle" Text="Title" />
                        </div>
                        <div class="rightPanel">
                            <telerik:RadComboBox runat="server" ID="cbxTitle" Width="100px" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblTownofBirth" Text="Town of Birth" />
                        </div>
                        <div class="rightPanel2">
                            <asp:TextBox runat="server" ID="txtTownofBirth" />
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblPrefix" Text="Prefix" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxPrefix" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblSuffix" Text="Suffix" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxSuffix" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblCountryofBirth" Text="Country of Birth" />
                        </div>
                        <div class="rightPanel2">
                            <asp:TextBox runat="server" ID="txtCountryofBirth" />
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblMartialStatus" Text="Martial Status" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxMartialStatus" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblGender" Text="Gender" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxGender" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblNationality1" Text="Nationality 1" />
                        </div>
                        <div class="rightPanel2">
                            <telerik:RadComboBox runat="server" ID="cbxNationality1" Width="153px" />
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblBirthDate" Text="Birth Date" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadDatePicker runat="server" ID="dpBirthDate" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblAge" Text="Age" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <asp:TextBox runat="server" ID="txtAge" Width="93px" Enabled="false" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblNationality2" Text="Nationality 2" />
                        </div>
                        <div class="rightPanel2">
                            <telerik:RadComboBox runat="server" ID="cbxNationality2" Width="153px" />
                        </div>
                    </div>
                    <div class="generalTag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblRetirementDate" Text="Retirement Date" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadDatePicker runat="server" ID="dpRetirementDate" Width="100px" />
                        </div>
                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblRetireDue" Text="Retire Due" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <asp:TextBox runat="server" ID="txtRetireDue" Width="93px" Enabled="false" />
                        </div>
                    </div>
                </div>
                <div style="width: 200px;float:left">
                    <asp:Image runat="server" ID="imgProfileImage" Width="200px" Height="200px" ImageUrl="~/Images/humanresources.png"/>
                </div>`
            </fieldset>
            <fieldset style="width: 975px; margin-top: 10px;">
                <legend>Employee Details</legend>
                <div>
                    <telerik:RadTabStrip ID="TabStrip1" runat="server" Skin="Simple" MultiPageID="RadMultiPag1"
                        SelectedIndex="1" Font-Names="Calibri" Font-Size="Small" Width="975px" Align="Left">
                        <Tabs>
                            <telerik:RadTab Text="Employment">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Assignment">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Education">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Empl. Documents">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Legal & Compliance">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Salary">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Communication" Selected="True">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Contacts">
                            </telerik:RadTab>
                            <telerik:RadTab Text="Medical Data">
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPag1" runat="server" SelectedIndex="0">
                        <telerik:RadPageView ID="RadPageView1" runat="server" Height="300" Style="overflow: hidden">
                            <div style="float: left; width: 605px;">
                                <fieldset style="width: 270px; margin-left: 0px; margin-top: 5px; float: left;">
                                    <legend>Status</legend>
                                    <div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEmploymentStatus" Text="Employment Status" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxEmploymentStatus" Width="130px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEmploymentType" Text="Employment Type" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxEmploymentType" Width="130px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblNoofContracts" Text="No of Contracts" />
                                        </div>
                                        <div style="width: 100px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtNoofContracts" Width="30px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblIsdefinitiveContract" Text="Isdefinitive Contract" />
                                        </div>
                                        <div style="width: 35px; float: left; height: 30px;">
                                            <asp:CheckBox runat="server" ID="chkIsdefinitiveContract" Width="30px" />
                                        </div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblRehire" Text="Re-hire" />
                                        </div>
                                        <div style="width: 35px; float: left; height: 30px;">
                                            <asp:CheckBox runat="server" ID="chkRehire" Width="30px" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 270px; margin-left: 10px; margin-top: 5px; float: left;">
                                    <legend>Effective Dates</legend>
                                    <div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblOriginalHireDate" Text="Original Hire Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpOriginalHireDate" Width="130px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblProbationEndDate" Text="Probaton End Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpProbationEndDate" Width="130px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblContractEndDate" Text="Contract End Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpContractEndDate" Width="130px" />
                                        </div>
                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblYearofService" Text="Year of Service" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtYearofService" Width="120px" ReadOnly="true" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 573px; margin-left: 0px; margin-top: 5px; float: left;">
                                    <legend>Temp Employment Info</legend>
                                    <div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblRecruitmentCompany" Text="Recruitment Company" />
                                        </div>
                                        <div style="width: 330px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtRecruitmentCompany" Width="330px" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEducationInstitution" Text="Education Institution" />
                                        </div>
                                        <div style="width: 330px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtEducationInstitution" Width="330px" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEductionStartDate" Text="Start Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpEductionStartDate" Width="130px" />
                                        </div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEducationEndDate" Text="End Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpEducationEndDate" Width="130px" />
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                            <div style="float: left; width: 350px;">
                                <fieldset style="width: 335px; margin-left: 0px; margin-top: 5px; float: left;">
                                    <legend>Working Hours</legend>
                                    <div style="width: 335px; float: left;">
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label25" Text="Dialy Break Allowance" />
                                        </div>
                                        <div style="width: 35px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox3" Width="35px" />
                                        </div>
                                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label26" Text="FTE Allocation" />
                                        </div>
                                        <div style="width: 35px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox4" Width="35px" />
                                        </div>
                                    </div>
                                    <div style="width: 335px; float: left; margin-top: 17px;">
                                        <div style="width: 80px; float: left;">
                                            <div style="width: 80px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label38" Text="" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label43" Text="Monday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label44" Text="Tuesday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label45" Text="Wednesday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label46" Text="Thursday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label47" Text="Friday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label48" Text="Saturday" /></div>
                                            <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label49" Text="Sunday" /></div>
                                        </div>
                                        <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                            <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label39" Text="Start" Font-Bold="true" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox18" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox17" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox16" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox15" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox14" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox13" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="Label56" Width="35px" /></div>
                                        </div>
                                        <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                            <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label40" Text="End" Font-Bold="true" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox19" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox20" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox21" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox22" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox23" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox24" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox25" Width="35px" /></div>
                                        </div>
                                        <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                            <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label41" Text="Total" Font-Bold="true" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox26" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox27" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox28" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox29" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox30" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox31" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:TextBox runat="server" ID="TextBox32" Width="35px" /></div>
                                        </div>
                                        <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                            <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                <asp:Label runat="server" ID="Label42" Text="" Width="35px" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox33" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox34" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox35" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox36" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox37" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox38" /></div>
                                            <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                <asp:CheckBox runat="server" ID="TextBox39" /></div>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView2" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <fieldset style="width: 935px; margin-top: 5px; float: left;">
                                    <legend>Assignment Details</legend>
                                    <div style="float: left; width: 170px;">
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label1" Text="Company Cost Centre" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblAssignmentDeptName" Text="Department Name" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label2" Text="Location" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label3" Text="Job Title" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label4" Text="Position" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label5" Text="Supervisor" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label6" Text="Mentor" />
                                        </div>
                                        <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label7" Text="Grade" />
                                        </div>
                                    </div>
                                    <div style="float: left; width: 200px;">
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxCompanyCostCentre" Width="200px" />
                                        </div>
                                        <div style="width: 400px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentDepartmentName" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentLocation" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentJobTitle" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentPosition" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentSupervisor" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentMentor" Width="200px" />
                                        </div>
                                        <div style="width: 300px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxAssignmentGrade" Width="200px" />
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView3" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <div>
                                    <fieldset style="width: 365px; margin-top: 5px; float: left;">
                                        <legend>Overview Education/Training</legend>
                                        <%--<div style="width:270px; text-align:center;">
                                            <asp:GridView ID="GridView1" runat="server" Height="150px">
                                            </asp:GridView>
                                        </div>--%>
                                    </fieldset>
                                </div>
                                <div>
                                    <fieldset style="width: 540px; margin-left: 5px; margin-top: 5px; float: left;">
                                        <legend>Education Details</legend>
                                        <div style="width: 140px; float: left; margin-left: 10px;">
                                            <div style="width: 150px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="lblEducationType" Text="Education Type" /><br />
                                            </div>
                                            <div style="width: 150px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label8" Text="Institution" /><br />
                                            </div>
                                            <div style="width: 150px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label9" Text="Qualification Name" /><br />
                                            </div>
                                            <div style="width: 150px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label10" Text="Highest Grade Optained" /><br />
                                            </div>
                                            <div style="width: 150px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label11" Text="Date Optained" />
                                            </div>
                                        </div>
                                        <div style="width: 280px; float: left;">
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <telerik:RadComboBox runat="server" ID="cbxEducationType" Width="205px" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <asp:TextBox runat="server" ID="txtInstitution" Width="200px" />
                                                <asp:Button runat="server" ID="btnSaveEducationDetails" Width="70px" Height="25px"
                                                    Text="Add" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <asp:TextBox runat="server" ID="txtQualificationName" Width="200px" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <asp:TextBox runat="server" ID="txtHighestGradeOptained" Width="200px" />
                                                <asp:Button runat="server" ID="btnDeleteEducationDetails" Width="70px" Height="25px"
                                                    Text="Delete" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <telerik:RadDatePicker runat="server" ID="dpEducationDateOptained" Width="130px" />
                                            </div>
                                        </div>
                                        <fieldset style="width: 505px; margin-left: 5px; float: left; height: 60px;">
                                            <legend>Notes</legend>
                                            <div style="width: 500px; float: left; height: 45px;">
                                                <asp:TextBox runat="server" ID="txtEducationNotes" Width="500px" Height="40px" />
                                            </div>
                                        </fieldset>
                                    </fieldset>
                                </div>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView4" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <div>
                                    <fieldset style="width: 365px; margin-top: 5px; float: left;">
                                        <legend>Overview Employee Documents</legend>
                                        <%--<div style="width:270px; text-align:center;">
                                            <asp:GridView ID="GridView1" runat="server" Height="150px">
                                            </asp:GridView>
                                        </div>--%>
                                    </fieldset>
                                </div>
                                <div>
                                    <fieldset style="width: 540px; margin-left: 5px; margin-top: 5px; float: left;">
                                        <legend>Document Details</legend>
                                        <div style="width: 110px; float: left; margin-left: 10px;">
                                            <div style="width: 110px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label12" Text="Document Type" /><br />
                                            </div>
                                            <div style="width: 110px; float: left; height: 30px;">
                                                <asp:Label runat="server" ID="Label13" Text="Document Name" /><br />
                                            </div>
                                        </div>
                                        <div style="width: 280px; float: left;">
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <telerik:RadComboBox runat="server" ID="cbxDocuementType" Width="205px" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px;">
                                                <asp:TextBox runat="server" ID="txtDocuementName" Width="200px" />
                                            </div>
                                            <div style="width: 280px; float: left; height: 30px; margin-top: 10px;">
                                                <asp:Button runat="server" ID="btnSaveDocumentDetails" Width="70px" Height="25px"
                                                    Text="Add" />
                                                <asp:Button runat="server" ID="btnDeleteDocumentDetails" Width="70px" Height="25px"
                                                    Text="Delete" />
                                            </div>
                                        </div>
                                        <fieldset style="width: 505px; margin-left: 5px; float: left; height: 140px;">
                                            <legend>Notes</legend>
                                            <div style="width: 500px; float: left; height: 100px;">
                                                <asp:TextBox runat="server" ID="txtDocuementNotes" Width="500px" Height="115px" />
                                            </div>
                                        </fieldset>
                                    </fieldset>
                                </div>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView5" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <div style="margin-top: 10px;">
                                    <telerik:RadTabStrip ID="RadTabStrip2" runat="server" Skin="Simple" MultiPageID="RadMultiPag2"
                                        SelectedIndex="0" Font-Names="Calibri" Font-Size="Small" Width="975px" Align="Left">
                                        <Tabs>
                                            <telerik:RadTab Text="Identification Details">
                                            </telerik:RadTab>
                                            <telerik:RadTab Text="Reference">
                                            </telerik:RadTab>
                                            <telerik:RadTab Text="Interview & Checks">
                                            </telerik:RadTab>
                                            <telerik:RadTab Text="Principles">
                                            </telerik:RadTab>
                                        </Tabs>
                                    </telerik:RadTabStrip>
                                    <telerik:RadMultiPage ID="RadMultiPage2" runat="server" SelectedIndex="0">
                                        <telerik:RadPageView ID="RadPageView11" runat="server" Height="300" Style="overflow: hidden">
                                            <div style="float: left;">
                                                <fieldset style="width: 280px; margin-top: 5px; float: left;">
                                                    <legend>Nationality 1</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label77" Text="Identification Type" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label82" Text="Identification No" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label83" Text="Issue Date" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label84" Text="Valid Through" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 150px; float: left;">
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadComboBox runat="server" ID="RadComboBox2" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox54" Width="130px" />
                                                        </div>
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker3" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker4" Width="130px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                            <div style="float: left;">
                                                <fieldset style="width: 280px; margin-left: 10px; margin-top: 5px; float: left;">
                                                    <legend>Nationality 2</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label78" Text="Identification Type" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label79" Text="Identification No" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label80" Text="Issue Date" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label81" Text="Valid Through" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 150px; float: left;">
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadComboBox runat="server" ID="RadComboBox3" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox53" Width="130px" />
                                                        </div>
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker5" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker6" Width="130px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                            <div style="float: left;">
                                                <fieldset style="width: 280px; margin-left: 10px; margin-top: 5px; float: left;">
                                                    <legend>Driving Licence</legend>
                                                    <div style="width: 100px; float: left;">
                                                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label85" Text="Licence No" />
                                                        </div>
                                                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label86" Text="Category Type" />
                                                        </div>
                                                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label87" Text="Issue Date" />
                                                        </div>
                                                        <div style="width: 100px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label88" Text="Valid Through" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 150px; float: left; margin-left: 10px;">
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadComboBox runat="server" ID="RadComboBox4" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox55" Width="130px" />
                                                        </div>
                                                        <div style="width: 140px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker7" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; float: left; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker8" Width="130px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                        </telerik:RadPageView>
                                        <telerik:RadPageView ID="RadPageView12" runat="server" Height="300" Style="overflow: hidden">
                                            <div style="float: left;">
                                                <fieldset style="width: 930px; margin-top: 5px; float: left;">
                                                    <legend>Referance Details</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: center; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label94" Text="" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label89" Text="Referance Name" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label90" Text="Company Name" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label91" Text="Position" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label92" Text="Email" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label93" Text="Phone" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label113" Text="Comments" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 230px; float: left;">
                                                        <div style="width: 220px; text-align: center; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label95" Text="Reference 1" Font-Bold="true" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label96" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label97" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label98" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label99" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label100" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox56" Width="200px" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 230px; float: left;">
                                                        <div style="width: 220px; text-align: center; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label101" Text="Reference 2" Font-Bold="true" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label102" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label103" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label104" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label105" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label106" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox57" Width="200px" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 230px; float: left;">
                                                        <div style="width: 220px; text-align: center; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label107" Text="Reference 3" Font-Bold="true" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label108" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label109" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label110" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label111" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label112" Width="200px" />
                                                        </div>
                                                        <div style="width: 220px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="TextBox58" Width="200px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                        </telerik:RadPageView>
                                        <telerik:RadPageView ID="RadPageView13" runat="server" Height="300" Style="overflow: hidden">
                                            <div style="float: left;">
                                                <fieldset style="width: 450px; margin-top: 5px; float: left;">
                                                    <legend>Interview Details</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label114" Text="Interview Date" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label115" Text="Source" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label116" Text="Name Interviewer" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 250px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker9" Width="130px" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label118" Width="200px" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="Label119" Width="200px" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 430px; float: left;">
                                                        <fieldset style="width: 430px; margin-top: 5px; float: left;">
                                                            <legend>Comments</legend>
                                                            <asp:TextBox runat="server" ID="txtInterviewComments" Width="420px" Height="80px" />
                                                        </fieldset>
                                                    </div>
                                                </fieldset>
                                            </div>
                                            <div style="float: left;">
                                                <fieldset style="width: 450px; margin-top: 5px; float: left; height: 230px;">
                                                    <legend>Checks</legend>
                                                    <div style="width: 200px; float: left;">
                                                        <div style="width: 200px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label117" Text="BKR" />
                                                        </div>
                                                        <div style="width: 200px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label120" Text="Certificate of Good Conduct" />
                                                        </div>
                                                        <div style="width: 200px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label121" Text="Municipal Personal Records" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 250px; float: left;">
                                                        <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:CheckBox runat="server" ID="CheckBox1" />
                                                        </div>
                                                        <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:CheckBox runat="server" ID="TextBox59" />
                                                        </div>
                                                        <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:CheckBox runat="server" ID="CheckBox2" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                        </telerik:RadPageView>
                                        <telerik:RadPageView ID="RadPageView14" runat="server" Height="300" Style="overflow: hidden">
                                            <div style="float: left;">
                                                <fieldset style="width: 450px; margin-top: 5px; float: left;">
                                                    <legend>Insider Dealing</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label122" Text="Insider" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label123" Text="Department" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 230px; float: left;">
                                                        <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:CheckBox runat="server" ID="Label124" />
                                                        </div>
                                                        <div style="width: 200px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <telerik:RadComboBox runat="server" ID="Label125" Width="200px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                            <div style="float: left;">
                                                <fieldset style="width: 450px; margin-top: 5px; float: left;">
                                                    <legend>Relation Within Company</legend>
                                                    <div style="width: 130px; float: left;">
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label126" Text="Relative Name" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label127" Text="Department" />
                                                        </div>
                                                        <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:Label runat="server" ID="Label128" Text="Relation" />
                                                        </div>
                                                    </div>
                                                    <div style="width: 230px; float: left;">
                                                        <div style="width: 230px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="CheckBox3" Width="200px" />
                                                        </div>
                                                        <div style="width: 230px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <telerik:RadComboBox runat="server" ID="RadComboBox5" Width="200px" />
                                                        </div>
                                                        <div style="width: 230px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                            <asp:TextBox runat="server" ID="CheckBox31" Width="200px" />
                                                        </div>
                                                    </div>
                                                </fieldset>
                                            </div>
                                        </telerik:RadPageView>
                                    </telerik:RadMultiPage>
                                </div>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView6" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView7" runat="server" Height="300" Style="overflow: hidden">
                            <div style="float: left;">
                                <fieldset style="width: 440px; margin-left: 10px; margin-top: 5px; float: left;">
                                    <legend>Permanent Address Details</legend>
                                    <div style="text-align: center;">
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label14" Text="Address" />
                                        </div>
                                        <div style="width: 280px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtPermAddress" Width="280px" />
                                        </div>
                                        <div style="width: 30px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label15" Text="No" />
                                        </div>
                                        <div style="width: 50px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtPermNo" Width="50px" />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label16" Text="Zip Code" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtPremZipCode" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label17" Text="City" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtPermCity" Width="160px" />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label18" Text="Province" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox1" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label19" Text="Country" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox2" Width="160px" /><br />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label20" Text="Telephone" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox5" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label21" Text="Since" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker1" Width="160px" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 440px; margin-left: 10px; margin-top: 5px; float: left;">
                                    <legend>Temporary Address Details</legend>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label22" Text="Address" />
                                        </div>
                                        <div style="width: 280px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox6" Width="280px" />
                                        </div>
                                        <div style="width: 30px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label27" Text="No" />
                                        </div>
                                        <div style="width: 50px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox7" Width="50px" />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label28" Text="Zip Code" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox8" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label29" Text="City" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox9" Width="160px" />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label30" Text="Province" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox10" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label31" Text="Country" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox11" Width="160px" /><br />
                                        </div>
                                    </div>
                                    <div>
                                        <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label32" Text="Telephone" />
                                        </div>
                                        <div style="width: 130px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox12" Width="130px" />
                                        </div>
                                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label33" Text="Since" />
                                        </div>
                                        <div style="width: 160px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="RadDatePicker2" Width="160px" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 913px; margin-left: 10px; margin-top: 5px; float: left;">
                                    <legend>Contact Details</legend>
                                    <div style="float: left; width: 100px;">
                                        <div style="text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label23" Text="Mobile Private" />
                                        </div>
                                        <div style="text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label34" Text="Email Private" />
                                        </div>
                                        <div style="text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label35" Text="Twitter" />
                                        </div>
                                    </div>
                                    <div style="float: left; width: 350px;">
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtMobilePrivate" Width="300px" /></div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtEmailPrivate" Width="300px" /></div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtTwitter" Width="300px" /></div>
                                    </div>
                                    <div style="float: left; width: 120px;">
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label24" Text="Mobile Company" /></div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label36" Text="Email Company" /></div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="Label37" Text="LinkedIn Profile" /></div>
                                    </div>
                                    <div style="float: left; width: 300px;">
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtMobileCompany" Width="300px" />
                                        </div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtEmailCompany" Width="300px" />
                                        </div>
                                        <div style="float: left; margin-right: 10px; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtLinkedInProfile" Width="300px" />
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView8" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <fieldset style="width: 450px; float: left; height: 240px; margin-top: 5px;">
                                    <legend>Primary Contact Details</legend>
                                    <div style="width: 100px; float: left; margin-top: 10px;">
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label50" Text="Name" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label52" Text="Relation" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label51" Text="Address" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label53" Text="Home Phone" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label54" Text="Work Phone" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label55" Text="Mobile" />
                                        </div>
                                    </div>
                                    <div style="width: 100px; float: left; margin-top: 10px;">
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label57" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label58" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label59" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label60" Width="150px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label61" Width="150px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="Label62" Width="150px" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 450px; margin-left: 5px; float: left; height: 240px; margin-top: 5px;">
                                    <legend>Secondary Contact Details</legend>
                                    <div style="width: 100px; float: left; margin-top: 10px;">
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label63" Text="Name" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label64" Text="Relation" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label65" Text="Address" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label66" Text="Home Phone" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label67" Text="Work Phone" />
                                        </div>
                                        <div style="width: 90px; text-align: right; float: left; height: 30px;">
                                            <asp:Label runat="server" ID="Label68" Text="Mobile" />
                                        </div>
                                    </div>
                                    <div style="width: 100px; float: left; margin-top: 10px;">
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox40" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox41" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox42" Width="250px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox43" Width="150px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox44" Width="150px" />
                                        </div>
                                        <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="TextBox45" Width="150px" />
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView9" runat="server" Height="300" Style="overflow: hidden">
                            <div class="tag">
                                <div style="float: left;">
                                    <fieldset style="width: 937px; margin-top: 5px; float: left;">
                                        <legend>Contact Details</legend>
                                        <div style="float: left; width: 120px;">
                                            <div style="text-align: right; float: right; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label69" Text="Physician Name" />
                                            </div>
                                            <div style="text-align: right; float: right; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label70" Text="Phone" />
                                            </div>
                                            <div style="text-align: right; float: right; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label71" Text="Pharmacy Name" />
                                            </div>
                                            <div style="text-align: right; float: right; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label75" Text="Phone" />
                                            </div>
                                        </div>
                                        <div style="float: left; width: 350px;">
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox46" Width="300px" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox47" Width="150px" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox48" Width="300px" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox52" Width="150px" /></div>
                                        </div>
                                        <div style="float: left; width: 180px;">
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label72" Text="Blood Group" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label73" Text="Health Insurance Company" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label74" Text="Health Insurance Number" /></div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:Label runat="server" ID="Label76" Text="Collective Scheme" /></div>
                                        </div>
                                        <div style="float: left; width: 270px;">
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox49" Width="150px" />
                                            </div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <telerik:RadComboBox runat="server" ID="RadComboBox1" Width="200px" />
                                            </div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:TextBox runat="server" ID="TextBox51" Width="270px" />
                                            </div>
                                            <div style="float: left; margin-right: 10px; height: 30px;">
                                                <asp:CheckBox runat="server" ID="TextBox50" />
                                            </div>
                                        </div>
                                    </fieldset>
                                    <fieldset style="width: 937px; margin-top: 5px; float: left;">
                                        <legend>Special Notes</legend>
                                        <asp:TextBox runat="server" ID="txtMedicalDataNotes" Height="100px" Width="930px" />
                                    </fieldset>
                                </div>
                            </div>
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>
                </div>
            </fieldset>
        </div>
    </div>
</asp:Content>
