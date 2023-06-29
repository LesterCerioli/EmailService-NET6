using NetDevPack.Domain;

namespace Delirio.Modules.Email.Domain.ValueObjects
{
    public class Cnpj : ValueObject
    {
        

        public Cnpj(string cnpjNuber)
        {
            CnpjNumber = cnpjNuber;
        }

        public string? CnpjNumber { get; private set; }



        private static bool IsCnpj(string cnpjNumber)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpjNumber = cnpjNumber.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpjNumber.Length != 14)
                return false;

            string tempCnpj = cnpjNumber.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpjNumber.EndsWith(digito);

        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}