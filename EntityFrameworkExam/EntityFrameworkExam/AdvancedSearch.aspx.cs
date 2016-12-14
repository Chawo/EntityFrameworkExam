using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchAuthorsResultGridView();
        }

        protected void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            using (var ctx = new BooksEntities1())
            {
                 PopupateSearchAuthorsResultGridView();
            }
        }

        protected void btnTitleSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchTitlesResultGridView();
        }

        private void PopupateSearchAuthorsResultGridView()
        {
            using (var ctx = new BooksEntities1())
            {
                var authorsQuery = ctx.Authors.Where(x => x.FirstName.ToLower() == txtAuthorSearchText.Text.ToLower() || x.LastName.ToLower() == txtAuthorSearchText.Text.ToLower()).ToList();

                authorsResultGridView.DataSource = authorsQuery;
                authorsResultGridView.DataBind();
            }

        }

        private void PopupateSearchTitlesResultGridView()
        {
            using (var ctx = new BooksEntities1())
            {
              var titlesQuery = ctx.Titles.Where(x => x.Title1.ToLower() == txtTitleSearchText.Text.ToLower()).ToList();

              titlesResultGridView.DataSource = titlesQuery;
              titlesResultGridView.DataBind();
            }

        }
    }
}