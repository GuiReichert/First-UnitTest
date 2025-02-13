using Calculator.Services;


namespace CalculatorTests;
public class CalculatorServiceTests
{
    private CalculatorService _calculatorService;

    public CalculatorServiceTests()
    {
        _calculatorService = new CalculatorService();
    }




    [Fact]
    public void MustDoSumOf10and5ThenReturn15()
    {
        // Arrange - Preparations for the tests 

        int num1 = 5;
        int num2 = 10;


        // Act - Execute test

        int result = _calculatorService.Sum(num1, num2);



        // Assert - Validate results


        Assert.Equal(15, result);


        // to run test: "dotnet test" in the terminal 

    }

    [Fact]
    public void MustDoSumOfNegative2and2ThenReturn0()
    {
        // Arrange - Preparations for the tests 

        int num1 = -2;
        int num2 = 2;


        // Act - Execute test

        int result = _calculatorService.Sum(num1, num2);



        // Assert - Validate results


        Assert.Equal(0, result);


        // to run test: "dotnet test" in the terminal 

    }

    [Fact]
    public void MustCheckIf4IsEvenAndReturnTrue()
    {
        //Arrange
        int num = 4;

        //Act

        var result = _calculatorService.isEven(num);

        //Assert

        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void MustCheckIfNumbersDescribedAreEvenAndReturnTrue(int num)
    {
        // in this case, we don't need the "Arrange"

        // Act
        var result = _calculatorService.isEven(num);

        // Assert
        Assert.True(result);

    }



}
