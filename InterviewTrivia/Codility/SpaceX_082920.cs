using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS.Trivia.Codility.SpaceX
{
    public class Turbulence
    {
        public int solution(int[] A)
        {
            int priorValue = A[0];
            bool turbulentFlag;
            var longestTurbulence = 2;

            var turbulenceStack = new Stack<int>();

            if(A.Distinct().Count() == 1)
            {
                return 1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                turbulentFlag = priorValue != A[i] &&
                    ((priorValue > A[i] && i != A.Length - 1 ? A[i] < A[i + 1] : false) ||
                    (priorValue < A[i] && i != A.Length - 1 ? A[i] > A[i + 1] : false));

                if (turbulentFlag)
                {
                    longestTurbulence++;
                }
                else
                {
                    turbulenceStack.Push(longestTurbulence);
                    longestTurbulence = 2;
                }

                priorValue = A[i];
            }

            return turbulenceStack.Max() ;
        }
    }

    public class CityRoutes
    {
        public int solution(int[] T)
        {
            var routes = new Stack<int[]>();

            // build routes
            List<int> workingList = null;
            for (int i = 0; i < T.Length; i++)
            {
                bool home = T[i] == 0;
                if (home) // init vars
                {
                    if (workingList != null && workingList.Any())
                    {
                        routes.Push(workingList.ToArray());
                    }
                    workingList = new List<int>();
                }
                workingList.Add(T[i]);
            }

            var result = routes.Where(x => x.Count(y => y % 2 != 0)<2)
                .Max(route => route.Count());
            return result;


        }
    }

    public class CoinAdjacency
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int result = 0;
            for (int i = 0; i < n - 1; i++) // get all existing adjacencies
            {
                if (A[i] == A[i + 1])
                    result = result + 1;
            }
            int r = 0;
            for (int i = 0; i < n; i++) // find any flips that create adjacencies
            {
                int count = 0;
                if (i > 0)
                {
                    if (A[i - 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                if (i < n - 1)
                {
                    if (A[i + 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                r = Math.Max(r, count);                
            }
            return result + r;
        }

    }
}
