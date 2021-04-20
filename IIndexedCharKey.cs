using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public interface IIndexedCharKey
    {
        // Return the character at charIndex of the string
        char GetKeyChar(int charIndex);
    }
}
