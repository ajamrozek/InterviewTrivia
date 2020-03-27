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
            var maxLength = 0;
            
            // get all distinct charactered items
            var baseSet = A.Where(itemA => itemA.Distinct().Count() == itemA.Length); 

            // use the base set to drive the "ommitted" value 
            foreach (var item in baseSet) 
            {
                // set the base result for all items except the ommited value
                var baseResult = baseSet.Where(itemB => itemB != item);

                // set the final result to the remaining items that contain unique characters.
                // drop any items that contain a char already in the result
                var result = string.Join(string.Empty,
                    baseResult.Where((itemB) =>
                    {
                        // all items not the current item
                        var altResult = baseResult.Where(itemC => itemC != itemB);

                        // drop the item if it has a non-unique char
                        return !itemB.ToCharArray()
                            .Any(charB => string.Join(string.Empty, altResult).Contains(charB));
                    }));

                // set the maxLength if a new champion is detected
                maxLength = result.Length > maxLength ? result.Length : maxLength;
            }

            return maxLength;
        }




    }
}
