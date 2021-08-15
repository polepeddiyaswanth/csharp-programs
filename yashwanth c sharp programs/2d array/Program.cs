using System;

namespace _2d_array
{
    class Program
    {
        static void Main()
        {
           int[,] array = new int[100,100];
            int n1,n2,i,j;
            Console.Write("enter the range of first array:");
            n1=int.Parse(Console.ReadLine());
            Console.Write("enter the range of second array:");
            n2=int.Parse(Console.ReadLine());
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("Enter value for array[{0}][{0}]:" ,i, j);
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.write("\nTwo Dimensional array elements:\n");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    printf("%d ", disp[i][j]);
                    if (j == n2 - 1)
                    {
                        printf("\n");
                    }
                }
            }
        }
    }
}
