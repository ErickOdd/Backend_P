using CulturaInglesa.Api.Models;
using System;
using System.Collections.Generic;

namespace CulturaInglesa.Api.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundo);

        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundos();

        FundoCapital ObterPorId(Guid id);

        void RemoverFundo(FundoCapital fundo);
    }
}