using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Translation;
using Esr.Core.Domain.Translation;
using System;
using System.Linq.Expressions;

namespace Esr.Module.ControlPainel.Controllers
{
    public class TranslateController
    {
        private TranslateApp _TranslateApp;
        private IFactoryConnection _connection;

        public TranslateController(IFactoryConnection connection)
        {
            _connection = connection;
            _TranslateApp = new TranslateApp(connection);
        }

        public bool Save(Translate Translate)
        {
            _TranslateApp.InsertOrUpdate(Translate);
            return _connection.Save();
        }

        public IList Search(Expression<Func<Translate, bool>> expression)
        {
            return _TranslateApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<Translate, bool>> expression)
        {
            _TranslateApp.Remove(_TranslateApp.Search(expression).ToList());
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TranslateApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TranslateApp.Remove(_TranslateApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Translates
        /// </summary>
        /// <returns>{ c.Id, c.PropertyName, c.Portugues, c.English, c.Espanhol }</returns>
        public IList ListTranslate()
        {
            return _TranslateApp.Search()
                .Select(c => new
                { c.Id, c.PropertyName, c.Portugues, c.English, c.Espanhol }).ToList();
        }

        public Translate FindId(int id)
        {
            return _TranslateApp.FindId(id);
        }
    }
}