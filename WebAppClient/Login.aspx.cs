using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;

namespace WebFormsIdentity
{
    public partial class Login : System.Web.UI.Page
    {
        protected void LoginUser_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser() { UserName = UserName.Text };
            IdentityResult result = manager.Create(user, Password.Text);

            if (result.Succeeded)
            {
                //DBshit db.get(user)
                // if pw ==DB.PW && DB.getUser != null
                //login, add something to session
                Response.Redirect("UserEntryPage.aspx");
                //else if  DB.getUser != null (user does not exist)
                //reload page




            }
            else
            {
                StatusMessage.Text = result.Errors.FirstOrDefault();
            }
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}