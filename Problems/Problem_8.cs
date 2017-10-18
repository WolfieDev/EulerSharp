using System;
namespace EulerSharp
{
	public class Problem_8
	{
		/*
		 * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
		 * (Data in /Data/Problem_8.txt)
		 * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. 
		 * What is the value of this product?
		 */ 


		private Int64 result;

		public Problem_8()
		{
			result = 1;
			string data = Tools.DataCompleteReader("Problem_8.txt");
			data = data.Replace("\n", string.Empty); //Remove line breaks
			Int64 temp = 1;
			for (int i = 0; i < data.Length - 13; i++)
			{
				temp = 1;
				string subs = data.Substring(i, 13);
				for (int j = 0; j < subs.Length; j++)
					temp *= Int64.Parse(subs[j].ToString());
				if (temp > result)
					result = temp;
			}

		}

		public Int64 Result { get { return result; } }
	}
}
