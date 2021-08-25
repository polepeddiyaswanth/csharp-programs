using System;

namespace _2d_array
{
    class Array
    {
        static int Main()
        {
            int[,] array = new int[100, 100];
            int n1, n2, i, j,ch, sum=0,x,row=0,col=0,flag=0,c=0;
            Console.Write("enter the range of first array:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("enter the range of second array:");
            n2 = int.Parse(Console.ReadLine());
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("Enter value for array[{0}][{1}]:", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nTwo Dimensional array elements:\n");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                    if (j == n2 - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
            do
            {
                Console.Write("\nDo you want to print:\n1:index value\n2:matrix\n3.sum of all elements\n4.enter the number in the matrix it will show position\n5.if you want to replace any element in matrix\n6.if you want to count the number how many times repeated\n7.to write the matrix in ascending order.\n8.to write the matrix in descending order.\n9.to exit the programme\n");
                 ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.Write("enter the row:");
                        i = int.Parse(Console.ReadLine());
                        Console.Write("enter the coloumn:");
                        j = int.Parse(Console.ReadLine());
                        Console.Write("the value of the index is {0}", array[i, j]);
                        break;
                    case 2:
                        Console.Write("\nTwo Dimensional array elements:\n");
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                Console.Write("{0} ", array[i, j]);
                                if (j == n2 - 1)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                        break;
                    case 3:
                        for (i = 0; i < n1; i++)
                        
                            for (j = 0; j < n2; j++)
                       
                                sum += array[i,j];
                        {
                            Console.Write("\nSum of All Elements in Matrix = {0}", sum);
                        }
                        break;
                    case 4:
                        Console.Write("Enter the search element:\n");
                         x = int.Parse(Console.ReadLine());

                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                if (array[i,j] == x)
                                {
                                    flag = 1;
                                    row = i;
                                    col = j;
                                }
                            }
                        }
                        if (flag == 1)
                        {
                            Console.Write("Position of Search Element {0} is [{1},{2}]", x, row, col);
                        }
                        else
                            Console.Write("Given Search Element is not found....");
                        break;
                    case 5:
                        Console.Write("enter the number which want to replace:");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.Write("enter the new number");
                        int m2 = int.Parse(Console.ReadLine());
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                if (array[i,j] == m1)
                                    array[i,j] = m2;
                            }
                        }
                       Console.Write("after replacing the elements in matrix:\n");
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                Console.Write("{0} ",array[i,j]);
                                if (j == n2 - 1)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.Write("what is the value you want to count:");
                        int a = int.Parse(Console.ReadLine());
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                if (array[i,j] == a)
                                    c++;
                            }
                        }
                        Console.Write("count={0}", c);
                        break;
                    case 7:
                        Console.Write("after ascending order\n");
                        for (i = 0; i < n1; ++i)
                        {
                            for (j = 0; j < n2; ++j)
                            {
                                for (int k = (j + 1); k < n2; ++k)
                                {
                                    if (array[i,j] > array[i,k])
                                    {
                                        a = array[i,j];
                                       array[i,j] = array[i,k];
                                       array[i,k] = a;
                                    }
                                }
                            }
                        }
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                Console.Write("{0} ", array[i,j]);
                                if (j == n2 - 1)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                        break;
                    case 8:
                        Console.Write("after descending order:\n");
                        for (i = 0; i < n1; ++i)
                        {
                            for (j = 0; j < n2; ++j)
                            {
                                for (int k = (j + 1); k < n2; ++k)
                                {
                                    if (array[i,j] < array[k,j])
                                    {
                                        a =array[i,j];
                                        array[i,j] = array[i,k];
                                        array[i,k] = a;
                                    }
                                }
                            }
                        }
                        for (i = 0; i < n1; i++)
                        {
                            for (j = 0; j < n2; j++)
                            {
                                Console.Write("{0} ", array[i,j]);
                                if (j == n2 - 1)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                        break;
                            case 9:
                               Console.Write("bye");
                        break;
                    default:
                        Console.Write("choose correct option.");
                        break;


                }
            }
            while (ch != 9);
                return 0;    
          }
      }
 }

