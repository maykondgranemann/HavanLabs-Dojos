using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class OperacoesProduto : Crud
    {
        int idProd = 1;
        public OperacoesProduto()
        {
            opCadastrar = CadastrarProd;
            opListar = ListarProd;
            opEditar = EditarProd;
            opDeletar = DeletarProd;
        }

        private void CadastrarProd()
        {
            Console.WriteLine($"Cadastrando {idProd}o Produto");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine().Trim();
            Console.Write("Digite o valor: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Produto modelCat = new Produto(idProd, nome, valor);
            lista.Add(modelCat);
            idProd++;
        }

        private void ListarProd()
        {
            Console.WriteLine("\t\tLista De Produtos\n");
            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
        private void EditarProd()
        {
            ListarProd();
            Console.WriteLine("Selecione o Id do Produto: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var model = (Produto)lista.Find(p => p.Id == id);
            Console.Write("Digite o nome: ");
            model.Nome = Console.ReadLine().Trim();
            Console.Write("Digite o valor: ");
            model.Valor = Convert.ToDecimal(Console.ReadLine());


        }
        private void DeletarProd()
        {
            ListarProd();
            Console.WriteLine("Selecione o Id do Produto: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var model = lista.Find(p => p.Id == id);
            lista.Remove(model);

        }
    }
}
