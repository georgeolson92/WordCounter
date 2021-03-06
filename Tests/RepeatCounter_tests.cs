using Xunit;
using WordCounter.Objects;

namespace WordCounter.Tests
{
  public class RepeatCounter_tests
  {
    [Fact]
    public void RepeatCounter_userInputCat_OutputOne()
    {
      //Arrange
      string expectedResult = "1";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cat", "cat");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RepeatCounter_userInputCat_OutputZero()
    {
      //Arrange
      string expectedResult = "0";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cat", "dog");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RepeatCounter_userInputCats_OutputFive()
    {
      //Arrange
      string expectedResult = "5";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cats", "cats orange cats brown cats blue cats purple cats");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RepeatCounter_userInputPunctuation_OutputTwo()
    {
      //Arrange
      string expectedResult = "2";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cat", "I walked my cat, a purple cat, named Catherine, to the cathedral");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RepeatCounter_userInputUppercase_OutputOne()
    {
      //Arrange
      string expectedResult = "1";

      //Act
      RepeatCounter repeatCounter = new RepeatCounter();
      string result = repeatCounter.CountRepeats("cat", "Cat behavior is always fascinating. I love cats.");

      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
