using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
  public class InfoCheck : CheckExpressions
  {
    
    public static bool CheckString(string number, int x)
    {
      if (IsANumber(number) == true)
      {
        Console.Clear();
        Console.WriteLine($"\r\n====================================================");
        Console.WriteLine((x == 1) ? $"The first number you entered is {number}." : $"The Second number you entered is {number}");
        Console.WriteLine($"====================================================\r\n");
        return true;
      }
      else
      {
        Console.Clear();
        Console.WriteLine($"\r\n====================================================");
        Console.WriteLine($"{number} is not a number, please enter in a number!");
        Console.WriteLine($"====================================================\r\n");
        return false;
      }
    }
  }
}
