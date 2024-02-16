using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._2_Базовый_Вар_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 3;
            const int n = 4;
            int[,] a = new int[m, n];
            Random rand = new Random();
            int i, j, k, x;

            Console.WriteLine("Исходная матрица");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(100);
                    Console.Write($"{a[i, j],4}");
                }
                Console.WriteLine();
            }

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[m - 1, i] > a[m - 1, j])
                    {
                        for (k = 0; k < m; k++)
                        {
                            x = a[k, i];
                            a[k, i] = a[k, j];
                            a[k, j] = x;
                        }
                    }
                }
            }

            Console.WriteLine("Сортировка по возрастанию последней строки");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
