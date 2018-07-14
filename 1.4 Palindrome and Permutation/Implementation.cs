using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4_Palindrome_and_Permutation
{
    public class Implementation
    {
        #region Tests Start

        public static void AND()
        {
            // If the mask value is 1, and the value is 1, it sets it to 1
            // If the mask value is 1, and the value is 0, it keeps that 0
            // If the mask value is 0, the value is set to 0 regardless
            // 42   = 0010 1010
            // 36   = 0010 0100
            //
            // val  = 0010 0000 = 32
            int val = 42 & 36;
            Console.WriteLine("AND {0}", val);
        }

        public static void OR()
        {
            // If the mask value is 0, the original is returned
            // If the mask value is 1, 1 is returned (i.e. true || false == true)
            // 42   = 0010 1010
            // 36   = 0010 0100
            //
            // val  = 0010 1110 = 46
            int val = 42 | 36;
            Console.WriteLine("OR {0}", val);
        }

        public static void SHIFTLEFT()
        {
            // 42   = 0010 1010
            // If I shift left two positions "<< 2" = 1010 1000 = 168
            int val = 42;
            val = val << 2;
            Console.WriteLine("val << 2: {0}", val);

            // Pushing beyond 8 bits
            // 42   = 0000 0000 0010 1010
            // If I shift left four positions "<< 4" = 0000 0010 1010 0000 = 672 (512 + 128 + 32)
            val = 42;
            val = val << 4;
            Console.WriteLine("val << 4: {0}", val);
        }

        #endregion

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

    
    // Count of how many time each caracter appear. Then ensure no more than one caracter has odd count
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

    //Improvement of "solution 1" 
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

     // Solution with array manipulation
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
                int index = GetCharNumber(c); 
                
                bitVector = Toggle(bitVector, index); 
            }
            return bitVector;
        }

    /* Toggle the ith bit in the integer. */
    public static int Toggle(int bitVector, int index)
    {
        if (index < 0) return bitVector;

            //LD mask has precisely one bit set, all other bits are zero. If index is 0, mask is 1. If index is 1, 
            // mask is 2. If index is 2, mask is 4. If index is 3, mask is 8.
            int mask = 1 << index; //LD left shift, then we consider the integer of the binary 
            Console.WriteLine("----- Toggle method ----- mask: " + mask);
       
        if ((bitVector & mask) == 0) //LD true if the bitVector is not set. If the bitVector was set, the result of bitVector & mask would be equal to mask
            {
                //LD We OR the value to set the bit
                bitVector |= mask; 
                //Console.WriteLine("----- Toggle method ----- setting bitvector: " + bitVector );
            }
            else
            {
                //LD We AND ~mask to unset the bit. Mask has precisely one bit set, and therefore ~mask has all except one bit set.
                bitVector &= ~mask; 
                //Console.WriteLine("----- Toggle method ----- unsetting bitvector: " + bitVector);
            }
        //Console.WriteLine("----- Toggle method ----- RETURN");
        return bitVector;
    }

    /* Check that exactly one bit is set by subtracting one from the
         * integer and ANDing it with the original integer. 
        */
    public static bool CheckExactlyOneBitSet(int bitVector)
    {
        return (bitVector & (bitVector - 1)) == 0;
            /*
            When you subtract 1 from a number, all bits after the last 1 become 1. This happens for the same reason 
            that when a base-10 number ends with one or more zeros, if you subtract 1, then all the trailing zeros become 9. 
            I suggest to down in binary a bunch of numbers, and their values after subtracting 1. 
            The simple math becomes obvious.

            Let's look at an example:

            16 : 10000
            15 : 01111
            It's clear that AND-ing the two numbers will result in 0

            It's clear that AND-ing some number num with num-1 basically zeros out all the bits from the last 1 
            until the end. If there were any other bits before, they will remain, and the result will not be zero. 
            The result will only be zero if there was only one 1. 
            */
        }

    #endregion Solution 3


    }
}
