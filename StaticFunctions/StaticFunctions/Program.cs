﻿using System;

namespace StaticFunctions
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();

            s.count();
            s.count();
            s.count();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
            Console.ReadKey();

        }
    }
}
