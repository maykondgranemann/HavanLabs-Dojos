using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    class Menu : Tela
    {
        public void CriaMenu()
        {
            Cabecalho();
            MontaMenu();
            Escolha();
        }
        private void MontaMenu()
        {
            Console.WriteLine("\n1- Categorias \n0- Sair");
            
        }
        ModuloCategoria moduloCategoria = new ModuloCategoria();
        private void Escolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    moduloCategoria.MenuCategoria();
                    break;
                case 0:

                    break;
                default:
                    break;
            }
        }
    }
}
