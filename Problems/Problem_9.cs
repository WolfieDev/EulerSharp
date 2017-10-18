using System;
namespace EulerSharp
{
	public class Problem_9
	{
		/*
		 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
		 * Find the product abc.
		 */

		private int result;

		public Problem_9()
		{
			for (int x = 1; x < 1000 / 3; x++)
			{
				for (int y = x; y < 1000 / 2; y++)
				{
					int z = 1000 - x - y;
					if ((int)Math.Pow(x, 2) + (int)Math.Pow(y, 2) == (int)Math.Pow(z, 2))
						result = x * y * z;
				}
			}
		}

		public int Result { get { return result; } }
	}
}
