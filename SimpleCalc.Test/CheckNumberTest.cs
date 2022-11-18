using System;
using Xunit;

namespace SimpleCalc.Tests
{
  public class CheckNumberTest
  {
    [Fact]
    public void CheckNumberFault()
    {
      //arrange
      CheckNumbers checkNumber = new CheckNumbers();
      string myNumber = "2";

      //act

      bool output = CheckNumbers.IsInputANumber(myNumber);

      //assert

      Assert.True(output);

    }
  }
}
