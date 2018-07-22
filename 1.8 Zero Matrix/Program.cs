using System;

namespace _1._8_Zero_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrix = new int[4, 4] { { 1, 2, 0, 4 }, { 12, 1, 1, 5 }, { 11, 1, 1, 6 }, { 10, 9, 8, 7 } };
            /* 
             * //LD input matrix
             1   2   0   4
             12  1   1   5
             11  1   1   6
             10  9   8   7
             */

            Implementation.SetZeros(matrix);
            Implementation.displayMatrix(matrix);
            
            /* 
             * //LD expected output matrix
             0   0   0   0
             9   1   0   2
             8   1   0   3
             7   6   0   4
             */



            
        }
    }
}
