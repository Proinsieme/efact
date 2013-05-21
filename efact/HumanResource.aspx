<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.Master" AutoEventWireup="true" CodeBehind="HumanResource.aspx.cs" Inherits="efact.HumanResource" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Src="~/ActivitiesAndAttentions.ascx" TagPrefix="uc1" TagName="activitiesandattentions" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <span>
        <img src="Images/efact-HR.png" />
    </span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>--%>
    <div class="hrContentContainer">
        <div class="hrContentBlock">
            <div class="hrSlideBar">
                <div class="gadget">
                    <ul class="sb_menu">
                        <li><a href="efactModules.aspx">Home</a></li>
                        <%--class="active">--%>

                        <li><a id="activitiesAndAttentionLink" href="#">Activies & Attention</a></li>
                        <li><a href="EmployeeDetails.aspx" onclick="">Staffs</a></li>
                    </ul>
                </div>
            </div>
            <div class="hrMainBar">
                <div id="activities">
                    <br />
                    <uc1:activitiesandattentions runat="server" ID="ActivitiesAndAttentions" Visible="true" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
