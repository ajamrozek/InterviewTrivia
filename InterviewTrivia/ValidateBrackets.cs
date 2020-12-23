using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia
{
    public class ValidateBrackets
    {
        private string[] brackets = { "()", "{}", "[]" };

        public bool IsBalanced(string source)
        {
            var result = true;
            var bracketStack = new Stack<char>();

            foreach (var sourceChar in source)
            {
                var bracketsFound = brackets.FirstOrDefault(brack => brack.Contains(sourceChar));
                if (!string.IsNullOrEmpty(bracketsFound))
                {
                    var bracketFoundIndex = bracketsFound.IndexOf(sourceChar);

                    // if a close bracket is found and there's nothing in the stack yet, we're imbalanced. exit now
                    if (bracketFoundIndex > 0 && !bracketStack.Any())
                    {
                        return false;
                    }

                    // if there's nothing in the bracket stack yet, push the current sourceChar
                    if (!bracketStack.Any())
                    {
                        bracketStack.Push(sourceChar);
                    }
                    else // check the prior bracketStack item for parity against the current sourceChar
                    {
                        var priorBracket = bracketStack.Peek();

                        // current sourceChar is a close
                        if (bracketFoundIndex == 1)
                        {
                            // prior bracket matches, pop stack
                            if (priorBracket == bracketsFound[0])
                            {
                                bracketStack.Pop();
                            }
                            else // imbalanced. exit now
                            {
                                return false;
                            }
                        }
                        else 
                        {
                            bracketStack.Push(sourceChar);
                        }
                    }

                }
            }

            result = bracketStack.Count() == 0;

            return result;
        }
    }
}
