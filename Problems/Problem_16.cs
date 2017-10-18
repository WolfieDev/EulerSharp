using System;
using System.Numerics;

namespace EulerSharp
{
	public class Problem_16
	{
		/*
		 * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
		 * What is the sum of the digits of the number 2^1000?
		 */

		private BigInteger result;

		public Problem_16()
		{
			result = 0;
			BigInteger pow = (BigInteger)Math.Pow(2, 1000);
			String data = pow.ToString();
			for (int i = 0; i < data.Length; i++)
				result += int.Parse(data[i].ToString());
		}

		public BigInteger Result { get { return result; } }
	}
}
