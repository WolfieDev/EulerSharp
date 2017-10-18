using System;
using System.Collections.Generic;
namespace EulerSharp
{
	public class Problem_17
	{
		/*
		 * If the numbers 1 to 5 are written out in words: one, two, three, four, five, 
		 * then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
		 * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
		 * NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) 
		 * contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
		 * The use of "and" when writing out numbers is in compliance with British usage.
		 */
		private int result;

		public Problem_17()
		{
			result = 0;
			CountCharacters(342);
			Console.WriteLine(result);
			for (int i = 1; i <= 10; i++)
				CountCharacters(i);
		}

		private void CountCharacters(int number)
		{
			string data = number.ToString();
			switch(data.Length)
			{
				case 1:
					result += dictUnits[number].Length;
					break;
				case 2:
					if (number >= 10 && number < 20)
						result += dictTeen[number].Length;
					else
					{
						result += dictDcns[int.Parse(data[0].ToString())].Length;
						result += dictDcns[int.Parse(data[1].ToString())].Length;
					}
					break;
				case 3:
					int lastPair = int.Parse(data[1].ToString()+data[2].ToString());
					if(lastPair == 0)
						result += (dictUnits[int.Parse(data[0].ToString())] + "hundred").Length;
					else
						result += (dictUnits[int.Parse(data[0].ToString())] + "hundredand").Length;
					if (lastPair >= 10 && lastPair < 20)
						result += dictTeen[number].Length;
					else
					{
						result += dictDcns[int.Parse(data[0].ToString())].Length;
						result += dictDcns[int.Parse(data[1].ToString())].Length;
					}
					break;
					
			}
		}

		private Dictionary<int, string> dictUnits = new Dictionary<int, string>()
		{
			//Units
			{ 1,"one"},
			{ 2,"who"},
			{ 3,"three"},
			{ 4,"four"},
			{ 5,"five"},
			{ 6,"six"},
			{ 7,"seven"},
			{ 8,"eight"},
			{ 9,"nine"},
			{ 0, ""}
		};

		private Dictionary<int, string> dictDcns = new Dictionary<int, string>()
		{
			//Tys
			{ 2,"twenty"},
			{ 3,"thirty"},
			{ 4,"fourty"},
			{ 5,"fifty"},
			{ 6,"sixty"},
			{ 7,"seventy"},
			{ 8,"eighty"},
			{ 9,"ninety"},
			{ 0,""}
		};

		private Dictionary<int, string> dictTeen = new Dictionary<int, string>()
		{
			//Units
			{ 10,"ten"},
			{ 11,"eleven"},
			{ 12,"twelve"},
			{ 13,"thirteen"},
			{ 14,"fourteen"},
			{ 15,"fifteen"},
			{ 16,"sixteen"},
			{ 17,"seventeen"},
			{ 18,"eighteen"},
			{ 19,"nineten"}
		};

		public int Result { get { return result; } }


	}
}
