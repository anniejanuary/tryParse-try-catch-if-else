using System;

namespace IfElseExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check();
            Console.Read();
        }

        public static void Check()
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();


            try
            {
                int userInputParsedIntoInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Please only enter numbers");
            }


            if (userInputParsedIntoInt % 2 == 0)
            {
                Console.WriteLine("Parse was successfull, you entered an even number");
            }
            else if (userInputParsedIntoInt %2 != 0)
            {
                Console.WriteLine("Parse was successfull, you entered an odd number");
            }
            else
            {
                Console.WriteLine("Parse unsuccessfull, please only enter digits");
            }
       
        }
    }
}
