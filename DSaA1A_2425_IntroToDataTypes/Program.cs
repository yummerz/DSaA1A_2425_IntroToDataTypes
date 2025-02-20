using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSaA1A_2425_IntroToDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data type declarations
            // <dt> <vn> = <initial value>
            byte a = 1;

            short b = 1;
            int c = 1;
            long d = 1;

            float e = 1f;

            double f = 1d;

            char g = 'a';

            bool i = true;
            i = !i;

            string j = "hello";
            #endregion

            b = a;
            c = b;
            d = c;
            
            //ok
            a = (byte)b;
            a = (byte)c;

            int k = 65;
            char l = (char)k;

            Console.WriteLine(l);

            l = (char)(k + 32);
            Console.WriteLine(l);

            k = l;
            Console.WriteLine(k);

            string thing = "Southville";

            for (int x = 0; x < thing.Length; x++)
                Console.Write((int)thing[x] + " ");
            Console.WriteLine();
            for (int x = thing.Length - 1; x > -1; x--)
                Console.Write(thing[x]);

            char[] thing2 = thing.ToCharArray();

            Console.Clear();
            //while(true)
            //{
            //    a++;
            //    Console.WriteLine(a);
            //    if (a == 0)
            //        Console.ReadKey();
            //}

            b = -300;
            a = (byte)b;

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
