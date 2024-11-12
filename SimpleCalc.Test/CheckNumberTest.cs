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

      testNumber = InfoCheck.IsANumber("2");
      testOporator = InfoCheck.IsValidOperator("1");
      testYesOrNo1 = InfoCheck.IsYesNo("yes");
      testYesOrNo2 = InfoCheck.IsYesNo("no");
      testYesOrNo3 = InfoCheck.IsYesNo("y");
      testYesOrNo4 = InfoCheck.IsYesNo("n");



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
