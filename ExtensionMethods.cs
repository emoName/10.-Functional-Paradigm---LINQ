using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class ExtensionMethods
    {


      static  void Compare(this int a, int b)
        {
            Console.WriteLine("a>b");
        }


        static void ExMain()
        {
            int a = 5;
            int b = 3;

            a.Compare(b);



        }


    }
}
