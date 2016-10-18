using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the square array");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("entered array is ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            PrintSpiral(a,n);
            Console.Read();
        }
        public static void PrintSpiral(int[,] a,int n)
        {
            int length = n + (n - 1);
            int count = 0;
            int i = 0, j = 0;
            while(count<length)
            {
                if(count<length)
                {
                    for(j= i;j<(n-i);j++)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    j--;
                    count++;   
                }
                if (count < length)
                {
                    for (i=i+1; i <= j; i++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    i--;
                    count++;
                }
                if (count < length)
                {
                    for (j = j-1; j >= (n - i-1); j--)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    j++;
                    count++;
                }
                if (count < length)
                {
                    for (i=i-1 ; i > j ; i--)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    i++;
                    count++;
                }

            }
        }
    }
}
