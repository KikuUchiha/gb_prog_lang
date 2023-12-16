using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    internal class Program
    {
        static int A(int m, int n)
        {
            if (m == 0) 
                return n + 1;
            if (m > 0 && n == 0) 
                return A(m - 1, 1);
            return A(m - 1, A(m, n - 1));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m < 0 || n < 0)
                Console.WriteLine("Значения m и n не могут быть меньше нуля");
            else
                Console.WriteLine(A(m, n));
        }
    }
}
