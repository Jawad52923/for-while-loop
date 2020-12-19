using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int a=Convert.ToInt16(Console.ReadLine());

            int i = 1;
            do
            {
                Console.WriteLine(a +"x"+ i + "=" + a*i);
                i++;
            } while (i<=10);






















            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }

            //    Console.WriteLine();
            //    i++;
            //}
        }
    }
}
