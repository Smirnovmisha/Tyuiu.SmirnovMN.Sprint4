using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint4.Task4.V24.Lib;

namespace Tyuiu.SmirnovMN.Sprint4.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Смирнов М.Н. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант 24                                                              *");
            Console.WriteLine("* Выполнил: Смирнов Михаил Николаевич | ИИПБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 5. Заменить четные элементы *");
            Console.WriteLine("* массива на 1.                                                           *");
            Console.WriteLine("* 7, 9, 7, 6, 7,                                                          *");
            Console.WriteLine("* 9, 9, 8, 6, 7,                                                          *");
            Console.WriteLine("* 8, 6, 5, 6, 7,                                                         *");
            Console.WriteLine("* 9, 9, 7, 8, 7,                                                         *");
            Console.WriteLine("* 5, 9, 9, 8, 9,                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int m = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((matrix[i, j] < 1) || (matrix[i, j] > 5)) m += 1;
                }
            }
            if (m > 0)
            {
                Console.WriteLine(0);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nМассив: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                int[,] res = ds.Calculate(matrix);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{res[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}