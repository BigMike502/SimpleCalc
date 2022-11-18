using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
  class Equations : CheckExpressions
  {
    string operatorSelection;
    double numberA;
    double numberB;
    double total;
    public void MathCheck(string number1, String number2)
    {
      numberA = Convert.ToDouble(number1);
      numberB = Convert.ToDouble(number2);

      start:
      Console.WriteLine($"\r\nWould you like to 1:add 2:subtract 3:multiply 4:divide");
      operatorSelection = Console.ReadLine();

      if (CheckOperatorInput(operatorSelection) != true)
      {
        Console.WriteLine($"\r\n====================================================");
        Console.WriteLine($"{operatorSelection}: was not a correct value, please enter 1, 2, 3 or 4!");
        Console.WriteLine($"====================================================\r\n");
        goto start;
      }

      switch (operatorSelection)
      {
        case "1":
          total = numberA + numberB;
          Console.WriteLine($"{numberA} + {numberB} = {total}");
          break;

        case "2":
          total = numberA - numberB;
          Console.WriteLine($"{numberA} - {numberB} = {total}");
          break;

        case "3":
          total = numberA * numberB;
          Console.WriteLine($"{numberA} * {numberB} = {total}");
          break;

        case "4":
          total = numberA / numberB;
          Console.WriteLine($"{numberA} / {numberB} = {total}");
          break;
      }
    }
  }
}
