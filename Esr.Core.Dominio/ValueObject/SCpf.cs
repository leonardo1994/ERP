using System;
using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class SCpf
    {
        public string Codigo { get; set; }

        protected SCpf()
        {

        }

        public SCpf(string cpf)
        {
            try
            {
                cpf = CpfLimpo(cpf);
                if (!IsCpf(cpf))
                    throw new Exception();

                if (!string.IsNullOrWhiteSpace(cpf))
                    Codigo = cpf;
            }
            catch (Exception)
            {
                throw new Exception("Cpf inválido: " + cpf);
            }
        }

        public string GetSemZeros()
        {
            return Codigo;
        }

        public static string CpfLimpo(string cpf)
        {
            cpf = TextHelper.GetNumeros(cpf);

            if (string.IsNullOrEmpty(cpf))
                return "";

            while (cpf.StartsWith("0"))
                cpf = cpf.Substring(1);

            return cpf;
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

        public static bool IsCpf(string cpf)
        {
            if (!string.IsNullOrEmpty(cpf))
            {
                while (cpf.Length < 11)
                    cpf = "0" + cpf;

                var multiplicador1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                var multiplicador2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                var tempCpf = cpf.Substring(0, 9);
                var soma = 0;

                for (var i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                var resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                var digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (var i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto;
                return cpf.EndsWith(digito);
            }
            return true;
        }

        public override string ToString()
        {
            return GetCpfCompleto();
        }
    }
}
