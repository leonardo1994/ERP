using Esr.Core.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Core.Domain.ClassBase
{
    public interface IFactoryService<TEObject>  where TEObject : class
    {
        // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
        // CNPJ: 23.416.009/0001-83
        // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

        /// <summary>
        /// Método para Insert ou Update uma entidade
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool InsertOrUpdate(TEObject obj);
        IQueryable<TEObject> Search(Expression<Func<TEObject, bool>> condicao);
        IQueryable<TEObject> SearchAll();
        TEObject FindId(int id);
        bool RemoveId(int id);
        bool RemoveObject(TEObject obj);
        bool RemoveListId(Expression<Func<TEObject, bool>> condicao);
        IQueryable<TEObject> AsNoTracking(Expression<Func<TEObject, bool>> expression);
    }
}
