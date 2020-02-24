using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Weekend_Lab.Models
{
    public class RepeatWord
    {
        public string Word { get; set; }
        public int Number { get; set; }

       

        public RepeatWord()
        {

        }

        public string RepeatWordFromUser()
        {
            var result = Word;
            for (int i = 0; i < Number - 1; i++)
            {
                result += Word;
            }

            return result;

            //return String.Concat(Enumerable.Repeat(Word, Number));
        }
    }
}
