using System;
using System.Linq;

namespace REPEATER
{
    public class FuncoesComuns
    {
        public static string AlfanumericoAleatorio(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijlmnopqrstuvxz";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());

            return result;
        }
    }
}
