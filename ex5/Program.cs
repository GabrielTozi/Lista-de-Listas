using System;
using System.Collections.Generic;

namespace ex5
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

            Num.Sort();

            foreach (var list in Num)
            {
                if (n < list)
                    n = list;
            }
            Console.Clear();

            Console.WriteLine("Quantidade de números inseridos: " + Num.Count + "\nMaior número: " + n);
        }
    }
}
