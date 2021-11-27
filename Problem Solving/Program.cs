using System;
using System.Linq;

namespace Problem_Solving
{
    class Program
    {
        //http://www.codeabbey.com/index/task_list

        // Main program to run
        static void Main(string[] args)
        {
            Console.WriteLine("You can do it!");
            Rounding();
        }

        // Methods
        public static int SumInLoop ()
        {
            // Amount in values to sum
            Console.Write("Enter list value: ");
            int x = Int32.Parse(Console.ReadLine());
            int sumValue = 0;

            // Ask for data to summarize
            Console.Write("Values to summarize: ");
            string userInput = Console.ReadLine();
            string[] userInputArray = userInput.Split(' ');


            // Summarize Loop
            for (int i = 0; i < x; i++)
            {
                int temp = Int32.Parse(userInputArray[i]);
                sumValue += temp;
            }

            return sumValue;
        }

        public static void SumsInLoop ()
        {
            // Number of iterations input
            Console.Write("Enter times to iterate: ");
            int x = Int32.Parse(Console.ReadLine());
            int[] sumsValue = new int[x];

            // For loop
            for (int i = 0; i < x; i++)
            {
                Console.Write("Please enter two values: ");
                string userInput = Console.ReadLine();
                string[] userInputArray = userInput.Split(' ');
                int num1 = Int32.Parse(userInputArray[0]);
                int num2 = Int32.Parse(userInputArray[1]);
                sumsValue[i] = num1 + num2;
            }

            Console.WriteLine("Answers: ");
            Console.WriteLine(string.Join(" ", sumsValue));
        }

        public static void MinimumOfTwo ()
        {
            // Number of iterations to input
            Console.Write("Enter times to iterate: ");
            int x = Int32.Parse(Console.ReadLine());
            int[] sumsValue = new int[x];

            // For loop
            for (int i = 0; i < x; i++)
            {
                Console.Write("Please enter two values: ");
                string userInput = Console.ReadLine();
                string[] userInputArray = userInput.Split(' ');
                int num1 = Int32.Parse(userInputArray[0]);
                int num2 = Int32.Parse(userInputArray[1]);

                // If statement to compare values
                if (num1 < num2)
                {
                    sumsValue[i] = num1;
                } else
                {
                    sumsValue[i] = num2;
                }
                
            }

            Console.WriteLine("Answers: ");
            Console.WriteLine(string.Join(" ", sumsValue));
        }

        public static void MinimumOfThree ()
        {
            // Number of iterations to input
            Console.Write("Enter times to iterate: ");
            int x = Int32.Parse(Console.ReadLine());
            int[] minValue = new int[x];

            // For loop
            for (int i = 0; i < x; i++)
            {
                // Asks for user input, and converts to number array
                Console.Write("Please enter three values: ");
                string userInput = Console.ReadLine();
                string[] userInputArray = userInput.Split(' ');
                int[] userInputArrayNum = Array.ConvertAll(userInputArray, int.Parse);

                // Finds and returns miniumum number from array
                int min = userInputArrayNum.Min();
                minValue[i] = min;
            }

            Console.WriteLine("Answers: ");
            Console.WriteLine(string.Join(" ", minValue));

        }
        
        public static void Rounding ()
        {
            // Number of iterations to input
            Console.Write("Enter times to iterate: ");
            int x = Int32.Parse(Console.ReadLine());
            double[] roundValue = new double[x];

            // For Loop
            for (int i = 0; i < x; i++)
            {
                // Asks for user input, and converts to number array
                Console.Write("Please enter two numbers: ");
                string userInput = Console.ReadLine();
                string[] userInputArray = userInput.Split(' ');
                double[] userInputArrayNum = Array.ConvertAll(userInputArray, double.Parse);

                // Divides and rounds numbers
                double dividedNum = Math.Round(userInputArrayNum[0] / userInputArrayNum[1]);

                // Adds to roundValue array for answer
                roundValue[i] = dividedNum;
            }

            Console.WriteLine("Answers: ");
            Console.WriteLine(string.Join(" ", roundValue));
        }
    }
}
