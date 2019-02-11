using System.Linq;
using Desafio.Models;
using Desafio.Repositorio;

namespace Desafio.Services
{
    public class Servicos
    {
        public double CalcularValorLiquido(Transacao transacao)
        {
            var repositorioDeMdr = new RepositorioMdr();
            var mdr = repositorioDeMdr.RetornarTodasAsMdr();
            var adquirenteDaTransacao = mdr.FirstOrDefault((u) => u.Adquirente[u.Adquirente.Length - 1] == transacao.Adquirente[0]);
            var taxasDaBandeira = adquirenteDaTransacao.Taxas.FirstOrDefault((p) => p.Bandeira == transacao.Bandeira);
            if (transacao.Tipo.Equals("Credito"))
            {              
                return (transacao.Valor - transacao.Valor / 100 * taxasDaBandeira.Credito);
            }
            else 
                return (transacao.Valor - transacao.Valor / 100 * taxasDaBandeira.Debito);
        }
    }
}