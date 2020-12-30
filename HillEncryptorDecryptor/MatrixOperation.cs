using System;

namespace HillEncryptorDecryptor
{
	class MatrixOperation
	{
		public static void PrintMatrix(double[][] matrix, string name = "Matrix")
		{
			Console.WriteLine(name);
			for (int i = 0; i < matrix.Length; i++)
			{
				Console.Write("[ ");
				for (int j = 0; j < matrix[0].Length; j++)
				{
					Console.Write(matrix[i][j] + ", ");
				}
				Console.WriteLine("]");
			}
			Console.WriteLine("\n");
		}

		public static double[][] MatrixCreate(int rows, int cols)
		{
			double[][] result = new double[rows][];
			for (int i = 0; i < rows; ++i)
				result[i] = new double[cols];
			return result;
		}

		public static double[][] MultiplyMatrix(double[][] matrixA, double[][] matrixB)
		{
			double[][] result = MatrixCreate(matrixA.Length, matrixB[0].Length);

			if (matrixA[0].Length != matrixB.Length)
			{
				throw new Exception("Couldn't Multiply these matrices!");
			}

			double temp;
			for (int i = 0; i < matrixA.Length; i++)
			{
				for (int j = 0; j < matrixB[0].Length; j++)
				{
					temp = 0;
					for (int k = 0; k < matrixA[0].Length; k++)
					{
						temp += matrixA[i][k] * matrixB[k][j];
					}
					result[i][j] = (double)Math.Round(temp);
				}
			}
			return result;
		}

		public static double[][] MatrixModule(double[][] matrix, int limit)
		{
			double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[0].Length; j++)
				{
					result[i][j] = matrix[i][j] - limit * Math.Floor(matrix[i][j] / limit);
				}
			}
			return result;
		}

		public static double MatrixDeterminant(double[][] matrix)
		{
			int order = matrix.Length;
			if (order > 2)
			{
				double value = 0;
				for (int j = 0; j < order; j++)
				{
					double[][] temp = CreateSmallerMatrix(matrix, 0, j);
					value += matrix[0][j] * (SignOfElement(0, j) * MatrixDeterminant(temp));
				}
				return value;
			}
			else if (order == 2)
			{
				return ((matrix[0][0] * matrix[1][1]) - (matrix[1][0] * matrix[0][1]));
			}
			else
			{
				return ((double)matrix[0][0]);
			}
		}

		public static bool IsMatrixInvertible(double[][] matrix)
		{
			return MatrixDeterminant(matrix) != 0;
		}

		public static double[][] MatrixInverse(double[][] matrix)
		{
			int n = matrix.Length;
			double[][] result = MatrixDuplicate(matrix);

			int[] perm;
			int toggle;
			double[][] lum = MatrixDecompose(matrix, out perm,
			  out toggle);
			if (lum == null)
				throw new Exception("Unable to compute inverse");

			double[] b = new double[n];
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					if (i == perm[j])
						b[j] = 1.0;
					else
						b[j] = 0.0;
				}

				double[] x = HelperSolve(lum, b);

				for (int j = 0; j < n; ++j)
					result[j][i] = x[j];
			}
			return result;
		}

		static int SignOfElement(int i, int j)
		{
			return (i + j) % 2 == 0 ? 1 : -1;
		}

		static double[][] CreateSmallerMatrix(double[][] matrix, int i, int j)
		{
			int order = matrix.Length;
			double[][] result = MatrixCreate(order - 1, order - 1);
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
							result[x][y] = matrix[m][n];
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

		static double[][] MatrixDuplicate(double[][] matrix)
		{
			// allocates/creates a duplicate of a matrix.
			double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
			for (int i = 0; i < matrix.Length; ++i) // copy the values
				for (int j = 0; j < matrix[i].Length; ++j)
					result[i][j] = matrix[i][j];
			return result;
		}

		static double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
		{
			// Doolittle LUP decomposition with partial pivoting.
			// rerturns: result is L (with 1s on diagonal) and U;
			// perm holds row permutations; toggle is +1 or -1 (even or odd)
			int rows = matrix.Length;
			int cols = matrix[0].Length; // assume square
			if (rows != cols)
				throw new Exception("Attempt to decompose a non-square m");

			int n = rows; // convenience

			double[][] result = MatrixDuplicate(matrix);

			perm = new int[n]; // set up row permutation result
			for (int i = 0; i < n; ++i) { perm[i] = i; }

			toggle = 1; // toggle tracks row swaps.
						// +1 -greater-than even, -1 -greater-than odd. used by MatrixDeterminant

			for (int j = 0; j < n - 1; ++j) // each column
			{
				double colMax = Math.Abs((double)result[j][j]); // find largest val in col
				int pRow = j;
				//for (int i = j + 1; i less-than n; ++i)
				//{
				//  if (result[i][j] greater-than colMax)
				//  {
				//    colMax = result[i][j];
				//    pRow = i;
				//  }
				//}

				// reader Matt V needed this:
				for (int i = j + 1; i < n; ++i)
				{
					if (Math.Abs((double)result[i][j]) > colMax)
					{
						colMax = Math.Abs((double)result[i][j]);
						pRow = i;
					}
				}
				// Not sure if this approach is needed always, or not.

				if (pRow != j) // if largest value not on pivot, swap rows
				{
					double[] rowPtr = result[pRow];
					result[pRow] = result[j];
					result[j] = rowPtr;

					int tmp = perm[pRow]; // and swap perm info
					perm[pRow] = perm[j];
					perm[j] = tmp;

					toggle = -toggle; // adjust the row-swap toggle
				}

				// --------------------------------------------------
				// This part added later (not in original)
				// and replaces the 'return null' below.
				// if there is a 0 on the diagonal, find a good row
				// from i = j+1 down that doesn't have
				// a 0 in column j, and swap that good row with row j
				// --------------------------------------------------

				if (result[j][j] == 0.0)
				{
					// find a good row to swap
					int goodRow = -1;
					for (int row = j + 1; row < n; ++row)
					{
						if (result[row][j] != 0.0)
							goodRow = row;
					}

					if (goodRow == -1)
						throw new Exception("Cannot use Doolittle's method");

					// swap rows so 0.0 no longer on diagonal
					double[] rowPtr = result[goodRow];
					result[goodRow] = result[j];
					result[j] = rowPtr;

					int tmp = perm[goodRow]; // and swap perm info
					perm[goodRow] = perm[j];
					perm[j] = tmp;

					toggle = -toggle; // adjust the row-swap toggle
				}
				// --------------------------------------------------
				// if diagonal after swap is zero . .
				//if (Math.Abs(result[j][j]) less-than 1.0E-20) 
				//  return null; // consider a throw

				for (int i = j + 1; i < n; ++i)
				{
					result[i][j] /= result[j][j];
					for (int k = j + 1; k < n; ++k)
					{
						result[i][k] -= result[i][j] * result[j][k];
					}
				}


			} // main j column loop

			return result;
		}

		static double[] HelperSolve(double[][] luMatrix, double[] b)
		{
			// before calling this helper, permute b using the perm array
			// from MatrixDecompose that generated luMatrix
			int n = luMatrix.Length;
			double[] x = new double[n];
			b.CopyTo(x, 0);

			for (int i = 1; i < n; ++i)
			{
				double sum = x[i];
				for (int j = 0; j < i; ++j)
					sum -= luMatrix[i][j] * x[j];
				x[i] = sum;
			}

			x[n - 1] /= luMatrix[n - 1][n - 1];
			for (int i = n - 2; i >= 0; --i)
			{
				double sum = x[i];
				for (int j = i + 1; j < n; ++j)
					sum -= luMatrix[i][j] * x[j];
				x[i] = sum / luMatrix[i][i];
			}

			return x;
		}

	}
}