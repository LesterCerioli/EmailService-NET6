using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        
        public string? StoreMail {get; private set;}

        public string? CopyMail {get; private set;}
        
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}