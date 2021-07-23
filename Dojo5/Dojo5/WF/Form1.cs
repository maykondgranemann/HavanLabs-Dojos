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

namespace WF
{
    public partial class Fcategoria : Form
    {
        public Fcategoria()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Id = Convert.ToInt32(tbIdC.Text);
            cat.Nome = tbNomeC.Text;
            cat.Descricao = tbDescriC.Text;
        }
    }
}
