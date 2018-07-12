using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4_Palindrome_and_Permutation
{
    class Implementation
    {

    //LD it could be possible to use a dictionary instead of an array
    // like in "_1._2_Check_Permutation" -> "CheckPermutationOne"
    public static int[] BuildCharFrequencyTable(String phrase)
    {
        int[] table = new int[26];
        foreach (char c in phrase)
        {
            int x = GetCharNumber(c);
            if (x != -1)
            {
                table[x]++;
            }
        }
        return table;
    }

    public static int GetCharNumber(char c)
    {
        var val = char.ToLower(c) - 'a';
        if (0 <= val && val <= 25)
        {
            return val;
        }
        return -1;
    }

    /*
     * Count of how many time each caracter appear. Then ensure no more than one caracter has odd count
     */
    #region Solution 1

    public static bool IsPermutationOfPalindrome(String phrase)
    {
        int[] table = BuildCharFrequencyTable(phrase);
        return CheckMaxOneOdd(table);
    }

    //LD this method return true only if one odd. We loop the full array of values.
    public static bool CheckMaxOneOdd(int[] table)
    {
        bool foundOdd = false;
        foreach (int count in table)
        {
            if (count % 2 == 1)
            {
                if (foundOdd)
                {
                    return false;
                }
                foundOdd = true;
            }
        }
        return true;
    }

    #endregion Solution 1

    /*
        Improvement of "solution 1" 
    */
    #region Solution 2

    public static bool IsPermutationOfPalindrome2(String phrase)
    {
        int countOdd = 0;
        int[] table = new int[26];
        foreach (char c in phrase.ToCharArray())
        {
            int x = GetCharNumber(c);
            if (x != -1)
            {
                table[x]++;

                if (table[x] % 2 == 1)
                {
                    countOdd++;
                }
                else
                {
                    countOdd--;
                }
            }
        }
        return countOdd <= 1;
    }

        #endregion Solution 2

    /*
         
    */
    #region Solution 3

    public static bool IsPermutationOfPalindrome3(String phrase)
    {
            int bitVector = MarkBitForOddCharacterCount(phrase);
            return bitVector == 0 || CheckExactlyOneBitSet(bitVector);
    }

    /* Create bit vector for string. For each letter with value i,
     * toggle the ith bit. */
        public static int MarkBitForOddCharacterCount(String phrase)
        {
            int bitVector = 0;
            foreach (char c in phrase.ToCharArray())
            {
                int x = GetCharNumber(c);
                bitVector = Toggle(bitVector, x);
            }
            return bitVector;
        }

        /* Toggle the ith bit in the integer. */
        public static int Toggle(int bitVector, int index)
    {
        if (index < 0) return bitVector;

        int mask = 1 << index;
        if ((bitVector & mask) == 0)
        {
            bitVector |= mask;
        }
        else
        {
            bitVector &= ~mask;
        }
        return bitVector;
    }

    /* Check that exactly one bit is set by subtracting one from the
     * integer and ANDing it with the original integer. */

    public static bool CheckExactlyOneBitSet(int bitVector)
    {
        return (bitVector & (bitVector - 1)) == 0;
    }

    #endregion Solution 3


}
}
