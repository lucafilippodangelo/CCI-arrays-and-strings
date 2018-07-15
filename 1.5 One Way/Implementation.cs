using System;
using System.Collections.Generic;
using System.Text;

namespace _1._5_One_Way
{
    public class Implementation
    {
        //LD main method
        public static bool OneEditAway(String first, String second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(second, first);
            }
            return false;
        }

        public static bool OneEditReplace(String s1, String s2)
        {
            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                    {
                        return false; //LD more than one difference discovered, then return false.
                    }
                    foundDifference = true; //LD first difference discovered.
                }
            }
            return true;
        }

        public static bool OneEditInsert(String s1, String s2)
        {
            int index1 = 0;
            int index2 = 0;
            //LD when I want to play with two index in same direction and for instance comparing two strings, is good to use a while.
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        //LD found a difference and the indexes are already different means that a second difference is discovered
                        return false; //LD 
                    }
                    index2++; //LD found a difference, increase the index of the second string
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        #region not tested

        public static bool OneEditAway2(String first, String second)
        {
            /* Length checks. */
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            /* Get shorter and longer string.*/
            String s1 = first.Length < second.Length ? first : second;
            String s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    /* Ensure that this is the first difference found.*/
                    if (foundDifference) return false;
                    foundDifference = true;
                    if (s1.Length == s2.Length)
                    { // On replace, move shorter pointer
                        index1++;
                    }
                }
                else
                {
                    index1++; // If matching, move shorter pointer
                }
                index2++; // Always move pointer for longer string
            }
            return true;
        }

        #endregion

    }
}
