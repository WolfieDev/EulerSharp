using System;
namespace EulerSharp
{
	public class Problem_7
	{
		/*
		 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
		 * What is the 10001st prime number?
		 */ 

		private Int64 result;

		public Problem_7()
		{
			Int64 number = 1;
			int counter = 1;
			while (counter <= 10001)
			{
				if (Tools.IsPrime(number))
				{
					counter++;
				}
				number++;
			}
			result = number - 1;
		}

		public Int64 Result { get { return result; } }
	}
}
