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
      //  Log log = new Log();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

     /*   protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUserName.Text.Trim();
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

        }*/

       /* protected void CreateLog(int UserId, string Category, string description)
        {
            try
            {
                Logs logs = new Logs();
                logs.UserID = UserId;
                logs.Category = Category;
                logs.Description = description;
                db.Logs.Add(logs);
                //db.logs.Add(logs);
                int sucess = db.SaveChanges();

                if (sucess == 0)
                {
                    lblSuccess.Text = "Error Creating Logs";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        */

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUsername.Text.Trim();
            var passWord = tbxPassword.Text.Trim();

            foreach (var userRecord in db.Users.Where(t => t.Username == userName && t.Password == passWord))
            {
                authenticated = true;

            //    CreateLog(user.UID, "Login", "User " + user.Username + " Aut Suc");
                user = userRecord;
                break;

                ((MasterPage)this.Master).currentUser = this.user;
            }

            if (authenticated)
            {
                Response.Redirect("../pages/Home.aspx");
            }
            else
            {
                lblSuccess.Text = "Problem Loggin In";
            }
            
        }
    }
}