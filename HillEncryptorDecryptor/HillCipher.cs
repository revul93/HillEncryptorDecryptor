using System;
using System.Collections.Generic;

namespace HillEncryptorDecryptor
{
    class HillCipher
    {
        private string alphabet;
        private string key;
        private Dictionary<char, int> alphabetDictionary;
        private Dictionary<int, char> reverseAlphabetDictionary;
        private double[][] keyMatrix;
        private double[][] inverseKeyMatrix;

        public HillCipher(string alphabet, string key)
        {
            if (Helper.DuplicateChars(alphabet))
            {
                throw new Exception("Alphabet contains duplicate characters");
            }

            if (!Helper.IsSquare(key.Length))
            {
                throw new Exception("Key length is not squared");
            }

            this.alphabet = alphabet.ToUpper();
            alphabetDictionary = BuildAlphabetDictionary(this.alphabet);
            reverseAlphabetDictionary = BuildReverseAlphabetDictionary(alphabetDictionary);
            
            this.key = key.ToUpper();
            keyMatrix = BuildKeyMatrix(this.key, alphabetDictionary);
            if (!MatrixOperation.IsMatrixInvertible(keyMatrix))
            {
                throw new Exception("Key matrix is not invertible");
            }
            if (!Helper.Coprime((int)MatrixOperation.MatrixDeterminant(keyMatrix), alphabetDictionary.Count + 65))
            {
                throw new Exception("Key matrix determenant must be coprime with alphabet length");
            }

            MatrixOperation.PrintMatrix(keyMatrix, "Key Matrix");
        }

        public string Encrypt(string plaintext)
        {
            return EncrpyDecrypt(plaintext, "ENCRYPT");
        }

        public string Decrypt(string ciphertext)
        {
            inverseKeyMatrix = MatrixOperation.MatrixInverse(keyMatrix);
            MatrixOperation.PrintMatrix(inverseKeyMatrix, "Inverse Matrix");
            
            inverseKeyMatrix = MatrixOperation.MatrixModule(inverseKeyMatrix, alphabetDictionary.Count);
            MatrixOperation.PrintMatrix(inverseKeyMatrix, "Inverse Matrix % 26");

            return EncrpyDecrypt(ciphertext, "DECRYPT");
        }

        public string EncrpyDecrypt(string input, string mode = "ENCRYPT")
        {
            if (mode != "ENCRYPT" && mode != "DECRYPT")
            {
                throw new Exception("Invalid mode. Specify ENCRYPT or DECRYPT");
            }

            input = input.ToUpper();
            string inputSubString = "";

            string output = "";
            int keyMatrixOrder = keyMatrix.Length;
            Dictionary<int, char> NotCipheredCharacters = new Dictionary<int, char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!alphabetDictionary.ContainsKey(input[i]))
                {
                    if (char.IsWhiteSpace(input[i]) || char.IsPunctuation(input[i]) || char.IsDigit(input[i]))
                    {
                        NotCipheredCharacters.Add(i, input[i]);
                        continue;
                    }
                    throw new Exception(input[i] + " is not exist in alphabet!");
                }

                inputSubString += input[i];
                if (inputSubString.Length == keyMatrixOrder)
                {
                    double[][] inputSubStringMatrix = Helper.OneColumnMatrix(inputSubString, alphabetDictionary);
                    Console.WriteLine(inputSubString);
                    MatrixOperation.PrintMatrix(inputSubStringMatrix, "Input Substring Matrix");

                    double[][] subOutputMatrix;
                    if (mode == "DECRYPT")
                    {
                        subOutputMatrix = MatrixOperation.MultiplyMatrix(inverseKeyMatrix, inputSubStringMatrix);
                    }
                    else
                    {
                        subOutputMatrix = MatrixOperation.MultiplyMatrix(keyMatrix, inputSubStringMatrix);
                    }
                    MatrixOperation.PrintMatrix(subOutputMatrix, "Sub Output Matrix");
                    subOutputMatrix = MatrixOperation.MatrixModule(subOutputMatrix, alphabetDictionary.Count);
                    MatrixOperation.PrintMatrix(subOutputMatrix, "Sub Output Matrix % 26");

                    output += Helper.ExtractChars(subOutputMatrix, reverseAlphabetDictionary);
                    inputSubString = "";
                }
            }

            if (inputSubString.Length > 0)
            {
                output += inputSubString;
            }
            foreach (KeyValuePair<int, char> pair in NotCipheredCharacters)
            {
                output = output.Insert(pair.Key, pair.Value.ToString());
            }

            return output;
        }

        private Dictionary<char, int> BuildAlphabetDictionary(string alphabet)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            int i = 0;
            foreach (char letter in alphabet)
            {
                dictionary.Add(letter, i);
                i++;
            }

            return dictionary;
        }

        private Dictionary<int, char> BuildReverseAlphabetDictionary(Dictionary<char, int> dictionary)
        {
            Dictionary<int, char> result = new Dictionary<int, char>();
            foreach(KeyValuePair<char, int> element in dictionary)
            {
                result.Add(element.Value, element.Key);
            }

            return result;
        }
        
        private double[][] BuildKeyMatrix(string key, Dictionary<char, int> dictionary)
        {
            int matrixOrder = (int)Math.Sqrt(key.Length);
            double[][] matrix = MatrixOperation.MatrixCreate(matrixOrder, matrixOrder);
            int keyIndex = 0;
            for (int i = 0; i < matrixOrder; i++)
            {
                for (int j = 0; j < matrixOrder; j++)
                {
                    matrix[i][j] = dictionary[key[keyIndex]];
                    keyIndex++;
                }
            }

            return matrix;
        }
    }
}
