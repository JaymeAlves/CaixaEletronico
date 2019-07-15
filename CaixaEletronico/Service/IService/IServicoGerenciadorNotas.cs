using CaixaEletronico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Service.IService
{
    public interface IServicoGerenciadorNotas
    {
        void InserirNotas(Notas notas, int quantidade);
    }
}
