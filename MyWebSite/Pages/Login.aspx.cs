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
        //create new entity framwwork object 
        LibraryDBEntities db = new LibraryDBEntities();
        //create new user to store details of login 
        User user = new User();


        protected void Page_Load(object sender, EventArgs e)
        {
            //clears any exisiting session logins 
            Session.Clear();
        }

        //method to create log entry for DB when login 
        protected int CreateLog(int UserId, string Category, string description, DateTime Date)
        {
            //create var to savesucess
            int saveSuccess = 0;

            try
            {
                //new logs object to store in db
                Logs2 logs = new Logs2();
                //set userID in table was retieved userID
                logs.UserID = UserId;
                //set category in table was set text
                logs.Category = Category;
                //set description in table was set text
                logs.Description = description;
                //set log date as current date
                logs.Date = Date; 
                //store log info
                db.Logs2.Add(logs);

                //save changes to db
                saveSuccess = db.SaveChanges();

                //if no connection to db or can't save 
                if (saveSuccess == 0)
                {
                    lblSuccess.Text = "Error Creating Logs";
                }

            }
            catch (Exception ex)
            {
                lblSuccess.Text = "Error in database " + ex.InnerException;
            }
            //return save value to method 
            return (saveSuccess);
        }

        //Click event for login 
        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            //create var to check authentication
            bool authenticated = false;
            //create var to store username from textbox 
            var userName = tbxUsername.Text.Trim();
            //create var to store password from textbox 
            var passWord = tbxPassword.Text.Trim();
            //create var to savesucess 
            int saveSuccess = 0;

            //check Users in user table using retrieved parameters 
            foreach (var userRecord in db.Users.Where(t => t.Username == userName && t.Password == passWord))
            {
                //if users found set bool to true 
                authenticated = true;
                //set user object as the retireved user 
                user = userRecord;
                //break loop 
                break;
            }
            //
            DateTime today = DateTime.UtcNow;

            try
            {
                // Cannot save record whilst inside a foreach loop. Must be completed outside the loop
                saveSuccess = CreateLog(Convert.ToInt16(user.UID), "Login", "User " + user.Username.ToString() + " authenticated successfully.", today);
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
            catch (Exception ex)
            {

                lblSuccess.Text = "Wrong username or password!  " + ex.InnerException;
            }
            
        }
    }
}