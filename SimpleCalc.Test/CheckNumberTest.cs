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
      bool testOporator;
      bool testYesOrNo1;
      bool testYesOrNo2;
      bool testYesOrNo3;
      bool testYesOrNo4;


      //act

      testNumber = InfoCheck.IsInputANumber("2");
      testOporator = InfoCheck.CheckOperatorInput("1");
      testYesOrNo1 = InfoCheck.CheckYesOrNo("yes");
      testYesOrNo2 = InfoCheck.CheckYesOrNo("no");
      testYesOrNo3 = InfoCheck.CheckYesOrNo("y");
      testYesOrNo4 = InfoCheck.CheckYesOrNo("n");


      //assert

      Assert.True(testNumber);
      Assert.True(testOporator);
      Assert.True(testYesOrNo1);
      Assert.True(testYesOrNo2);
      Assert.True(testYesOrNo3);
      Assert.True(testYesOrNo4);


    }
  }
}
