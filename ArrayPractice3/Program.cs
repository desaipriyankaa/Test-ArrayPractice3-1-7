using System;

namespace ArrayPractice3
{
    //Take input from usere
    // Display Multidimentional array
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] arr1 = new int[2, 2];
            Console.WriteLine("Specify members of Array :");
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
        }
    }
}
