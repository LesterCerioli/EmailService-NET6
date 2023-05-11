using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class Telephone : ValueObject
    {
        
        [Required(ErrorMessage = "O preenchimento do telefone é obrigatório")]
        [MinLength(10)]
        public string? TelephoneNumber { get; private set; }

        public string? RegionTelephone { get; private set; }
        
        public static bool ValidarTelephone(string telephone)
        {
            string shortenNum = Regex.Replace(telephone, @"[^0-9a-zA-Z]+", "");

            if (telephone.Length == 13)
            {
                Console.WriteLine("O número de telefone é válido");
                return true;
            }

            else
            {
                Console.Write("O número de telefone é inválido");
                return false;
            }
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}