using Calculator.Services;

CalculatorService calculator = new CalculatorService();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {calculator.Sum(num1,num2)}");