using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DisplayMulitplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, d = 4, e = 5,
            f = 6, g = 7, h = 8, i = 9, j = 10;
            int product;
           
            while (a <= 10)
            {
                product = a * 1;
                WriteLine("{0} * 1 = {1}", a, product);
                a = a + 1;
            }
            while (b <= 10)
            {
                product = b * 2;
                WriteLine("{0} * 2 = {1}", b, product);
                b = b + 1;
            }
            while (c <= 10)
            {
                product = c * 3;
                WriteLine("{0} * 3 = {1}", c, product);
                c = c + 1;
            }
            while (d <= 10)
            {
                product = d * 4;
                WriteLine("{0} * 4 = {1}", d, product);
                d = d + 1;
            }
            while (e <= 10)
            {
                product = e * 5;
                WriteLine("{0} * 5 = {1}", e, product);
                e = e + 1;
            }
            while (f <= 10)
            {
                product = f * 6;
                WriteLine("{0} * 6 = {1}", f, product);
                f = f + 1;
            }
            while (g <= 10)
            {
                product = g * 7;
                WriteLine("{0} * 7 = {1}", g, product);
                g = g + 1;
            }
            while (h <= 10)
            {
                product = h * 8;
                WriteLine("{0} * 8 = {1}", h, product);
                h = h + 1;
            }
            while (i <= 10)
            {
                product = i * 9;
                WriteLine("{0} * 9 = {1}", i, product);
                i = i + 1;
            }
            while (j <= 10)
            {
                product = j * 10;
                WriteLine("{0} * 10 = {1}", j, product);
                j = j + 1;
            }
        }   
    }
}

