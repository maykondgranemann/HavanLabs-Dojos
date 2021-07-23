using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCadastro
{
    class CrudConsole
    {
        public RepositoryProduto Repository { get; set; }

        public CrudConsole()
        {
            Repository = new RepositoryProduto();
        }
        public void Create()
        {
            Produto model = new Produto();
            Console.Write("Digite o ID: ");
            model.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            model.Nome = Console.ReadLine();
            Console.Write("Descrição: ");
            model.Descricao = Console.ReadLine();
            Console.Write("Valor: R$");
            model.Valor = Convert.ToDecimal(Console.ReadLine());
            Repository.Create(model);
        }
    }
}
