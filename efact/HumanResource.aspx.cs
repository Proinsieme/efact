using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace efact
{
    public partial class HumanResource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void activitiesAndAttentionLink_Click(object sender, EventArgs e)
        {
            ActivitiesAndAttentions.Visible = true;
        }
    }
}