<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="UnAuthorized.aspx.cs" Inherits="efact.UnAuthorized" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <p>You are unauthorized to view this page.</p>
        <br />
        <p>Please login here... <a href="Login.aspx" /></p>
    </div>
</asp:Content>
