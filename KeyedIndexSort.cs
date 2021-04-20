using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class KeyedIndexSort
    {
        public KeyedIndexSort(IEnumerable<ICharKey> thingToSort, IAlphabet alphabet)
        {
        }

        public IEnumerable<ICharKey> GetSorted()
        {
            return sortedArray;
        }

        // Count array size of alphabet + 1;
        int[] count;
        ICharKey[] sortedArray;
    }
}
