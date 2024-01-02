using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data_short
{
    public class Program
    {
        static List<Student> ReadStudentData(string path)
        {
            List<Student> student = new List<Student>();
            string[] data=File.ReadAllLines(path);
            foreach (string line in data) 
            {
                string[] part = line.Split(',');
                if(part.Length ==2)
                {
                    string name = part[0].Trim();
                    string className = part[1].Trim();
                    student.Add(new Student(name, className));  
                }
            }
            return student.OrderBy(s=>s.Name).ToList();
        }
        static void DisplayAll(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name},{student.Class1}");
            }
        }
        static void SearchStudent(List<Student> students,string n)
        {
            var re=students.Where(s=>s.Name.ToLower().Contains(n.ToLower())).ToList();
            if (re.Any())
            {
                Console.WriteLine("Search Result is:");
                DisplayAll(re);
            }
            else
            {
                Console.WriteLine($"No Student found with Name {n}.");
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\dell\\source\\repos\\Files\\StudentData.txt";
            List<Student> students = ReadStudentData(path);
            
            Console.WriteLine("Choose Any Option\n1.Display all Students\n2.Search Student");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Rainbow School Students");
                DisplayAll(students);
            }
            else if (n == 2)
            {
                Console.WriteLine("Enter Student Name");
                string n1 = Console.ReadLine();
                SearchStudent(students,n1);
            }
            else
            {
                Console.WriteLine("Invalid option try again");
                Main(args);
            }
        }
    }
}
