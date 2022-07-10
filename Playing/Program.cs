using System;

namespace Playing
{
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();


            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 50);

                //Init guess var

                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 50");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkYellow, "Stop putting letters you Joker");
                        continue;
                    }

                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkBlue, "Wrong Number, Try again");

                    }


                }

                // Output Success Message

                PrintColorMessage(ConsoleColor.DarkMagenta, "You are Correct");

                //Reset Text Color
                Console.ResetColor();

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }


        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Deo";

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game . . .", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
 