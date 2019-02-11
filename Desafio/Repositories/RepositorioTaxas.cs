using Desafio.Models;
using System.Collections.Generic;

namespace Desafio.Repositorio
{
    public class RepositorioTaxas
    {
        public List<Taxa> RetornarTodasAsTaxasA()
        {
            return new List<Taxa>()
            {
                new Taxa { Bandeira = "Visa", Credito = 2.25, Debito = 2.00 },
                new Taxa { Bandeira = "Master", Credito = 2.35, Debito = 1.98 }
            };
        }

        public List<Taxa> RetornarTodasAsTaxasB()
        {
            return new List<Taxa>()
            {
                new Taxa {Bandeira = "Visa", Credito = 2.50, Debito = 2.08},
                new Taxa {Bandeira = "Master", Credito  = 2.65, Debito = 1.75}
            };
        }

        public List<Taxa> RetornarTodasAsTaxasC()
        {
            return new List<Taxa>()
            {
                new Taxa {Bandeira = "Visa", Credito = 2.75, Debito = 2.16},
                new Taxa {Bandeira = "Master", Credito  = 3.10, Debito = 1.58}
            };
        }
    }
}