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
                if (objLogin != null)
                {
                    if (objLogin.RecordStatus == "U")
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('User is in Unauthorized state. Please check this with your Security Officer(s)');", true);
                    }
                    else if (objLogin.ActivationDate > DateTime.Today)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('User activation date is not reached. Activation date is " + objLogin.ActivationDate + "');", true);
                    }
                    else if (DateTime.Today > objLogin.ProfileEndDate)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Your login profile date has expired, please contact your Security Officer(s)');", true);
                    }
                    else if (objLogin.PasswordExpireDate > DateTime.Today)
                    {
                        //if ((objLogin.PasswordExpireDate - DateTime.Today).Days)) // <= Session["PasswordExpireDate"])
                        //{
                            ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Password will expire about " + (objLogin.PasswordExpireDate - DateTime.Today).Days + " day(s)');", true);
                        //}
                    }
                    else if ((objLogin.PasswordExpireDate - DateTime.Today).Days <= Convert.ToInt32(Session["PasswordExpireDate"]))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Password is expired, please change your password');", true);
                        Response.Redirect("ChangePassword.aspx");
                        Session["OldPassword"] = pwbPassword.Text;
                    }
                    else
                    {
                        ConfigurationManager.AppSettings["GlbUserId"] = loginExists;
                        //string glbUserId = ConfigurationManager.AppSettings["GlbUserId"].ToString();
                        Response.Redirect("efactModules.aspx");
                    }
                }
               
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