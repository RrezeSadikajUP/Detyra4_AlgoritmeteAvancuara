using System;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] array = new int[1000000];
            Random RNumber = new Random();


            for (int i = 0; i < 1000000; i++)
            {
                array[i] = RNumber.Next(1, 1000000);
            }

            int temp;
            Console.WriteLine("Wait until array is sorted...");

            //Console.Write("Unsorted array: ");
            //Print(array);

            for (int i = 0; i <= array.Length - 2; i++)

            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.Write("Sorted array: ");
            Print(array);
            watch.Stop();
            var timeforelapse = watch.ElapsedMilliseconds;

            Console.WriteLine("Elapsed Time is {0} ms", timeforelapse);

            Console.ReadLine();
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

