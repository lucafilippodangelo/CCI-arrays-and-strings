using System;

namespace _1._5_One_Way
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "pse";
            String b = "pale";
            bool isOneEdit = Implementation.OneEditAway(a, b);
            Console.WriteLine("{0}, {1}: {2}", a, b, isOneEdit);

            string c = "pse";
            string d = "psea";
            bool isOneEditTestTwo = Implementation.OneEditAway(c,d);
            Console.WriteLine("{0}, {1}: {2}", c, d , isOneEditTestTwo);
            Console.ReadLine();
        }
    }
}
