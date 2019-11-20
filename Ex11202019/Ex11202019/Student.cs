using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11202019
{
    public class Student
    {
        int id;
        string name;
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public override  string ToString()
        {
            return "Id " + id + " | Name " + name;
        }
    }
    class SortStudent : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;
            if (x == null || y == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (s1.Id == s2.Id)
                {
                    return 0;
                }
                else if (s1.Id < s2.Id)
                {
                    return -1;
                }
                else return 1;
            }

        }
    }
}
