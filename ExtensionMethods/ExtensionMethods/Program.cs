using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //getOperation();
            getOperationWithExtension();
        }

        static void getOperation()
        {
            string str1 = "Orkan";
            Console.WriteLine(str1.ToCharArray());
            Console.Read();
        }

        static void getOperationWithExtension()
        {
            string str1 = "Orkan";
            Console.WriteLine(str1.KarakterDizisineCevir());
            Console.WriteLine(str1.HepsiBuyukHarf());
            Console.Read();
        }
    }
}