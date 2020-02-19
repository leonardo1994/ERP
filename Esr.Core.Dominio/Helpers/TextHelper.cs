using System;
using System.Globalization;
using System.Linq;

namespace Esr.Core.Domain.Helpers
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class TextHelper
    {
        public static string RemoverAcentos(string texto)
        {
            if (texto == null) return string.Empty;

            const string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            const string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (var i = 0; i < comAcentos.Length; i++)
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());

            return texto;
        }

        public static string FormatarTextoParaUrl(string texto)
        {
            texto = RemoverAcentos(texto);

            var textoretorno = texto.Replace(" ", "");

            const string permitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmonopqrstuvwxyz0123456789-_";

            for (var i = 0; i < texto.Length; i++)
                if (!permitidos.Contains(texto.Substring(i, 1)))
                {
                    textoretorno = textoretorno.Replace(texto.Substring(i, 1), "");
                }

            return textoretorno;
        }

        public static string GetNumeros(string texto)
        {
            return string.IsNullOrEmpty(texto) ? "" : new string(texto.Where(char.IsDigit).ToArray());
        }

        public static string AjustarTexto(string valor, int tamanho)
        {
            if (valor.Length > tamanho)
            {
                valor = valor.Substring(1, tamanho);
            }
            return valor;
        }

        /// <summary>
        /// deixa as primeiras letras maiusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string ToTitleCase(string texto)
        {
            texto = texto.Trim();
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return Ortografia(textInfo.ToTitleCase(textInfo.ToLower(texto)));
        }

        /// <summary>
        /// deixa as letras minusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string ToLowerCase(string texto)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return textInfo.ToLower(RemoverAcentos(texto));
        }

        /// <summary>
        /// deixa as letras maiusculas
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string ToUperCase(string texto)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return textInfo.ToUpper(RemoverAcentos(texto));
        }

        public static string Ortografia(string palavra)
        {
            var array = palavra.Split(' ');
            return array.Aggregate("", (current, t) => current + " " + Verifica(t)).Trim();
        }

        public static string Verifica(string palavra)
        {
            if (palavra.Length == 1) return ToLowerCase(palavra);

            switch (palavra.ToUpper())
            {
                case "AC":
                    return ToUperCase(palavra);
                case "AL":
                    return ToUperCase(palavra);
                case "AP":
                    return ToUperCase(palavra);
                case "AM":
                    return ToUperCase(palavra);
                case "BA":
                    return ToUperCase(palavra);
                case "CE":
                    return ToUperCase(palavra);
                case "DF":
                    return ToUperCase(palavra);
                case "ES":
                    return ToUperCase(palavra);
                case "GO":
                    return ToUperCase(palavra);
                case "MA":
                    return ToUperCase(palavra);
                case "MT":
                    return ToUperCase(palavra);
                case "MS":
                    return ToUperCase(palavra);
                case "MG":
                    return ToUperCase(palavra);
                case "PA":
                    return ToUperCase(palavra);
                case "PB":
                    return ToUperCase(palavra);
                case "PR":
                    return ToUperCase(palavra);
                case "PE":
                    return ToUperCase(palavra);
                case "PI":
                    return ToUperCase(palavra);
                case "RJ":
                    return ToUperCase(palavra);
                case "RN":
                    return ToUperCase(palavra);
                case "RS":
                    return ToUperCase(palavra);
                case "RO":
                    return ToUperCase(palavra);
                case "RR":
                    return ToUperCase(palavra);
                case "SC":
                    return ToUperCase(palavra);
                case "SP":
                    return ToUperCase(palavra);
                case "SE":
                    return ToUperCase(palavra);
                case "TO":
                    return ToUperCase(palavra);
                case "AS":
                    return ToLowerCase(palavra);
                case "OS":
                    return ToLowerCase(palavra);
                case "AOS":
                    return ToLowerCase(palavra);
                case "DA":
                    return ToLowerCase(palavra);
                case "DAS":
                    return ToLowerCase(palavra);
                case "DO":
                    return ToLowerCase(palavra);
                case "DOS":
                    return ToLowerCase(palavra);
                case "DE":
                    return ToLowerCase(palavra);
                case "CNPJ":
                    return ToUperCase(palavra);
                case "RG":
                    return ToUperCase(palavra);
                case "CPF":
                    return ToUperCase(palavra);
                case "CIC":
                    return ToUperCase(palavra);
                case "PIS":
                    return ToUperCase(palavra);
                case "COFINS":
                    return ToUperCase(palavra);
                case "IPI":
                    return ToUperCase(palavra);
                default:
                    return palavra;
            }
        }
    }
}
