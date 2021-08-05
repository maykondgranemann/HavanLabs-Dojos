using AppWeb.Models;
using AppWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Cadastro : System.Web.UI.Page
    {
        public CarrosRepository Repository { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Repository = new CarrosRepository();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Carros carro = new Carros();
            carro.Id = Convert.ToInt32(this.txtId.Text);
            carro.Marca = this.txtMarca.Text;
            carro.Modelo = this.txtModelo.Text;
            Repository.Create(carro);
            this.LimpaCampos();
        }


        public void LimpaCampos()
        {
            this.txtId.Text = String.Empty;
            this.txtMarca.Text = String.Empty;
            this.txtModelo.Text = String.Empty;

        }
    }
}