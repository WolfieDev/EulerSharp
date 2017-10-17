using System;
namespace EulerSharp
{
	public class Problem_3
	{
		/*
		 *The prime factors of 13195 are 5, 7, 13 and 29.
		 *What is the largest prime factor of the number 600851475143 ?
		 */
		private Int64 result;

		public Problem_3()
		{
			Int64 number = 600851475143;
			result = 0;
			while (number % 2 == 0)
			{
				number = number / 2;
			}
			for (Int64 i = 3; i < Math.Sqrt(number); i += 2)
			{
				if (number % i == 0)
				{
					result = i;
					number = number / i;
				}
			}
			if (number > 2)
			{
				result = number;
			}
		}

		public Int64 Result { get { return result; } }
	}
}
