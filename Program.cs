using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region задание 1

            int[] arr = { 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 9, 10 };

            int evenCount = arr.Count(x => x % 2 == 0);
            int oddCount = arr.Count(x => x % 2 == 1);
            int uniqueCount = arr.Distinct().Count();

            Console.WriteLine("Четных элементов: " + evenCount);
            Console.WriteLine("Нечетных элементов: " + oddCount);
            Console.WriteLine("Уникальных элементов: " + uniqueCount + '\n');

            #endregion


            #region задание 2

            Console.Write("Введите значение: ");
            int value = Convert.ToInt32(Console.ReadLine());

            int count = arr.Count(x => x < value);

            Console.WriteLine("Количество элементов, меньших " + value + ": " + count + '\n');

            #endregion


            #region задание 3

            int[] arr1 = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            Console.Write("Введите три числа через пробел: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = Convert.ToInt32(input[i]);
            }

            count = 0;
            for (int i = 0; i < arr1.Length - 2; i++)
            {
                if (arr1[i] == nums[0] && arr1[i + 1] == nums[1] && arr1[i + 2] == nums[2])
                {
                    count++;
                }
            }

            Console.WriteLine("Количество повторений последовательности: " + count + '\n');

            #endregion


            #region задание 4

            int[] arr2 = { 1, 2, 3, 4 };
            int[] arr3 = { 3, 4, 5, 6 };

            int[] common = arr2.Intersect(arr3).Distinct().ToArray();

            Console.WriteLine("Общие элементы двух массивов без повторений: ");
            foreach (int item in common)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine('\n');

            #endregion


            #region задание 5

            int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int min = arr4[0, 0];
            int max = arr4[0, 0];
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    if (arr4[i, j] < min)
                    {
                        min = arr4[i, j];
                    }
                    if (arr4[i, j] > max)
                    {
                        max = arr4[i, j];
                    }
                }
            }

            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Максимальное значение: " + max);

            #endregion

        }
    }
}
