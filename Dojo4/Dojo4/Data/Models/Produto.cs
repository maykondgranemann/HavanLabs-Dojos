using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Produto(int id, string nome, decimal valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
        }
        public Produto()
        {

        }
        public override string ToString()
        {
            return $"ID {this.Id}\tNome: {this.Nome}\tValor: {this.Valor}";
        }
    }
}
