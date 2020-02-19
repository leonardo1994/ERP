namespace Esr.Core.Domain.RepositoryFactory
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    /// Base para criar familia de fabrica de repositorios.
    /// </summary>
    /// <typeparam name="TEObject"></typeparam>
    public abstract class FactoryRepository<TEObject> : IFactoryRepository<TEObject> where TEObject : class
    {
        public abstract IFactoryConnection FactoryConnection();
        public abstract IFactoryCommand<TEObject> FactoryCommand(IFactoryConnection conexao);
    }
}
