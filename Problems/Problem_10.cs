using System;
namespace EulerSharp
{
	public class Problem_10
	{
		/*
		 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
		 * Find the sum of all the primes below two million.
		 */

		private long result;

		public Problem_10()
		{
			result = 0;
			for (int i = 1; i < 2000000; i++)
			{
				if (Tools.IsPrime(i))
				{
					result += i;
				}
			}

		}

		public Int64 Result { get { return result; } }
	}
}
