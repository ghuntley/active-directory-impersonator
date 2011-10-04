using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.ghuntley.toolbox
{
    public partial class debug : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("ASP.NET running as: " + Environment.UserName + "<br/>");
            Response.Write("Authenticated as: " + User.Identity.Name + "<br/>");
            using (new Impersonator(Config.adUsername, Config.adDomain, Config.adPassword))
            {
                Response.Write("ASP.NET (after impersonation) running as: " + Environment.UserName + "<br/>");
                Response.Write("Authenticated (after impersonation) as: " + User.Identity.Name + "<br/>");
            }
        }
    }
}