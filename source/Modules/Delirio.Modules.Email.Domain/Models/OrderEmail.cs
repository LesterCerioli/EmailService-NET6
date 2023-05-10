using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.Modules
{
    public class OrderEmail : Entity, IAggregateRoot
    {
        public string? Email { get; private set; }

    }
}