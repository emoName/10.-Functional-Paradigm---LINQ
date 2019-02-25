using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LINQ_Expresion
    {
        static public void Method()
        {
            var a = new
            {
                id = 3,
                value = 34,
                name = "aaaaaa"
            };
            var b = new
            {
                id = 4,
                value = 34,
                name = "aaaaaa"
            };
            var c = new
            {
                id = 2,
                value = 34,
                name = "aaaaaa"
            };


            var list = new[] { a, b, c }.ToList();

            var list1 = from l in list
                        where l.id <= 3 & l.name == "aaaaaa"
                        select new
                        {
                            l.value,
                            l.id
                        };


            var list2 = from l in list
                        where l.id <= 3 & l.name == "aaaaaa"
                        select  l.id
                        ;





            list2 = list2.GetEnumerator();


            IEnumerator list21 =  list2.GetEnumerator();
            //int i = 0;
            //Console.WriteLine($" {list2} ");
          
            

            foreach ( var item in list1 )
            {
                Console.WriteLine($" {item.id} , {item.value} ");

            }
            foreach ( var item in list2 )
            {
                Console.WriteLine(item);

             
            }

            Console.WriteLine("-----------------------------");


            while ( list21.MoveNext() )
            {
                Console.WriteLine(list21.Current);
            }



        }






    }
}
