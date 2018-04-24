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

         protected int CreateLog(int UserId, string Category, string description)
         {
             int saveSuccess = 0;
             try
             {
               
                 Log logs = new Log();
                 logs.UserID = UserId;
                 logs.Category = Category;
                 logs.Description = description;
                 db.Logs.Add(logs);

                saveSuccess = db.SaveChanges();

                 if (saveSuccess == 0)
                 {
                     lblSuccess.Text = "Error Creating Logs";
                 }
             }
             catch (Exception ex)
             {
                lblSuccess.Text = "Error in database " + ex.InnerException;
             }
            return (saveSuccess);
        }


        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUsername.Text.Trim();
            var passWord = tbxPassword.Text.Trim();
            int saveSuccess = 0;

            foreach (var userRecord in db.Users.Where(t => t.Username == userName && t.Password == passWord))
            {
                authenticated = true;
                user = userRecord;
                break;
            }
            // Cannot save record whilst inside a foreach loop. Must be completed outside the loop
            saveSuccess = CreateLog(Convert.ToInt16(user.UID), "Login", "User " + user.Username.ToString() + " authenticated successfully.");
            // saveSuccess indicates if the record has been saved successfully into the SQL database

            if (authenticated)
            {
                // Use a session state to store the current user.
                HttpContext.Current.Session["currentUser"] = user;

                //Send user to the home page when authenticated
                Response.Redirect("~/pages/home.aspx");
            }
            else
            {
                lblSuccess.Text = "Incorrect Username or Password";
            }
            
        }
    }
}