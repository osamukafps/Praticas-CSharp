using System;
using System.Globalization;
using System.Collections.Generic;

namespace PraticaMemArrayListas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registered? ");
            int funcionarios = int.Parse(Console.ReadLine());

            Funcionario func = new Funcionario();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            for(int i = 0; i < funcionarios; i++)
            {               
                func = new Funcionario();

                Console.Write("Employee ID: ");
                func.Id = int.Parse(Console.ReadLine() + "\n");
                
                Console.Write("Employee name: ");
                func.Nome = Console.ReadLine() + "\n";

                Console.Write("Employee salary: ");
                func.SetSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("|-----------------------|");

                listaFuncionarios.Add(func);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idFuncionarioBusca = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("|-----------------------|");

            int idFuncionarioEncontrado = listaFuncionarios.FindIndex(x => x.Id == idFuncionarioBusca);

            if(idFuncionarioEncontrado >= 0)
            {
                listaFuncionarios[idFuncionarioEncontrado].AumentarSalario(idFuncionarioEncontrado, porcentagem);              
            }

            else
                Console.WriteLine("This ID doesn't exists!");

            Console.WriteLine("");
            Console.WriteLine("Updated employees list: ");

            foreach (var funcionario in listaFuncionarios)
            {
                Console.WriteLine(funcionario);
                Console.WriteLine("----------");
            }


        }
    }
}
