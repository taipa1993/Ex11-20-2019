using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11202019
{
    class TestArr : BaseClass
    {
        internal override void Run()
        {
            ArrayList arrayListA = new ArrayList(2);
            ArrayList arrayListB = new ArrayList();

            Console.WriteLine(" Default Capacity : {0} ",arrayListB.Capacity );

            Console.WriteLine("Capacity of ArrayListA :{0} ", arrayListA.Capacity);
            Console.WriteLine("Number of elements in ArrayListA when Start: {0}", arrayListA.Count);
           
            // add in arrayListA
            arrayListA.Add(new Student(1, "tai"));
            arrayListA.Add(new Student(2, "nhan"));
            arrayListA.Add(new Student(0,"Nam"));           

            Console.WriteLine("Number of elements in ArrayList after add : {0}", arrayListA.Count);
            Console.WriteLine("Capacity of ArrayListA after add : {0}", arrayListA.Capacity);

            // Soft arraylist by one Compare
            arrayListA.Sort(new SortStudent());

            Console.WriteLine("List soft by id : ");
            foreach (Student item in arrayListA)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
            
        }
    }
    
}
