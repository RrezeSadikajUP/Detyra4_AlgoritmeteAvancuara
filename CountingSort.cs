using System;

namespace CountingSort
{
    class CountingSort
    {
        public static void Main()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] array = new int[1000000];
            Random RNumber = new Random();


            for (int i = 0; i < 1000000; i++)
            {
                array[i] = RNumber.Next(1, 1000000);
            }

            Console.WriteLine("Array is sorting...");

            //Console.Write("Unsorted array: ");
            //Print(array);

            

            Console.Write("Sorted array: ");
            Print(array);
            var timeforelapse = watch.ElapsedMilliseconds;

            Console.WriteLine("Elapsed Time is {0} ms", timeforelapse);
            Console.ReadLine();

            Sort(array);
        }
        static void Sort(int[] array)
        {
            int length = array.Length;

            int[] output = new int[length];

            int[] count = new int[1000000];

            for (int i = 0; i < 100; ++i)
            {
                count[i] = 0;
            }
            for (int i = 0; i < length; ++i)
            {
                ++count[array[i]];
            }

            for (int i = 1; i <= 99; ++i)
            {
                count[i] += count[i - 1];
            }

            for (int i = length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }

            for (int i = 0; i < length; ++i)
            {
                array[i] = output[i];
            }
        }

        private static void Print(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}