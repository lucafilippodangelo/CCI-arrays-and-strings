using System;

namespace _1._4_Palindrome_and_Permutation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LD TESTS
            /*
            Implementation.OR();
            Implementation.AND();
            Implementation.SHIFTLEFT();
            */
           
            bool b = Implementation.IsPermutationOfPalindrome("Tacotac");
            bool sb = Implementation.IsPermutationOfPalindrome3("Tacotac");
            
            Console.ReadLine();
        }
    }
}
