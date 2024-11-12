 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalc
{
  public class CheckExpressions
  {

    public static bool IsANumber(string number)
    {
      
      if (Regex.Match(number, @"^[0-9]+$").Success) 
      {
        return true;  
      }
      else
      {
        return false;
      }
    }

    public static bool IsValidOperator(string number)
    {
      if (Regex.Match(number, @"^[1-4]{1}$").Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool IsYesNo(string YesOrNo)
    {
      if (Regex.Match(YesOrNo, @"^(?:yes\b|y\b|no\b|n\b)$").Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
