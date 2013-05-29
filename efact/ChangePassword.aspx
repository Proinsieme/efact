<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="efact.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblError" />
    </div>
    <div>
        <span>Old Password</span> <asp:TextBox runat="server" ID="OldPassword" /><br />
        <span>New Password</span> <asp:TextBox runat="server" ID="NewPassword" /><br />
        <span>Confirm New Password</span> <asp:TextBox runat="server" ID="ConfirmNewPassword" /><br />
        <asp:Button runat="server" ID="Save" Text="Save" />
    </div>
</asp:Content>
