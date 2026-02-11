int number1, number2;
string operation;
int result;
// Getting first number
Console.WriteLine("Enter first number:");
number1 = int.Parse(Console.ReadLine());
// Getting operation
Console.WriteLine("Enter operation (+, -, *, /):");
operation = int.Parse(Console.ReadLine()).ToString();
// Getting second number
Console.WriteLine("Enter second number:");
number2 = int.Parse(Console.ReadLine());
// Performing operation
switch (operation)
{
	case "+":
		result = number1 + number2;
		break;
	case "-":
		result = number1 - number2;
		break;
	case "*":
		result = number1 * number2;
		break;
	case ":":
		result = number1 / number2;
		break;
	default:
		Console.WriteLine("Invalid operation");
		return;
}
// Displaying result
Console.WriteLine("Result: " + result);