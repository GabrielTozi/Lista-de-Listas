using System;
using System.Collections.Generic;

namespace ex4
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
            List<string> Num = new List<string>();
            string cont = " ", a = " ";
            while (cont != "sair")
            {
                Menu.menu();
                Console.WriteLine("\nDigite um nome");
                cont = Console.ReadLine();

                if (cont != "sair")
                    Num.Add(cont);
            }
            Console.Clear();

            Console.WriteLine("Digite o nome que deseja pesquisar");
            cont = Console.ReadLine();
            
            if (Num.Contains(cont) == false)
                Console.WriteLine("Falha ao buscar o nome indicado");
            else
                Console.WriteLine("Nome achado com sucesso");

            Console.WriteLine(a);
        }
    }
}
