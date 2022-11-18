using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
  public class IntroCheck : CheckNumbers
  {
    
    public static bool CheckString(string number, int x)
    {
      if (IsInputANumber(number) == true)
      {
        Console.Clear();
        Console.WriteLine((x == 1) ? $"The first number you entered is {number}." : $"The Second number you entered is {number}");
        return true;
      }
      else
      {
        Console.Clear();
        Console.WriteLine($"{number} is not a number, please enter in a number!");
        return false;
      }
    }
  }
}
