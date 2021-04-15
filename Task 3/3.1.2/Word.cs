using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
    class Word
    {
        public string WordText { get; private set; }
        public int WordFrequency { get; private set; }

        public Word(string word, int frequency)
        {
            this.WordText = word;
            this.WordFrequency = frequency;
        }

        public override string ToString()
        {
            return WordText + " : " + WordFrequency;
        }
    }
}
