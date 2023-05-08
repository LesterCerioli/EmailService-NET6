using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Delirio.Modules.Domain.EmailCore.Models
{
    public class OrderEmail : Entity, IAggregateRoot
    {
        public string? Email { get; private set; }
    }
}
