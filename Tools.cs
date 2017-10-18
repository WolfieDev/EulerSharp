using System;
using System.IO;

namespace EulerSharp
{
	public class Tools
	{
		/*
		 * Tool library for problems.
		 */ 


		/*
		 * Check if an integer number is prime
		 */ 
		public static bool IsPrime(long number)
		{
			if (number < 2) return false;
			if (number % 2 == 0) return (number == 2);
			int root = (int)Math.Sqrt((double)number);
			for (int i = 3; i <= root; i += 2)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

		/*
		 * Data readers with string[] (lines) and string output
		 */ 
		public static string[] DataLineReader(string file)
		{
			string path = Path.Combine(@"../../Data/" + file);
			return File.ReadAllLines(path);
		}

		public static string DataCompleteReader(string file)
		{
			string path = Path.Combine(@"../../Data/" + file);
			return File.ReadAllText(path);
		}

		/*
		 * Check if a number is a perfect square
		 */ 
		public static bool PerfectSquare(long number)
		{
			double root = Math.Sqrt(number);
			if (root % 1 == 0)
				return true;
			else 
				return false;
		}

		/*
		 * Checks the amount of divisors from a number
		 */
		public static int NumberOfDivisors(long number)
		{
			int nod = 0;
			int sqrt = (int)Math.Sqrt(number);

			for (int i = 1; i <= sqrt; i++)
			{
				if (number % i == 0)
				{
					nod += 2;
				}
			}
			//Correction if the number is a perfect square
			if (PerfectSquare(number))
			{
				nod--;
			}

			return nod;
		}
	}
}
