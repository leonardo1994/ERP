using System;
using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class Cnpj
    {
        public string Codigo { get; set; }

        protected Cnpj()
        {

        }

        public Cnpj(string cnpj)
        {
            try
            {
                cnpj = CnpjLimpo(cnpj);
                if (!IsCnpj(cnpj))
                    throw new Exception();
                if (!string.IsNullOrWhiteSpace(cnpj))
                    Codigo = cnpj;
            }
            catch (Exception)
            {
                throw new Exception("Cnpj inválido: " + cnpj);
            }
        }

        public string GetSemZeros()
        {
            return Codigo;
        }

        public static string CnpjLimpo(string cnpj)
        {
            cnpj = TextHelper.GetNumeros(cnpj);

            return string.IsNullOrEmpty(cnpj) ? "" : cnpj;
        }

        public string GetCpfCompleto()
        {
            var cpf = Codigo;

            if (string.IsNullOrEmpty(cpf))
                return "";

            while (cpf.Length < 11)
                cpf = "0" + cpf;

            return cpf;
        }

        public static bool IsCnpj(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj)) return true;
            while (cnpj.Length < 11)
                cnpj = "0" + cnpj;

            var multiplicador1 = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",","");

            if (cnpj.Length != 14)
                return false;
            var tempCnpj = cnpj.Substring(0, 12);

            var soma = 0;

            for (var i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            var resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            var digito = resto.ToString();
            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (var i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto;

            return cnpj.EndsWith(digito);
        }

        public override string ToString()
        {
            return GetCpfCompleto();
        }
    }
}
