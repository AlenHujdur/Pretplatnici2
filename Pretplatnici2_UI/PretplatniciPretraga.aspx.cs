using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pretplatnici2_UI
{
    public partial class PretplatniciPretraga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
               BindPretplatnici();
            }
        }

        protected void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            BindPretplatnici();
        }

        private void BindPretplatnici()
        {
            GridPretplatnici.DataSource = Pretplatnici2_DAL.Service_DA.PreuzmiPretplatnika(txtPretraga.Text);
            GridPretplatnici.DataBind();
        }
    }
}