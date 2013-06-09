<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.Master" AutoEventWireup="true"
    CodeBehind="Test.aspx.cs" Inherits="efact.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <script type="text/javascript">
            function itemOpened(s, e) {
                if ($telerik.isIE8) {
                    // Fix an IE 8 bug that causes the list bullets to disappear (standards mode only)
                    $telerik.$("li", e.get_item().get_element())
                              .each(function () { this.style.cssText = this.style.cssText; });
                }
            }
        </script>
    </telerik:RadScriptBlock>
    <div class="qsf-demo-canvas">
        <div id="MegaDropDown">
            <telerik:RadMenu runat="server" ID="RadMenu1" Skin="Sitefinity" OnClientItemOpened="itemOpened"
                Width="880" Height="60" EnableShadows="true">
                <Items>
                    <telerik:RadMenuItem Text="Human Resource" PostBack="false">
                        <Items>
                            <telerik:RadMenuItem CssClass="Products" Width="640">
                                <ItemTemplate>
                                    <div id="CatWrapper" class="Wrapper" style="width: 435px;">
                                        <h3>
                                            Human Resource</h3>
                                        <telerik:RadSiteMap ID="RadSiteMap1" runat="server" Skin="Hay" EnableTextHTMLEncoding="true">
                                            <LevelSettings>
                                                <telerik:SiteMapLevelSetting Level="0">
                                                    <ListLayout RepeatColumns="3" RepeatDirection="Vertical" />
                                                </telerik:SiteMapLevelSetting>
                                            </LevelSettings>
                                            <Nodes>
                                                <telerik:RadSiteMapNode NavigateUrl="#" Text="Today">
                                                    <Nodes>
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Tables &amp; Chairs" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Leave Registration" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Overtime Reporting" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Sick Reporting" />
                                                    </Nodes>
                                                </telerik:RadSiteMapNode>
                                                <telerik:RadSiteMapNode NavigateUrl="#" Text="Organization">
                                                    <Nodes>
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Management" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Organization Chart" />
                                                    </Nodes>
                                                </telerik:RadSiteMapNode>
                                                <telerik:RadSiteMapNode NavigateUrl="#" Text="Staff">
                                                    <Nodes>
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employment Details" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employee Assessment" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employee Leaves" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employee Overtime" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employee Sick Reporting" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Loan & Advances" />
                                                    </Nodes>
                                                </telerik:RadSiteMapNode>
                                                <telerik:RadSiteMapNode NavigateUrl="#" Text="Staff Statistics">
                                                    <Nodes>
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employees List" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Employee Details" />
                                                    </Nodes>
                                                </telerik:RadSiteMapNode>
                                                <telerik:RadSiteMapNode NavigateUrl="#" Text="Maintenance">
                                                    <Nodes>
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="General Definitions" />
                                                        <telerik:RadSiteMapNode NavigateUrl="#" Text="Staff Definitions" />
                                                    </Nodes>
                                                </telerik:RadSiteMapNode>
                                            </Nodes>
                                        </telerik:RadSiteMap>
                                    </div>
                                    <div id="FeatProduct">
                                        <h3>
                                            Featured</h3>
                                        <img src="Images/humanresources.png" alt="Deco Mirror Table Lamp - $ 24.99" width="128"
                                            height="150" />
                                        <p>
                                            Logo
                                            <br />
                                        </p>
                                    </div>
                                </ItemTemplate>
                            </telerik:RadMenuItem>
                        </Items>
                    </telerik:RadMenuItem>
                </Items>
            </telerik:RadMenu>
        </div>
    </div>--%>
</asp:Content>
