using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Produto : System.Web.UI.Page
    {
        public RepositoryProduto Repository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Repo"] == null)
            {
                this.Repository = new RepositoryProduto();
                Session.Add("nome", this.Repository);
               
            }
            else
            {
                this.Repository = (RepositoryProduto)Session["Repo"];
            }
            CarregaLista();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Data.Models.Produto produto = new Data.Models.Produto();
            produto.Id = Convert.ToInt32( txbId.Text);
            produto.Nome = txbNome.Text;
            produto.Descricao = txbDescricao.Text;
            produto.Valor = Convert.ToDecimal(txbValor.Text);            
            this.Repository.Create(produto);
            CarregaLista();
        }

        private void CarregaLista()
        {
            this.gdProdutos.DataSource = Repository.ReadAll();
            this.gdProdutos.DataBind();
        }
    }
}