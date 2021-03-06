﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1_Is_Unique
{
    public static class Implementation
    {
        
        //LD O(N²) - Nested For
        public static Boolean ImplementationOne(string inputS)
        {
        Console.WriteLine("String: " + inputS);
            for(int i = 0; i< inputS.Length-1;i++)
            {
                for (int j = i+1; j <= inputS.Length-1; j++)
                {
                    if (inputS.Substring(i, 1) == inputS.Substring(j, 1))
                    {
                        Console.WriteLine($"match found in position: {i} {j}");//LD return true if duplicate found
                        return true;
                    }
                }
            }
            Console.WriteLine("no match");
            return false;
        }


        //LD Bit Vector
        public static Boolean ImplementationTwo(string str)
        {
            {
                Console.WriteLine(str + " ------------------------------------------- "); 
                if (str.Length > 256) {return false;}

                var checker = 0;
                for (var i = 0; i < str.Length; i++)
                {
                    var val = str[i] - 'a'; Console.WriteLine("str[i]: " + str[i] ); Console.WriteLine("val: " + val);

                    Console.WriteLine("checker: " + checker); Console.WriteLine(" 1 << val: " + (1 << val));
                    if ((checker & (1 << val)) > 0)
                    {
                        Console.WriteLine("match found");//LD return true if duplicate found
                        return true;
                    }

                    //LD The | operator performs a bitwise logical OR 
                    // operation on integral operands and logical OR on bool operands
                    checker |= (1 << val);

                    Console.WriteLine("checker: "+ checker);
                    Console.WriteLine(""); 
                }

                return false;
            }
        }


        //LD hash table
        public static Boolean ImplementationThree(string str)
        {
            var hashset = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashset.Contains(c)) return true;
                hashset.Add(c);
            }

            return false;
        }

    }
}//namespace
