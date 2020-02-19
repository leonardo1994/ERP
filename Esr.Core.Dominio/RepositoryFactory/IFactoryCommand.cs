using Esr.Core.Domain.ClassBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Core.Domain.RepositoryFactory
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    ///  A interface IEFabricaComandos, é responsável por tratar de comportamentos 
    ///  de comandos em banco de dados.
    /// </summary>
    /// <typeparam name="TEObject"></typeparam>
    public interface IFactoryCommand<TEObject> : IDisposable where TEObject : class
    {
        bool InsertOrUpdate(TEObject eobject);
        bool Remove(TEObject eobject);
        bool Remove(int id);
        bool Remove(IEnumerable<TEObject> eObjects);
        TEObject FindId(int id);
        IQueryable<TEObject> Search(Expression<Func<TEObject, bool>> expression);
        IQueryable<TEObject> Search();
        IQueryable<TEObject> AsNoTracking(Expression<Func<TEObject, bool>> expression);
        IList<TEObject> SqlQuery(string sql, params object[] parameters);
        IQueryable<TEObject> SearchInOfType<T>(Expression<Func<T, bool>> expression) where T: class, IEntityBase;
        IQueryable<T> SearchOfType<T>(Expression<Func<TEObject, bool>> expression) where T : class, IEntityBase;
    }
}