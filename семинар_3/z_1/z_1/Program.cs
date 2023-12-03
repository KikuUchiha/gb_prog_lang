using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int sum = 0; //количество элементов массива, значения которых лежат в отрезке [20,90]

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                 array[i] = rnd.Next(1, 100);

            Console.WriteLine(string.Join(", ", array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 90 && array[i] >= 20)
                    sum++;
            }

            Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90]: " + sum);
        }
    }
}
