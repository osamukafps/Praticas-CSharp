using ExercicioEnumDois.Entities;
using ExercicioEnumDois.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioEnumDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- SEJA BEM-VINDO! -----");
            Console.Write(Environment.NewLine + " *** INFORME OS DADOS DO CLIENTE *** " + Environment.NewLine);
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine()).Date;

            Cliente cliente = new Cliente(nome, email, dataNascimento);
            Console.WriteLine();

            Console.WriteLine("----- DADOS DO PEDIDO -----");

            Console.Write("Status do pedido: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Console.Write("Informe a quantidade de itens no pedido: ");
            int quantidadeItens = int.Parse(Console.ReadLine());

            Pedido pedido = new Pedido();
            pedido.Status = status;
            pedido.Cliente = cliente;
            Console.WriteLine();

            for (int i = 1; i <= quantidadeItens; i++)
            {
                Produto produto = new Produto();

                Console.WriteLine($"----- INFORME OS DADOS DO ITEM #{i} -----");
                Console.Write("Nome do Produto: ");
                produto.Nome = Console.ReadLine();              

                Console.Write("Preço do produto: R$");
                produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double preco = produto.Preco;

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                var itensPedido = new ItensPedido(quantidade, preco, produto);

                pedido.AdicionarItem(itensPedido);              
            }
            Console.WriteLine();

            pedido.Data = DateTime.Now;
            Console.WriteLine("----- RESUMO DO PEDIDO -----");
            Console.WriteLine();
            Console.WriteLine(pedido.ToString());

        }
    }
}
