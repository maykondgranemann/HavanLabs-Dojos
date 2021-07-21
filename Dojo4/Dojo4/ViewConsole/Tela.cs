using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Tela
    {
        public void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************Havan Labs**************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escolha uma opcao:");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
