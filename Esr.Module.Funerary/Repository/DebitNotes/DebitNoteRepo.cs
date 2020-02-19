using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.DebitNotes;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.DebitNotes
{
    public class DebitNoteRepo : IFactoryCommand<DebitNote>
    {
        private readonly IFactoryCommand<DebitNote> _efcmd;

        public DebitNoteRepo(IFactoryConnection efc)
        {
            IFactoryRepository<DebitNote> efr = new DbContext<DebitNote>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(DebitNote eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(DebitNote eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<DebitNote> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public DebitNote FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<DebitNote> Search(Expression<Func<DebitNote, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<DebitNote> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<DebitNote> AsNoTracking(Expression<Func<DebitNote, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<DebitNote> IFactoryCommand<DebitNote>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<DebitNote> IFactoryCommand<DebitNote>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<DebitNote>.SearchOfType<T>(Expression<Func<DebitNote, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
