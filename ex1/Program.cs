using System;
using System.Collections.Generic;

namespace ex1
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
           
            Console.WriteLine("Quantidade de números inseridos: " + Num.Count);
        }
    }
}
