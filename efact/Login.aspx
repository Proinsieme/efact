<%@ Page Title="" Language="C#" MasterPageFile="~/efact.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="efact.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div style="text-align: center">
        <img src="Images/efact_logo1.png" title="eFact Application" />
    </div>
    <%-- <div class="logo">
         simplifying | Business
    </div>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <hgroup class="title">
    </hgroup>
    <div style="text-align: right">
        <asp:Label runat="server" ID="FailureText" />
    </div>

    <script type="text/javascript">
        //$(document).ready(function () {
        //    $("#tbxUserName").validate({
        //        rules: {
        //            field: {
        //                required: true,
        //                minlength: 8
        //            }
        //        }
        //    });
        //});
    </script>

    <section id="loginForm">
        <%-- <asp:Login ID="LoginForm" runat="server">--%>
        <%-- <LayoutTemplate>--%>
        <%--<p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>--%>
        <fieldset>
            <legend>Login eFact</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="tbxUserName">User name</asp:Label>
                    <span style="padding-left: 10px">
                        <asp:TextBox runat="server" ID="tbxUserName" Width="150px" OnTextChanged="tbxUserName_TextChanged" />
                    </span>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxUserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                </li>
                <br />
                <li>
                    <asp:Label runat="server" AssociatedControlID="pwbPassword">Password</asp:Label>
                    <span style="padding-left: 19px">
                        <asp:TextBox runat="server" ID="pwbPassword" TextMode="Password" Width="150px" />
                    </span>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pwbPassword" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                </li>
                <br />
                <li style="padding-left: 130px;">
                    <span>
                        <asp:Button ID="LoginButton" runat="server" CssClass="button" Text="Log in" OnClick="Login_Click" />
                        <%--<asp:Button ID="ClearButton" runat="server" CssClass="button" Text="Clear" OnClick="Clear_Click" />--%>
                    </span>
                </li>
                <%--<li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label ID="Label3" runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label>
                        </li>--%>
            </ol>

        </fieldset>
        <br />
        <br />
        <fieldset>
            <legend></legend>
            <ul>
                <li>Copyright
                </li>
                <li style="padding-right: 50px">
                    <p>This package is provided under a license agreement and its content and documentation cannot be distributed or disclosed to third parties without the prior written consent of Proinsieme B.V. The Netherlands</p>
                </li>
            </ul>

        </fieldset>
        <%-- </LayoutTemplate>--%>
        <%-- </asp:Login>--%>
        <p>
        </p>
    </section>
</asp:Content>
