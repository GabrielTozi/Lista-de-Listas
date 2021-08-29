using System;
using System.Collections.Generic;

namespace ex2
{
    class Menu
    {
        public static void menu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Digite 'sair' para sair");
            Console.WriteLine("=======================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();
            string cont = " ";
            int n = 0;
            while (cont != "sair")
            {
                Menu.menu();
                Console.WriteLine("\nDigite um número");
                cont = Console.ReadLine();
                if (cont != "sair")
                {
                    Num.Add(int.Parse(cont));
                }
            }
            Console.Clear();

            foreach (var list in Num)
            {
                Console.WriteLine(list);
            }
            foreach (var list in Num)
            {
                n += list;
            }

            Console.WriteLine("\nSoma dos números inseridos: " + n);
        }
    }
}
