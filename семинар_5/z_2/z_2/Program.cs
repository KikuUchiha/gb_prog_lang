using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            Random random = new Random(); // Генератор случайных чисел
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(-10, 11);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int col = int.Parse(Console.ReadLine());
            //Создание двумерного массива
            int[,] matrix = new int[row, col];
            InputMatrix(matrix);
            PrintMatrix(matrix);

            //Создание одномерного массива
            int[] array = new int[col];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                array[i] = matrix[0, i];//записываем первую строку массива в другой массив
                matrix[0, i] = matrix[row - 1, i];//присваиваем значения элементов последней строки первой
                matrix[row - 1, i] = array[i];//последней строке присваиваем значения из одномерного массива(значения, которые были в первой строке)
            }
            Console.WriteLine("Поменяем местами первую и последнюю строку массива:");
            PrintMatrix(matrix);
        }
    }
}
