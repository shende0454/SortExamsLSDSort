using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public interface IAlphabet
    {
        // Return the indexTh character in the alphabet
        char ToChar(int index);

        // Given an char, return the associated index
        int ToIndex(char c);

        // Return true if the char is part of the alphabet
        bool Contains(char c);

        // Radix is the number of chars in alphabet
        int Radix { get;  }

        // Ceiling(log2(Radix))
        int NBitsToRepresent { get; }

        // Given a string return an enumeration of associated indices
        IEnumerable<int> ToIndices(String s);

        string ToChars(IEnumerable<int> indices);
    }
}
