﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickshort
{
    class Program
    {
        private int [] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("enter the number off elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n======================");
            Console.WriteLine("Enter Arrray Elememts = ");
            Console.WriteLine("\n======================");

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        void swap (int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            i = low + 1;
            j = high;

            pivot = arr[low];
            while (i <= j)
            {
                while((arr[i] <= pivot )  && (i<= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) ;
                {
                    swap(i, j);
                }
            }
        }



        static void Main(string[] args)
        {
        }
    } 
}
