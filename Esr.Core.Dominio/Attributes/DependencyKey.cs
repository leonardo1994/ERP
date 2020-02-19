using System;

namespace Esr.Core.Domain.Attributes
{
    public class DependencyKey : Attribute
    {
        public string NamePropertyDependent { get; }

        public string NameProperySearch { get; set; }

        public DependencyKey(string nameProperty)
        {
            NamePropertyDependent = nameProperty;
        }

        public DependencyKey(string namePropertyValue, string namePropertySearch)
        {
            NamePropertyDependent = namePropertyValue;
            NameProperySearch = namePropertySearch;
        }
    }
}
