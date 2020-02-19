using System;
using Esr.Core.Domain.Helpers;

namespace Esr.Core.Domain.ValueObject
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class SPassword
    {
        public string Key { get; }

        public virtual string Senha { get { return Key; } set
        { if (value == null) throw new ArgumentNullException(nameof(value)); }
        }
        protected SPassword()
        {

        }

        public SPassword(string senha)
        {
            Key = GerarSenha(senha);
        }

        private static string GerarSenha(string senha)
        {
            return CriptografiaHelper.CriptografarSenha(senha).ToString();
        }

        public override string ToString()
        {
            return Key;
        }
    }
}
