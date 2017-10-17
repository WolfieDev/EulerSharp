using System;
using System.Collections.Generic;
namespace EulerSharp
{
	public class Problem_4
	{
		/*
		 * A palindromic number reads the same both ways. 
		 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
		 * Find the largest palindrome made from the product of two 3-digit numbers.
		 */
		private int result;

		public Problem_4()
		{
			List<Int32> ls = new List<Int32>();
			for (int i = 0; i < 999; i++)
			{
				for (int j = 0; j < 999; j++)
				{
					string res = (i * j).ToString();
					string primero = res.Substring(0, res.Length / 2);
					char[] array = res.ToCharArray();
					Array.Reverse(array);
					string temp = new string(array);
					string segundo = temp.Substring(0, temp.Length / 2);
					if (primero.Equals(segundo))
					{
						ls.Add(Int32.Parse(res));
					}
				}
			}
			ls.Sort();
			result = ls[ls.Count - 1];
		}

		public int Result { get { return result; } }
	}
}
