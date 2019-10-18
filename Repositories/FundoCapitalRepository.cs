using Backend_P.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend_P.Repositories
{
    public class FundoCapitalRepository: IFundoCapitalRepository
    {
        private readonly List<FundoCapital> _storage;

        public FundoCapitalRepository(){
            _storage = new List<FundoCapital>();
        }

        void IFundoCapitalRepository.Adicionar(FundoCapital fundo){
            _storage.Add(fundo);
        }

        void IFundoCapitalRepository.Alterar(FundoCapital fundo){
            var index = _storage.FindIndex(0,1,x=> x.Id == fundo.Id);
            _storage[index] = fundo;
        }

        IEnumerable<FundoCapital> IFundoCapitalRepository.ListarFundos(){
            return _storage;
        }

        FundoCapital IFundoCapitalRepository.ObterPorId(Guid id){
            return _storage.FirstOrDefault(x=> x.Id == id);
        }

        void IFundoCapitalRepository.RemoverFundo(FundoCapital fundo){
            _storage.Remove(fundo);
        }
    }
}