using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data_short
{
    public class Student
    {
        public string Name { get;}
        public string Class1 { get;}
        public Student(string name, string ClassName)
        {
            Name = name;
            Class1 = ClassName;
        }
    }
}
