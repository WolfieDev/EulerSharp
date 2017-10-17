using System;
namespace EulerSharp
{
	public class Problem_11
	{
		/*
		 * In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
		 * (Grid in /Data/Problem_11.txt)
		 * The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
		 * What is the greatest product of four adjacent numbers in the same direction 
		 * (up, down, left, right, or diagonally) in the 20×20 grid?
		 */

		private int[,] matrix;
		private int result;

		public Problem_11()
		{
			GenerateMatrix(Tools.DataLineReader("Problem_11.txt"));
			result = Evaluate(matrix);
		}

		private void GenerateMatrix(string[] data)
		{
			int x = 1;
			//Scanning for X and checking Matrix structure
			for (int j = 0; j < data.Length; j++)
			{
				//First line defines Width
				if (j == 0)
				{
					char[] firstLine = data[j].ToCharArray();
					for (int i = 0; i < firstLine.Length; i++)
					{
						if (firstLine[i] == ' ')
							x++;
					}
				}
				else
				{
					char[] line = data[j].ToCharArray();
					int temp = 1;
					for (int i = 0; i < line.Length; i++)
					{
						if (line[i] == ' ')
							temp++;
					}
					if (temp != x)
						throw new Exception("Introduced matrix not rectangular");
				}
			}

			matrix = new int[x, data.Length];

			//Population

			for (int i = 0; i < data.Length; i++)
			{
				int counter = 0;
				string fragment = "";
				char[] line = data[i].ToCharArray();
				for (int j = 0; j < line.Length; j++)
				{
					if (line[j] != ' ')
						fragment += line[j];
					else
					{
						matrix[i, counter] = Int32.Parse(fragment);
						fragment = "";
						counter++;
					}
				}
			}
		}

		private int Evaluate(int[,] m)
		{
			result = 0;
			int vert = 0;
			int horz = 0;
			int diag = 0;
			int idia = 0;
			string coords = "";
			string values = "";

			//Vertical evaluation
			for (int i = 0; i < m.GetLength(0) - 3; i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					int temp = m[i, j] * m[i + 1, j] * m[i + 2, j] * m[i + 3, j];
					if (temp > vert)
					{
						vert = temp;
						coords = "\n\tFrom: [" + j + "," + i + "] To: [" + j + "," + (i + 3) + "]";
						values = "\n\tValues: " + m[i, j] + ", " + m[i + 1, j] + ", " + m[i + 2, j] + ", " + m[i + 3, j];
					}
				}
			}
			//Console.WriteLine("Vertical evaluation max: " + vert + " " + coords + " " + values);
			if (vert > result)
				result = vert;

			//Horizontal evaluation
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1) - 3; j++)
				{
					int temp = m[i, j] * m[i, j + 1] * m[i, j + 2] * m[i, j + 3];
					if (temp > horz)
					{
						horz = temp;
						coords = "\n\tFrom: [" + j + "," + i + "] To: [" + (j + 3) + "," + i + "]";
						values = "\n\tValues: " + m[i, j] + ", " + m[i, j + 1] + ", " + m[i, j + 2] + ", " + m[i, j + 3];
					}
				}
			}
			//Console.WriteLine("Horizontal evaluation max: " + horz + " " + coords + " " + values);
			if (horz > result)
				result = horz;

			//Diagonal evaluation
			for (int i = 0; i < m.GetLength(0) - 3; i++)
			{
				for (int j = 0; j < m.GetLength(1) - 3; j++)
				{
					int temp = m[i, j] * m[i + 1, j + 1] * m[i + 2, j + 2] * m[i + 3, j + 3];
					if (temp > diag)
					{
						diag = temp;
						coords = "\n\tFrom: [" + j + "," + i + "] To: [" + (j + 3) + "," + (i + 3) + "]";
						values = "\n\tValues: " + m[i, j] + ", " + m[i + 1, j + 1] + ", " + m[i + 2, j + 2] + ", " + m[i + 3, j + 3];
					}
				}
			}
			//Console.WriteLine("Diagonal evaluation max: " + diag + " " + coords + " " + values);
			if (diag > result)
				result = diag;

			//Inverse diagonal evaluation
			for (int i = 0; i < m.GetLength(0) - 3; i++)
			{
				for (int j = m.GetLength(1) - 1; j > 3; j--)
				{
					int temp = m[i, j] * m[i + 1, j - 1] * m[i + 2, j - 2] * m[i + 3, j - 3];
					if (temp > idia)
					{
						idia = temp;
						coords = "\n\tFrom: [" + j + "," + i + "] To: [" + (j - 3) + "," + (i + 3) + "]";
						values = "\n\tValues: " + m[i, j] + ", " + m[i + 1, j - 1] + ", " + m[i + 2, j - 2] + ", " + m[i + 3, j - 3];
					}
				}
			}
			//Console.WriteLine("Inverse diagonal evaluation max: " + idia + " " + coords + " " + values);
			if (idia > result)
				result = idia;

			//Console.WriteLine("Biggest: " + result);
			return result;
		}

		public int Result { get { return result; } }

	}
}
