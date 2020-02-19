using System;
using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class SCep
    {
        public long? CepCod { get; private set; }
        public const int CepMaxLength = 8;

        protected SCep()
        {

        }

        public SCep(string cep)
        {
            Guard.ForNullOrEmptyDefaultMessage("CEP", cep);
            cep = TextHelper.GetNumeros(cep);
            Guard.StringLength("CEP", CepMaxLength, cep);
            try
            {
                CepCod = Convert.ToInt64(cep);
            }
            catch (Exception)
            {
                throw new Exception("Cep inválido: " + cep);
            }
        }

        public bool Vazio()
        {
            return !CepCod.HasValue;
        }

        public string GetCepFormatado()
        {
            if (CepCod == null)
                return "";

            var cep = CepCod.ToString();

            while (cep.Length < 8)
                cep = "0" + cep;

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }

        public override string ToString()
        {
            return GetCepFormatado();
        }
    }
}
