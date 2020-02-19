using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.Colors;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.Colors
{
    public class ColorRepo : IFactoryCommand<Color>
    {
        private readonly IFactoryCommand<Color> _efcmd;

        public ColorRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Color> efr = new DbContext<Color>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Color eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Color eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Color> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Color FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Color> Search(Expression<Func<Color, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Color> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Color> AsNoTracking(Expression<Func<Color, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Color> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Color> IFactoryCommand<Color>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Color>.SearchOfType<T>(Expression<Func<Color, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
