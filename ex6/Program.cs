using System;
using System.Collections.Generic;

namespace ex6
{
    class Menu
    {
        public static void menu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Digite '0' para sair");
            Console.WriteLine("=======================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> Par = new List<int>();
            List<int> Imp = new List<int>();
            int cont = 1;

            while (cont != 0)
            {
                Menu.menu();
                Console.WriteLine("\nDigite um número");
                cont = int.Parse(Console.ReadLine());

                if (cont != 0)
                {
                    if (cont % 2 == 0)
                        Par.Add(cont);
                    else
                        Imp.Add(cont);
                }                    
            }
            Console.Clear();

            Console.WriteLine("Números pares");
            foreach (var list in Par)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("Números impares");
            foreach (var list in Imp)
            {
                Console.WriteLine(list);
            }
        }
    }
}
