using System;
using TrabalhandoComInterfaces.Dominio;
using TrabalhandoComInterfaces.Serviço;

namespace TrabalhandoComInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- BEM VINDO AO SISTEMA DE PAGAMENTO ONLINE! ----------");

            Console.WriteLine("Informe os dados do contrato!");

            Console.Write("Número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato: ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine()).Date;
            Console.Write("Valor total do contrato: R$");
            double valorContrato = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe o número de parcelas: ");
            int qtdParcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContratoService contratoService = new ContratoService(new PaypalService());
            contratoService.ProcessarContrato(contrato, qtdParcelas);

            Console.WriteLine("PARCELAS: ");
            foreach(var parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }

            

        }
    }
}
