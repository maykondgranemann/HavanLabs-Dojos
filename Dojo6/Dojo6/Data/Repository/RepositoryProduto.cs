using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;



namespace Data.Repository
{
    public class RepositoryProduto
    {
        public static List<Produto> produtos { get; set; }
        public RepositoryProduto()
        {
            produtos = new List<Produto>();
        }

        public void Create(Produto model)
        {
            produtos.Add(model);
        }

        public List<Produto> ReadAll()
        {
            return produtos;
        }
    }
}
