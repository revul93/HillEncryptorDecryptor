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
        private int[,] keyMatrix;

        public HillCipher(string alphabet, string key)
        {
            if (DuplicateChars(alphabet))
            {
                throw new Exception("Alphabet contains duplicate characters");
            }

            if (!IsSquare(key.Length))
            {
                throw new Exception("Key length is not squared");
            }

            this.alphabet = alphabet;
            this.key = key;
            alphabetDictionary = BuildAlphabetDictionary(this.alphabet);
            reverseAlphabetDictionary = BuildReverseAlphabetDictionary(alphabetDictionary);
            keyMatrix = BuildKeyMatrix(this.key, alphabetDictionary);

            if (MatrixOperation.IsMatrixInvertible(keyMatrix))
            {
                throw new Exception("Key matrix is not inversible");
            }

        }

        public string Encrypt(string plaintext)
        {
            if (key.Length > plaintext.Length)
            {
                throw new Exception("Key length must be less than plaintext length");
            }

            string ciphertext = "";
            string temp = "";
            Dictionary<int, char> NotCipheredCharacters = new Dictionary<int, char>();

            for (int i = 0; i < plaintext.Length; i++)
            {
                if (!alphabetDictionary.ContainsKey(plaintext[i]))
                {
                    if (char.IsWhiteSpace(plaintext[i]) || char.IsPunctuation(plaintext[i]) || char.IsDigit(plaintext[i]))
                    {
                        NotCipheredCharacters.Add(i, plaintext[i]);
                        continue;
                    }
                    throw new Exception(plaintext[i] + " is not exist in alphabet!");
                }
                temp += plaintext[i];
                if (temp.Length == (int)Math.Sqrt(key.Length))
                {
                    int[,] tempMatrix = new int[temp.Length, 1];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tempMatrix[j, 0] = temp[j];
                    }

                    int[,] cipheredMatrix = MatrixOperation.MultiplyMatrix(keyMatrix, tempMatrix);
                    cipheredMatrix = MatrixOperation.MatrixModule(cipheredMatrix, alphabetDictionary.Count);
                    ciphertext += ExtractChars(cipheredMatrix);
                    temp = "";
                }
            }
            if (temp.Length > 0)
            {
                ciphertext += temp;
            }
            foreach(KeyValuePair<int, char> pair in NotCipheredCharacters)
            {
                ciphertext = ciphertext.Insert(pair.Key, pair.Value.ToString());
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            if (key.Length > ciphertext.Length)
            {
                throw new Exception("Key length must be less than plaintext length");
            }

            string plaintext = "";
            string temp = "";
            Dictionary<int, char> PlainCharacters = new Dictionary<int, char>();
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (!alphabetDictionary.ContainsKey(ciphertext[i]))
                {
                    if (char.IsWhiteSpace(ciphertext[i]) || char.IsPunctuation(ciphertext[i]) || char.IsDigit(ciphertext[i]))
                    {
                        PlainCharacters.Add(i, ciphertext[i]);
                        continue;
                    }
                    throw new Exception(ciphertext[i] + " is not exist in alphabet!");
                }
                temp += ciphertext[i];
                if (temp.Length == (int)Math.Sqrt(key.Length))
                {
                    int[,] tempMatrix = new int[temp.Length, 1];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tempMatrix[j, 0] = temp[j];
                    }

                    int[,] inverseKeyMatrix = MatrixAdvancedOperations.Get2DMatrixInverse<int>(keyMatrix);
                    int[,] plainMatrix = MatrixOperation.MultiplyMatrix(keyMatrix, tempMatrix);
                    plainMatrix = MatrixOperation.MatrixModule(plainMatrix, alphabetDictionary.Count);
                    plaintext += ExtractChars(plainMatrix);
                    temp = "";
                }

            }

            return plaintext;
        }

        private bool DuplicateChars(string alphabet)
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

        private bool IsSquare(int number)
        {
            return Math.Sqrt(number) % 1 == 0;
        }

        private string ExtractChars(int[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += reverseAlphabetDictionary[matrix[i,j]];
                }
            }

            return result;
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
        
        private int[,] BuildKeyMatrix(string key, Dictionary<char, int> dictionary)
        {
            int matrixOrder = (int)Math.Sqrt(key.Length);
            int[,] matrix = new int[matrixOrder, matrixOrder];
            int keyIndex = 0;
            for (int i = 0; i < matrixOrder; i++)
            {
                for (int j = 0; j < matrixOrder; j++)
                {
                    matrix[i, j] = dictionary[key[keyIndex]];
                    keyIndex++;
                }
            }

            return matrix;
        }

    }
}
