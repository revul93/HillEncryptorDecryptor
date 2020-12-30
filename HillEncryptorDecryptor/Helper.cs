using System;
using System.Collections.Generic;

namespace HillEncryptorDecryptor
{
    public static class Helper
    {
        public static double[][] OneColumnMatrix(string input, Dictionary<char, int> dictionary)
        {
            double[][] result = MatrixOperation.MatrixCreate(input.Length, 1);
            for (int j = 0; j < input.Length; j++)
            {
                result[j][0] = dictionary[input[j]];
            }
            return result;
        }

        public static string ExtractChars(double[][] matrix, Dictionary<int, char> dictionary)
        {
            string result = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    result += dictionary[(int)matrix[i][j]];
                }
            }

            return result;
        }

        public static bool DuplicateChars(string alphabet)
        {
            for (int i = 0; i < alphabet.Length - 1; i++)
            {
                for (int j = i + 1; j < alphabet.Length; j++)
                {
                    if (alphabet[i] == alphabet[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsSquare(int number)
        {
            return Math.Sqrt(number) % 1 == 0;
        }

        public static bool Coprime(int a, int b)
        {
            return Gcd(a, b) == 1;
        }

        static int Gcd(int a, int b)
        {
            int tmp;
            if (a < b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            while (b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return Math.Abs(a);
        }
    }
}
