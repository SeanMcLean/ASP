using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowUser();
        }
        private void ShowUser()
        {
            user.Username = ((MasterPage)this.Master).currentUser.Username;
            //user = ((MasterPage)this.Master).currentUser;

            lblWelcome.Text = user.Username.ToString();
        }
    }
}