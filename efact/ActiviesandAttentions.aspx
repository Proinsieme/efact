<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.Master" AutoEventWireup="true" CodeBehind="ActiviesandAttentions.aspx.cs" Inherits="efact.ActiviesandAttentions" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/ActivitiesAndAttentions.ascx" TagPrefix="uc1" TagName="activitiesandattentions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <span>
        <img src="Images/efact-HR.png" />
    </span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hrContentContainer">
        <div class="hrContentBlock">
            <div class="hrSlideBar">
                <div class="gadget">
                    <ul class="sb_menu">
                        <li><a href="efactModules.aspx">Home</a></li>
                        <%--class="active">--%>

                        <li class="active"><a id="activitiesAndAttentionLink" href="ActiviesandAttentions.aspx">Activies & Attention</a></li>
                        <li><a href="EmployeeDetails.aspx" onclick="">Staffs</a></li>
                    </ul>
                </div>
            </div>
            <div class="hrMainBar">
                <div id="activities">
                    <br />
                    <fieldset style="width: 660px;">
                        <legend>Activities</legend>
                        <div id="Div1">
                            <div style="margin-left: 10px; margin-top:5px;">
                                <telerik:RadTabStrip ID="RadTabStripActivities" runat="server" SelectedIndex="0" MultiPageID="RadMultiPage1">
                                    <Tabs>
                                        <telerik:RadTab runat="server" Text="Upcoming Activities" Selected="True">
                                        </telerik:RadTab>
                                        <telerik:RadTab runat="server" Text="More Upcoming">
                                        </telerik:RadTab>
                                    </Tabs>
                                </telerik:RadTabStrip>
                                <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">
                                    <telerik:RadPageView ID="RadPageView1" runat="server">
                                        <div style="margin: 20px;">
                                            <fieldset>
                                                <legend> Employees on Leave </legend>
                                                <ul>
                                                    <li>0001 HO Guray Pekbay</li>
                                                    <li>0003 BR James Smith</li>
                                                    <li>0211 BR Harry Potter</li>
                                                </ul>

                                            </fieldset>


                                            <%--</ItemTemplate>
                                            </telerik:RadListView>--%>
                                        </div>

                                    </telerik:RadPageView>
                                    <telerik:RadPageView ID="RadPageView2" runat="server">
                                        <div>
                                            <fieldset style="margin: 20px;">
                                                <legend> Birthdays </legend>
                                                <ul>
                                                    <li>Content="29 Jan 2013  TR Diwali in Turkey"</li>
                                                    <li>23 Feb 2013  TR Youth and Sports</li>
                                                    <li>22 Feb 2013  NL Spring</li>
                                                    <li>25 Feb 2013  DE Berlin</li>
                                                    <li>20 Mrt 2013  GB Holiday XXX</li>
                                                    <li>26 Mrt 2013  US Holiday YYY</li>
                                                    <li>28 Mrt 2013  TR Holiday ZZZ</li>
                                                </ul>
                                            </fieldset>
                                        </div>
                                    </telerik:RadPageView>
                                </telerik:RadMultiPage>
                            </div>

                        </div>
                    </fieldset>
                    <br />
                    <fieldset style="width: 660px;">
                        <legend>Attentions</legend>
                        <div style="margin-left: 10px; margin-top:5px;">
                            <telerik:RadTabStrip ID="RadTabStripAttentions" runat="server">
                                <Tabs>
                                    <telerik:RadTab runat="server" Text="Upcoming">
                                    </telerik:RadTab>
                                </Tabs>
                            </telerik:RadTabStrip>
                            <telerik:RadMultiPage ID="RadMultiPage2" runat="server" SelectedIndex="0">
                                <telerik:RadPageView ID="RadPageView3" runat="server">
                                    <div style="margin: 20px;">
                                            <fieldset>
                                                <legend> Notes </legend>
                                                <ul>
                                                    <li style="font-size:medium; font-weight:bold;">Employee                    |       Note Type</li>
                                                </ul>
                                                <ul>
                                                    <li>0001 HO Guray Pekbay        |       0024 Contract Renewal</li>
                                                </ul>
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
</asp:Content>
