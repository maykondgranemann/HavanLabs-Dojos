using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Repository
{
    public class RepositoryCategoria
    {
        private List<Categoria> Categorias { get; set; }
        public RepositoryCategoria()
        {
            this.Categorias = new List<Categoria>();
        }
        public void Create(Categoria model)
        {
            this.Categorias.Add(model);
        }
    }
    
}
