using System;
using System.Collections.Generic;
using System.Text;

namespace _1._7_Rotate_Matrix
{
    public static class Implementation
    {
        public static void Rotate(int[,] matrix, int n)
    {
        for (var layer = 0; layer < n / 2; ++layer)
        {
            var first = layer;
            var last = n - 1 - layer;

            for (var i = first; i < last; ++i)
            {
                var offset = i - first;
                var top = matrix[first,i]; // save top

                // left -> top
                matrix[first,i] = matrix[last - offset,first];

                // bottom -> left
                matrix[last - offset,first] = matrix[last,last - offset];

                // right -> bottom
                matrix[last,last - offset] = matrix[i,last];

                // top -> right
                matrix[i,last] = top; // right <- saved top
            }
        }
    }

        public static void displayMatrix(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) //LD row
            {
                for (int i = 0; i < matrix.GetLength(0); i++) //LD column
                {
                    Console.Write(" "+ matrix[j, i]+ " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
