using Desafio.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Desafio.Models
{
    public class Transacao
    {     
        [Range(0, double.MaxValue)]
        [Required]
        public double Valor { get; set; }
        [Required][StringRange(ValoresPermitidos = new[] { "A", "B", "C" })]
        public string Adquirente { get; set; }
        [Required][StringRange(ValoresPermitidos = new[] { "Visa", "Master"})]
        public string Bandeira { get; set; }
        [Required][StringRange(ValoresPermitidos = new[] { "Debito", "Credito" })]
        public string Tipo { get; set; }
    }
}