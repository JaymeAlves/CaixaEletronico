using CaixaEletronico.Domain.Models;
using CaixaEletronico.Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Service
{
    class ServicoGerenciadorNotas : IServicoGerenciadorNotas
    {
        public void InserirNotas(Notas notas, int quantidade)
        {
            notas.AdicionarNotas(quantidade);
        }
    }
}
