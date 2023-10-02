using System;
using System.Collections.Generic;

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Remover Produto pelo ID");
            Console.WriteLine("3. Editar Produto pelo ID");
            Console.WriteLine("4. Visualizar Todos os Produtos");
            Console.WriteLine("5. Sair");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        RemoverProduto();
                        break;
                    case 3:
                        EditarProduto();
                        break;
                    case 4:
                        VisualizarProdutos();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static void AdicionarProduto()
    {
        Console.WriteLine("Informe o nome do produto:");
        string nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome inválido. O produto não foi adicionado.");
            return;
        }

        Console.WriteLine("Informe o ID do produto:");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido. O produto não foi adicionado.");
            return; 
        }

        produtos.Add(item: new Produto { Nome = nome, ID = id });
        Console.WriteLine("Produto adicionado com sucesso!");
    }


    static void RemoverProduto()
    {
        Console.WriteLine("Informe o ID do produto a ser removido:");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Produto produtoParaRemover = produtos.Find(p => p.ID == id);

            if (produtoParaRemover != null)
            {
                produtos.Remove(produtoParaRemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Tente novamente.");
        }
    }

    static void EditarProduto()
    {
        Console.WriteLine("Informe o ID do produto a ser editado:");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            Produto produtoParaEditar = produtos.Find(p => p.ID == id);
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            if (produtoParaEditar != null)
            {
                Console.WriteLine("Informe o novo nome do produto:");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                string novoNome = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                produtoParaEditar.Nome = novoNome;
                Console.WriteLine("Produto editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Tente novamente.");
        }
    }

    static void VisualizarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.ID}, Nome: {produto.Nome}");
        }
    }
}
public class Produto
{


    public int ID { get; } 
    public string? Nome { get; set; }
}
