using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace com.ghuntley.toolbox
{
    internal class Config
    {
        internal static string adDomain = WebConfigurationManager.AppSettings["adDomain"].ToString();
        internal static string adUsername = WebConfigurationManager.AppSettings["adUsername"].ToString();
        internal static string adPassword = WebConfigurationManager.AppSettings["adPassword"].ToString();
    }
}