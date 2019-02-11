using Desafio.Models;
using System.Collections.Generic;

namespace Desafio.Repositorio
{
    public class RepositorioMdr
    {
        public List<Mdr> RetornarTodasAsMdr()
        {
            var repositorioDeTaxas = new RepositorioTaxas();
            var TaxasDaAdquirenteA = repositorioDeTaxas.RetornarTodasAsTaxasA();
            var TaxasDaAdquirenteB = repositorioDeTaxas.RetornarTodasAsTaxasB();
            var TaxasDaAdquirenteC = repositorioDeTaxas.RetornarTodasAsTaxasC();

            return new List<Mdr>()
            {
                new Mdr { Adquirente = "Adquirente A", Taxas = TaxasDaAdquirenteA},
                new Mdr { Adquirente = "Adquirente B", Taxas = TaxasDaAdquirenteB},
                new Mdr { Adquirente = "Adquirente C", Taxas = TaxasDaAdquirenteC},
            };
        }
    }
}