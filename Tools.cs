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
		public static bool IsPrime(Int64 num)
		{
			if (num == 1)
				return false;
			if (num == 2)
				return true;
			if (num % 2 == 0)
				return false;
			for (Int64 i = 2; i < num; i++)
			{
				if (num % i == 0) return false;
			}
			return true;
		}

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

		public static bool PerfectSquare(int number)
		{
			double root = Math.Sqrt(number);
			if (root % 1 == 0)
				return true;
			else 
				return false;
		}
	}
}
