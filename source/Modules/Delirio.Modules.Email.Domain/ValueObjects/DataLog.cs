using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class DataLog : ValueObject
    {
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public DateTimeOffset? CreationDate { get; private set; }

        public DateTimeOffset? LastShotDate { get; private set; }

        
    }
}