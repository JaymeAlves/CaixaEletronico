using CaixaEletronico.Domain.Operacoes;
using System;

namespace CaixaEletronico.Views
{
    public class InterfaceCaixa
    {
        
        public void CarregaOpcoes()
        {
            Console.Clear();
            Console.WriteLine("*** Caixa Eletronico! ***\n");
            Console.WriteLine("1. Carregar notas");
            Console.WriteLine("2. Saque");
            Console.WriteLine("3. Relatório");
            Console.WriteLine("4. Sair\n");
        }

        public void SolicitarValorNotas()
        {
            Console.WriteLine("\nDigite o valor da nota a ser adicionada:");
        }

        public void SolicitarNotas()
        {
            Console.WriteLine("\nDigite a quantidade de notas a serem depositadas:");
        }

        public void ExibeRelatorio(Caixa caixa)
        {
            Console.WriteLine("\n*** Relatório - Quantidade de Notas ***\n");
            foreach (var nota in caixa.Notas)
            {
                Console.WriteLine($"Notas de R${nota.Valor.ToString()},00 reais: {nota.Quantidade.ToString()}");
            }

            Console.WriteLine($"Total caixa: R${caixa.SaldoTotal},00");
            Console.ReadLine();
        }

        public void SolicitaQuantidadeSaque()
        {
            Console.WriteLine("Digite a quantidade a ser sacada: ");
        }

    }
}
