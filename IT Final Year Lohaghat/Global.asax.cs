using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace IT_Final_Year_Lohaghat
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["ApplicationsCount"] = 0;
            Application["SessionsCount"] = 0;
            Application["ApplicationsCount"] = (int)Application["ApplicationsCount"] + 1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["SessionsCount"] = (int)Application["SessionsCount"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            Application["SessionsCount"] = (int)Application["SessionsCount"] + 1;
        }
    }
}