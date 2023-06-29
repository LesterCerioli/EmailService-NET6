using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Domain.Models
{
    public enum PaymentStatus
    {
        Success = 1,
        NotAuthorized =2,
        TerminalNotAuthorized =3,
        NrCreditCardInvalid =4
    }
}
