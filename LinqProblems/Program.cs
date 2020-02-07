using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // WITH LINQ
            //------------------------------------------------------#1
            //Word_List word_List = new Word_List();
            //List<Words> words = word_List.LetterExtractor();

            //var wordsWithTH = words.FindAll(w => w.word.Contains("th"));
            //foreach (var word in wordsWithTH)
            //{
            //    Console.WriteLine(word.word);
            //}

            //-------------------------------------------------------#2

            LinqProblemTwo linqProblemTwo = new LinqProblemTwo();
            linqProblemTwo.RemoveDuplicates();

            Console.ReadLine();

            
        }

    }
}
