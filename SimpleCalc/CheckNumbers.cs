using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalc
{
  public class CheckNumbers
  {

    public static bool IsInputANumber(string number)
    {
      
      if (Regex.Match(number, "^[0-9]{1}").Success) 
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
