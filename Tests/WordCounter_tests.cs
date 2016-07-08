using Xunit;

namespace WordCounter
{
  public class RepeatCounter_tests
  {
    [Fact]
    public void RepeatCounter_userInputCats_OutputFive()
    {
      //Arrange
      string expectedResult = "5";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cats", "Red cats orange cats brown cats blue cats purple cats");

      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
