using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class ListBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDropDownMenu();
            }

        }

        protected void authorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopupateBooksGridView();
        }

        private void PopupateBooksGridView()
        {
            using (var ctx = new BooksEntities1())
            {
                var selected = int.Parse(authorsDropDownList.SelectedValue);

                var titlesQuery = ctx.Authors.Where(x=>x.AuthorID == selected).Include("Titles").ToList();

                titlesGridView.DataSource = titlesQuery.First().Titles;
                titlesGridView.DataBind();
            }
        }


        private void LoadDropDownMenu()
        {
            using (var ctx = new BooksEntities1())
            {
                var authorsQuery = ctx.Authors.ToList();
                //Todo: Get all authors and bind them to the dropdown menu

                authorsDropDownList.DataValueField = "AuthorID";
                authorsDropDownList.DataTextField = "FirstName";
                authorsDropDownList.DataSource = authorsQuery;
                authorsDropDownList.DataBind();
            }
            

        }
    }
}