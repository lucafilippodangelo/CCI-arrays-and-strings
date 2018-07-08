using System;
using System.Collections.Generic;
using System.Text;

namespace _1._2_Check_Permutation
{
    public static class Implementation
    {
        public static bool CheckPermutationOne(string strA, string strB)
        {
            if (strA.Length != strB.Length)
            {
                return false;
            }

            var letterCount = new Dictionary<char, int>();

            foreach (var character in strA)
            {
                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                    letterCount[character] = 1;
            }

            foreach (var character in strB)
            {
                if (letterCount.ContainsKey(character))
                {
                    letterCount[character]--;
                    if (letterCount[character] < 0)
                    {
                        return false;
                    }
                }
                else return false;
            }

            return true;
        }

        public static bool CheckPermutationTwo(string strA, string strB)
        {
            if (strA.Length != strB.Length) { return false; }

            var arrA = strA.ToCharArray(); //LD convert to a char array
            Array.Sort(arrA); //LD sort the array
            strA = new string(arrA); //LD create a new string from the array

            var arrB = strB.ToCharArray();
            Array.Sort(arrB);
            strB = new string(arrB);

            return strA.Equals(strB);
        }

    }
}
