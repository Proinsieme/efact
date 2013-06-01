<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="efact.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblError" CssClass="errorLabel" />
    </div>
    <div>
        <div>
            <span style="width: inherit">Old Password</span>
            <asp:TextBox runat="server" ID="OldPassword" TextMode="Password" Enabled="false" /><br />
            <span>New Password</span>
            <asp:TextBox runat="server" ID="NewPassword" TextMode="Password" /><br />
            <span>Confirm New Password</span>
            <asp:TextBox runat="server" ID="ConfirmNewPassword" TextMode="Password" OnTextChanged="ConfirmNewPassword_TextChanged" /><br />
        </div>
        <div style="text-align:center">
            <asp:Button runat="server" ID="Save" Text="Save" OnClick="Save_Click" />
            <asp:Button runat="server" ID="Clear" Text="Clear" OnClick="Clear_Click" />
        </div>
    </div>
</asp:Content>
