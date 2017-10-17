using System;
namespace EulerSharp
{
	public class Problem_1
	{
		public Problem_1()
		{
			int result = 0;
			for (int i = 1; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					result += i;
			}
			Console.WriteLine("Result: {0}", result);
		}
	}
}
