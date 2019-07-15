using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Domain.Models
{
    public class Notas
    {
        public int Quantidade { get; private set; }

        public Notas()
        {
            Quantidade = 0;
        }

        public void AdicionarNotas(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}
