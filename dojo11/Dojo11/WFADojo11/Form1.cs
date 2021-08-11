using Dojo11.Models;
using Dojo11.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADojo11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DrogasRepository repo = new DrogasRepository();
            Drogas model = new Drogas();
            model.Nome = this.txbNome.Text;
            model.Brisa = this.txbBrisa.Text;
            model.Peso = Convert.ToDecimal(this.txbPeso.Text);
            repo.Create(model);
            this.txbNome.Text = String.Empty;
            this.txbBrisa.Text = String.Empty;
            this.txbPeso.Text = String.Empty;
        }
    }
}
