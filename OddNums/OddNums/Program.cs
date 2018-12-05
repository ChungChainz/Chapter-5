using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            while(i <= 99)
            {
               i= i + 2;
               WriteLine(i);           
            }
        }
    }
}
