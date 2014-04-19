using System;

namespace Every1924
{
	class Prob1924
	{
		static void Main(string[] args)
		{
			int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			string[] weekday = new string[7] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

			string input = Console.ReadLine();
			string[] inpArr = input.Split(' ');
			int month = Convert.ToInt32(inpArr[0]);
			int day = Convert.ToInt32(inpArr[1]);

			int wantDay = 0;

			for (int i = 0; i < month - 1; i++)
			{
				wantDay += days[i];
			}

			wantDay += day;
			Console.WriteLine(weekday[wantDay % 7]);
		}
	}
}
			
