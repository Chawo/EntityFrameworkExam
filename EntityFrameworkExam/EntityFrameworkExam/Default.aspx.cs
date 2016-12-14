using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchResultsGridViews();
        }

        private void PopupateSearchResultsGridViews()
        {

            using (var ctx = new BooksEntities1())
            {
                string searchText = txtSearchText.Text;

                ctx.Authors.Load();
                ctx.Titles.Load();

                var titlesQuery = ctx.Titles.Where(t => t.Title1 == searchText).ToList();

                var authorsQuery = ctx.Authors.Where(a=>a.FirstName == searchText || a.LastName == searchText).ToList();

                authorsResultGridView.DataSource = authorsQuery;
                authorsResultGridView.DataBind();

                titlesResultGridView.DataSource = titlesQuery;
                titlesResultGridView.DataBind();
            }

        }
    }
}