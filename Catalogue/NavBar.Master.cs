using DbEntities;
using OperationsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catalogue
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Catalogue 
            bool key = false;

            if (Session["User"] != null)
            {
                User user = new User();
                user = (User)Session["User"];
                key = user.IsAdmin;
            }

            Security security = new Security(key);
            if (!security.IsAdmin(this.Page.Request.Path.ToString()))
            {
                string message = "You cannot access this page because you are either not an administrator or not logged in. If you are logged in and are an administrator, please check.";
                Response.Redirect($"AuthorizationAccesPage.aspx?message={message}");
            }
        }
    }
}