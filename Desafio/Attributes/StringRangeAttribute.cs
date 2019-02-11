using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Desafio.Attributes
{

    public class StringRangeAttribute : ValidationAttribute
        {
            public string[] ValoresPermitidos { get; set; }

            protected override ValidationResult IsValid(object valor, ValidationContext validationContext)
            {
                if (ValoresPermitidos?.Contains(valor?.ToString()) == true)
                {
                    return ValidationResult.Success;
                }
                var msg = $"Por favor insira um dos valores permitidos: {string.Join(", ", (ValoresPermitidos ?? new string[] { "Nenhum valor permitido encontrado" }))}.";
                return new ValidationResult(msg);
            }
        }
}