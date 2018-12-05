using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial;
            char salesperson;
            string sale;
            double saleAmountD, saleAmountE, saleAmountF ;
            double sumD = 0, sumE = 0, sumF = 0;
            

            do
            {
 
                WriteLine("Enter the Salesperson inital here (d, e, or f) Enter (z or Z) to quit>>>");
                initial = ReadLine();             
                salesperson = Convert.ToChar(initial);

                if (salesperson == 'd' || salesperson == 'D')
                {
                    WriteLine("Enter the amount of the sales here>>>");
                    sale = ReadLine();
                    saleAmountD = Convert.ToDouble(sale);
                    sumD = sumD + saleAmountD;
                }
                else if (salesperson == 'e' || salesperson == 'E')
                {
                    WriteLine("Enter the amount of the sales here>>>");
                    sale = ReadLine();
                    saleAmountE = Convert.ToDouble(sale);
                    sumE = sumE + saleAmountE;
                }
                else if (salesperson == 'f' || salesperson == 'F')
                {
                    WriteLine("Enter the amount of the sales here>>>");
                    sale = ReadLine();
                    saleAmountF = Convert.ToDouble(sale);
                    sumF = sumF + saleAmountF;
                }
                else
                {
                    WriteLine("Error");
                }
            } while (initial != "z" && initial != "Z");
            WriteLine("The amount of sales for Danielle was {0}.", sumD);
            WriteLine("The amount of sales for Edward was {0}.", sumE);
            WriteLine("The amount of sales for Francis was {0}.", sumF);
        }
    }
}
