using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Core.Repository.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Esr.Core.Component
{
    /// <summary>
    /// Name Class: SReflection
    /// Description: SReflection é responsável em trabalhar com objetos em modo de execução.    
    /// Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    /// CNPJ: 23.416.009/0001-83
    /// 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    /// </summary>
    public class SReflection
    {
        /// <summary>
        /// GetTypeObject
        /// Description: Método responsável em pegar tipo do objeto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Type GetTypeObject(object obj)
        {
            if (obj == null) return null;
            var type = obj.GetType();
            return type.Name.Contains("_") ? type.BaseType : obj.GetType();
        }

        /// <summary>
        /// GetProperties
        /// Description: Método responsável em pegar todos as propriedades contida no objeto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public PropertyInfo[] GetProperties(object obj)
        {
            return obj?.GetType()?.GetProperties(BindingFlags.NonPublic | BindingFlags.Public
        | BindingFlags.Instance | BindingFlags.Static);
        }

        /// <summary>
        /// GetProperties
        /// Description: Método responsável em pegar tipo de uma propriedade
        /// </summary>
        /// <param name="property">Propriedade</param>
        /// <returns></returns>
        public Type GetTypeProperty(PropertyInfo property)
        {
            try
            {
                return property.PropertyType.GetGenericArguments()[0];
            }
            catch (Exception)
            {

                return property.PropertyType;
            }

        }

        /// <summary>
        /// GetTypeObjectCollection
        /// Description: Método responsável em pegar o tipo do objeto em uma coleção (Lista).
        /// Ex.: List<Pessoa></Pessoa>, metodo retorna o tipo Pessoa 
        /// </summary>
        /// <param name="obj">Objeto do tipo ICollection</param>
        /// <returns></returns>
        public Type GetTypeObjectCollection(object obj)
        {
            var objTipo = obj?.GetType().GetGenericArguments();
            var tipo = objTipo?[0];
            return tipo;
        }

        /// <summary>
        /// CreateNewInstance
        /// Description: Método responsável em criar novas instâncias de objetos em tempo de execução
        /// </summary>
        /// <param name="typeObject">Tipo do objeto que será criado</param>
        /// <param name="paramsConstructor">Valores para paramêtros dos construtores do objeto</param>
        /// <returns></returns>
        public object CreateNewInstance(Type typeObject, params object[] paramsConstructor)
        {
            return typeObject == null ? null : Activator.CreateInstance(typeObject, paramsConstructor);
        }

        /// <summary>
        /// CreateNewInstance
        /// Description: Método responsável em criar novas instâncias de objetos em tempo de execução
        /// </summary>
        /// <param name="typeObject">Tipo do objeto que será criado</param>
        /// <returns></returns>
        public object CreateNewInstance(Type typeObject)
        {
            try
            {
                return typeObject == null ? null : Activator.CreateInstance(typeObject, false);
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// Cria uma instância retornando objeto generico.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="typeObject"></param>
        /// <returns></returns>
        public T CreateNewInstance<T>(Type typeObject)
        {
            return (T)(typeObject == null ? null : Activator.CreateInstance(typeObject, false));
        }

        /// <summary>
        /// CreateList
        /// Description: Método responsável em criar uma lista em tempo execução.
        /// </summary>
        /// <param name="typeList">Tipo do objeto que será a lista</param>
        /// <returns></returns>
        public IList CreateList(Type typeList)
        {
            var constructorInfo = typeof(List<>)
                .MakeGenericType(typeList)
                .GetConstructor(Type.EmptyTypes);
            return (IList)constructorInfo?.Invoke(null);
        }

        /// <summary>
        /// SetObjectList
        /// Description: Método responsável em pegar valores de uma lista generica, passar para uma lista, com seu tipo definido.
        /// </summary>
        /// <param name="property">Propriedade que será usada para setar os valores.</param>
        /// <param name="listGetValues">Lista generica, para pegar os dados</param>
        /// <returns></returns>
        public IList SetObjectList(PropertyInfo property, IQueryable listGetValues)
        {
            var typeProperty = GetTypeProperty(property);
            var listSetValues = CreateList(typeProperty);
            var objeto = CreateNewInstance(typeProperty);

            var objectList = objeto.GetType()
                .GetProperties()
                .FirstOrDefault(c => c.PropertyType.Name == GetTypeObjectCollection(listGetValues).Name
                && !c.CustomAttributes.Any());

            foreach (var item in listGetValues)
            {
                var objetoValue = CreateNewInstance(typeProperty);
                objectList?.SetValue(objetoValue, item);
                listSetValues.Add(objetoValue);
            }
            return listSetValues;
        }

        /// <summary>
        /// SetObjectList
        /// Description: Método responsável em pegar valores de uma lista generica, passar para uma lista, com seu tipo definido.
        /// </summary>
        /// <param name="property">Propriedade que será usada para setar os valores.</param>
        /// <param name="listGetValues">Lista generica, para pegar os dados</param>
        /// <returns></returns>
        public IList SetObjectList(PropertyInfo property, ICollection listGetValues)
        {
            var typeProperty = GetTypeProperty(property);
            var listSetValues = CreateList(typeProperty);
            var objeto = CreateNewInstance(typeProperty);

            var objectList = objeto.GetType()
                .GetProperties()
                .FirstOrDefault(c => c.PropertyType.Name == GetTypeObjectCollection(listGetValues).Name
                && !c.CustomAttributes.Any());

            foreach (var item in listGetValues)
            {
                var objetoValue = CreateNewInstance(typeProperty);
                objectList?.SetValue(objetoValue, item);
                listSetValues.Add(objetoValue);
            }
            return listSetValues;
        }

        public IList ToList(object obj)
        {
            if (obj == null) return null;
            var listType = typeof(List<>).MakeGenericType(GetTypeObjectCollection(obj));
            var result = (IList)Activator.CreateInstance(listType);

            foreach (var j in (IEnumerable)obj)
                result.Add(j);

            return result;
        }

        /// <summary>
        /// SetObjectList
        /// Description: Método responsável em pegar valores de uma lista generica, passar para uma lista, com seu tipo definido.
        /// </summary>
        /// <param name="typeList">Propriedade que será usada para setar os valores.</param>
        /// <param name="listGetValues">Lista generica, para pegar os dados</param>
        /// <returns></returns>
        public IList SetObjectList(Type typeList, IList listGetValues)
        {
            var listSetValues = CreateList(typeList);

            var objeto = CreateNewInstance(typeList);

            var objectList = objeto.GetType()
                .GetProperties()
                .FirstOrDefault(c => c.PropertyType.Name == GetTypeObjectCollection(listGetValues).Name);

            foreach (var item in listGetValues.Cast<object>().Where(item => item != null))
            {
                objectList?.SetValue(objeto, item);
                listSetValues.Add(objeto);
            }
            return listSetValues;
        }

        /// <summary>
        /// SetObjectList
        /// Description: Método responsável em pegar valores de uma Coleção definida, passar para uma lista, com seu tipo definido.
        /// </summary>
        /// <param name="typeList">Propriedade que será usada para setar os valores.</param>
        /// <param name="listGetValues">Lista definida, para pegar os dados</param>
        /// <returns></returns>
        public IList SetObjectList(Type typeList, ICollection listGetValues)
        {
            var listaType = typeList.UnderlyingSystemType.GenericTypeArguments.Single();
            var listSetValues = CreateList(listaType);
            if (listGetValues == null) return listSetValues;
            foreach (var item in listGetValues)
            {
                var firstOrDefault = item.GetType()
                    .GetProperties()
                    .FirstOrDefault(c => c.PropertyType.Name == listaType.Name);
                if (firstOrDefault == null) continue;
                var teste = firstOrDefault.GetValue(item);
                listSetValues.Add(teste);
            }
            return listSetValues;
        }

        /// <summary>
        /// Reponsável em pegar lista de valores e transporta para nova lista onde as propriedade são compativeis.
        /// </summary>
        /// <param name="typeList"></param>
        /// <param name="listGetValues"></param>
        /// <returns></returns>
        public IList SetObjectList(Type typeList, IEnumerable listGetValues)
        {
            Type listaType;
            try
            {
                listaType = typeList.UnderlyingSystemType.GenericTypeArguments.Single();
            }
            catch (Exception)
            {
                listaType = typeList.UnderlyingSystemType;
            }

            var listSetValues = CreateList(listaType);
            if (listGetValues == null) return listSetValues;
            foreach (var item in listGetValues)
            {
                var teste = item.GetType()
                    .GetProperties().FirstOrDefault(c => c.PropertyType.Name == listaType.Name)?.GetValue(item);
                listSetValues.Add(teste ?? item);
            }
            return listSetValues;
        }

        /// <summary>
        /// ConvertProperty
        /// Description: Método responsável em converter valores genericos para um tipo definido
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public object ConvertProperty(PropertyInfo property)
        {
            if (property == null) return null;
            switch (Type.GetTypeCode(property.PropertyType))
            {
                case TypeCode.Empty:
                    return "";
                case TypeCode.Object:
                    return CreateNewInstance(property.PropertyType);
                case TypeCode.DBNull:
                    return DBNull.Value;
                case TypeCode.Boolean:
                    return false;
                case TypeCode.Char:
                    return ' ';
                case TypeCode.SByte:
                    return sbyte.MaxValue;
                case TypeCode.Byte:
                    return byte.MaxValue;
                case TypeCode.Int16:
                    return 0;
                case TypeCode.UInt16:
                    return 0;
                case TypeCode.Int32:
                    return 0;
                case TypeCode.UInt32:
                    return 0;
                case TypeCode.Int64:
                    return 0;
                case TypeCode.UInt64:
                    return 0;
                case TypeCode.Single:
                    return 0;
                case TypeCode.Double:
                    return 0;
                case TypeCode.Decimal:
                    return decimal.Zero;
                case TypeCode.DateTime:
                    return DateTime.Now;
                case TypeCode.String:
                    return "";
                default:
                    return CreateNewInstance(property.PropertyType);
            }
        }

        /// <summary>
        /// Description: Método responsável em executar um pesquisa dinamicamente.
        /// de acordo com método passado como parametro.
        /// </summary>
        /// <param name="typeClass">Type da classe que será instanciada.</param>
        /// <param name="method">Nome do método que será executado.</param>
        /// <returns></returns>
        public IList GetListContext(Type typeClass, string method)
        {
            IList listContext = null;
            try
            {
                var methodInfo = typeClass.GetMethods().FirstOrDefault(c => !c.GetParameters().Any() && c.Name == method);
                listContext = methodInfo.Invoke(CreateNewInstance(typeClass, new RepositoryInjection().GetClass<IFactoryConnection>()), null) as IList;
            }
            catch (Exception)
            {
                // ignored
            }

            return listContext;
        }

        /// <summary>
        /// Description: Método responsável em executar um pesquisa dinamicamente.
        /// de acordo com método passado como parametro.
        /// </summary>
        /// <param name="typeClass">Type da classe que será instanciada.</param>
        /// <param name="method">Nome do método que será executado.</param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IList GetListContext(Type typeClass, string method, params object[] obj)
        {
            IList listContext = null;

            var methodInfo = typeClass.GetMethods().Where(c => c.Name == method && c.GetParameters().Any(d => obj.First().GetType() == d.ParameterType || obj.First().GetType().BaseType == d.ParameterType)).FirstOrDefault();

            if (methodInfo == null)
                throw new Exception($"Método: {method} não encontrado.\nController: { typeClass.Name }.\nCom Parâmetro: { obj.First().GetType().ToString()  }");

            //var methodInfo = typeClass.GetMethod(method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            listContext = methodInfo.Invoke(CreateNewInstance(typeClass, new RepositoryInjection().GetClass<IFactoryConnection>()), obj) as IList;

            return listContext;
        }

        public IEntityBase GetContext(Type typeClass, string method, params object[] obj)
        {
            IEntityBase listContext = null;
            try
            {
                var methodInfo = typeClass.GetMethod(method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                listContext = methodInfo.Invoke(CreateNewInstance(typeClass, new RepositoryInjection().GetClass<IFactoryConnection>()), obj) as IEntityBase;
            }
            catch (Exception)
            {
                // ignored
            }

            return listContext;
        }

        /// <summary>
        /// Description: Método responsável em executar um delete dinamicamente.
        /// de acordo com método passado como parametro.
        /// </summary>
        /// <param name="typeClass">Type da classe que será instanciada.</param>
        /// <param name="method">Nome do método que será executado.</param>
        /// <param name="parametros">Parametro para remover o item</param>
        /// <returns></returns>
        public bool ExecuteContext(Type typeClass, string method, params object[] parametros)
        {
            bool context;
            var methodInfo = typeClass.GetMethods().Where(c => c.Name == method && c.GetParameters().Any(d => parametros.First().GetType() == d.ParameterType || parametros.First().GetType().BaseType == d.ParameterType)).FirstOrDefault();

            if (methodInfo == null)
                throw new Exception($"Método: {method} não encontrado.\nController: { typeClass.Name }.\nCom Parâmetro: { parametros.First().GetType().ToString()  } or { parametros.First().GetType().BaseType.ToString() }");

            //var methodInfo = typeClass.GetMethod(method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var instance = CreateNewInstance(typeClass, new RepositoryInjection().GetClass<IFactoryConnection>());
            var returnInvoke = methodInfo.Invoke(instance, parametros);
            if (returnInvoke is bool)
                context = (bool)returnInvoke;
            else
                context = (int)returnInvoke != 0;

            return context;
        }

        /// <summary>
        /// Pesquisa elemento no contexto apenas com Id
        /// </summary>
        /// <param name="typeClass"></param>
        /// <param name="method"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public object FindIdContext(Type typeClass, string method, params object[] parametros)
        {
            object context = null;
            try
            {
                var methodInfo = typeClass.GetMethod(method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                context = methodInfo.Invoke(CreateNewInstance(typeClass, new RepositoryInjection().GetClass<IFactoryConnection>()), parametros);
            }
            catch (Exception)
            {
                // ignored
            }
            return context;
        }

        /// <summary>
        /// Pega um objeto e passa para outro objeto alocado em outro espaço da memoria.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object ObjectToNewObject(object obj)
        {
            var newObj = CreateNewInstance(obj.GetType());
            var properties = GetProperties(obj);
            foreach (var item in properties)
            {
                try
                {
                    item.SetValue(newObj, item.GetValue(obj));
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return newObj;
        }

        /// <summary>
        /// Para EF reseta propriedades que serão desconsideradas no contexto.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object ToEntity(object obj)
        {
            var newObj = CreateNewInstance(obj.GetType());
            var properties = GetProperties(obj);
            foreach (var item in properties)
            {
                try
                {
                    switch (Type.GetTypeCode(item.GetType()))
                    {
                        case TypeCode.Int32:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case TypeCode.String:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case TypeCode.DateTime:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case TypeCode.Boolean:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case TypeCode.Empty:
                            break;
                        case TypeCode.Object:
                            break;
                        case TypeCode.DBNull:
                            break;
                        case TypeCode.Char:
                            break;
                        case TypeCode.SByte:
                            break;
                        case TypeCode.Byte:
                            break;
                        case TypeCode.Int16:
                            break;
                        case TypeCode.UInt16:
                            break;
                        case TypeCode.UInt32:
                            break;
                        case TypeCode.Int64:
                            break;
                        case TypeCode.UInt64:
                            break;
                        case TypeCode.Single:
                            break;
                        case TypeCode.Double:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        case TypeCode.Decimal:
                            item.SetValue(newObj, item.GetValue(obj));
                            break;
                        default:
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

        /// <summary>
        /// Pega o tipo da propriedade.
        /// </summary>
        /// <param name="fieldInfo"></param>
        /// <returns></returns>
        public Type GetTypeProperty(FieldInfo fieldInfo)
        {
            try
            {
                return fieldInfo.FieldType.GetGenericArguments()[0];
            }
            catch (Exception)
            {
                return fieldInfo.FieldType;
            }
        }

        public object ConvertValue(object value, PropertyInfo property)
        {
            return Convert.ChangeType(value, property.PropertyType);
        }

        public object ChangeType(object value, Type conversion)
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
    }
}