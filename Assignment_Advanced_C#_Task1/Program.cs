using Assignment_Advanced_C__Task1.BubbleSort;
using Assignment_Advanced_C__Task1.Genaric;

namespace Assignment_Advanced_C__Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            /*
             * 1. The Bubble Sort Algorithm has a time Complexitly of O(n^2) in its Worst and average Cases , Which makes
             * it inefficient for large datasets. How We Can optimize The Sort Algorithm and implement the code of this 
             * optimize Bubble Sort Algorithm
             */

            //int[] arr = { 3, 5, 9, 7, 5, 6, 5, 1, 4, 2, 3 };
            //
            //Console.Write("Arr :[");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]},");
            //}
            //
            //Console.WriteLine("\n---------------");
            //Console.WriteLine("Array After Sorting");
            //Sort.BubbleSort(arr);
            #endregion

            #region Question 02
            /*
            2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
               The range should support basic operations such as checking if a value is within the range 
               and determining the length of the range.
               Requirements:
               1.Create a generic class named Range<T> where T represents the type of values.
               2.Implement a constructor that takes the minimum and maximum values to define the range.
               3.Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
               4.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
               5.Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
            */

            Range<int> range = new Range<int>(5, 15);
            Console.WriteLine($"Is 10 in range: {range.IsInRange(10)}");  // True
            Console.WriteLine($"Is 20 in range: {range.IsInRange(20)}");  // False
            Console.WriteLine($"Length of range: {range.Length()}");      // 10
            #endregion   
        }
    }
}