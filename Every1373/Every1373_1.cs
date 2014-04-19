using System;

class Every1373
{
	static string plusZero(string input)
	{
		if (input.Length % 3 == 0)
		{
			return input;
		}
		

		int plus = 3 - (input.Length % 3);

		for (int i = 0; i < plus; i++)
		{
			input = "0" + input;
		}
		return input;
	}
	
	static void Main()
	{
		string input = Console.ReadLine();
		string newInput = plusZero(input);
		int length = newInput.Length;
		int[] arr = new int[3] { 4, 2, 1 };
		int[] temp = new int[length/3];
		string newNumber = "";

		for (int i = 0; i < length/3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				temp[i] += ((int)Char.GetNumericValue(newInput[3*i+j]))*arr[j];
			}
			newNumber += Convert.ToString(temp[i]);
		}
			Console.WriteLine(newNumber);
	}
}

