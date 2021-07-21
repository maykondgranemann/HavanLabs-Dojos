using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public delegate void Operacao();
    class Crud
    {
        protected List<BaseModel> lista = new List<BaseModel>();
        protected Operacao opCadastrar;
        protected Operacao opListar;
        protected Operacao opEditar;
        protected Operacao opDeletar;

        public void Cadastrar()
        {
            opCadastrar();
        }

        public void Listar()
        {
            opListar();
        }
        public void Editar()
        {
            opEditar();
        }
        public void Deletar()
        {
            opDeletar();
        }
    }
}
