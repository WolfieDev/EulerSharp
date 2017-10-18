using System;

namespace EulerSharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var watch = System.Diagnostics.Stopwatch.StartNew();

			Console.WriteLine(new Problem_17().Result);

			watch.Stop();
			Console.WriteLine("{0} elapsed",watch.Elapsed.ToString());
		}

	}
}
