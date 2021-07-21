using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class ModuloCategoria : Tela
    {
        OperacoesCategoria opCat;
        public ModuloCategoria()
        {
            opCat = new OperacoesCategoria();
        }
        public void MenuCategoria()
        {
            int escolha = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                Console.WriteLine("\n1 - Cadastrar \n2 - Listar \n3 - Editar \n4 - Deletar \n0 - Sair");
                escolha = Escolha();
            } while (escolha != 0);

        }
        public int Escolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    opCat.Cadastrar();
                    break;
                case 2:
                    opCat.Listar();
                    break;
                case 3:
                    opCat.Editar();
                    break;
                case 4:
                    opCat.Deletar();
                    break;
                default:
                    break;
            }
            return escolha;
        }

    }
}
