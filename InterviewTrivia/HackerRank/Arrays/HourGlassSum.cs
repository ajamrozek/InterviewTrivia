using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CS.Trivia.HackerRank.Arrays
{
    public class HourGlassSum
    {
        
        public static int hourglassSum(int[][] arr)
        {
            const int hourGlassSize = 3;
            const int arrSize = 6;
            var allResults = new List<int>();
            
            for(var rowIndex = 0; rowIndex <= arrSize - hourGlassSize; rowIndex++)
            {
                for (var colIndex = 0; colIndex <= arrSize - hourGlassSize; colIndex++)
                {
                    var workingResults = new List<int>();

                    // get top row
                    for (int subIndex = 0; subIndex < hourGlassSize; subIndex++)
                    {
                        workingResults.Add(arr.ElementAt(rowIndex).ElementAt(colIndex + subIndex));
                    }

                    // get middle row
                    workingResults.Add(arr.ElementAt(rowIndex + 1).ElementAt(colIndex + 1));

                    // get bottom row
                    for (int subIndex = 0; subIndex < hourGlassSize; subIndex++)
                    {
                        workingResults.Add(arr.ElementAt(rowIndex + 2).ElementAt(colIndex + subIndex));
                    }

                    allResults.Add(workingResults.Sum());
                }
            }

            return allResults.Max();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
