using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = add(10, 12);
            int result2 = add(10,12,12);

            Console.WriteLine("{0},{1}",result1,result2);
            Console.ReadLine();
         }
        public static int add(int a, int b) {
            return a + b;
        }
        public static int add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
