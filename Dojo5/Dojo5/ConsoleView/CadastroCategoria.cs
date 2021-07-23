using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace ConsoleView
{
    class CadastroCategoria
    {
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
        }
    }
}
