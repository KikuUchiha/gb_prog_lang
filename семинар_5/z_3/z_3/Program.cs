using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            Random random = new Random(); // Генератор случайных чисел
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(0, 11);
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

        static void MinSum(int[,] matrix, out int result)
        {
            int Min = 0;//минимальная сумма элементов строки
            int NumberRow = 0;//номер строки с минимальной суммой элементов
            int Sum = 0;   
            
            //Находим сумму элементов первой строки
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Min = Min + matrix[0,i];
            }

            //перебор массива, исключая перебор первой строки
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Sum = Sum + matrix[i,j];//находим сумму элементов строки
                }

                if (Min > Sum)
                {
                    Min = Sum;
                    NumberRow = i;
                }
                Sum = 0;
                
            }
            result = NumberRow;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            InputMatrix(matrix);
            PrintMatrix(matrix);

            int NumberRow;
            MinSum(matrix, out NumberRow);

            Console.WriteLine("Номер строки с наименьшей суммой элементов: " + NumberRow );
        }
    }
}
