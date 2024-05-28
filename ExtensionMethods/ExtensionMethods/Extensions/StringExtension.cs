using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    public static class StringExtension
    {
        public static char[] KarakterDizisineCevir(this string str)
        {
            return str.ToCharArray();
        }

        public static string HepsiBuyukHarf(this string str)
        {
            return str.ToUpper();
        }
    }
}