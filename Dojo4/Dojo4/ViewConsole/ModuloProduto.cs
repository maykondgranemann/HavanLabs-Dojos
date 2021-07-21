using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{

    public class ModuloProduto : Tela
    {
        OperacoesProduto opProd = new OperacoesProduto();
        
        public void MenuProduto()
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
        private int Escolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    opProd.Cadastrar();
                    break;
                case 2:
                    opProd.Listar();
                    break;
                case 3:
                    opProd.Editar();
                    break;
                case 4:
                    opProd.Deletar();
                    break;
                default:
                    break;
            }
            return escolha;
        }
    }
}
