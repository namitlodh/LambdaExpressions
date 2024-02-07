using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            List<Student> list = new List<Student>()
            {
                new Student { Rollno=1, Name="Rahul"},
                new Student { Rollno=2, Name="Anu"},
                new Student { Rollno=3, Name="Namit"},
                new Student { Rollno=4, Name="Dinesh"},
                new Student { Rollno=5, Name="Siddhant"}
            };
            Console.Write("The list of student : \n");
            foreach (var i in list)
            {
                Console.WriteLine($"{i.Rollno} : {i.Name}");
            }
            Console.WriteLine();

            var integers=list.OrderBy(x =>x.Name);
            Console.Write("The updated list is: \n");
            foreach (var d in integers)
            {
                Console.WriteLine($"{d.Rollno} : {d.Name}");
            }
            Console.ReadLine();
        }
    }
}
