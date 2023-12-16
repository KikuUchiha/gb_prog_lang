using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
    internal class Program
    {
        static string mas_invert(char[] input, int lenght_mas, int n)
        {
            if (n == lenght_mas )
                return "";
            return mas_invert(input, lenght_mas, n + 1) + $"{input[n]}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое слово или предложение");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int lenght_mas = chars.Length;
            int n = 0;

            Console.WriteLine(mas_invert(chars, lenght_mas, n));
        }

    }
}
