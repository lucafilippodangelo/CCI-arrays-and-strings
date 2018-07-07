using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1_Is_Unique
{
    public static class Implementation
    {
        //STRING TO BE SUBSTITUTE BY UT
        
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

    }
}//namespace
