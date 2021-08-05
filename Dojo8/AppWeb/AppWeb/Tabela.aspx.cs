using AppWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Tabela : System.Web.UI.Page
    {
        public CarrosRepository Repository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Repository = new CarrosRepository();
            gvCarros.DataSource = Repository.Read();
            gvCarros.DataBind();
        }

        protected void gvCarros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int linha = e.RowIndex;
            int id = Convert.ToInt32(gvCarros.Rows[linha].Cells[1].Text);
            Repository.Delete(id);
            gvCarros.DataSource = Repository.Read();
            gvCarros.DataBind();
        }
    }
}