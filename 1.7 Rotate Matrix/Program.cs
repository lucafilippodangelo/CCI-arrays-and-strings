using System;

namespace _1._7_Rotate_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 4;

            var matrix = new int[4,4] { { 1, 2, 3, 4 }, { 12, 1, 1, 5 }, { 11, 1, 1, 6 }, { 10, 9, 8, 7 } };
            /* 
             * //LD input matrix
             1   2   3   4
             12  1   1   5
             11  1   1   6
             10  9   8   7
             */

            Implementation.displayMatrix(matrix);

            /* 
             * //LD expected output matrix
             10  11  12  1
             9   1   1   2
             8   1   1   3
             7   6   5   4
             */

            Implementation.Rotate(matrix, size);

            Implementation.displayMatrix(matrix);



        }



    }
}
