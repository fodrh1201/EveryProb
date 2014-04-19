using System;

class Every1924_1
{
	static void Main(string[] args)
	{
		int[] sumDays = new int[12] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
		string[] weekDays = new string[7] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

        string line = Console.ReadLine();
		string[] words = line.Split(' ');

		int month = Convert.ToInt32(words[0]);
		int day = Convert.ToInt32(words[1]);

		Console.WriteLine(weekDays[(sumDays[month - 1] + day) % 7]);
	}
}

	
