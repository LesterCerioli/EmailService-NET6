using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        [MaxLength(300)]
        [Required(ErrorMessage = "O ENDEREÇO deve ser informado")]
        public string? Street { get; private set; }

        public string? Number { get; private set; }

        [MaxLength(30)]
        public string? Complement { get; private set; }

        public string? District { get; private set; }

        [MaxLength(300)]
        public string? City { get; private set; }

        [MaxLength(150)]
        public string? State { get; private set; }

        [MaxLength(250)]
        public string? Country { get; private set; }

        public string? PostalCode { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
