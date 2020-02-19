using System;
using System.Data.Entity;

namespace Esr.Core.Domain.RepositoryFactory
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    /// A interface IEFabricaConexoes, é responsável em gerenciar 
    /// conexoes de seu respectivo banco de dados.
    /// </summary>
    public interface IFactoryConnection : IDisposable
    {
        void Setup(DbModelBuilder modelBuilder);
        bool Save();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
