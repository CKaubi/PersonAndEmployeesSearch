using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCrypt.Net;

namespace WebApplicationServicePerson
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        
        protected void ButtonRegistration_Click(object sender, EventArgs e)
        { 

            if (TextBoxPasswordDouble.Text.Trim()!="" && TextBoxPasswordDouble.Text.Trim() == TextBoxPassword.Text.Trim())
            {
                string encryptedStringAES = BCrypt.Net.BCrypt.HashPassword(TextBoxPassword.Text);
                
                DatabaseProvaider databaseProvaider = new DatabaseProvaider();

                bool chekcLogin = databaseProvaider.CheckLogins(TextBoxLogin.Text.Trim());
                if (!chekcLogin)
                {
                    databaseProvaider.Registration(TextBoxLogin.Text, encryptedStringAES);
                    LabelStatus.Text = Resources.RegistrationCompleteMessage;
                    LabelCheck.Text = "";
                }
                else
                {
                    LabelStatus.Text = "";
                    LabelCheck.Text = Resources.UsernameIsBusyMessage;
                }
            }
            else
            {
                LabelStatus.Text = "";
                LabelCheck.Text = Resources.PasswordMustMatchMessage;
            }
        }
        protected void ButtonLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}