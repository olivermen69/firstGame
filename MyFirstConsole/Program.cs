using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            float y = 4.5f;
            string str = "lorem ipsum";
            bool myBool = false;

            float result = 0;

            result = 5 + 7;
            Console.WriteLine("suma: " + result);

            result = 5 - 7;
            Console.WriteLine("resta: " + result);

            result = 5 * 7;
            Console.WriteLine("multi: " + result);

            result = 5f / 7f;
            Console.WriteLine("divid: " + result);

            result = 5 % 2;
            Console.WriteLine("modul: " + result);

            Console.ReadLine();
        }
    }
}
