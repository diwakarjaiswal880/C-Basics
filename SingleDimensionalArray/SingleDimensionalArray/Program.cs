﻿using System;

namespace SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
