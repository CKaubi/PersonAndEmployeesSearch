using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCrypt.Net;
namespace WebApplicationServicePerson
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            DatabaseProvaider databaseProvaider = new DatabaseProvaider();
            Page.Validate();
            if (!Page.IsValid) return;
            string encryptedPassword = databaseProvaider.GetPassword(TextBoxLogin.Text.Trim());

            if (encryptedPassword != null && BCrypt.Net.BCrypt.Verify(TextBoxPassword.Text , encryptedPassword))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBoxLogin.Text, false);
            }
            else
            {
                LBStatus.Text = Resources.ErrorAutification;
            }
        }

        protected void ButtonRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}