using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.IO;
using System.Threading.Tasks;


namespace WebApplicationServicePerson
{
    public partial class PersonInfo : BaseForm
    {
        protected string ReturnUrl
        {
            get
            {
                if (ViewState["ReturnUrl"] != null)
                    return ViewState["ReturnUrl"].ToString();
                else
                    return null;
            }
            set { ViewState["ReturnUrl"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person>();
            persons.Add((Person)Session["Person"]);

            GridViewPersonInfo.DataSource = persons;
            GridViewPersonInfo.DataBind();

            if (!IsPostBack)
            {
                if (Request.UrlReferrer != null)
                    ReturnUrl = Request.UrlReferrer.ToString();
            }
        }

        protected void ButtonOnBasePage_Click(object sender, EventArgs e)
        {
            Response.Redirect(ReturnUrl);
        }
    }
}