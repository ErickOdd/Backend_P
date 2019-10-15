using System;
using System.Collections.Generic;
using Backend_P.Models;
using Backend_P.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend_P.Controllers
{
    public class FundoCapitalController: Controller
    {

        private readonly IFundoCapitalRepository _repositorio;

        public FundoCapitalController(IFundoCapitalRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("v1/fundoscapital")]
        public IActionResult ListarFundos()
        {
            return Ok(_repositorio.ListarFundos());
        }
   
        [HttpPost("v1/fundoscapital/")]
        public IActionResult AdicionarFundo([FromBody]FundoCapital fundo)
        {
            _repositorio.Adicionar(fundo);
            return Ok();
        }

        [HttpPut("v1/fundoscapital/{id}")]
        public IActionResult AlterarFundo(Guid id,[FromBody]FundoCapital fundo)
        {
            //id = Guid(id);
            var fundoAntigo = _repositorio.ObterPorId(id);
            if (fundoAntigo == null)
            {
                return NotFound();
            }            fundoAntigo.nome = fundo.nome;

            fundoAntigo.valorAtual = fundo.valorAtual;
            fundoAntigo.valorNecessario = fundo.valorNecessario;
            fundoAntigo.dataResgate = fundo.dataResgate;
            _repositorio.Alterar(fundoAntigo);
            return Ok();
        }

        [HttpGet("v1/fundoscapital/{id}")]
        public IActionResult ObterFundo(Guid id,[FromBody]FundoCapital fundo)
        {
            var fundoAntigo = _repositorio.ObterPorId(id);
            if (fundoAntigo == null)
            {
                return NotFound();
            }
       
            return Ok(fundoAntigo);
        }

        [HttpDelete("v1/fundoscapital/{id}")]
        public IActionResult RemoverFundo(Guid id,[FromBody]FundoCapital fundo)
        {
            var fundoAntigo = _repositorio.ObterPorId(id);
            if (fundoAntigo == null)
            {
                return NotFound();
            }
            _repositorio.RemoverFundo(fundo);
            return Ok();
        }

    }


    
}