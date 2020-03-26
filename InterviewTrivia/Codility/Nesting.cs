using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Codility
{
    public class Nesting
    {
        private const string OpenChars = "({[";
        private const string CloseChars = ")}]";

        public int solution(string S)
        {
            int result = 1;
            var workingStack = new Stack<char>();
            foreach (var sItem in S)
            {
                var openCharIdx = OpenChars.IndexOf(sItem);
                if (openCharIdx >= 0)
                {
                    workingStack.Push(sItem);
                }

                var closeCharIdx = CloseChars.IndexOf(sItem);
                if(closeCharIdx >= 0 )
                {
                    if(workingStack.Count == 0)
                    {
                        result = 0;
                        break;
                    }

                    var temp = workingStack.Pop();

                    result = closeCharIdx == OpenChars.IndexOf(temp) ? 1 : 0;
                    if(result == 0)
                    {
                        break;
                    }
                }
            }

            result = result == 1 && workingStack.Count == 0 ? 1 : 0;

            return result;
        }
    }
}
