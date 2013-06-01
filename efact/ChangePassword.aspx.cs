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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["GlbUserId"] == "")
            {
                Response.Redirect("UnAuthorized.aspx");
            }
            OldPassword.Text = "Nesimi123456789";
            NewPassword.Focus();
        }

        protected void OldPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(OldPassword.Text))
            {
                if (OldPassword.Text != Session["OldPassword"])
                {
                    lblError.Text = "Please check current password";
                }
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            eFact.BLL.Login objLogin = new eFact.BLL.Login();
            if (VerifyPassword())
            {
                objLogin.SaveUserPassword(ConfigurationManager.AppSettings["GlbUserId"], ConfirmNewPassword.Text);
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            OldPassword.Text = string.Empty;
            NewPassword.Text = string.Empty;
            ConfirmNewPassword.Text = string.Empty;
        }

        protected void ConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            VerifyPassword();
        }

        private bool VerifyPassword()
        {
            bool IsPasswordMatch = false;
            if (!string.IsNullOrWhiteSpace(NewPassword.Text) && !string.IsNullOrWhiteSpace(ConfirmNewPassword.Text))
            {
                if (NewPassword.Text != ConfirmNewPassword.Text)
                {
                    lblError.Text = "Password is not maching. Please check !";
                }
                else
                {
                    IsPasswordMatch = true;
                }
            }
            return IsPasswordMatch;
        }
    }
}