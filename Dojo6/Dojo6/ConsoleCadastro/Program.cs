using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudConsole crud = new CrudConsole();
            crud.Create();
            Console.ReadLine();
        }
    }
}
