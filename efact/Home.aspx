<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="efact.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="toolbar" style="padding-bottom: 5px;">
        <telerik:RadToolBar ID="RadToolBar1" runat="server" OnClientButtonClicking="onClientButtonClicking"
            EnableRoundedCorners="True" EnableShadows="True" Width="100%" Skin="Default" SingleClick="None">
            <Items>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/New.png"
                    Text="New" ToolTip="New">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/Save.png"
                    Text="Save" ToolTip="Save">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/Print.png"
                    Text="Print" ToolTip="Print">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/DeleteHS.png"
                    Text="Delete" ToolTip="Delete">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/Print.png"
                    Text="Print" ToolTip="Print">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/Approve16.png"
                    Text="Approve" ToolTip="Approve">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/Setting16.png"
                    Text="Setting" ToolTip="Setting">
                </telerik:RadToolBarButton>
                <telerik:RadToolBarButton ImageUrl="Images/Menu Icons/About16.png"
                    Text="About" ToolTip="About">
                </telerik:RadToolBarButton>
            </Items>
        </telerik:RadToolBar>
    </div>
    <div style="width: 170px; float: left;">
        <aside>
            <div>
                <%--<telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" LoadingPanelID="RadAjaxLoadingPanel1">--%>
                <telerik:RadTreeView ID="RadTreeViewHumanResource" runat="server" EnableDragAndDrop="true" OnNodeClick="RadTreeViewHumanResource_NodeClick"
                    OnClientContextMenuItemClicking="onClientContextMenuItemClicking" OnClientContextMenuShowing="onClientContextMenuShowing">
                    <Nodes>
                        <telerik:RadTreeNode
                            AllowEdit="false" Text="Today" NavigateUrl="EmployeeDetails.aspx">
                            <Nodes>
                                <telerik:RadTreeNode
                                    AllowEdit="false" Text="Leave Registration" ContextMenuID="EmptyFolderContextMenu">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode
                                    AllowEdit="false" Text="Overtime Reporting">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode
                                    AllowEdit="false" Text="Sick Reporting" ContextMenuID="EmptyFolderContextMenu">
                                </telerik:RadTreeNode>
                            </Nodes>
                        </telerik:RadTreeNode>
                        <telerik:RadTreeNode runat="server" Text="Organization">
                            <Nodes>
                                <telerik:RadTreeNode runat="server" Text="Management">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Organization Chart">
                                </telerik:RadTreeNode>
                            </Nodes>
                        </telerik:RadTreeNode>
                        <telerik:RadTreeNode runat="server" Text="Staff">
                            <Nodes>
                                <telerik:RadTreeNode runat="server" Text="Employment Details">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Employee Assessment">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Employee Leaves">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Employee Overtime">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Loan &amp; Advances">
                                </telerik:RadTreeNode>
                            </Nodes>
                        </telerik:RadTreeNode>
                        <telerik:RadTreeNode runat="server" Text="Staff Statistics">
                            <Nodes>
                                <telerik:RadTreeNode runat="server" Text="Employees List">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Employee Details">
                                </telerik:RadTreeNode>
                            </Nodes>
                        </telerik:RadTreeNode>
                        <telerik:RadTreeNode runat="server" Text="Maintenance">
                            <Nodes>
                                <telerik:RadTreeNode runat="server" Text="General Definitions">
                                </telerik:RadTreeNode>
                                <telerik:RadTreeNode runat="server" Text="Staff Definitions">
                                </telerik:RadTreeNode>
                            </Nodes>
                        </telerik:RadTreeNode>
                    </Nodes>
                </telerik:RadTreeView>
                <%-- </telerik:RadAjaxPanel>--%>
            </div>
        </aside>
    </div>

    <div id="hrMainBar" runat="server" style="width: 980px; float: left; height: 100%;">

        <%--<asp:Panel runat="server" ID="panelStaff">--%>
        <div id="panelStaff" runat="server">
            <telerik:RadGrid ID="EmployeeSearchListDataGrid" runat="server" Width="100%" CellSpacing="0" GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="false" OnItemCommand="EmployeeSearchListDataGrid_ItemCommand">
                <ClientSettings>
                    <Selecting AllowRowSelect="True" />
                </ClientSettings>
                <MasterTableView>
                    <CommandItemSettings ShowExportToPdfButton="True" />
                    <Columns>
                        <telerik:GridTemplateColumn>
                            <ItemTemplate>
                                <telerik:RadButton runat="server" ID="btnSelectGridItem" CommandName="Select"
                                    AutoAdjustImageControlSize="false" Height="32px" Width="32px" Image-EnableImageButton="true" Image-ImageUrl="~/Images/Icons/Select.png"
                                    AlternateText="Select the Employee">
                                </telerik:RadButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="EmployeeId" FilterControlAltText="Filter TemplateColumn column" HeaderText="Employee Id" UniqueName="EmployeeId" Visible="true">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="EmployeeCode" FilterControlAltText="Filter TemplateColumn column" HeaderText="Empl. Code" UniqueName="EmployeeCode">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="FullName" FilterControlAltText="Filter TemplateColumn column" HeaderText="Employee Name" UniqueName="FullName">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="DateOfBirth" DataFormatString="{0:dd MMM yyyy}" FilterControlAltText="Filter TemplateColumn column" HeaderText="Date of Birth" UniqueName="DateOfBirth">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="DepartmentName" FilterControlAltText="Filter TemplateColumn column" HeaderText="Department" UniqueName="DepartmentName">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="LocationName" FilterControlAltText="Filter TemplateColumn column" HeaderText="Location" UniqueName="LocationName">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="EmplRelCode" FilterControlAltText="Filter TemplateColumn column" HeaderText="Rel. Code" UniqueName="EmplRelCode">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="StatusName" FilterControlAltText="Filter TemplateColumn column" HeaderText="Status" UniqueName="StatusName">
                        </telerik:GridBoundColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
        </div>
        <%--</asp:Panel>--%>

        <%--<asp:Panel runat="server" ID="panelEmployeeDetails" Visible="false">--%>
        <div id="panelEmployeeDetails" runat="server" visible="false">
            <div class="hrContentContainer">
                <div style="width: 850px; float: left; margin-left: 0px;">
                    <fieldset style="width: 979px; margin-left: 0px;">
                        <legend>General Employee Info</legend>
                        <div style="float: left; width: 720px;">
                            <div class="generalTag">
                                <div class="leftPanel1">
                                    <asp:Label runat="server" ID="lblUserName" Text="Last Name" />
                                </div>
                                <div class="rightPanel">
                                    <asp:TextBox runat="server" ID="txtLastName" Width="200px" />
                                </div>
                                <div class="leftPanel2">
                                    <asp:Label runat="server" ID="lblEmployeeCode" Text="Employee Code" />
                                    <asp:Label runat="server" ID="txbEmployeeId" Visible="false" />
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
                                    <telerik:RadComboBox ID="cbxPrimaryLanguage" runat="server" Width="153px" MaxHeight="200px" DataTextField="LanguageName" EmptyMessage="- Select a Language -">
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
                                    <telerik:RadComboBox ID="cbxSecondaryLanguage" runat="server" Width="153px" MaxHeight="200px" DataTextField="LanguageName" EmptyMessage="- Select a Language -">
                                    </telerik:RadComboBox>
                                </div>
                            </div>
                            <div class="generalTag">
                                <div class="leftPanel1">
                                    <asp:Label runat="server" ID="lblTitle" Text="Title" />
                                </div>
                                <div class="rightPanel">
                                    <telerik:RadComboBox runat="server" ID="cbxTitle" Width="100px" EmptyMessage="- Select -" />
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
                                    <telerik:RadComboBox runat="server" ID="cbxPrefix" Width="100px" EmptyMessage="- Select -">
                                        <Items>
                                            <telerik:RadComboBoxItem Text="Senior" Value="Senior" />
                                            <telerik:RadComboBoxItem Text="Junior" Value="Junior" />
                                        </Items>
                                    </telerik:RadComboBox>
                                </div>
                                <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                                    <asp:Label runat="server" ID="lblSuffix" Text="Suffix" />
                                </div>
                                <div style="width: 100px; float: left;">
                                    <telerik:RadComboBox runat="server" ID="cbxSuffix" Width="100px" EmptyMessage="- Select -">
                                        <Items>
                                            <telerik:RadComboBoxItem Text="Prof." Value="Prof." />
                                            <telerik:RadComboBoxItem Text="Dr." Value="Dr." />
                                        </Items>
                                    </telerik:RadComboBox>
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
                                    <telerik:RadComboBox runat="server" ID="cbxMartialStatus" Width="100px" EmptyMessage="- Select -" />
                                </div>
                                <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                                    <asp:Label runat="server" ID="lblGender" Text="Gender" />
                                </div>
                                <div style="width: 100px; float: left;">
                                    <telerik:RadComboBox runat="server" ID="cbxGender" Width="100px" EmptyMessage="- Select -" />
                                </div>
                                <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                                    <asp:Label runat="server" ID="lblNationality1" Text="Nationality 1" />
                                </div>
                                <div class="rightPanel2">
                                    <telerik:RadComboBox runat="server" ID="cbxNationality1" Width="153px" EmptyMessage="- Select -" MaxHeight="200px" />
                                </div>
                            </div>
                            <div class="generalTag">
                                <div class="leftPanel1">
                                    <asp:Label runat="server" ID="lblBirthDate" Text="Birth Date" />
                                </div>
                                <div style="width: 100px; float: left;">
                                    <telerik:RadDatePicker runat="server" ID="dpBirthDate" Width="100px" DataFormatString="{0:dd MMM yyyy}" />
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
                                    <telerik:RadComboBox runat="server" ID="cbxNationality2" Width="153px" EmptyMessage="- Select -" MaxHeight="200px" />
                                </div>
                            </div>
                            <div class="generalTag">
                                <div class="leftPanel1">
                                    <asp:Label runat="server" ID="lblRetirementDate" Text="Retirement Date" />
                                </div>
                                <div style="width: 100px; float: left;">
                                    <telerik:RadDatePicker runat="server" ID="dpRetirementDate" Width="100px" DateInput-DisplayDateFormat="{dd MMM yyyy}" />
                                </div>
                                <div style="width: 100px; text-align: right; float: left; margin-right: 10px;">
                                    <asp:Label runat="server" ID="lblRetireDue" Text="Retire Due" />
                                </div>
                                <div style="width: 100px; float: left;">
                                    <asp:TextBox runat="server" ID="txtRetireDue" Width="93px" Enabled="false" />
                                </div>
                            </div>
                        </div>
                        <div style="width: 200px; float: left">
                            <asp:Image runat="server" ID="imgProfileImage" Width="200px" Height="200px" ImageUrl="~/Images/humanresources.png" />
                            <asp:TextBox runat="server" ID="txbProfileImagePath" />
                        </div>
                        `
                    </fieldset>
                    <div runat="server" id="divEmployeeDetails">
                    <fieldset style="width: 920px; margin-top: 10px;">
                        <legend>Employee Details</legend>
                        <div>
                            <telerik:RadTabStrip ID="TabStrip1" runat="server" MultiPageID="RadMultiPag1"
                                ScrollChildren="True" SelectedIndex="8" Font-Names="Calibri" Font-Size="Small" Width="975px" Skin="Telerik">
                                <Tabs>
                                    <telerik:RadTab Text="Employment">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Assignment">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Education">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Empl. Documents" Selected="True">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Legal & Compliance">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Salary">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Communication" Selected="True">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Contacts">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Medical Data" Selected="True">
                                    </telerik:RadTab>
                                </Tabs>
                            </telerik:RadTabStrip>
                            <telerik:RadMultiPage ID="RadMultiPag1" runat="server" SelectedIndex="0" Visible="true">
                                <telerik:RadPageView ID="RadPageView1" runat="server" Height="300" Style="overflow: hidden">
                                    <div style="float: left; width: 605px;">
                                        <fieldset style="width: 270px; margin-left: 0px; margin-top: 5px; float: left;">
                                            <legend>Status</legend>
                                            <div>
                                                <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="lblEmploymentStatus" Text="Employment Status" />
                                                </div>
                                                <div style="width: 140px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxEmploymentStatus" Width="130px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="lblEmploymentType" Text="Employment Type" />
                                                </div>
                                                <div style="width: 140px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxEmploymentType" Width="130px" EmptyMessage="- Select -" />
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
                                                    <asp:Label runat="server" ID="lblEducationStartDate" Text="Start Date" />
                                                </div>
                                                <div style="width: 140px; float: left; height: 30px;">
                                                    <telerik:RadDatePicker runat="server" ID="dpEducationStartDate" Width="130px" />
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
                                                        <asp:Label runat="server" ID="Label38" Text="" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label43" Text="Monday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label44" Text="Tuesday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label45" Text="Wednesday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label46" Text="Thursday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label47" Text="Friday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label48" Text="Saturday" />
                                                    </div>
                                                    <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label49" Text="Sunday" />
                                                    </div>
                                                </div>
                                                <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                                    <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label39" Text="Start" Font-Bold="true" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtMonStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtTuesStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtWedStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtThurStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtFidayStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtSatStartTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <telerik:RadMaskedTextBox runat="server" ID="txtSunStartTime" Width="35px" />
                                                    </div>
                                                </div>
                                                <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                                    <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label40" Text="End" Font-Bold="true" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtMonEndTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtTuesEndTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtWedEndTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtThursEndtime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtFridayEndTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtSatEndTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtSunEndTime" Width="35px" />
                                                    </div>
                                                </div>
                                                <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                                    <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label41" Text="Total" Font-Bold="true" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtMonTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtTuesTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtWedTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtThursTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtFridayTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtSatTotalTime" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:TextBox runat="server" ID="txtSunTotalTime" Width="35px" />
                                                    </div>
                                                </div>
                                                <div style="width: 50px; float: left; text-align: center; margin-left: 10px;">
                                                    <div style="width: 40px; text-align: center; float: left; margin-left: 10px; height: 25px;">
                                                        <asp:Label runat="server" ID="Label42" Text="" Width="35px" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsMonday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsTuesday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsWednesday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsThursday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsFriday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsSaturday" />
                                                    </div>
                                                    <div style="width: 40px; text-align: center; float: left; margin-right: 10px; height: 25px;">
                                                        <asp:CheckBox runat="server" ID="chkIsSunday" />
                                                    </div>
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
                                                    <telerik:RadComboBox runat="server" ID="cbxCompanyCostCentre" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 400px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentDepartmentName" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentLocation" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentJobTitle" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentPosition" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentSupervisor" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentMentor" Width="200px" EmptyMessage="- Select -" />
                                                </div>
                                                <div style="width: 300px; float: left; height: 30px;">
                                                    <telerik:RadComboBox runat="server" ID="cbxAssignmentGrade" Width="200px" EmptyMessage="- Select -" />
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
                                                        <telerik:RadComboBox runat="server" ID="cbxEducationType" Width="205px" EmptyMessage="- Select -" />
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
                                                        <telerik:RadComboBox runat="server" ID="cbxDocumentType" Width="205px" EmptyMessage="- Select -" />
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
                                            <telerik:RadTabStrip ID="RadTabStrip2" runat="server" MultiPageID="RadMultiPag2"
                                                SelectedIndex="3" Font-Names="Calibri" Font-Size="Small" Width="975px" Skin="Telerik">
                                                <Tabs>
                                                    <telerik:RadTab Text="Identification Details">
                                                    </telerik:RadTab>
                                                    <telerik:RadTab Text="Reference">
                                                    </telerik:RadTab>
                                                    <telerik:RadTab Text="Interview & Checks">
                                                    </telerik:RadTab>
                                                    <telerik:RadTab Text="Principles" Selected="True">
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
                                                                    <telerik:RadComboBox runat="server" ID="RadComboBox2" Width="130px" EmptyMessage="- Select -" />
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
                                                                    <telerik:RadComboBox runat="server" ID="RadComboBox3" Width="130px" EmptyMessage="- Select -" />
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
                                                                    <telerik:RadComboBox runat="server" ID="RadComboBox4" Width="130px" EmptyMessage="- Select -" />
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
                                                                    <telerik:RadDatePicker runat="server" ID="dpInterviewDate" Width="130px" />
                                                                </div>
                                                                <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:TextBox runat="server" ID="txtInterviewSource" Width="200px" />
                                                                </div>
                                                                <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:TextBox runat="server" ID="txtInterviewerName" Width="200px" />
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
                                                                    <asp:CheckBox runat="server" ID="chkBKR" />
                                                                </div>
                                                                <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:CheckBox runat="server" ID="chkGoodConduct" />
                                                                </div>
                                                                <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:CheckBox runat="server" ID="chkMunicipalRecords" />
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
                                                                    <asp:CheckBox runat="server" ID="chkInsider" />
                                                                </div>
                                                                <div style="width: 200px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                    <telerik:RadComboBox runat="server" ID="cbxPrincipleDepartment" Width="200px" EmptyMessage="- Select -" />
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
                                                                    <telerik:RadComboBox runat="server" ID="cbxPrincipleRelationDepartment" Width="200px" EmptyMessage="- Select -" />
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
                                        <div style="margin-top: 10px;">
                                            <telerik:RadTabStrip ID="RadTabStrip3" runat="server" MultiPageID="RadMultiPag3"
                                                SelectedIndex="2" Font-Names="Calibri" Font-Size="Small" Width="975px" Skin="Telerik">
                                                <Tabs>
                                                    <telerik:RadTab Text="Salary Details">
                                                    </telerik:RadTab>
                                                    <telerik:RadTab Text="Allowance">
                                                    </telerik:RadTab>
                                                    <telerik:RadTab Text="Salary Cumulative" Selected="True">
                                                    </telerik:RadTab>
                                                </Tabs>
                                            </telerik:RadTabStrip>
                                            <telerik:RadMultiPage ID="RadMultiPage3" runat="server" SelectedIndex="1">
                                                <telerik:RadPageView ID="RadPageView15" runat="server" Height="300" Style="overflow: hidden">
                                                    <fieldset style="width: 930px; margin-top: 5px; float: left;">
                                                        <legend>General Details</legend>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label129" Text="Currency" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label130" Text="Gross Hourly Rate" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label131" Text="Gross Monthly Salary" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label132" Text="Payment freq." />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label133" Text="Salary Effective Date" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 140px;">
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadComboBox runat="server" ID="cbxCurrency" Width="105px" EmptyMessage="- Select -" />
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="Label135" Width="100px" />
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="Label136" Width="100px" />
                                                            </div>
                                                            <div style="width: 140px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadComboBox runat="server" ID="cbxPaymentFreq" Width="130px" EmptyMessage="- Select -">
                                                                    <Items>
                                                                        <telerik:RadComboBoxItem runat="server" Text="Monthly" Value="Monthly" />
                                                                        <telerik:RadComboBoxItem runat="server" Text="Weekly" Value="Weekly" />
                                                                        <telerik:RadComboBoxItem runat="server" Text="Four Weekly" Value="Four Weekly" />
                                                                    </Items>
                                                                </telerik:RadComboBox>
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadDatePicker runat="server" ID="RadDatePicker10" Width="130px" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label134" Text="" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label137" Text="" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label138" Text="" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label139" Text="Salary Grade" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label140" Text="Wage Tax" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <%--<telerik:RadComboBox runat="server" ID="RadComboBox8" Width="105px" />--%>
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <%--<asp:TextBox runat="server" ID="TextBox60" Width="100px" />--%>
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <%--<asp:TextBox runat="server" ID="TextBox61" Width="100px" />--%>
                                                            </div>
                                                            <div style="width: 140px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadComboBox runat="server" ID="cbxSalaryGrade" Width="135px" EmptyMessage="- Select -" />
                                                            </div>
                                                            <div style="width: 140px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="txtWageTax" Width="130px" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label141" Text="Account No" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label142" Text="IBAN" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label143" Text="Bank Name" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label144" Text="Swift Code" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label145" Text="Payment Method" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 150px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox61" Width="150px" />
                                                            </div>
                                                            <div style="width: 150px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox63" Width="150px" />
                                                            </div>
                                                            <div style="width: 150px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox64" Width="150px" />
                                                            </div>
                                                            <div style="width: 150px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox65" Width="150px" />
                                                            </div>
                                                            <div style="width: 150px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadComboBox runat="server" ID="RadComboBox8" Width="155px" EmptyMessage="- Select -" />
                                                            </div>
                                                        </div>
                                                    </fieldset>
                                                </telerik:RadPageView>
                                                <telerik:RadPageView ID="RadPageView10" runat="server" Height="300" Style="overflow: hidden">
                                                    <fieldset style="width: 610px; margin-top: 5px; float: left;">
                                                        <legend>Allowance Details</legend>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label146" Text="Monthly Mobile Limit" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label147" Text="Monthly Conveyance" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="Label148" Width="100px" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="Label149" Width="100px" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label150" Text="Special Allowance" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label151" Text="Lunch Allowance" />
                                                            </div>
                                                            <div style="width: 150px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label152" Text="House Rent Allowance" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox60" Width="100px" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox66" Width="100px" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:TextBox runat="server" ID="TextBox67" Width="100px" />
                                                            </div>
                                                        </div>
                                                    </fieldset>
                                                    <fieldset style="width: 300px; margin-top: 5px; float: left;">
                                                        <legend>Expact Info</legend>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label153" Text="30% Rule Applicable" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label155" Text="" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label154" Text="30% Rule Start Date" />
                                                            </div>
                                                            <div style="width: 120px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:Label runat="server" ID="Label158" Text="30% Rule Start Date" />
                                                            </div>
                                                        </div>
                                                        <div style="float: left; width: 150px;">
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:RadioButton runat="server" ID="TextBox70" Text="Yes" />
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <asp:RadioButton runat="server" ID="CheckBox4" Text="No" />
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadDatePicker runat="server" ID="RadDatePicker12" Width="100px" />
                                                            </div>
                                                            <div style="width: 120px; text-align: left; float: left; margin-right: 10px; height: 30px;">
                                                                <telerik:RadDatePicker runat="server" ID="RadDatePicker11" Width="100px" />
                                                            </div>
                                                        </div>
                                                    </fieldset>
                                                </telerik:RadPageView>
                                            </telerik:RadMultiPage>
                                        </div>
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
                                                    <asp:TextBox runat="server" ID="txtPermZipCode" Width="130px" />
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
                                                    <asp:Label runat="server" ID="txtPermProvince1" Text="Province" />
                                                </div>
                                                <div style="width: 130px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPermProvince" Width="130px" />
                                                </div>
                                                <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label19" Text="Country" />
                                                </div>
                                                <div style="width: 160px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPermCountry" Width="160px" /><br />
                                                </div>
                                            </div>
                                            <div>
                                                <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label20" Text="Telephone" />
                                                </div>
                                                <div style="width: 130px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPermTelephone" Width="130px" />
                                                </div>
                                                <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label21" Text="Since" />
                                                </div>
                                                <div style="width: 160px; float: left; height: 30px;">
                                                    <telerik:RadDatePicker runat="server" ID="dpPermSince" Width="160px" />
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
                                                    <asp:TextBox runat="server" ID="txtTempAddress" Width="280px" />
                                                </div>
                                                <div style="width: 30px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label27" Text="No" />
                                                </div>
                                                <div style="width: 50px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempNo" Width="50px" />
                                                </div>
                                            </div>
                                            <div>
                                                <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label28" Text="Zip Code" />
                                                </div>
                                                <div style="width: 130px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempZipCode" Width="130px" />
                                                </div>
                                                <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label29" Text="City" />
                                                </div>
                                                <div style="width: 160px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempCity" Width="160px" />
                                                </div>
                                            </div>
                                            <div>
                                                <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label30" Text="Province" />
                                                </div>
                                                <div style="width: 130px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempProvince" Width="130px" />
                                                </div>
                                                <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label31" Text="Country" />
                                                </div>
                                                <div style="width: 160px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempCountry" Width="160px" /><br />
                                                </div>
                                            </div>
                                            <div>
                                                <div style="width: 60px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label32" Text="Telephone" />
                                                </div>
                                                <div style="width: 130px; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTempTelephone" Width="130px" />
                                                </div>
                                                <div style="width: 70px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label33" Text="Since" />
                                                </div>
                                                <div style="width: 160px; float: left; height: 30px;">
                                                    <telerik:RadDatePicker runat="server" ID="dpTempSince" Width="160px" />
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
                                                    <asp:TextBox runat="server" ID="txtMobilePrivate" Width="300px" />
                                                </div>
                                                <div style="float: left; margin-right: 10px; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtEmailPrivate" Width="300px" />
                                                </div>
                                                <div style="float: left; margin-right: 10px; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtTwitter" Width="300px" />
                                                </div>
                                            </div>
                                            <div style="float: left; width: 120px;">
                                                <div style="float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label24" Text="Mobile Company" />
                                                </div>
                                                <div style="float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label36" Text="Email Company" />
                                                </div>
                                                <div style="float: left; margin-right: 10px; height: 30px;">
                                                    <asp:Label runat="server" ID="Label37" Text="LinkedIn Profile" />
                                                </div>
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
                                                    <asp:TextBox runat="server" ID="txtPriDetailId" Width="250px" Visible="false" />
                                                    <asp:TextBox runat="server" ID="txtPriContactName" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPriRelation" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPriAddress" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPriHomePhoneNo" Width="150px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPriWorkPhone" Width="150px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtPriMobile" Width="150px" />
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
                                                    <asp:TextBox runat="server" ID="txtSecDetailId" Width="250px" />
                                                    <asp:TextBox runat="server" ID="txtSecContactName" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtSecRelation" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtSecAddress" Width="250px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtSecHomePhoneNo" Width="150px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtSecWorkPhone" Width="150px" />
                                                </div>
                                                <div style="width: 250px; text-align: left; float: left; height: 30px;">
                                                    <asp:TextBox runat="server" ID="txtSecMobile" Width="150px" />
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
                                                        <asp:TextBox runat="server" ID="txtMedPhysicalName" Width="300px" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:TextBox runat="server" ID="txtMedPhysicianPhoneNo" Width="150px" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:TextBox runat="server" ID="txtMedPharmacyName" Width="300px" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:TextBox runat="server" ID="txtMedPharmacyPhoneNo" Width="150px" />
                                                    </div>
                                                </div>
                                                <div style="float: left; width: 180px;">
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:Label runat="server" ID="Label72" Text="Blood Group" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:Label runat="server" ID="Label73" Text="Health Insurance Company" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:Label runat="server" ID="Label74" Text="Health Insurance Number" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:Label runat="server" ID="Label76" Text="Collective Scheme" />
                                                    </div>
                                                </div>
                                                <div style="float: left; width: 270px;">
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:TextBox runat="server" ID="txtBloodGroup" Width="150px" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <telerik:RadComboBox runat="server" ID="cbxInsuranceCompany" Width="200px" EmptyMessage="- Select -" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:TextBox runat="server" ID="txtMedInsuranceNumber" Width="270px" />
                                                    </div>
                                                    <div style="float: left; margin-right: 10px; height: 30px;">
                                                        <asp:CheckBox runat="server" ID="chkCollectiveScheme" />
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
                    <div runat="server" id="divEmployeeLeaveDetails">
                    <fieldset style="width: 920px; margin-top: 10px;">
                        <legend>Employee Leave Details</legend>
                        <div>
                            <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPag1"
                                ScrollChildren="true" SelectedIndex="0" Font-Names="Calibri" Font-Size="Small" Width="975px" Skin="Telerik">
                                <Tabs>
                                    <telerik:RadTab Text="Leave Registration">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Leave Request Rejection">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Education">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Leave Overview" Selected="True">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Leave List">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Leave Settings">
                                    </telerik:RadTab>
                                </Tabs>
                            </telerik:RadTabStrip>
                            <telerik:RadMultiPage ID="RadMultiPage12" runat="server" SelectedIndex="0">
                                <telerik:RadPageView ID="RadPageView16" runat="server" Height="300" Style="overflow: hidden">
                                    <div class="tag">
                                        <fieldset style="width: 935px; margin-top: 5px; float: left;">
                                            <legend>Registration</legend>
                                            <div style="float: left;">
                                                <div>
                                                    <fieldset style="width: 550px; margin-top: 5px; float: left;">
                                                        <legend>Leave Registration Details</legend>
                                                        <div>
                                                            <div style="float:left;">
                                                                <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                </div>
                                                                <div style="width: 130px; float: left; height: 30px;text-align:left; padding-left:30px;">
                                                                    <asp:Label runat="server" ID="Label18" Text="Date" Font-Bold="true" />
                                                                </div>
                                                                <div style="width: 170px; float: left; height: 30px;text-align:left;">
                                                                    <asp:Label runat="server" ID="Label59" Text="Hours" Font-Bold="true" />
                                                                </div>
                                                                <div style="width: 120px; text-align: right; float: left; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label56" Text="Leave Calculation" Font-Bold="true" />
                                                                </div>
                                                            </div>
                                                            <div style="float:left;"> 
                                                                <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label160" Text="Leave Start"/>
                                                                </div>
                                                                <div style="width: 120px; float: left; height: 30px;">
                                                                    <telerik:RadDatePicker runat="server" ID="dpLeaveStartDate" Width="120px"/>
                                                                </div>
                                                                <div style="width: 150px; float: left; height: 30px;">
                                                                     <asp:TextBox runat="server" ID="txtLeaveStartHours" Width="60px"/>
                                                                </div>
                                                                <div style="width: 110px; text-align: left; float: left; height: 30px;">
                                                                    <asp:Label runat="server" ID="TextBox1" Text="Number of Days" />
                                                                </div>
                                                                <div style="width: 70px; text-align: left; height: 30px; float: left;">
                                                                    <asp:TextBox runat="server" ID="txtNumberOfDays" Width="65px" Enabled="false"/>
                                                                </div>
                                                            </div>
                                                            <div style="float:left;"> 
                                                                <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label57" Text="Leave End"/>
                                                                </div>
                                                                <div style="width: 120px; float: left; height: 30px;">
                                                                    <telerik:RadDatePicker runat="server" ID="dpLeaveEndDate" Width="120px"/>
                                                                </div>
                                                                <div style="width: 150px; float: left; height: 30px;">
                                                                     <asp:TextBox runat="server" ID="txtLeaveEndTime" Width="60px"/>
                                                                </div>
                                                                <div style="width: 110px; text-align: left; float: left; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label58" Text="Number of Hours" />
                                                                </div>
                                                                <div style="width: 70px; text-align: left; height: 30px; float: left;">
                                                                    <asp:TextBox runat="server" ID="txtNumberOfHours" Width="65px" Enabled="false" />
                                                                </div>
                                                            </div>
                                                            <div style="float:left;"> 
                                                                <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label60" Text="Leave Type"/>
                                                                </div>
                                                                <div style="width: 270px; float: left; height: 30px;">
                                                                    <telerik:RadComboBox runat="server" ID="cbxLeaveType" Width="185px"/>
                                                                </div>
                                                                <div style="width: 100px; text-align: left; float: left; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label61" Text="Registration No" />
                                                                </div>
                                                                <div style="width: 80px; text-align: left; height: 30px; float: left;">
                                                                    <asp:TextBox runat="server" ID="TextBox8" Width="75px" Enabled="false" />
                                                                </div>
                                                            </div>
                                                             <div style="float:left;"> 
                                                                <div style="width: 80px; text-align: right; float: left; margin-right: 10px; height: 30px;">
                                                                    <asp:Label runat="server" ID="Label62" Text="Leave Reason"/>
                                                                </div>
                                                                <div style="width: 450px; float: left; height: 55px;">
                                                                    <asp:TextBox runat="server" ID="TextBox2" Width="445px" TextMode="MultiLine" Height="50px" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </fieldset>
                                                </div>
                                                <div>
                                                    <fieldset style="width: 550px; margin-top: 5px; float: left;">
                                                        <legend>HR Remarks</legend>
                                                        <div style="width: 550px; float: left; height: 55px;">
                                                            <asp:TextBox runat="server" ID="TextBox5" Width="545px" TextMode="MultiLine" Height="50px" />
                                                        </div>
                                                    </fieldset>
                                                </div>
                                            </div>
                                            <div>
                                                <fieldset style="width: 330px; margin-top: 5px; float: left;">
                                                    <legend>Current Year Balance</legend>
                                                    <div style="float: left; width:100px; text-align:right;">
                                                        <asp:Label runat="server" ID="lblCasualLeave" Text="Casual Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label118" Text="Sick Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label124" Text="Maternity Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label119" Text="Paternity Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label125" Text="Marriage Leave" Height="30px" />
                                                    </div>
                                                    <div style="float: left; width:55px; text-align:center;">
                                                        <asp:TextBox runat="server" ID="Label156" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="Label157" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="Label159" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="Label161" Height="25px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="Label162" Height="25px" Width="30px" />
                                                    </div>
                                                    <div style="float: left; width:120px; text-align:right;">
                                                        <asp:Label runat="server" ID="Label163" Text="House Move Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label164" Text="Mortality Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label165" Text="Special Leave" Height="30px" />
                                                        <asp:Label runat="server" ID="Label166" Text="Study Leave" Height="30px" />
                                                    </div>
                                                    <div style="float: left; width:55px; text-align:center;">
                                                        <asp:TextBox runat="server" ID="TextBox6" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="TextBox7" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="TextBox9" Height="20px" Width="30px" />
                                                        <asp:TextBox runat="server" ID="TextBox10" Height="25px" Width="30px" />
                                                    </div>
                                                </fieldset>
                                            </div>
                                        </fieldset>
                                    </div>
                                </telerik:RadPageView>
                            </telerik:RadMultiPage>
                        </div>
                    </fieldset>
                    </div>
                </div>
            </div>
        </div>
        <%--</asp:Panel>--%>

        <div id="divEmployeeAssessment">
        </div>
    </div>

    <script type="text/javascript">

        function onClientContextMenuShowing(sender, args) {
            var treeNode = args.get_node();
            treeNode.set_selected(true);
            //enable/disable menu items
            setMenuItemsState(args.get_menu().get_items(), treeNode);
        }

        function onClientContextMenuItemClicking(sender, args) {
            var menuItem = args.get_menuItem();
            var treeNode = args.get_node();
            menuItem.get_menu().hide();

            switch (menuItem.get_value()) {
                case "NewFolder":
                    break;
                case "MarkAsRead":
                    break;
                case "Delete":
                    var result = confirm("Are you sure you want to delete the item: " + treeNode.get_text());
                    args.set_cancel(!result);
                    break;
            }
        }

        function onClientButtonClicking(sender, args) {
            var button = args.get_item();
            var parent = button.get_parent();
            var toolBar = button.get_toolBar();
            var alignDropDown = toolBar.get_items().getItem(5);

            if (parent == alignDropDown)
                alignDropDown.set_imageUrl(button.get_imageUrl());
            //]]>
        }

    </script>
</asp:Content>
