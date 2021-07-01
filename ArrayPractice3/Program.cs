using System;

namespace ArrayPractice3
{
    //Take input from usere
    // Display Multidimentional array
    class Program
    {
        static void Main(string[] args)
        {
            // Array 1
            int[,] arr1 = new int[2, 2];
            Console.WriteLine("Specify members of Array 1:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }

            // Array 2
            int[,] arr2 = new int[2, 2];
            Console.WriteLine("Specify members of Array 2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Addition of two array
            int[,] resultArray = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultArray[i,j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Result of array Addition is :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(resultArray[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
