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
        
        static void Main(string[] args)
        { 
            
            AddDelegate ad = delegate(int a, int b)
            {
                Console.WriteLine(a + b);
                Console.WriteLine(a*b);
            };
            ad.Invoke(100,50);
            Console.ReadLine();
        }
    }
}
