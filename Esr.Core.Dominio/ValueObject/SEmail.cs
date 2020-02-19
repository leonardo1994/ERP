using System;
using System.Text.RegularExpressions;
using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class SEmail
    {
        public const int EnderecoMaxLength = 254;

        public string Endereco { get; set; }

        //Construtor do EntityFramework
        protected SEmail()
        {

        }

        public SEmail(string endereco)
        {
            Endereco = string.Empty;
            if (string.IsNullOrEmpty(endereco)) return;
            Guard.ForNullOrEmptyDefaultMessage(endereco, "E-mail");
            Guard.StringLength("E-mail", endereco, EnderecoMaxLength);

            if (IsValid(endereco) == false)
                throw new Exception("E-mail inválido");

            Endereco = endereco;
        }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }

        public override string ToString()
        {
            return Endereco;
        }
    }
}
