using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTrivia
{
    class Parenthesis
    {
        private StringBuilder workingResult;
        public IEnumerable<string> AllResults { get; private set; }
        internal char openChar;
        internal char closeChar;

        public Parenthesis(string paren = "()", int numberOfSets = 3)
        {
            SetOpenCloseChars(paren);

            workingResult = new StringBuilder();
            AllResults = new List<string>();


            char[] str = new char[2 * numberOfSets];

            SetParenthesis(str, numberOfSets);
        }

        private void SetOpenCloseChars(string paren)
        {
            if(paren.Length != 2)
            {
                throw new ArgumentException("Paren must be 2 characters long.");
            }

            openChar = paren.ToCharArray()[0];
            closeChar = paren.ToCharArray()[1];
        }

        internal void SetParenthesis(char[] str, int pos, int numberOfSets, int open, int close)
        {
            /// at the end
            if (close == numberOfSets)
            {
                /// assign the possible combinations thus far to the workingResult
                for (int i = 0; i < str.Length; i++)
                {
                    this.workingResult.Append(str[i]);
                }

                /// add to all results
                ((List<string>)AllResults).Add(this.workingResult.ToString());

                /// clear workingResult
                this.workingResult.Clear();

                /// exit this call, recursion termination
                return;
            }
            else /// processing non-terminating elements
            {
                /// more opens than closes means assign closeChar, 
                /// SetParens recursive call with incremented pos, same open count and increment close count
                if (open > close)
                {
                    str[pos] = closeChar;
                    SetParenthesis(str, pos + 1, numberOfSets, open, close + 1);
                }

                /// opens less than the number of iterations means assign openChar, 
                /// SetParens recursive call with incremented pos, incremented open count and same close count
                if (open < numberOfSets)
                {
                    str[pos] = openChar;
                    SetParenthesis(str, pos + 1, numberOfSets, open + 1, close);
                }
            }
        }

        internal void SetParenthesis(char[] str, int numberOfSets)
        {
            if (numberOfSets > 0)
                SetParenthesis(str, 0, numberOfSets, 0, 0);
            return;
        }

    }
}
