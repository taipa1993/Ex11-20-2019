using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11202019
{
    class TestList : BaseClass
    {
        internal override void Run()
        {
            List<Student> listA = new List<Student>(2);
            List<Student> listB = new List<Student>();

            Console.WriteLine("Default Capacity : {0} ", listB.Capacity);

            Console.WriteLine("Capacity of ListA :{0} ", listA.Capacity);
            Console.WriteLine("Number of elements in ListA when Start: {0}", listA.Count);

            // add in arrayListA
            listA.Add(new Student(1, "tai"));
            listA.Add(new Student(2, "nhan"));
            listA.Add(new Student(0, "Nam"));

            Console.WriteLine("Number of elements in List after add : {0}", listA.Count);
            Console.WriteLine("Capacity of ListA after add : {0}", listA.Capacity);
            Console.ReadKey();
        }
    }
}
