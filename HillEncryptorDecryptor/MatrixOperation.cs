using System;

namespace HillEncryptorDecryptor
{
	class MatrixOperation
	{

		public static void PrintMatrix(int[,] matrix, string name = "Matrix")
		{
			Console.WriteLine(name);
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				Console.Write("[ ");
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + ", ");
				}
				Console.WriteLine("]");
			}
			Console.WriteLine("\n");
		}

		public static int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
		{
			int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

			if (matrixA.GetLength(1) != matrixB.GetLength(0))
			{
				throw new Exception("Couldn't Multiply these matrices!");
			}

			int temp;
			for (int i = 0; i < matrixA.GetLength(0); i++)
			{
				for (int j = 0; j < matrixB.GetLength(1); j++)
				{
					temp = 0;
					for (int k = 0; k < matrixA.GetLength(1); k++)
					{
						temp += matrixA[i, k] * matrixB[k, j];
					}
					result[i, j] = temp;
				}
			}
			return result;
		}

		public static int[,] MatrixModule(int[,] matrix, int limit)
        {
			int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					result[i,j] = matrix[i, j] %= limit;
				}
			}

			return result;
		}

		static int[,] CreateSmallerMatrix(int[,] matrix, int i, int j)
		{
			int order = (int)Math.Sqrt(matrix.Length);
			int[,] result = new int[order - 1, order - 1];
			int x = 0, y;
			for (int m = 0; m < order; m++, x++)
			{
				if (m != i)
				{
					y = 0;
					for (int n = 0; n < order; n++)
					{
						if (n != j)
						{
							result[x, y] = matrix[m, n];
							y++;
						}
					}
				}
				else
				{
					x--;
				}
			}
			return result;
		}

		static double MatrixDeterminant(int[,] matrix)
		{
			int order = (int)Math.Sqrt(matrix.Length);
			if (order > 2)
			{
				double value = 0;
				for (int j = 0; j < order; j++)
				{
					int[,] temp = CreateSmallerMatrix(matrix, 0, j);
					value += matrix[0, j] * (SignOfElement(0, j) * MatrixDeterminant(temp));
				}
				return value;
			}
			else if (order == 2)
			{
				return ((matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]));
			}
			else
			{
				return (matrix[0, 0]);
			}
		}

		public static bool IsMatrixInvertible(int[,] matrix)
		{
			return MatrixDeterminant(matrix) == 0;
		}

		public static int SignOfElement(int i, int j)
		{
			return (i + j) % 2 == 0 ? 1 : -1;
		}

	}
}