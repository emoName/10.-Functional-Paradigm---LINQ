using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Functional_Paradigm
{
    // trebue sa fie static Deoarece ii extension method
    static class ExtensionMethods
    {

        //Treabue sa fie Public ca sa fie acesibil de oriunde
        // Nu poti folosi 2 extensii intro metoda
        // { this } trebue sa la primul parametru
        public static void Compare(this int a, int b)
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
