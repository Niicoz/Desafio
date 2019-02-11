using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Desafio.Models;
using Desafio.Services;
using Desafio.Attributes;

namespace Desafio.Controllers
{
    public class TransactionController : ApiController
    {
        public Servicos servicos = new Servicos();
        public List<ValorLiquid> valorliquido = new List<ValorLiquid>();
        public List<Transacao> transacoes = new List<Transacao>();

        [ValidateModel]
        public IHttpActionResult Post(Transacao Transacao)
        {           
            transacoes.Add(Transacao);                 
            double valor = servicos.CalcularValorLiquido(Transacao);
            valorliquido.Add(new ValorLiquid(valor));
            var ultimoValorLiquido = valorliquido.Last();
            return Ok(ultimoValorLiquido);           
        }      
    }
}




