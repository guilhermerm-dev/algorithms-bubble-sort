using System;
using System.Linq;

namespace algorithms_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 10, 2, 3, 8, 9, 5, 4, 6, 7, 1 };
            int[] arrayB = { 10, 20, 30, 80, 90, 50, 40, 60, 70, 100 };
            var bubbleSort = new BubbleSort();
            bubbleSort.Sort(arrayA);
            bubbleSort.RecursiveSort(arrayB, arrayB.Length - 1);
            arrayA.ToList().ForEach(item => Console.WriteLine($"{item}"));
            Console.WriteLine();
            arrayB.ToList().ForEach(item => Console.WriteLine($"{item}"));
        }
    }
}
