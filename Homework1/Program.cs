using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args) //Entry point
        {
            //The first array with integer data
            int[] arrayInt = new int[3];
            arrayInt[0] = 10;
            arrayInt[1] = arrayInt[0] * arrayInt[0];
            arrayInt[2] = arrayInt[0] + arrayInt[1];

            //The second array with long data
            long[] arrayLong = new long[3];
            arrayLong[0] = 2350678;
            arrayLong[1] = arrayLong[0] * arrayLong[0];
            arrayLong[2] = arrayLong[0] + arrayLong[1];

            //The third array with float data
            float[] arrayFloat = new float[3];
            arrayFloat[0] = arrayInt[0] + arrayLong[0];
            arrayFloat[1] = arrayInt[1] + arrayLong[1];
            arrayFloat[2] = arrayInt[2] + arrayLong[2];

            //The output to Console
            Console.WriteLine("arrayInt[0] = {0}", arrayInt[0]);
            Console.WriteLine("arrayInt[1] = {0}", arrayInt[1]);
            Console.WriteLine("arrayInt[2] = {0}", arrayInt[2]);

            Console.WriteLine("arrayLong[0] = {0}", arrayLong[0]);
            Console.WriteLine("arrayLong[1] = {0}", arrayLong[1]);
            Console.WriteLine("arrayLong[2] = {0}", arrayLong[2]);

            Console.WriteLine("arrayFloat[0] = {0}", arrayFloat[0]);
            Console.WriteLine("arrayFloat[1] = {0}", arrayFloat[1]);
            Console.WriteLine("arrayFloat[2] = {0}", arrayFloat[2]);
        }
    }
}
