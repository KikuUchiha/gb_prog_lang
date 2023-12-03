using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int sum = 0;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(255);

            Console.WriteLine(string.Join(", ", array));

            for (int i = 0; i < array.Length; i++)
                if (array[i]%2 == 0) 
                    sum++;

            Console.WriteLine("Количество чётных чисел в массиве: " + sum);
        }
    }
}
