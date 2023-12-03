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
            int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
            int temp;
            // Вывод исходного массива
            Console.Write("Исходный массив: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            // Реверсирование массива
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                // Меняем местами элементы
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            // Вывод измененного массива
            Console.Write("\nПеревернутый массив: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
