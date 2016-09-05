using System;

class Arithmetic 
{
	public static void Main() 
	{
		var firstNum = 0.0;
		var firstNumber = "";
		var secondNum = 0.0;
		var secondNumber = "";
		var operatorValue = "";
		var finalNumber = 0.0;
		while(true)
		{
			while(true)
			{
				firstNumber = requestNumber();
				if(firstNumber.ToLower() == "quit")
				{
					break;
				}
				bool result = double.TryParse(firstNumber, out firstNum);

				if(result)
				{
					break;
				} else {
					Console.WriteLine("Please enter a valid number.");
				}
			}
			if(firstNumber.ToLower() == "quit")
			{
				break;
			}


			while(true)
			{
				operatorValue = requestOperator();
				if(operatorValue == "*" || operatorValue == "/" || operatorValue == "+" || operatorValue == "-"  || operatorValue.ToLower() == "quit")
				{
					break;
				} else
				{
					Console.WriteLine("Please enter a an operator (*, /, -, +)");
				}
			}
			if(operatorValue.ToLower() == "quit")
			{
				break;
			}

			while(true)
			{
				secondNumber = requestNumber();
				bool result = double.TryParse(secondNumber, out secondNum);
				if(result || secondNumber.ToLower() == "quit")
				{
					break;
				} else {
					Console.WriteLine("Please enter a valid number.");
				}
			}
			if(secondNumber.ToLower() == "quit")
			{
				break;
			}

			if(operatorValue == "/") 
			{
				finalNumber = firstNum / secondNum;
			} else if(operatorValue == "*"){
				finalNumber = firstNum * secondNum;
			} else if(operatorValue == "-"){
				finalNumber = firstNum - secondNum;
			} else if(operatorValue == "+"){
				finalNumber = firstNum + secondNum;
			}
			Console.WriteLine(firstNumber + operatorValue + secondNumber + "=" + finalNumber);
		}

		
	}


	public static string requestNumber() 
	{

		Console.WriteLine("Please enter a number:");
		return Console.ReadLine();
	}

	public static string requestOperator() 
	{
		Console.WriteLine("Please enter an operator:");
		return Console.ReadLine();
	}
}