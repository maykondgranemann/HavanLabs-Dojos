using System;
using Data.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWF
{
    public partial class CategoriaForm : Form
    {
        public List<Categoria> Categoria { get; set; }

        public CategoriaForm()
        {
            InitializeComponent();
            Categoria = new List<Categoria>();
            dgCategorias.AutoGenerateColumns = false;
            dgCategorias.AllowUserToAddRows = false;
            CarregarLista();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Id = Convert.ToInt32(tbId.Text);
            categoria.Nome = tbNome.Text;
            categoria.Descricao = tbDescricao.Text;
            int indexDadoProcurado = Categoria.FindIndex(c => c.Id == categoria.Id);
            if (indexDadoProcurado == -1)
            {
                this.Categoria.Add(categoria);
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                this.Categoria[indexDadoProcurado] = categoria;
                MessageBox.Show("Editado com sucesso");
            }
            CarregarLista();
            LimparCampos();
        }

        private void CarregarLista()
        {
            dgCategorias.Rows.Clear();                      
            foreach (var item in Categoria)
            {
                dgCategorias.Rows.Add(item.Id, item.Nome, item.Descricao);
            }
            dgCategorias.Refresh();
        }

        private void LimparCampos()
        {
            tbId.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbDescricao.Text = String.Empty;
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.ColumnIndex;
         
            if(indice == 3)
            {
                Categoria categoria =  this.Categoria[e.RowIndex];
                CarregaFormulario(categoria);
            }
            else if(indice == 4) 
            {
                Categoria categoria = this.Categoria[e.RowIndex];
                this.Categoria.Remove(categoria);
                MessageBox.Show("Removido com sucesso");                
                CarregarLista();
            }
        }
        private void CarregaFormulario(Categoria categoria)
        {
            this.tbId.Text = categoria.Id.ToString();
            this.tbNome.Text = categoria.Nome;
            this.tbDescricao.Text = categoria.Descricao;
            this.lbMensagem.Text = String.Empty;

        }
    }
}
