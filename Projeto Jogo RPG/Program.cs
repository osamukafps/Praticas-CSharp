using System;
using Projeto_Jogo_RPG.Entidades;

namespace Projeto_Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi hero = new Heroi("Arus", 12, "Knight");
            Mago mago = new Mago("Jenica", 13,"Wizard");

            Console.Write(mago.Attack());
        }
    }
}
