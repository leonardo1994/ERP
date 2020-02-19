using System;
using System.Collections.Generic;

namespace Esr.Core.Component
{
    public class SInvokeMethod
    {
        public SInvokeMethod(Type typeClass)
        {
            TypeClass = typeClass;
        }

        public SInvokeMethod(Type typeClass, string nameMethod)
        {
            NameMethod = nameMethod;
            TypeClass = typeClass;
        }

        public SInvokeMethod(Type typeClass, string nameMethod, Type typeBaseClassControl, Type typeBaseClassControlApp, string namePropertyBaseClass, string namePropertyBaseClassControl)
        {
            NameMethod = nameMethod;
            TypeClass = typeClass;

            TypeBaseClassControl = typeBaseClassControl;
            TypeBaseClassControlApp = typeBaseClassControlApp;

            NameBaseClass = namePropertyBaseClass;
            NameBaseClassControl = namePropertyBaseClassControl;

        }

        public SInvokeMethod()
        {
        }

        public Type TypeClass { get; set; }
        public Type TypeBaseClassControl { get; set; }
        public Type TypeBaseClassControlApp { get; set; }
        public string NameMethod { get; set; }
        public string NameBaseClass { get; set; }
        public string NameBaseClassControl { get; set; }
    }
}
