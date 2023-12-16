using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace z_1
{
    internal class Program
    {
        static string rec(int a, int b)
        {
            if (a==b)
                return "";
            return rec(a,b - 1) + $"{b} ";
        }

        static void start_consl()
        {
            Console.Clear();
            Console.Write("Введите числа a и b, где a < b ");
            Console.WriteLine();
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b) //проверка условия, для работы с промежутком (a;b)
                Console.WriteLine(rec(a, b - 1));
            else
                start_consl();//если условие не выполнено, заново очистить консоль и ввести числа
        }
        static void Main(string[] args)
        {
            start_consl();
        }
    }
}
