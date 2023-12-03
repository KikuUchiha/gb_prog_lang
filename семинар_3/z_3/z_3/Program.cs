using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Создание объекта для генерации чисел
            Random rnd = new Random();

            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = Math.Round(rnd.NextDouble(), 2) + rnd.Next(255);//т.к nextDouble генерирует числа в диапазоне [0,1], прибавлю целое рандомное число(чтобы в результете были числа > 1)
            Console.WriteLine(string.Join(", ", array));

            double max = array[0];
            double min = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                        if (min > array[i])
                        {
                            min = array[i];
                        }
                }
                else
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + (max - min));
        }
    }
}
