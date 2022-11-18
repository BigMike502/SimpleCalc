using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
  public class Equations : CheckNumbers
  {
    int mathamatics = 0;
    public void MathCheck(string numberA, String numberB)
    {
      while (mathamatics != 1 || mathamatics != 2 || mathamatics != 3 || mathamatics != 4)
      {
        Console.WriteLine($"{Environment.NewLine}Would you like to 1:add 2:subtract 3:multiply 4:divide");
        string operatorSelection = Console.ReadLine();

        bool isOpNumber = int.TryParse(operatorSelection, out int operatorInt);

        if (isOpNumber != true)
        {
          Console.WriteLine($"{operatorInt}: was not a correct value, please enter 1, 2, 3 or 4!");
          continue;
        }
        else
        {
          mathamatics = operatorInt;
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
    }


  }
}
