using System;

namespace Homework2
{
    class Program
    {
        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        static void ReverseArray(int[] array)
        {
            Console.WriteLine("The initial array:");
            PrintArray(array);
            int temp = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            Console.WriteLine("\nThe result of the array reversing: ");          
            PrintArray(array);
        }

        static void SwapMinMax(int[] array)
        {
            Console.WriteLine("\nThe initial array:");
            PrintArray(array);
            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;
            int temp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }

            }
            temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;
            Console.WriteLine("\nThe result of swapping min and max elements in the array:");
            PrintArray(array);
        }

        static int GetCountMostFreqChars(char[] array)
        {
            Console.WriteLine("\nThe initial array:");
            PrintArray(array);
            int maxCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }

                }
                if (maxCount < count)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        static void Main(string[] args)
        {
            /*Task1. Reverse int array.*/
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ReverseArray(array1);

            /*Task2. Reverse max and min in the array.*/
            int[] array2 = { 10, 322, 56, 790, 67, 789 };
            SwapMinMax(array2);
 
            /**********************************************************/
            /*Task3. Find the count of the most frequent characters.*/
            char[] array3 = {'a', 'c', 'f', 'd', 'f', 'd', 't', 't', 'f', 'a', 'g', 'f', 'A', 'g'};
            Console.WriteLine("\nThe quantity of the most frequent char in the array = {0}.", GetCountMostFreqChars(array3));
         }
    }
}
