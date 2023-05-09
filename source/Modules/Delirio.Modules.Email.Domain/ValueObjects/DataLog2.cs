using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class DataLog2 : ValueObject
    {
        
        public DataLog2(DateTime dataCriacao, DateTime? dataAtualizacao, DateTime? deletionDate)
        {
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
            DeletionDate = DateTime.Now;
        }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataAtualizacao { get; private set; }

        public DateTime? DeletionDate { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
        
        
    }
}