using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Data.Repository;

namespace WF
{
    public partial class Fcategoria : Form
    {
        private RepositoryCategoria Repository { get; set; }
        public Fcategoria()
        {
            InitializeComponent();
            Repository = new RepositoryCategoria();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Id = Convert.ToInt32(tbIdC.Text);
            cat.Nome = tbNomeC.Text;
            cat.Descricao = tbDescriC.Text;
            Repository.Create(cat);
        }
    }
}
