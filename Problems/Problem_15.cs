using System;
namespace EulerSharp
{
	public class Problem_15
	{
		private long result;
		private int square; //Size of the edge of the square

		public Problem_15()
		{
			square = 20;
			result = 0;
			move(0, 0);
		}

		private void move(int x, int y)
		{
			if (x < square)
				move(x + 1, y);
			if (y < square)
				move(x, y + 1);
			if (x == square && y == square)
			{
				result += 1;
			}
		}

		public long Result { get { return result; } }
	}
}
