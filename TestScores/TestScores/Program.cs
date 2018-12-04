using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string testValue;
            double total = 0;
            double testScore;
            double avg;
            const int MAX = 100, MIN = 0;
            int tick = 0;
            do
            {
                WriteLine("Enter test value here>>>(Press '!' when finished)");
                testValue = ReadLine();
                testScore = Convert.ToDouble(testValue);
                
                if(testScore <= MAX && testScore >= MIN)
                {
                    tick++;
                    total += testScore;
                    avg = total / tick;
                    WriteLine("There was {0} scores and the average was {1}%.", tick, avg);

                }
                else
                {
                    Write("ERROR REEEEE");
                }
            } while (testValue != "!");
          
        }
    }
}
