using System;


namespace SimpleCalc
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
        Console.WriteLine($"Welcome to SimpleCalc!\r\n");
        Console.WriteLine($"Please enter in numerical value!\r\nYou will be asked to Enter in TWO numbers!");
        
        Console.WriteLine($"\r\n\r\nYour first number please.");
        numberA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\r\nYour second number please");
        numberB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"The values you entered in are {numberA} and {numberB}.{Environment.NewLine}");

        while (mathamatics != 1 || mathamatics != 2 || mathamatics != 3 || mathamatics != 4)
        {
          Console.WriteLine($"{Environment.NewLine}Would you like to 1:add 2:subtract 3:multiply 4:divide");
          string operatorSelection = Console.ReadLine();

          bool isOpNumber = int.TryParse(operatorSelection, out int x);

          if (isOpNumber != true)
          {
            Console.WriteLine($"{operatorSelection}: was not a correct value, please enter 1, 2, 3 or 4!");
            continue;
          }
          else
          {
            mathamatics = Convert.ToInt32(operatorSelection);
          }

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

            break;

        }

        string continueResult;
        string lowerResult = "a";

        while (lowerResult is not "yes" or "y" or "no" or "n")
        {
          Console.WriteLine($"{Environment.NewLine}Whould you like to continue? \"yes or no\"");
          continueResult = Console.ReadLine().ToLower();
          //continueResult = continueResult.ToLower();
          if (continueResult is "yes" or "y")
          {
            Console.WriteLine();
            continueLoop = true;
            Console.WriteLine($"Starting a new calculation!{Environment.NewLine}");
            break;
          }
          else if (continueResult is "no" or "n")
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
