using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public delegate void AddDelegate(int x, int y);
    
    internal class Program
    {
        public void Addnums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Mulnums(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void Main(string[] args)
        { 
            Program program = new Program();
            AddDelegate ad = new AddDelegate(program.Addnums);
            ad += program.Mulnums;
            ad.Invoke(100, 50);
            Console.ReadLine();
        }
    }
}
