using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Functional_Paradigm
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
                        select l.id
                        ;



            var list3 = new
            {
                list = new[]
                {
                    list1,
                    list1
                }
            };
            var list4 = new
            {
                list = new[]
                {
                    list1,
                    list1
                }
            };

            var list5 = new[] { list3, list4 }.ToList();


            var list6 = list5.SelectMany(s => s.list);



            foreach ( var item in list6 )
            {
               // var al = item.GetEnumerator();
                foreach ( var ii in item )
                {
                    Console.WriteLine(ii.id+"+"+ii.value);
                }
            }


            Console.ReadLine();
            //  var list3 = list.OfType<a.GetType()  >();



            // list2 = 
            var i = list2.GetEnumerator().Current;

            IEnumerator list21 = list2.GetEnumerator();

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
