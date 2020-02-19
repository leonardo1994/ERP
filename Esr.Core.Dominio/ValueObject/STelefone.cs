using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class STelefone
    {
        public const int NumeroMaxLength = 20;
        public string Numero { get; private set; }

        public const int DddMaxLength = 3;
        public string Ddd { get; private set; }

        protected STelefone()
        {

        }

        public STelefone(string ddd, string numero)
        {
            SetTelefone(numero);
            SetDdd(ddd);
        }

        private void SetTelefone(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                numero = "";
            else
                Guard.StringLength("Telefone", numero, NumeroMaxLength);
            Numero = numero;
        }

        private void SetDdd(string ddd)
        {
            if (string.IsNullOrEmpty(ddd))
                ddd = "";
            else
                Guard.StringLength("Ddd", ddd, DddMaxLength);
            Ddd = ddd;
        }

        public string GetTelefoneCompleto()
        {
            return Ddd + Numero;
        }

        public override string ToString()
        {
            return GetTelefoneCompleto();
        }
    }
}
