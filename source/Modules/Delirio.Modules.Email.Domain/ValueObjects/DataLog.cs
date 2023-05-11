using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class DataLog : ValueObject
    {
        
        public DataLog()
        {
            CreationDate = DateTime.Now;
            DeletionDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }

        public DateTimeOffset? CreationDate { get; private set; }

        public DateTimeOffset? LastUpdateDate { get; private set; }

        public DateTimeOffset? DeletionDate {get; private set;}

        

        
    }
}