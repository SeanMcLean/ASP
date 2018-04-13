using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MyWebSite.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        LibraryDBEntities db = new LibraryDBEntities();
        User user = new User();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUsername.Text.Trim();
            var passWord = tbxPassword.Text.Trim();

            foreach(var userRecord in db.Users.Where(t => t.Username == userName && t.Password == passWord))
            {
                user = userRecord;
                authenticated = true;
            }

            if (authenticated)
            {
                ((MasterPage)this.Master).currentUser = this.user;

                Response.Redirect("~/pages/Home.aspx");
            }

        }
    }
}