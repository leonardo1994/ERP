using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.ValueObject;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Text.RegularExpressions;
using Esr.Core.Domain.FiltersCompanies;
using System.Data.Entity.Core;

namespace Esr.Core.Repository
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    /// Autor: Leonardo Teixeira
    /// </summary>
    /// <typeparam name="TEObject"></typeparam>
    public class DbContextCommand<TEObject> : IFactoryCommand<TEObject>, IDisposable where TEObject : class, IEntityBase
    {
        private readonly DbContextConnection _context;

        public DbContextCommand(IFactoryConnection connection)
        {
            _context = connection as DbContextConnection;
        }

        public bool InsertOrUpdate(TEObject eobject)
        {
            if (_context.Set<TEObject>().Any(c => c.Id == eobject.Id))
                return Update(eobject);
            else
                return Insert(eobject);
        }

        private bool Insert(TEObject eobject)
        {
            eobject.DateRegistration = DateTime.Now;
            eobject.CompanyControlId = GlobalUser.Company?.Id;
            eobject.UserControlId = GlobalUser.User?.Id;
            eobject.DateUpdate = null;
            _context.Set<TEObject>().Add(eobject);
            return true;
        }

        private bool Update(TEObject eobject)
        {
            eobject.DateUpdate = DateTime.Now;
            eobject.CompanyControlId = GlobalUser.Company.Id;
            eobject.UserControlId = GlobalUser.User.Id;
            var local = PegarObjetosLocal().FirstOrDefault(c => c.Id == eobject.Id);
            if (local != null)
                _context.Entry(local).State = EntityState.Detached;
            _context.Entry(ToEntity(eobject)).State = EntityState.Modified;
            return true;
        }

        public bool Remove(TEObject eobject)
        {
            _context.Set<TEObject>().Remove(_context.Set<TEObject>().Find(eobject.Id));
            return true;
        }

        public bool Remove(int id)
        {
            var obj = _context.Set<TEObject>().Find(id);
            if (obj == null)
                throw new Exception("Item não encontrado");
            return Remove(obj);
        }

        public bool Remove(IEnumerable<TEObject> eObjects)
        {
            _context.Set<TEObject>().RemoveRange(eObjects);
            return true;
        }

        public TEObject FindId(int id)
        {
            try
            {
                if (GlobalUser.Company == null) return _context.Set<TEObject>().AsNoTracking().FirstOrDefault(c => c.Id == id);

                var companyId = GlobalUser.Company.Id;
                string table = typeof(TEObject).Name;

                var procurarId = (from c in _context.Set<TEObject>().AsNoTracking().Where(c => c.Id == id)
                                  where _context.Set<FilterCompany>()
                                  .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                                  select c).FirstOrDefault();
                return procurarId;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar por id : " + ex.Message);
            }
        }

        IQueryable<TEObject> IFactoryCommand<TEObject>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            try
            {
                if (GlobalUser.Company == null) return _context.Set<T>().OfType<TEObject>();

                var companyId = GlobalUser.Company.Id;
                string table = typeof(T).Name;
                var consultar = (from c in _context.Set<T>().OfType<TEObject>()
                                 where _context.Set<FilterCompany>()
                                 .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                                 select c);

                return consultar;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar : " + ex.Message);
            }
        }

        public IQueryable<T> SearchOfType<T>(Expression<Func<TEObject, bool>> expression) where T : class, IEntityBase
        {
            try
            {
                if (GlobalUser.Company == null) return _context.Set<TEObject>().OfType<T>();

                var companyId = GlobalUser.Company.Id;
                string table = typeof(TEObject).Name;
                var consultar = (from c in _context.Set<TEObject>().OfType<T>()
                                 where _context.Set<FilterCompany>()
                                 .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                                 select c);

                return consultar;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar : " + ex.Message);
            }
        }

        public IQueryable<TEObject> Search(Expression<Func<TEObject, bool>> expression)
        {
            try
            {
                if (GlobalUser.Company == null) return _context.Set<TEObject>().Where(expression);

                var companyId = GlobalUser.Company.Id;
                string table = typeof(TEObject).Name;
                var sql = (from c in _context.Set<TEObject>().Where(expression)
                           where _context.Set<FilterCompany>()
                           .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                           select c);
                return sql;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar por filtro : " + ex.Message);
            }
        }

        public IQueryable<TEObject> Search()
        {
            try
            {
                if (GlobalUser.Company == null) return _context.Set<TEObject>();

                var companyId = GlobalUser.Company.Id;
                string table = typeof(TEObject).Name;
                var consultar = (from c in _context.Set<TEObject>()
                                 where _context.Set<FilterCompany>()
                                 .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                                 select c);

                return consultar;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar : " + ex.Message);
            }
        }

        public IQueryable<TEObject> AsNoTracking(Expression<Func<TEObject, bool>> expression)
        {
            if (GlobalUser.Company == null) return _context.Set<TEObject>()
                    .Where(expression).AsNoTracking();

            var companyId = GlobalUser.Company.Id;
            string table = typeof(TEObject).Name;
            var consultar = (from c in _context.Set<TEObject>().Where(expression)
                             where _context.Set<FilterCompany>()
                             .Any(f => (f.CompanyLeftId == companyId && f.DbTable.TableName == table && !f.Active) ||
                                 (f.CompanyLeftId == companyId && f.CompanyRightId == c.CompanyControlId
                                 && f.DbTable.TableName == table))
                             select c);
            return consultar.AsNoTracking();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ObservableCollection<TEObject> PegarObjetosLocal()
        {
            return _context.Set<TEObject>().Local;
        }

        public object ToEntity(object obj)
        {
            var newObj = Activator.CreateInstance(obj.GetType(), false);
            var properties = newObj.GetType().GetProperties();
            foreach (var item in properties)
            {
                try
                {
                    Type type;
                    try
                    {
                        type = item.PropertyType.GetGenericArguments()[0];
                    }
                    catch (Exception)
                    {
                        type = item.PropertyType;
                    }
                    switch (type.Name)
                    {
                        case nameof(Int32):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(Decimal):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(String):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(DateTime):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(Boolean):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(DBNull):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(SCpf):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(Cnpj):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(SEmail):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case nameof(Enum):
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        default:
                            type = item.PropertyType.BaseType;
                            if (type != null && type.Name == nameof(ValueType))
                                item.SetValue(newObj, item.GetValue(obj));
                            continue;
                    }

                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return newObj;
        }

        public DbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public IList<TEObject> SqlQuery(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<TEObject>(sql, parameters).ToList();
        }
    }

    public static class ConvertT
    {
        public static object ChangeType(this object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return Convert.ChangeType(value, t);
        }

        public static string GetTableName<T>(this DbContext context) where T : class
        {
            ObjectContext objectContext = ((IObjectContextAdapter)context).ObjectContext;

            return objectContext.GetTableName<T>();
        }

        public static string GetTableName<T>(this ObjectContext context) where T : class
        {
            string sql = context.CreateObjectSet<T>().ToTraceString();
            Regex regex = new Regex("FROM (?<table>.*) AS");
            Match match = regex.Match(sql);

            string table = match.Groups["table"].Value;
            return table.Replace("[", "").Replace("dbo", "").Replace(".", "").Replace("]", "");
        }
    }
}