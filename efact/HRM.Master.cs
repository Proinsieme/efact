using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace efact
{
    public partial class HRM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string LoginUser = Convert.ToString(ConfigurationManager.AppSettings["GlbUserId"]);
            if (WelcomeNote != null)
            {
                if (LoginUser.Trim() != "")
                {
                    WelcomeNote.Text = "Welcome " + LoginUser;
                    Seperator.Visible = true;
                    logout.Visible = true;
                }
                else
                {
                    WelcomeNote.Text = "";
                    Seperator.Visible = false;
                    logout.Visible = false;
                }
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["GlbUserId"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}