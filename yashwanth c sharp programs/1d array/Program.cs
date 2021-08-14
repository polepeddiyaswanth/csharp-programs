using System;

namespace even_or_odd
{
    class Program
    {
        static int Main()
        {
            int[] array = new int[100];
            int i,j,k,ch,x,index=-1,pos;
            Console.Write("enter the range of array:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter the values of array:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("array[{0}] : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the array values are");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            do
            {
                Console.Write("\n1.insert an element.\n");
                Console.Write("2.to delete the element.\n");
                Console.Write("3.sorting the array into ascending array.\n");
                Console.Write("4.sortng the array into descending order.\n");
                Console.Write("5.replace a number by using index value.\n");
                Console.Write("6.replacing new number by number.\n");
                Console.Write("7.reading new array elements.\n");
                Console.Write("8.delete by index.\n");
                Console.Write("9.delete by number.\n");
                Console.Write("10.insert a value through index.\n");
                Console.Write("11.finding the duplicate elements.\n");
                Console.Write("12.deleting the duplicate elements.\n");
                Console.Write("13.to exit the programme.\n");
                Console.Write("enter the option:");
                 ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("enter new element:");
                        int m = int.Parse(Console.ReadLine());
                        for (i = n - 1; i <= n; i++)
                        {
                            array[i + 1] = array[i];
                            array[n] = m;
                        }
                        for (i = 0; i < n; i++)
                        {
                            array[i] = array[i + 1];
                        }
                        n--;
                        for (i = 0; i <= n; i++)
                        {
                            Console.Write("{0}", array[i]);
                        }
                        break;
                    case 2:
                        Console.Write("after deleting the number");
                        for (i = 0; i < n - 1; i++)
                        {
                            array[i] = array[i + 1];
                        }
                        n--;
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0}", array[i]);

                        }
                        break;
                    case 3:
                        Console.Write("after ascending order\n");
                        for (i = 0; i < n; ++i)
                        {
                            for (j = i + 1; j < n; ++j)
                            {
                                if (array[i] > array[j])
                                {
                                    x = array[i];
                                    array[i] = array[j];
                                    array[j] = x;
                                }
                            }
                        }
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0} ", array[i]);
                        }
                        break;
                    case 4:
                        Console.Write("after descending order\n");
                        for (i = 0; i < n; ++i)
                        {
                            for (j = i + 1; j < n; ++j)
                            {
                                if (array[i] < array[j])
                                {
                                    x = array[i];
                                    array[i] = array[j];
                                    array[j] = x;
                                }
                            }
                        }
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0} ", array[i]);
                        }
                        break;
                    case 5:
                        Console.Write("please enter the position of the value to replace:");
                        pos = int.Parse(Console.ReadLine());
                        Console.Write("enter the new number:");
                        m = int.Parse(Console.ReadLine());
                        for (i = 0; i < n; i++)
                        {
                            array[pos] = m;
                        }
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0}", array[i]);
                        }
                        break;
                    case 6:
                        Console.Write("enter the number which want to replace:");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("enter the new number");
                        int m1 = int.Parse(Console.ReadLine());
                        for (i = 0; i < n; i++)
                        {
                            if (array[i] == m)
                                array[i] = m1;

                        }
                        Console.Write("after replacing the elements in matrix:\n");
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0} ", array[i]);

                        }
                        break;
                    case 7:
                        Console.Write("enter the values of array:\n");
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("array[{0}] : ", i);
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("the array values are");
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0} ", array[i]);
                        }
                        break;
                    case 8:
                        Console.Write("please enter the position of the value:");
                        pos = int.Parse(Console.ReadLine());
                        for (i = pos; i < n - 1; i++)
                        {
                            array[i] = array[i + 1];
                        }
                        n--;
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0}", array[i]);
                        }
                        break;
                    case 9:
                        Console.Write("enter the number to delete:");
                        x = int.Parse(Console.ReadLine());
                        for (i = 0; i < n; i++)
                        {
                            if (array[i] == x)
                            {
                                index = i;

                            }
                        }

                        if (index == -1)
                        {
                            Console.WriteLine("Element Not Found\n");
                        }
                        else
                        {
                            for (i = index; i < n - 1; i++)
                            {
                                array[i] = array[i + 1];
                            }
                            Console.Write("New Array : ");
                            for (i = 0; i < n - 1; i++)
                            {
                                Console.Write("{0} ", array[i]);
                            }
                        }
                        break;
                    case 10:
                        Console.Write("enter the position where you want to insert the element:");
                        pos = int.Parse(Console.ReadLine());
                        Console.Write("enter the value into that position:");
                        m = int.Parse(Console.ReadLine());
                        for (i = n - 1; i >= pos - 1; i--)
                            array[i + 1] = array[i];
                        array[pos - 1] = m;
                        Console.Write("final array after inserting the value is\n");
                        for (i = 0; i <= n; i++)
                            Console.Write("{0}", array[i]);
                        break;
                    case 11:
                        Console.Write("Duplicate elements in given array: \n");
                        for (i = 0; i < n; i++)
                        {
                            for (j = i + 1; j < n; j++)
                            {
                                if (array[i] == array[j])

                                    Console.Write("{0}\n", array[j]);
                            }
                        }
                        break;
                    case 12:
                        for (i = 0; i < n; i++)
                        {
                            for (j = i + 1; j < n; j++)
                            {
                                if (array[i] == array[j])
                                {
                                    for (k = j; k < n - 1; k++)
                                    {
                                        array[k] = array[k + 1];
                                    }
                                    n--;
                                    j--;
                                }
                            }
                        }

                        for (i = 0; i < n; i++)
                            Console.Write("{0}", array[i]);
                        break;
                    case 13:
                        Console.Write("bye");
                        break;
                    default:
                        Console.Write("choose correct option");
                        break;
                }
            }
            while (ch != 13);
            return 0;
        }
    }
}

