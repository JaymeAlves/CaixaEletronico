using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico.Domain.Operacoes
{
    public class Caixa
    {
        public List<Notas> Notas { get; private set; }

        public int SaldoTotal
        {
            get
            {
                int saldo = 0;

                foreach (var nota in Notas)
                {
                    saldo += nota.Quantidade * nota.Valor ;
                }

                return saldo;
            }
        }

        public Caixa()
        {
            Notas = new List<Notas>();
        }

        public void AdicionarNovoValorNotas(Notas nota)
        {
            Notas.Add(nota);
        }

        public void AdicionarQuantidadeNotas(string valorNota, int quantidade)
        {
            if(Notas.Any(x => x.Valor == Int32.Parse( valorNota)))
                Notas.Where(x => x.Valor == Int32.Parse(valorNota)).First().AdicionarNotas(quantidade);
        }
        
        public void Sacar(int valor)
        {
            Notas.OrderByDescending(x => x.Valor);
            foreach (var nota in Notas)
            {
                Console.WriteLine(nota.Valor);
            }

            foreach (var nota in Notas)
            {
                int quantidadenotas = nota.Valor / valor;
                if(nota.Quantidade >= quantidadenotas)
                {
                    valor -= quantidadenotas * nota.Valor ;
                    nota.DrecementarNotas(quantidadenotas);
                }else
                {
                    valor -= nota.Quantidade * nota.Valor;
                    nota.DrecementarNotas(nota.Quantidade);
                }
            }

            Console.Read();
        }
    }
}
