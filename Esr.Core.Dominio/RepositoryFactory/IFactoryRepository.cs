namespace Esr.Core.Domain.RepositoryFactory
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    /// IEFabricaRepositorio implemante a regra para criar uma fabrica de repositorio concreta.
    /// </summary>
    /// <typeparam name="TEObject"></typeparam>
    public interface IFactoryRepository<TEObject> where TEObject : class
    {
        IFactoryCommand<TEObject> FactoryCommand(IFactoryConnection conexao);
    }
}
