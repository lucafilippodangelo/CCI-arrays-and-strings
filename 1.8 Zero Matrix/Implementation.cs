using System;
using System.Collections.Generic;
using System.Text;

namespace _1._8_Zero_Matrix
{
    public static class Implementation
    {
        #region useful methods

        private static void NullifyRow(int[,] matrix, int row)
        {
            for (var j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[row,j] = 0;
            }
        }

        private static void NullifyColumn(int[,] matrix, int col)
        {
            for (var i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i,col] = 0;
            }
        }

        private static int[][] CloneMatrix(int[][] matrix)
        {
            var clone = new int[matrix.Length][];

            for (var i = 0; i < matrix.Length; i++)
            {
                clone[i] = new int[matrix[0].Length];

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    clone[i][j] = matrix[i][j];
                }
            }

            return clone;
        }

        private static bool MatricesAreEqual(int[][] matrix1, int[][] matrix2)
        {
            if (matrix1.Length != matrix2.Length || matrix1[0].Length != matrix2[0].Length)
            {
                return false;
            }

            for (var k = 0; k < matrix1.Length; k++)
            {
                for (var j = 0; j < matrix1[0].Length; j++)
                {
                    if (matrix1[k][j] != matrix2[k][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void displayMatrix(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) //LD row
            {
                for (int i = 0; i < matrix.GetLength(0); i++) //LD column
                {
                    Console.Write(" " + matrix[j, i] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        #endregion 

        //LD solution one, use arrays to store index where zero.
        public static void SetZeros(int[,] matrix)
        {
            var row = new bool[matrix.GetLength(0)];
            var column = new bool[matrix.GetLength(1)];

            // Store the row and column index with value 0
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            // Nullify rows
            for (var i = 0; i < row.Length; i++)
            {
                if (row[i])
                {
                    NullifyRow(matrix, i);
                }
            }

            // Nullify columns
            for (var j = 0; j < column.Length; j++)
            {
                if (column[j])
                {
                    NullifyColumn(matrix, j);
                }
            }
        }

        //LD solution two, use first row and column to store flags
        // THIS CODE NEED TO BE TESTED, ONCE THE CODE IS TRIVIAL, I DID NOT SPEND TIME ON THIS
        /*
        public static void SetZeros2(int[][] matrix)
        {
            var rowHasZero = false;
            var colHasZero = false;

            // Check if first row has a zero
            for (var j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    rowHasZero = true;
                    break;
                }
            }

            // Check if first column has a zero
            for (var i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    colHasZero = true;
                    break;
                }
            }

            // Check for zeros in the rest of the array
            for (var i = 1; i < matrix.Length; i++)
            {
                for (var j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // Nullify rows based on values in first column
            for (var i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    NullifyRow(matrix, i);
                }
            }

            // Nullify columns based on values in first row
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    NullifyColumn(matrix, j);
                }
            }

            // Nullify first row
            if (rowHasZero)
            {
                NullifyRow(matrix, 0);
            }

            // Nullify first column
            if (colHasZero)
            {
                NullifyColumn(matrix, 0);
            }
        }
        */
    }
}
