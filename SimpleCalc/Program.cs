using System;
using System.Dynamic;

namespace DummyField
{
  class Program
  {
    public static void Main(string[] args)
    {

      double numberA;
      double numberB;
      int mathamatics = 0;
      bool continueLoop = true;


      //int numberA;
      //int numberB;

      while (continueLoop == true)
      {
        Console.WriteLine($"Please enter in numerical value!{Environment.NewLine}Your first number please.");
        numberA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\r\nYour second number please");
        numberB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"The values you entered in are {numberA} and {numberB}.{Environment.NewLine}");

        while (mathamatics != 1 || mathamatics != 2 || mathamatics != 3 || mathamatics != 4)
        {
          Console.WriteLine();
          Console.WriteLine("Would you like to 1:add 2:subtract 3:multiply 4:divide");
          mathamatics = Convert.ToInt32(Console.ReadLine());

          double total;

          switch (mathamatics)
          {
            case 1:
              total = numberA + numberB;
              Console.WriteLine($"{numberA} + {numberB} = {total}");
              break;

            case 2:
              total = numberA - numberB;
              Console.WriteLine($"{numberA} - {numberB} = {total}");
              break;

            case 3:
              total = numberA * numberB;
              Console.WriteLine($"{numberA} * {numberB} = {total}");
              break;

            case 4:
              total = numberA / numberB;
              Console.WriteLine($"{numberA} / {numberB} = {total}");
              break;

            default:
              Console.WriteLine($"{mathamatics}: was not a correct value, please enter 1, 2, 3 or 4!");
              break;
          }

          if (mathamatics is 1 or 2 or 3 or 4)
          {
            break;
          }
        }

        string continueResult;
        string lowerResult = "a";

        while (lowerResult is not "yes" or "y" or "no" or "n")
        {
          Console.WriteLine($"Whould you like to continue? \"yes or no\"{Environment.NewLine}");
          continueResult = Console.ReadLine();
          lowerResult = continueResult.ToLower();
          if (lowerResult is "yes" or "y")
          {
            Console.WriteLine();
            continueLoop = true;
            Console.WriteLine($"Starting a new Calculation!{Environment.NewLine}");
            break;
          }
          else if (lowerResult is "no" or "n")
          {
            Console.WriteLine("Thank you for using my calculator! :D");
            continueLoop = false;
            Console.ReadLine();
            break;
          }
          else
          {
            Console.WriteLine($"Please enter in a yes or no.{Environment.NewLine}");
          }
        }
        
      }
    }
  }
}
