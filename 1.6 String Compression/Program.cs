using System;

namespace _1._6_String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            const string original = "abbccccccde";
            var compressed = Implementation.CompressBetter(original);
            Console.WriteLine("Original  : {0}", original);
            Console.WriteLine("Compressed: {0}", compressed);
            Console.ReadLine();
        }
    }
}
