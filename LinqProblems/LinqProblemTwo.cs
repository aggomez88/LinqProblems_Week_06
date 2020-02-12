using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class LinqProblemTwo
    {

        //Member Variables (HAS A)
        public List<string> duplicates;
        
        //Constructor
        public LinqProblemTwo()
        {
            duplicates = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        }
        //Member Methods (CAN DO)
        public void RemoveDuplicates()
        {
            var result = duplicates.Distinct();

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }



    }
}
