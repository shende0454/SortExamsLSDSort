using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class Alphabet : IAlphabet
    {
        // Alphabet grades = new Alphabet("abcdfiABCDFI");
        // Alphabet ssn = new Alphabet("0123456789");
        public Alphabet(string alphabet)
        {
            _alphabet = alphabet;

            Radix = _alphabet.Length;
            double bitsToRepresent = Math.Log((double)Radix) / Math.Log(2.0);
            NBitsToRepresent = (int) Math.Ceiling(bitsToRepresent);
        }

        public int Radix { get; }
        public int NBitsToRepresent { get; }

        public bool Contains(char c)
        {
            return _alphabet.Contains(c);
        }

        public char ToChar(int index)
        {
            return _alphabet[index];
        }

        public string ToChars(IEnumerable<int> indices)
        {
            StringBuilder builder = new StringBuilder();
            foreach(int index in indices)
            {
                builder.Append(ToChar(index));
            }
            return builder.ToString();
        }

        public int ToIndex(char c)
        {
            return _alphabet.IndexOf(c);
        }

        public IEnumerable<int> ToIndices(string stringToTranslate)
        {
            foreach(char charToTranslate in stringToTranslate)
            {
                yield return ToIndex(charToTranslate);
            }
        }

        private string _alphabet;
    }
}
