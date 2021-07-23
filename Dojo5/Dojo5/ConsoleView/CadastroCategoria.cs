using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository;

namespace ConsoleView
{
    class CadastroCategoria
    {
        private RepositoryCategoria Repository { get; set; }
        public CadastroCategoria()
        {
            Repository = new RepositoryCategoria();
        }
        public void CadastrarCategoria()
        {
            Categoria cat = new Categoria();
            Console.WriteLine("----------Bemvindo----------");
            Console.WriteLine("Insira o ID");
            cat.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Nome da Categoria");
            cat.Nome = Console.ReadLine();
            Console.WriteLine("Insira a descricao da Categoria");
            cat.Descricao = Console.ReadLine();
            Repository.Create(cat);
            this.ListaCategoria();
        }
        public void ListaCategoria()
        {
            foreach (var item in Repository.ReadAll())
            {
                Console.WriteLine($"ID: {item.Id}\nNome: {item.Nome}\nDescrição: {item.Descricao}");
            }

        }

    }
}
