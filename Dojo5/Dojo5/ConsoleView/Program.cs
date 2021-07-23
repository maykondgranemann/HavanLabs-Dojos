using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroCategoria cadcategoria = new CadastroCategoria();
            cadcategoria.CadastrarCategoria();
            Console.ReadLine();
        }
    }
}
