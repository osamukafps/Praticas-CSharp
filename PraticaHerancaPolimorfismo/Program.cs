using System;
using System.Collections.Generic;
using System.Globalization;
using PraticaHerancaPolimorfismo.Entities;

namespace PraticaHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de contribuintes: ");
            int c = int.Parse(Console.ReadLine());

            List<Contribuinte> listContribuintes = new List<Contribuinte>();

            for(int i = 1; i <= c; i++)
            {   
                Console.WriteLine($" ----- DADOS DO CONTRIBUINTE #{i} -----");

                Console.Write(Environment.NewLine + " F - Pessoa Física \n J - Pessoa Jurídica \n Opção: ");
                char opcao = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();              

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Arrecadação anual: R$");
                double renda = double.Parse(Console.ReadLine());

                if(opcao == 'F')
                {
                    Console.Write("Gastos com saúde: R$");
                    double gastosSaude = double.Parse(Console.ReadLine());
                    PessoaFisica pessoaFisica = new PessoaFisica(nome, renda, gastosSaude);
                    
                    listContribuintes.Add(pessoaFisica);
                }

                else
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    PessoaJuridica pessoaJuridica = new PessoaJuridica(nome, renda, numeroFuncionarios);

                    listContribuintes.Add(pessoaJuridica);
                }
                
                Console.WriteLine();

            }

            double total = 0;
            Console.WriteLine();
            int n = 0;

            foreach(var item in listContribuintes)
            {
                Console.WriteLine($"Contribuinte #{n}");
                Console.WriteLine($" Nome: {item.Nome} \n Impostos pagos: R${item.Imposto().ToString("F2", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                total += item.Imposto();
                n++;
            }

            Console.Write(Environment.NewLine + "TOTAL PAGO EM IMPOSTOS: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

