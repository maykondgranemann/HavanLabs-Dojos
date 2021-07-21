using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    class OperacoesCategoria : Crud
    {
        int idCat = 1;
        public OperacoesCategoria()
        {
            opCadastrar = CadastrarCat;
            opListar = ListarCat;
            opEditar = EditarCat;
            opDeletar = DeletarCat;
        }

        private void CadastrarCat()
        {
            Console.WriteLine($"Cadastrando {idCat}a Categoria");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine().Trim();
            Console.Write("Digite a descrição: ");
            string desc = Console.ReadLine();
            Categoria modelCat = new Categoria(idCat, nome, desc);
            lista.Add(modelCat);
            idCat++;
        }

        private void ListarCat()
        {
            Console.WriteLine("\t\tLista De Categorias\n");
            foreach (Categoria cat in lista)
            {
                Console.WriteLine(cat);
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
        private void EditarCat()
        {
            ListarCat();
            Console.WriteLine("Selecione o Id da categoria: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var model = (Categoria)lista.Find(c => c.Id == id);
            Console.Write("Digite o nome: ");
            model.Nome = Console.ReadLine().Trim();
            Console.Write("Digite a descrição: ");
            model.Descricao = Console.ReadLine();


        }
        private void DeletarCat()
        {
            ListarCat();
            Console.WriteLine("Selecione o Id da categoria: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var model = lista.Find(c => c.Id == id);
            lista.Remove(model);

        }
    }
}
