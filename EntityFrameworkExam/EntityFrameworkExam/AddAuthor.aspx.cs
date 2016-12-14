using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkExam
{
    public partial class AddAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorToDb();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCountryOfResidence.Text = "";
        }

        private void AddAuthorToDb()
        {
            //Todo: Add Author to the database through Entity framework

        }
    }
}