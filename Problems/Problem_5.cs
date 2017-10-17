using System;
namespace EulerSharp
{
	public class Problem_5
	{
		/*
		 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
		 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		 */
		private int result;

		public Problem_5()
		{
			bool found = false;
			bool last = false;
			Int32 num = 1;
			while (!found)
			{
				for (int i = 1; i < 21; i++)
				{
					if (num % i != 0)
					{
						last = true;
						continue;
					}
					else if (num % i == 0 && i == 20 && !last)
					{
						result = num;
						found = true;
					}
				}
				num++;
				last = false;
			}
		}

		public int Result { get { return result; } }

	}
}
