using System;
using Abstraindo_um_jogo_de_RPG.src.Entities;

namespace Abstraindo_um_jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight  arus = new Knight("Arus", 23, "Knight");
            wizard wizard = new wizard("Jennica", 23, "White wizard");

        
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            
        }
    }
}
