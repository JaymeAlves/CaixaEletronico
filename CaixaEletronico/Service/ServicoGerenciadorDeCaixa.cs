using CaixaEletronico.Domain.Operacoes;
using CaixaEletronico.Service.IService;
using System;

namespace CaixaEletronico.Service
{
    class ServicoGerenciadorDeCaixa : IServicoGerenciadorDeCaixa
    {
        public void InserirNotas(Caixa caixa, string valorNota, int quantidade)
        {
            caixa.AdicionarQuantidadeNotas(valorNota, quantidade);
        }

        public void Sacar(Caixa caixa, int valor)
        {
            //EXCEÇÃO: Caso valor a ser sacado maior que quantidade disponível em caixa, abortar operação
            //if (valor < caixa.SaldoTotal)
                //throw new Exception("")

            caixa.Sacar(valor);
        }
    }
}
