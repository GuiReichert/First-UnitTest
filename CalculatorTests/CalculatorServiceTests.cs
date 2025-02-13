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
    public void MustDoSumOf10with5ThenReturn15()
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


}
