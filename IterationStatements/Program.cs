using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Numbers 1000 to -1000:");
            PrintThousand();
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");

            Console.WriteLine("Numbers 3 to 999, counted by 3:");
            ByThrees();
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");


            Console.WriteLine("Check to see if two numbers are equal:");
            Console.WriteLine("Please give one number:");
            var userNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give a second number:");
            var userNumber2 = int.Parse(Console.ReadLine());
            IsEqual(userNumber1, userNumber2);
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");


            Console.WriteLine("Please give a number to see if it is even or odd:");
            var userNum = int.Parse(Console.ReadLine());
            IsEven(userNum);
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");

            Console.WriteLine("Please give a number to see if it is positive or negative:");
            var userInput = int.Parse(Console.ReadLine());
            IsPositive(userInput);
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");

            Console.WriteLine("Are you old enough to vote? Enter your age to check!");
            var userAge = int.Parse(Console.ReadLine());
            CanVote(userAge);
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");

            Console.WriteLine("Provide a number to see if it is in range between -10 and 10:");
            var userCheckRange = int.Parse(Console.ReadLine());
            InRange(userCheckRange);
        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are NOT equal!");
            }
        }

        public static void IsEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an EVEN number!");
            }
            else
            {
                Console.WriteLine($"{a} is an ODD number!");
            }

        }

        public static void IsPositive(int b)
        {
            if (b == 0)
            {
                Console.WriteLine($"{b} is not a positive OR negative number! How neat!");
            }
            else if (b < 0)
            {
                Console.WriteLine($"{b} is a NEGATIVE number!");
            }
            else
            {
                Console.WriteLine($"{b} is a POSITIVE number!");

            }

        }

        public static void CanVote(int k)
        {
            if (k >= 18)
            {
                Console.WriteLine($"Congrats! {k} years old is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry! {k} is not old enough to vote yet.");
            }

        }


        public static void InRange(int j)
        {
            if (j >= -10 && j <= 10)
            {
                Console.WriteLine($"The number you gave, {j} is in range!");
            }
            else
            {
                Console.WriteLine($"Sorry, {j} is NOT in range!");
            }

        }
    }
}
