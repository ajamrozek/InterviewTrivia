using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia
{
    public class TimesTable
    {
        public int[,] Result { get; private set; }

        public TimesTable(int size)
        {
            Result = new int[size, size];

            // set first row & col for calc matrix
            for (int i = 0; i < size; i++)
            {
                // first row = first col
                Result[0, i] = Result[i, 0] = i + 1;
            }

            // now do all calcs
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    Result[i, j] = Result[0, i] * Result[j, 0];
                }
            }
        }
    }
}
