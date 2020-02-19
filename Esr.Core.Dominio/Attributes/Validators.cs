using System;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.EnumBase;

namespace Esr.Core.Domain.Attributes
{
    public class CpfValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(value.ToString())) return ValidationResult.Success;
            var cpf = value as string;
            var valor = cpf?.Replace(".", ""); valor = valor?.Replace("-", "");
            if (valor?.Length != 11)
                return new ValidationResult("Cpf inválido");
            var igual = true;
            for (var i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0]) igual = false;
            if (igual || valor == "12345678909")
                return new ValidationResult("Cpf inválido");
            var numeros = new int[11];
            for (var i = 0; i < 11; i++) numeros[i] = int.Parse(valor[i].ToString());
            var soma = 0;
            for (var i = 0; i < 9; i++) soma += (10 - i) * numeros[i];
            var resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0) return new ValidationResult("Cpf inválido");
            }
            else if (numeros[9] != 11 - resultado) return new ValidationResult("Cpf inválido");
            soma = 0;
            for (var i = 0; i < 10; i++) soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return new ValidationResult("Cpf inválido");
            }
            else if (numeros[10] != 11 - resultado) return new ValidationResult("Cpf inválido");
            return ValidationResult.Success;
        }
    }

    public class CnpjValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(value.ToString())) return ValidationResult.Success;
            var vrCnpj = value as string;
            vrCnpj = vrCnpj?.Replace(".", "").Trim();
            vrCnpj = vrCnpj?.Replace(",", "");
            vrCnpj = vrCnpj?.Replace("/", "");
            if (vrCnpj?.Length >= 14)
                vrCnpj = vrCnpj.Substring(0, 12) + vrCnpj.Substring(13);
            var cnpj = vrCnpj;
            const string ftmt = "6543298765432";
            var digitos = new int[14];
            var soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            var resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            var cnpjOk = new bool[2];
            cnpjOk[0] = false;
            cnpjOk[1] = false;
            try
            {
                int nrDig;
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    if (cnpj != null) digitos[nrDig] = int.Parse(cnpj.Substring(nrDig, 1));
                    if (nrDig <= 11) soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12) soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }
                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);
                    else cnpjOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }
                if (cnpjOk[0] && cnpjOk[1])
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("Cnpj inválido");
            }
            catch (Exception)
            {
                return new ValidationResult("Cnpj inválido");
            }
        }
    }

    public class Unique : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }

    public class CompoundIndex : ValidationAttribute
    {
        public string[] Properties { get; }

        public CompoundIndex(string[] properties)
        {
            Properties = properties;
        }

        public override bool IsValid(object value)
        {
            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }

    public class LockedTrueValue : ValidationAttribute
    {
        public string[] PropertyName { get;}
        public object[] Value { get; }
        public bool UniqueValue { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="propertiesName"></param>
        /// <param name="objectValues"></param>
        /// <param name="uniqueValue">Indica se o primeiro valor valera para todos</param>
        public LockedTrueValue(string[] propertiesName, object[] objectValues, bool uniqueValue = false)
        {
            PropertyName = propertiesName;
            Value = objectValues;
            UniqueValue = uniqueValue;
        }

        public override bool IsValid(object value)
        {
            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }

    public class OperationValue : ValidationAttribute
    {
        public string PropertyOperationName { get; }
        public string PropertyResultName { get; }
        public TypeOperation TypeOperation { get; }

        public OperationValue(string propertyOperationName, string propertyResultName, TypeOperation typeOperation)
        {
            PropertyOperationName = propertyOperationName;
            PropertyResultName = propertyResultName;
            TypeOperation = typeOperation;
        }

        public override bool IsValid(object value)
        {
            return true;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }

    public class AppendValue : Attribute
    {
        public string[] PropertiesGetValue { get; set; }
        public string[] PropertiesSetValue { get; set; }

        public AppendValue(string[] propertiesNameGetValue, string[] propertiesNameSetValue)
        {
            PropertiesGetValue = propertiesNameGetValue;
            PropertiesSetValue = propertiesNameSetValue;
        }
    }
}
