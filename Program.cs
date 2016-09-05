using System;

class Averager 
{
	public static void Main()
	{
		var total = 0.0;
		var count = 0;

		while(true) 
		{
			Console.WriteLine("Enter a number or type \"done\" to see the average:");
			try 
			{
				var input = Console.ReadLine();
				if(input.ToLower() == "done"){
					break;
				}

				total += Convert.ToDouble(input);
			} 
			catch(Exception e) 
			{
            	Console.WriteLine("That is not valid input.", e);
			    continue;
			}
			count += 1;

		}

		Console.WriteLine("Average: " + (total/count));
	}
}