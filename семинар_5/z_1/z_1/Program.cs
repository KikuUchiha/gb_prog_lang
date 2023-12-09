using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_1
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            Random random = new Random();
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
            int[,] matrix = new int[4,4];
            InputMatrix(matrix);

            Console.Write("Введите номер строки: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите номер столбца: ");
            int col = int.Parse(Console.ReadLine());

            if (row >= 0 && row <= 4 && col >= 0 && col <= 4)
            {
                Console.WriteLine("Значение, выбранного вами элемента: " + matrix[row, col]);
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
            PrintMatrix(matrix);
        }
    }
}
