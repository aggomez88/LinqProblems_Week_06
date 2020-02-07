using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class Word_List
    {
        public List<Words> LetterExtractor()
        {
            return new List<Words>()
            {
                new Words(){word = "the"},
                new Words(){word = "bike"},
                new Words(){word = "this"},
                new Words(){word = "it"},
                new Words(){word = "tenth"},
                new Words(){word = "mathematics"}
            };
        }
    }
}
