<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="efact.EmployeeDetails" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <span>
        <img src="Images/efact-HR.png" />
    </span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
    <div class="hrContentContainer">
        <div class="hrContentBlock">
            <div class="hrSlideBar">
                <div class="gadget">
                    <ul class="sb_menu">
                        <li><a href="efactModules.aspx">Home</a></li>
                        <li><a id="activitiesAndAttentionLink" href="ActiviesandAttentions.aspx">Activies & Attention</a></li>
                        <li class="active"><a href="EmployeeDetails.aspx" onclick="">Staffs</a></li>
                    </ul>
                </div>
            </div>
            <div class="hrMainBar">
                <div id="emmployeedetails">
                    <div style="text-align: right">
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
            </div>
        </div>
    </div>
</asp:Content>
