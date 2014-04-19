using System;

class Every01
{
	static void Main(string[] args)
	{
		long max, min;
		string s = Console.ReadLine();

		string[] inputs = s.Split(' ');

		min = Convert.ToInt64(inputs[0]);
		max = Convert.ToInt64(inputs[1]);

		long smax = Convert.ToInt64(Math.Sqrt(max));
		
		int[] arr = new int[1000001];

		long squareNumCount = 0;

		long result = 0;

		for (int i = 0; i < 1000001; i++)
		{
			arr[i] = 0;
		}
		

		for (long j = 2; j <= smax; j++)
		{
			for (long k = 2 * j; k <= smax; k += j)
			{
				if (arr[j] == 0)
					arr[k] = arr[k] + 1;
				else if (arr[j] > 1)
					arr[k] = arr[k] - 1;
			}
			squareNumCount = squareNumCount - (max / (j*j) - (min - 1) / (j*j))*(arr[j] - 1);
		}

		result = max - min - squareNumCount + 1;
		
		Console.WriteLine(result);
	}
}

