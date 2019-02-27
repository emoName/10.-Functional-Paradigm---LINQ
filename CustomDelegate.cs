using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Functional_Paradigm
{


    class CustomDelegate
    {
        // delegatul trebue sa nu fie mai putin accesibil decit metoda care o foloseste
        public delegate int AisGreaterThanBDelegate(int a, int b);


        int compar(int a, int b)
        {
            return -1;
        }
        public void ApelCompare()
        {


            var _compare = new AisGreaterThanBDelegate(compar);

            Commpare(5, 8, _compare);

            Commpare(5, 8,
                            (int a, int b) =>
                                             {
                                                 return 1;
                                             }
                           );

            FuncCompare(4, 4,
                            (int a, int b) =>
                                             {
                                                 return true;
                                             }

                           );

        }
        public void Commpare(int a, int b, AisGreaterThanBDelegate AGreterThanB)
        {

            AGreterThanB(a, b);
        }

        public void FuncCompare(int a, int b, Func<int, int, bool> AGreterThanB)
        {

            void Comp(int c , int d , Action<int,int> action)
            {

            }

            Comp(a, b,(int c,int d)=>
                                      {
                                          Console.WriteLine(false);

                                      }
            );
            Console.WriteLine(AGreterThanB(a, b));
        }












    }
}
