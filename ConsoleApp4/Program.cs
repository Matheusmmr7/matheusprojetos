using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("codigo 1: Calcular 10% do numero");
            Console.WriteLine("codigo 2: calcular a % de um numero");
            Console.WriteLine("codigo 3: identificar se é par ou impar");
            Console.WriteLine("codigo 4: Calcular a raiz de uma função de 1°");
            Console.WriteLine("codigo 5: Calcular a raiz de uma função de 2°");
            Console.WriteLine("Digite o codigo: ");
            int Cod = Convert.ToInt32(Console.ReadLine());

            // Commit novo

            if (Cod == 3)
            {
                int x;
                Console.Clear();
                Console.WriteLine("\n\tDigite um número inteiro:");
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    Console.WriteLine("\nO número é par");
                }
                else
                {
                    Console.WriteLine("\nO número é impar");
                }
                Console.ReadKey();

            }
        }
    }
}
