using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eFact.BLL;
using System.Configuration;

namespace efact
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetSecurityParameter();
            }
        }

        private void GetSecurityParameter()
        {
            SecurityParameter objSecurityParameter = new SecurityParameter();
            objSecurityParameter = objSecurityParameter.SecurityParameterGet();

            if (objSecurityParameter != null)
            {
                Session["PasswordExpireDate"] = objSecurityParameter.PasswordExpireDate;
                Session["FourEyePolicy"] = objSecurityParameter.FourEyePolicy;
                Session["MaxLoginLimit"] = objSecurityParameter.MaxLoginLimit;
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            tbxUserName.Text = "";
            pwbPassword.Text = "";
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            eFact.BLL.Login objLogin = new eFact.BLL.Login();
            string loginExists = "0";

            loginExists = objLogin.CheckUserExists(tbxUserName.Text, pwbPassword.Text, out objLogin);

            if (loginExists != "0")
            {
                ConfigurationManager.AppSettings["GlbUserId"] = loginExists;
                //string glbUserId = ConfigurationManager.AppSettings["GlbUserId"].ToString();
                Response.Redirect("efactModules.aspx");
            }
            else
            {
                /* Failure report */
                FailureText.Text = "User not Exists !";
            }
        }

        protected void tbxUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbxUserName.Text.Trim() != "")
            {
                tbxUserName.Text = tbxUserName.Text.ToUpper();
            }
        }
       
    }
}