using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace WebApplicationServicePerson
{

    public partial class BaseForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string textMessage;
            textMessage = Resources.clarifyingMessage;
            LabelPrintInformation.Text = textMessage;

            textMessage = Resources.helpMessage;
            LabelHelp.Text = textMessage;
            if (!IsPostBack)
            {
                LabelEmployCheck.Text = "";
                DataBindGridviewNames();
            }
        }

        protected void ButtonFirst_Click(object sender, EventArgs e)
        {

            string textMessage = Resources.clarifyingMessage;
            LabelPrintInformation.Text = textMessage;
            PersonsRepository.Repository.Persons.Clear();

            PersonsRepository.Repository.Simbol = Convert.ToChar(TextBoxInputChar.Text);
            if (CheckEmployee.Checked)
            {
                if (GridViewNames.Columns[3].Visible == true)
                {
                    GridViewNames.Columns[3].Visible = false;
                }
                PersonsRepository.Repository.AddEmployee((int)Requests.first);
            }
            else
            {
                if (GridViewNames.Columns[3].Visible == false)
                {
                    GridViewNames.Columns[3].Visible = true;
                }
                PersonsRepository.Repository.AddPerson((int)Requests.first);
            }

            if (PersonsRepository.Repository.Persons.Count > 0)
            {
                if (ResultPanel.Visible == false)
                {
                    ResultPanel.Visible = true;
                }
                string NumberAndListNamesMessage = Resources.NumberAndListNames + PersonsRepository.Repository.Simbol;
                LabelInformationAfterInput.Text = NumberAndListNamesMessage;
                string countNameMessage = Resources.NumberNamesMessage + " : " + PersonsRepository.Repository.Persons.Count;
                LabelOutRezult.Text = countNameMessage;
                DataBindGridviewNames();
            }
            else
            {
                if (ResultPanel.Visible == true)
                {
                    ResultPanel.Visible = false;
                }
                textMessage = Resources.emptuNamesListMessage;
                LabelOutRezult.Text = textMessage;
            }
            TextBoxInputChar.Text = "";
        }

        protected void ButtonAny_Click(object sender, EventArgs e)
        {
            PersonsRepository.Repository.Persons.Clear();

            if (ResultPanel.Visible == true)
            {
                ResultPanel.Visible = false;
            }

            PersonsRepository.Repository.Simbol = Convert.ToChar(TextBoxInputChar.Text);

            if (CheckEmployee.Checked)
            {
                PersonsRepository.Repository.AddEmployee((int)Requests.any);
            }
            else
            {
                PersonsRepository.Repository.AddPerson((int)Requests.any);
            }

            if (PersonsRepository.Repository.Persons.Count > 0)
            {
                string numberNamesMessage = Resources.NumberNamesMessage + PersonsRepository.Repository.Persons.Count;

                LabelInformationAfterInput.Text = numberNamesMessage;
                List<string> names = PersonsRepository.Repository.GetFirstNames();
                int numberOccurrences = NumberOccurrencesInList(names);

                string resultMessageButtonAny = Resources.resultMessageButtonAny + numberOccurrences;
                LabelOutRezult.Text = resultMessageButtonAny;
                TextBoxInputChar.Text = "";
            }
            else
            {
                string textMessage = Resources.emptuNamesListMessage;
                LabelOutRezult.Text = textMessage;
            }
        }

      
        public int NumberOccurrencesInList(List<string> Names)
        {
            int counterOccurrences = 0;

            foreach (string name in Names)
            {
                counterOccurrences = counterOccurrences + name.Split(PersonsRepository.Repository.Simbol).Length-1;
            }

            return counterOccurrences;
        }

        public void DataBindGridviewNames()
        {
            if (PersonsRepository.Repository.Persons != null && PersonsRepository.Repository.Persons.Count > 0)
            {
                GridViewNames.DataSource = PersonsRepository.Repository.Persons;
                GridViewNames.DataBind();
            }
        }

        protected void GridViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)GridViewNames.SelectedDataKey.Value;
            Person person = PersonsRepository.Repository.GetPerson(id);
            if (person != null)
            {
                Session["Person"] = person;
                Response.Redirect("PersonInfo.aspx");
            }
            else
            {
                if (ResultPanel.Visible == true)
                {
                    ResultPanel.Visible = false;
                }
                LabelInformationAfterInput.Text = Resources.outdatedInformation;
                LabelOutRezult.Text = "";
                TextBoxInputChar.Text = "";
            }
        }

        protected void TextBoxInputChar_TextChanged(object sender, EventArgs e)
        {
            Validate("ButtonAny");
        }

        protected void GridViewNames_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Hire")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                PersonsRepository employees = new PersonsRepository();
                employees.Simbol = PersonsRepository.Repository.Simbol;
               
                employees.AddEmployee((int)Requests.first);
                Person employee = employees.GetPerson((int)GridViewNames.DataKeys[id].Value);
               
                if (employee == null)
                {
                    DatabaseProvaider databaseProvaider = new DatabaseProvaider();
                   databaseProvaider.HirePerson((int)GridViewNames.DataKeys[id].Value);
                    LabelEmployCheck.Text = "";
                }
                else
                {
                    LabelEmployCheck.Text = Resources.AlreadyHired;
                }
            }
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
        }
    }
}
