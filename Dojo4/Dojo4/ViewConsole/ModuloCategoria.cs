using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class ModuloCategoria : Tela
    {
        public void MenuCategoria()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("\n1 - Cadastrar \n2 - Alterar \n3 - Deletar \n4 - Listar \n0 - Sair");
        }
        public void Escolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

    }
}
