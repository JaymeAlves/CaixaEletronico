using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Domain.Operacoes
{
    public class Notas
    {
        public int Valor { get; private set; }
        public int Quantidade { get; private set; }

        public Notas(int valor)
        {
            Valor = valor;
            Quantidade = 0;
        }

        public Notas(int valor, int quantidade)
        {
            Valor = valor;
            Quantidade = quantidade;
        }

        public void AdicionarNotas(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void DrecementarNotas(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
