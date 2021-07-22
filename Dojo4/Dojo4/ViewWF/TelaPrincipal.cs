﻿using System;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;            
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CategoriaForm catForm = new CategoriaForm();
            catForm.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ProdutoForm produtoForm = new ProdutoForm();
            produtoForm.Show();
        }
    }
}
