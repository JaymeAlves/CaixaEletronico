using CaixaEletronico.Domain.Operacoes;

namespace CaixaEletronico.Service.IService
{
    public interface IServicoGerenciadorDeCaixa
    {
        void InserirNotas(Caixa caixa, string valorNota, int quantidade);
        void Sacar(Caixa caixa, int valor);
    }
}
