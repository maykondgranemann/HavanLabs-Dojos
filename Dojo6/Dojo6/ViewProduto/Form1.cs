using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProduto
{
    public partial class Form1 : Form
    {
        public RepositoryProduto Repository { get; set; }
        public Form1()
        {
            InitializeComponent();
            dgProdutos.AllowUserToAddRows = false;
            dgProdutos.AutoGenerateColumns = false;
            Repository = new RepositoryProduto();
            CarregaLista();
        }

        private void CarregaLista()
        {
            dgProdutos.Rows.Clear();
            foreach (Produto produto in Repository.ReadAll())
            {
                dgProdutos.Rows.Add(produto.Id, produto.Nome, produto.Descricao, produto.Valor);
            }
            dgProdutos.Refresh();
        }
    }
}
