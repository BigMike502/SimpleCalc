﻿using System;
using System.Collections.Generic;

namespace SimpleCalc
{
  class Program
  {
    public static void Main(string[] args)
    {
      string stringA;
      string stringB;
      Equations mathEquations = new Equations();
      bool continueLoop = true;

      Console.WriteLine($"Welcome to SimpleCalc!\r\n");

      while (continueLoop == true)
      {
      FirstNumber:
        Console.WriteLine($"Please enter in valid numerical value!\r\nYou will be asked to enter in TWO numbers!");

        Console.WriteLine($"\r\n\r\nYour first number please:");
        stringA = Console.ReadLine();
        if (InfoCheck.CheckString(stringA, 1) != true)
        {
          goto FirstNumber;
        }

      SecondNumber:
        Console.WriteLine("\r\nYour second number please:");
        stringB = Console.ReadLine();
        if (InfoCheck.CheckString(stringB, 2) != true)
        {
          goto SecondNumber;
        }
        Console.Clear();
        Console.WriteLine($"\r\n====================================================");
        Console.WriteLine($"The values you entered in are {stringA} and {stringB}.");
        Console.WriteLine($"====================================================\r\n\r\n");

        mathEquations.MathCheck(stringA, stringB);

        string continueResult;
        string lowerResult = "a";

        while (lowerResult is not "yes" or "y" or "no" or "n")
        {
          Console.WriteLine($"{Environment.NewLine}Whould you like to continue? \"yes or no\"");
          EndReadline:
          continueResult = Console.ReadLine().ToLower();
          if (CheckExpressions.IsYesNo(continueResult) != true)
          {
            Console.WriteLine($"{continueResult} is not correct, Please enter in a \"yes or no\"");
            goto EndReadline;
          }

          while (continueResult is "yes" or "y")
          { 
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine($"\r\n====================================================");
            Console.WriteLine($"Starting a new calculation!");
            Console.WriteLine($"====================================================\r\n\r\n");
            break;
          }
          while (continueResult is "no" or "n")
          {
            Console.WriteLine($"\r\n====================================================");
            Console.WriteLine($"Thank you for using my calculator! :D\r\nPress any key to exit!");
            Console.WriteLine($"====================================================\r\n\r\n");

            continueLoop = false;
            Console.ReadLine();

            break;
          }
          break;
        }
      }
    }
  }
}
