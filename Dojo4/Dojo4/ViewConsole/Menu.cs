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
            int escolha = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                MontaMenu();
                escolha = Escolha();
            } while (escolha != 0);
        }
        private void MontaMenu()
        {
            Console.WriteLine("\n1- Categorias\n2- Produtos\n0- Sair");
            
        }
        ModuloCategoria moduloCategoria = new ModuloCategoria();
        ModuloProduto moduloProduto = new ModuloProduto();
        private int Escolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    moduloCategoria.MenuCategoria();
                    break;
                case 2:
                    moduloProduto.MenuProduto();
                    break;
                default:
                    break;
            }
            return escolha;
        }
    }
}
