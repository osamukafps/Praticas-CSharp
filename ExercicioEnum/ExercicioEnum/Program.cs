using ExercicioEnum.Entities;
using ExercicioEnum.Enums;
using System;
using System.Globalization;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("----- WORKERS HOURS MANAGEMENT -----");
            Console.Write("Informe o departamento do funcionário: ");
            string departamento = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("----- DADOS DO FUNCIONÁRIO -----");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (Junior/MidLevel/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.Write("Salário base: R$");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(departamento);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salario, dept);


            Console.Write("Contratos para este funcionário: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "----- CONTRATOS -----");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Insira a data do {i}º contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHorista contratoHorista = new ContratoHorista(data, valor, horas);
                trabalhador.AdicionarContrato(contratoHorista);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Informe o mês e o ano(MM/YYYY) para calcular a renda: ");
            string dataRenda = Console.ReadLine();
            int mes = int.Parse(dataRenda.Substring(0, 2));
            int ano = int.Parse(dataRenda.Substring(3));

            Console.Write("Nome: " + trabalhador.Nome + Environment.NewLine);
            Console.Write("Departamento: " + trabalhador.Departamento.NomeDepartamento + Environment.NewLine);
            Console.Write($"Renda para o mês {mes}/{ano}: R$" + trabalhador.CalcularRenda(mes, ano).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
