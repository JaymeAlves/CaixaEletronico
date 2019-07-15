using CaixaEletronico.Domain.Models;
using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas10 = new Notas();
            Notas notas20 = new Notas();
            Notas notas50 = new Notas();

            Console.WriteLine("*** Caixa Eletronico! ***\n");

            string opcoes = "";

            while(opcoes != "6")
            {
                Console.WriteLine("\n1. Carregar notas de 10 reais");
                Console.WriteLine("2. Carregar notas de 20 reais");
                Console.WriteLine("3. Carregar notas de 50 reais");
                Console.WriteLine("4. Saque");
                Console.WriteLine("5. Relatório");
                Console.WriteLine("6. Sair");

                opcoes = Console.ReadLine();

                //switch
            }
            
        }
    }
}
