using System;
using System.Numerics;

namespace EulerSharp
{
	public class Problem_13
	{
		/*
		 * Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
		 * (Data in /Data/Problem_13.txt)
		 */

		private long result;
		private BigInteger sum;

		public Problem_13()
		{
			string[] data = Tools.DataLineReader("Problem_13.txt");
			sum = 0;
			for (int i = 0; i < data.Length; i++)
				sum += BigInteger.Parse(data[i]);
			result = long.Parse(sum.ToString().Substring(0,10));
		}

		public long Result { get { return result; } }
	}
}
