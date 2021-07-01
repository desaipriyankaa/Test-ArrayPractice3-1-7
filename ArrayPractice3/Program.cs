using System;

namespace ArrayPractice3
{
    // Display Multidimentional array
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] arr1 = { { 2,3} ,{ 4,5} };
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
