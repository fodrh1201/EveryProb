using System;

class Ever1373
{
	static void Main(string[] args)
	{
		string nums = Console.ReadLine();

		int count = nums.Length;

		int octaDigit = (count - 1) / 3;

		int[] multNums = new int[count];

		long[] result = new long[octaDigit+1]; 

		long final = 0;

		for (int i = 0; i < count; i ++)
		{
			if ((count-1-i) % 3 == 0)
			{
				multNums[i] = 1;
			}
			else if ((count-1-i) %  3 == 1)
			{
				multNums[i] = 2;
			}
			else
			{
				multNums[i] = 4;
			}
			
		}

		for (int i = 0; i < octaDigit + 1; i++)
		{
			for (int j = 3*i; j < 3*(i+1) && j < count; j++)
			{
				result[i] += multNums[count-1-j] * (Convert.ToInt64(nums[count-1-j])-48);
			}
			final += result[i] * Convert.ToInt64(Math.Pow(10, i));
		}

		Console.WriteLine(final);

	}
}
        


	
