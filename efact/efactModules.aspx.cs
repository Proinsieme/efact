﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace efact
{
    public partial class efactModules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["GlbUserId"] == "")
            {
                Response.Redirect("UnAuthorized.aspx");
            }
        }
    }
}