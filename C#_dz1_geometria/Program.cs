using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__dz1_geometria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int row = 5; int col = 5;
			char symbol = '*';

			// Прямоугольник
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{

					Console.Write(symbol);

				}
				Console.Write("\n");
			}

			// Треугольник 1
			Console.Write("\n");
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (i >= j)
					{
						Console.Write(symbol);
					}
				}
				Console.Write("\n");
			}

			// Треугольник 2
			Console.Write("\n");
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (i <= j)
					{
						Console.Write(symbol);
					}
				}
				Console.Write("\n");
			}

			// Треугольник 3
			Console.Write("\n");
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (i <= j)
					{
						Console.Write(symbol);
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}

			// Треугольник 4
			Console.Write("\n");
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (row - i <= j + 1)
					{
						Console.Write(symbol);
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}

			// Ромб
			row = 11; col = 10;
			symbol = '/';
			char symbol_2 = '\\';
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (j < col / 2 && j == col / 2 - i)
					{
						Console.Write(symbol);
					}
					else if (j >= col / 2 && j == col / 2 + i - 1)
					{
						Console.Write(symbol_2);
					}
					else if (i > row / 2 && j < col / 2 && j + row / 2 + 1 == i)
					{
						Console.Write(symbol_2);
					}
					else if (i > row / 2 && j >= col / 2 && j == col / 2 - i + col)
					{
						Console.Write(symbol);
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}

			// Прямоугольник + -
			Console.Write("\n");
			row = 5; col = 5;
			symbol = '+';
			symbol_2 = '-';
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{

					//if (i % 2 == 0 && j % 2 == 0)
					//{
					//	Console.Write(symbol);
					//}
					//else if (i % 2 != 0 && j % 2 != 0)
					//{
					//	Console.Write(symbol);
					//}

					if (i % 2 ==  j % 2)
					{
						Console.Write(symbol);
					}
					else
					{
						Console.Write(symbol_2);
					}
				}
				Console.Write("\n");
			}
		}
	}
}
