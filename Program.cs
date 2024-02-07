using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.Write("The list : ");
            foreach (var i in list)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();

            var integers=list.FindAll(x => (x%2)==0);
            Console.Write("The list for 2 factors are: ");
            foreach (var d in integers)
            {
                Console.Write("{0} ",d);
            }
            Console.ReadLine();
        }
    }
}
