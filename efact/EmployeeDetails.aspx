<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="efact.EmployeeDetails" %>

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

        <div>
            <fieldset style="width: 750px;">
                <legend>General Employee Info</legend>
                <div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblUserName" Text="Last Name" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtUserName" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblEmployeeCode" Text="Employee Code" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtEmployeeCode" />
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblMiddle" Text="Middle" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtMiddleName" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblPrimaryLanguage" Text="Primary Language" />
                        </div>
                        <div class="rightPanel">
                            <telerik:RadComboBox ID="cbxPrimaryLanguage" runat="server" Width="153px"></telerik:RadComboBox>
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblFirstName" Text="First Name" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtFirstName" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblSecondaryLanguage" Text="Secondary Language" />
                        </div>
                        <div class="rightPanel">
                            <telerik:RadComboBox ID="cbxSecondaryLanguage" runat="server" Width="153px"></telerik:RadComboBox>
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblTitle" Text="Title" />
                        </div>
                        <div class="rightPanel">
                            <telerik:RadComboBox runat="server" ID="cbxTitle" Width="100px" />
                        </div>
                        <div class="leftPanel2">
                            <asp:Label runat="server" ID="lblTownofBirth" Text="Town of Birth" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtTownofBirth" />
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblPrefix" Text="Prefix" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxPrefix" Width="100px" />
                        </div>
                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblSuffix" Text="Suffix" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxSuffix" Width="100px" />
                        </div>
                        <div style="width: 110px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblCountryofBirth" Text="Country of Birth" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtCountryofBirth" />
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblMartialStatus" Text="Martial Status" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxMartialStatus" Width="100px" />
                        </div>
                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblGender" Text="Gender" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadComboBox runat="server" ID="cbxGender" Width="100px" />
                        </div>
                        <div style="width: 110px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblNationality1" Text="Nationality 1" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtNationality1" />
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblBirthDate" Text="Birth Date" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadDatePicker runat="server" ID="dpBirthDate" Width="100px" />
                        </div>
                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblAge" Text="Age" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <asp:TextBox runat="server" ID="txtAge" Width="93px" Enabled="false" />
                        </div>
                        <div style="width: 110px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblNationality2" Text="Nationality 2" />
                        </div>
                        <div class="rightPanel">
                            <asp:TextBox runat="server" ID="txtNationality2" />
                        </div>
                    </div>
                    <div class="tag">
                        <div class="leftPanel1">
                            <asp:Label runat="server" ID="lblRetirementDate" Text="Retirement Date" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <telerik:RadDatePicker runat="server" ID="dpRetirementDate" Width="100px" />
                        </div>
                        <div style="width: 70px; text-align: right; float: left; margin-right: 10px;">
                            <asp:Label runat="server" ID="lblRetireDue" Text="Retire Due" />
                        </div>
                        <div style="width: 100px; float: left;">
                            <asp:TextBox runat="server" ID="txtRetireDue" Width="93px" Enabled="false" />
                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset style="width: 750px;margin-top:10px;">
                <legend>Employee Details</legend>
                <div>
                    <telerik:RadTabStrip ID="TabStrip1" runat="server" Skin="Simple" MultiPageID="RadMultiPag1" SelectedIndex="6" Font-Names="Calibri" Font-Size="Small" Width="95%" Align="Center">
                        <Tabs>
                            <telerik:RadTab Text="Employment"></telerik:RadTab>
                            <telerik:RadTab Text="Assignment"></telerik:RadTab>
                            <telerik:RadTab Text="Education"></telerik:RadTab>
                            <telerik:RadTab Text="Empl. Docu"></telerik:RadTab>
                            <telerik:RadTab Text="Legal & Compliance"></telerik:RadTab>
                            <telerik:RadTab Text="Salary"></telerik:RadTab>
                            <telerik:RadTab Text="Communi" Selected="True"></telerik:RadTab>
                            <%--<telerik:RadTab Text="Emergency Contacts"></telerik:RadTab>
                            <telerik:RadTab Text="Medical Data"></telerik:RadTab>--%>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPag1" runat="server" SelectedIndex="0">
                        <telerik:RadPageView ID="RadPageView1" runat="server" Height="300" Style="overflow: hidden">
                            <div style="float:left;">
                                <fieldset style="width: 280px; margin-left: 10px; margin-top: 5px;float:left;">
                                    <legend>Status</legend>
                                    <div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEmploymentStatus" Text="Employment Status" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxEmploymentStatus" Width="130px" />
                                        </div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblEmploymentType" Text="Employment Type" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadComboBox runat="server" ID="cbxEmploymentType" Width="130px" />
                                        </div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblNoofContracts" Text="No of Contracts" />
                                        </div>
                                        <div style="width: 100px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtNoofContracts" Width="30px" />
                                        </div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
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
                                <fieldset style="width: 280px; margin-left: 10px; margin-top: 5px;float:left;">
                                    <legend>Effective Dates</legend>
                                    <div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblOriginalHireDate" Text="Original Hire Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpOriginalHireDate" Width="130px" />
                                        </div>
                                         <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblProbationEndDate" Text="Probaton End Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpProbationEndDate" Width="130px" />
                                        </div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblContractEndDate" Text="Contract End Date" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <telerik:RadDatePicker runat="server" ID="dpContractEndDate" Width="130px" />
                                        </div>
                                        <div style="width: 130px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                            <asp:Label runat="server" ID="lblYearofService" Text="Year of Service" />
                                        </div>
                                        <div style="width: 140px; float: left; height: 30px;">
                                            <asp:TextBox runat="server" ID="txtYearofService" Width="130px" ReadOnly="true" />
                                        </div>
                                    </div>
                                </fieldset>
                                <fieldset style="width: 580px; margin-left: 10px; margin-top: 5px;float:left;">
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
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView2" runat="server" Height="500" Style="overflow: hidden">
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView3" runat="server" Height="500" Style="overflow: hidden">
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="RadPageView4" runat="server" Height="500" Style="overflow: hidden">
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>
                </div>
            </fieldset>
        </div>
    </div>
</asp:Content>
