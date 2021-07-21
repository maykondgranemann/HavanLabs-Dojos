using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Categoria : BaseModel
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nome, string desc)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = desc;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\tNome: {this.Nome}\tDescrição: {this.Descricao}";
        }
    }
}
