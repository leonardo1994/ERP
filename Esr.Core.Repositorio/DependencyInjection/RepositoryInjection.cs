using System;
using Esr.Core.Domain.RepositoryFactory;
using Ninject;

namespace Esr.Core.Repository.DependencyInjection
{
    public class RepositoryInjection
    {
        private StandardKernel _sk;

        public RepositoryInjection()
        {
            _sk = new StandardKernel();
            _sk.Bind<IFactoryConnection>().To(typeof(DbContextConnection));
        }

        public T GetClass<T>() where T : class
        {
            return this._sk.Get<T>();
        }
    }
}
