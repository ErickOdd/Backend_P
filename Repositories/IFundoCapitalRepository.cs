using Backend_P.Models;
using System;
using System.Collections.Generic;

namespace Backend_P.Repositories
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