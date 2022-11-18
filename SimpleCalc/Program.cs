using System;


namespace SimpleCalc
{
  class Program
  {
    public static void Main(string[] args)
    {
      string stringA;
      string stringB;
      bool continueLoop = true;

      Console.WriteLine($"Welcome to SimpleCalc!\r\n");

      while (continueLoop == true)
      {
      FirstNumber:
        Console.WriteLine($"Please enter in valid numerical value!\r\nYou will be asked to enter in TWO numbers!");

        Console.WriteLine($"\r\n\r\nYour first number please.");
        //numberA = Convert.ToInt32(Console.ReadLine());
        stringA = Console.ReadLine();
        if (!IntroCheck.CheckString(stringA, 1) == true)
        {
          Console.Clear();
          Console.WriteLine($"{stringA} is not a number, please enter in a number!");
          goto FirstNumber;
        }

      SecondNumber:
        Console.WriteLine("\r\nYour second number please");
        stringB = Console.ReadLine();
        if (!IntroCheck.CheckString(stringB, 2) == true)
        {
          Console.Clear();
          Console.WriteLine($"{stringB} is not a number, please enter in a number!");
          goto SecondNumber;
        }

        Console.WriteLine($"\r\nThe values you entered in are {stringA} and {stringB}.{Environment.NewLine}");

        

        //string continueResult;
        //string lowerResult = "a";

        //while (lowerResult is not "yes" or "y" or "no" or "n")
        //{
        //  Console.WriteLine($"{Environment.NewLine}Whould you like to continue? \"yes or no\"");
        //  continueResult = Console.ReadLine().ToLower();
        //  //continueResult = continueResult.ToLower();
        //  if (continueResult is "yes" or "y")
        //  {
        //    Console.WriteLine();
        //    continueLoop = true;
        //    Console.Clear();
        //    Console.WriteLine($"Starting a new calculation!{Environment.NewLine}\r\n");
        //    break;
        //  }
        //  else if (continueResult is "no" or "n")
        //  {
        //    Console.WriteLine($"Thank you for using my calculator! :D\r\nPress any key to exit!");
        //    continueLoop = false;
        //    Console.ReadLine();

        //    break;
        //  }
        //  else
        //  {
        //    Console.WriteLine($"Please enter in a yes or no.{Environment.NewLine}");
        //  }
        //}
      }
    }
  }
}
