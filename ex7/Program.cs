using System;
using System.Collections.Generic;

namespace ex7
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
            string cont = " ";
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

            if (Num.Remove(cont) == false)
                Console.WriteLine("Falha ao excluir o nome indicado");
            else
                Console.WriteLine("Nome removido com sucesso");
        }
    }
}
