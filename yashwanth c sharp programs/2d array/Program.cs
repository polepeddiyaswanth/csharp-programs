using System;

namespace _2d_array
{
    class Program
    {
        static void Main()
        {
           int[,] array = new int[100,100];
            int n1,n2;
            Console.Write("enter the range of first array:");
            n1=int.Parse(Console.ReadLine());
            Console.Write("enter the range of second array:");
            n2=int.Parse(Console.ReadLine());
            Console.ReadKey(); 
        }
    }
}
