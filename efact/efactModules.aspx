<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="efactModules.aspx.cs" Inherits="efact.efactModules" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <span style="font-size:large; font-family: calibri; font-weight: lighter;">efact Modules</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="efactModules">

        <div id="home" class="section">
                <ul id="module_menu">
                    <li><a href="ActiviesandAttentions.aspx" class="humanResource"><span style="">Human Resource</span></a></li>
                    <li><a href="#services" class="budget"><span>Budget</span></a></li>
                    <li><a href="#portfolio" class="invoice"><span>Invoice Processing</span></a></li>
                    <li><a href="#contact" class="expense"><span>Expense</span></a></li>
                    <li><a href="#portfolio" class="suppliers"><span>Suppliers</span></a></li>
                    <li><a href="#contact" class="security"><span>Security</span></a></li>
                    <li><a href="#portfolio" class="instructions"><span>Instructions</span></a></li>
                    <li><a href="#contact" class="timeManagement"><span>Time Management</span></a></li>
                    <li><a href="#portfolio" class="Approval"><span>Approval</span></a></li>
                    <li><a href="#contact" class="asset"><span>Fixed Assets</span></a></li>
                </ul>
            </div>


      <%--  <div id="moduleContentContainer" style="border-color:white">
            <div id="Div0" class="moduleContent">
               <img class="moduleImg" style="border-color:white" src="Images/Modules/Human Resource.png" title="Human Resource"  />
                </div>
            <div id="Div1" style="width: 100px; height: 100px; position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" style="border-color:white" src="Images/Modules/Budget.png" title="Budget" width="100px" height="100px"  />
           </div>
            <div id="Div2" style="width: 100px; height: 100px; position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg1" style="border-color:white" src="Images/Modules/Creditor Invoice Processing.png" width="100px" height="100px"  />
           </div>
            <div id="Div3" style="width: 100px; height: 100px; position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Expense Processing.png" width="100px" height="100px"  />
           </div>
            <div id="Div4" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Fixed Assets.png" width="100px" height="100px"  />
           </div>
            <div id="Div5" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Reporting.png" width="100px" height="100px" />
            </div>
            <div id="Div6" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Standing Instructions.png" width="100px" height="100px"  />
            </div>
            <div id="Div7" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Suppliers.png" width="100px" height="100px"  />
            </div>
            <div id="Div8" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Time Management.png" width="100px" height="100px"  />
            </div>
            <div id="Div9" style="width: 100px; height: 100px;position:relative; float:left; padding:10px;" class="moduleContent">
                <img class="moduleImg" src="Images/Modules/Transaction Approval.png" width="100px" height="100px"  />
            </div>
        </div>--%>
    </div>
</asp:Content>
