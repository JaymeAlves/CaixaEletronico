using CaixaEletronico.Domain.Operacoes;
using CaixaEletronico.Service;
using CaixaEletronico.Views;
using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instacia classes
            InterfaceCaixa interfaceCaixa = new InterfaceCaixa();

            ServicoGerenciadorDeCaixa servicoGerenciadorDeCaixa = new ServicoGerenciadorDeCaixa();

            Caixa caixa = new Caixa();

            Notas notas10 = new Notas(10,1);
            Notas notas20 = new Notas(20,1);
            Notas notas50 = new Notas(50,1);

            caixa.AdicionarNovoValorNotas(notas10);
            caixa.AdicionarNovoValorNotas(notas20);
            caixa.AdicionarNovoValorNotas(notas50);

            string opcoes = "";

            //Início da funcionalidade do caixa
            while (opcoes != "4")
            {
                interfaceCaixa.CarregaOpcoes();

                opcoes = Console.ReadLine();

                switch (opcoes)
                {
                    //Adicionar notas
                    case "1":
                        interfaceCaixa.SolicitarValorNotas();

                        string valorNota = Console.ReadLine();

                        interfaceCaixa.SolicitarNotas();

                        int quantidadeNota = Convert.ToInt32(Console.ReadLine());

                        servicoGerenciadorDeCaixa.InserirNotas(caixa, valorNota, quantidadeNota);
                        break;

                    //Relatório
                    case "2":
                        interfaceCaixa.SolicitaQuantidadeSaque();

                        int quantidadeSaque = Convert.ToInt32(Console.ReadLine());

                        servicoGerenciadorDeCaixa.Sacar(caixa, quantidadeSaque);
                        break;

                    case "3":
                        interfaceCaixa.ExibeRelatorio(caixa);
                        break;

                    case "4":
                        break;
                }
            }
        }
    }
}
