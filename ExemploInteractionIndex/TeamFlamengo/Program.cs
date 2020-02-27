using System;

namespace ExemploInteractionIndex
{
    class Program
    {
        static void Main()
        {
            var teamFlamengo = new string[] { "Arrascaeta", "Bruno Henrique", "Everton Ribeiro", "Gabriel Barbosa", "Gerson" };

            foreach (var player in teamFlamengo[0..3])
            {
                Console.WriteLine($"{player}");
            }
        }
    }
}
