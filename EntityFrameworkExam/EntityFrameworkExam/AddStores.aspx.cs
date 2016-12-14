using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkExam
{
    public partial class AddStores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAddStore_Click(object sender, EventArgs e)
        {
            AddStoreToDb();

            txtStoreLocation.Text = "";
            txtStoreTel.Text = "";
            chkPreferred.Checked = false;
        }

        private void AddStoreToDb()
        {
            //Todo: Add Store to the database through Entity framework
            using (var ctx = new BooksEntities1())
            {
                Store newStore = new Store()
                {
                    StoreLocation = txtStoreLocation.Text,
                    StoreTel = txtStoreTel.Text,
                    PreferredSupplier = chkPreferred.Checked
                };
                ctx.Stores.Add(newStore);
                ctx.SaveChanges();
            }
        }
    }
}