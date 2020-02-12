using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class LinqProblemThree
    {

        //Member Variables (HAS A)
        public List<string> classGrades;
        
        //Constructor
        public LinqProblemThree()
        {
            // .split(
            classGrades = new List<string>() 
            { 
                "80, 100, 92, 89, 65", 
                "93, 81, 78, 84, 69", 
                "73, 88, 83, 99, 64", 
                "98, 100, 66, 74, 55" 
            };
        }

        //Member Methods (CAN DO)

        public static decimal CalculateClassAverage(List<string> input)
        {
            var dropLowest = input.Select(x => x.Split(',').Select(y => Convert.ToDecimal(y)).ToList().OrderByDescending(z => z).Take(4).Average()).Average();
            Console.WriteLine(dropLowest);
            return dropLowest;
        }
        
    }
}
