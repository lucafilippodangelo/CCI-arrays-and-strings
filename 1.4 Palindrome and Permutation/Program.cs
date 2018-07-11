using System;

namespace _1._4_Palindrome_and_Permutation
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            String[] strings = {"Rats live on no evil star",
                            "A man, a plan, a canal, panama",
                            "Lleve",
                            "Tacotac",
                            "asda"};

            foreach (String s in strings)
            {
                bool a = Implementation.IsPermutationOfPalindrome(s);
                bool b = Implementation.IsPermutationOfPalindrome2(s);
                bool c = Implementation.IsPermutationOfPalindrome3(s);
                Console.WriteLine(s);
                if (a == b && b == c)
                {
                    Console.WriteLine("Agree: " + a);
                }
                else
                {
                    Console.WriteLine("Disagree: " + a + ", " + b + ", " + c);
                }
                Console.WriteLine();
            
        }
    }
    }
}
