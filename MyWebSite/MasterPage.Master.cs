using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public User currentUser = new User();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
        }
    }
}