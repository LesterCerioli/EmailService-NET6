using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class Telephone : ValueObject
    {
             

        public string? TelephoneRegion { get; private set; }

        [Required(ErrorMessage = "O preenchimento do telefone é obrigatório")]
        [MinLength(10)]
        public string? TelephoneNumber { get; private set; }

        
        [MinLength(10)]
        public string? TelephoneNumber2 { get; private set; }

        public static bool ValidarTelephone(string telephoneNumber)
        {
            string shortenNum = Regex.Replace(telephoneNumber, @"[^0-9a-zA-Z]+", "");

            if (telephoneNumber.Length == 13)
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

        public static bool ValidarTelephone2(string telephoneNumber2)
        {
            string shortenNum = Regex.Replace(telephoneNumber2, @"[^0-9a-zA-Z]+", "");

            if (telephoneNumber2.Length == 13)
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
