using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 10;
            string guess;
            int guessValue;
            int i = 0;

            do
            {
                WriteLine("Enter a number between 1 to 10 >>>>");
                guess = ReadLine();
                guessValue = Convert.ToInt32(guess);

                Random ranNumber = new Random();
                int randomNumber;
                randomNumber = ranNumber.Next(MIN, MAX);

                if(guessValue < randomNumber)
                {
                    Write("TOO LOW");
                    i = i + 1;
                }
                else if (guessValue > randomNumber)
                {
                    Write("TOO HIGH");
                    i = i + 1;
                }
            }while
        }
    }
}
