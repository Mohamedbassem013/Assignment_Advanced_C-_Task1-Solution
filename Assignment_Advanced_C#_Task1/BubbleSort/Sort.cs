using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task1.BubbleSort
{
    internal class Sort
    {
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array is null or empty.");
                return;
            }
            bool swapped;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                Console.WriteLine($"\nStep {i + 1}:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
