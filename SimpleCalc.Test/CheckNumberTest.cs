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
      bool testNumber;


      //act

      testNumber = InfoCheck.IsInputANumber("2");


      //assert

      Assert.True(testNumber);


    }
  }
}
