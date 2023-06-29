using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Email.Application.ViewModels
{
    public class MessageRecipientViewModel
    {
        public Guid Id { get; private set; }

        public string? RecipientMail { get; set; }
    }
}
