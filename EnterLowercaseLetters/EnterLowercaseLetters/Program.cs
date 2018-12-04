using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string lowerCase;
            char letter;


            do
            {
                WriteLine("Enter lowercase letters here>>>");
                lowerCase = ReadLine();
                letter = Convert.ToChar(lowerCase);

                if (letter >= 'a' && letter <= 'z')
                {
                    WriteLine("OK");
                }
                else
                {
                    WriteLine("Error ");
                }

            } while (lowerCase != "!");

        }
    }
}

