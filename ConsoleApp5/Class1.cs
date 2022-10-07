using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp5
{
    public class Election
    {



        public static void Main(string[] args)
        {

            int Age = 0;
            int Currentyear = 2022;
            int EligibleYear;
            int[] dob = new int[10];
            for(int i = 0; i < 10; i++)
            {

            }
            int len = dob.Length;
            for (int i = 0; i < len; i++)
            {
                Age = Currentyear - dob[i];


                if (Age >= 18)
                {
                    Console.WriteLine("Eligible for voting");
                    Console.WriteLine("Year of voting is " + Currentyear);
                }
                else if (Age < 18)

                {
                    Console.WriteLine("Not eligible for voting in 2022");
                    EligibleYear = dob[i] + 18;
                    Console.WriteLine("Will be eligible for voting in " + EligibleYear);

                }
                else
                {
                    Console.WriteLine("INVALID AGE");
                    Console.WriteLine("Voting eligible year is 0");
                }
            }
        }
    }
}
