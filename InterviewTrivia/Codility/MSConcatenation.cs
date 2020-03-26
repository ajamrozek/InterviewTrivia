using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.Codility
{
    public class MSConcatenation
    {
        public int solution(string[] A)
        {
            var workingResult = 0;
            var maxResult = 0;

            var workingDictionary = new Dictionary<string, bool>();//unused value, mostly care about the keys
            var candidateList = new List<string>();



            //make the candidates. insert them into the workingDictionary if not there
            foreach (var itemA in A)
            {                

                foreach (var itemB in A.Where(x => x != itemA))
                {
                    var candidate = $"{itemA}{itemB}";//fizzbuzz

                    if (!candidateList.Contains(itemB))
                    {

                    }


                    if(candidate.Distinct().Count() != candidate.Length)//need distinct letters
                    {
                        continue;
                    }

                    if (!workingDictionary.ContainsKey(candidate))
                    {
                        workingDictionary.Add(candidate, true);
                    }

                    candidate = $"{itemB}{itemA}";//buzzfizz
                    if (!workingDictionary.ContainsKey(candidate))
                    {
                        workingDictionary.Add(candidate, true);
                    }
                }
            }

            maxResult = workingDictionary.Count == 0 ? 0 : workingDictionary.Keys.Select(key => key.Length).Max();
            

            return maxResult;
        }
    }
}
