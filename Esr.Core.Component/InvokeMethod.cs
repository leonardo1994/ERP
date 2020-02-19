using System;
using System.Collections.Generic;

namespace Esr.Core.Component
{
    /// <summary>
    /// Classe responsável em obter os controles para os componetes se conversar com o Controller
    /// </summary>
    public class InvokeMethod
    {
        public Type TypeController { get; private set; }
        public IDictionary<TypeExecute, string> Methods { get; private set; }
        public Type TypeModel { get; private set; }

        /// <summary>
        /// Recebe como parâmetro o tipo de controller.
        /// </summary>
        /// <param name="typeController">Informe o tipo da classe de controle.</param>
        /// <param name="methods">Para cada método do TypeExecute informe qual é respectivo na classe de controle.</param>
        /// <param name="typeModel">Tipo do modelo de dados.</param>
        /// <example>new InvokeMethod(typeof(UserController), new Dictionary<TypeExecute, string>() { { TypeExecute.Insert, "Insert" } }, typeof(User));</example>
        public InvokeMethod(Type typeController, IDictionary<TypeExecute, string> methods, Type typeModel)
        {
            TypeController = typeController;
            Methods = methods;
            TypeModel = typeModel;
        }

        public InvokeMethod(Type typeController, TypeExecute typeExecute, string nameMethod, Type typeModel)
        {
            TypeController = typeController;
            Methods = new Dictionary<TypeExecute, string>() { { typeExecute, nameMethod } };
            TypeModel = typeModel;
        }
    }

    /// <summary>
    /// Métodos de execução dos componentes.
    /// </summary>
    public enum TypeExecute
    {
        InsertOrUpdate,
        Remove,
        RemoveListId,
        Search,
        SearchAll,
        FindId
    }
}
