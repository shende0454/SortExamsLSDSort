using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class KeyedIndexSort
    {
        IEnumerable<ICharKey> thingToSort;
        ICharKey[] thingToSortAr;
        IAlphabet alphabet;
        public KeyedIndexSort(IEnumerable<ICharKey> thingToSort, Alphabet alphabet)
        {
            
            this.thingToSort = thingToSort;
            this.alphabet = alphabet;
          //  thingToSort = thingToSort.ToArray();
           thingToSortAr = new ICharKey[thingToSort.Count()];
            thingToSortAr = thingToSort.ToArray();
            //count = new int[alphabet.Radix];
            //maybe string 4 aux ar below
            ICharKey[] aux = new ICharKey[thingToSort.Count()];
            count = new int[256 + 1];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            //for (int i = 0; i < thingToSort.Count(); i++)
            //{

            //        count[thingToSortAr[i].GetCharKey() + 1]++;

            //}
            // count number of times we see char
            int arraySize = 0;
            foreach (ICharKey key in thingToSortAr)
            {
                char charKey = key.GetCharKey();
                ++count[charKey + 1];
                ++arraySize;
            }
            //COMPUTE THE START INDEX
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i - 1] + count[i];
            }
            sortedArray = new ICharKey[thingToSort.Count()];
            //sort array
            foreach (ICharKey key in thingToSortAr)
            {
                sortedArray[count[key.GetCharKey()]] = key;
                ++count[key.GetCharKey()];
            }
            //for (int r = 0; r < alphabet.Radix; r++)
            //    count[r + 1] += count[r];

            //for (int i = 0; i < thingToSortAr.Count(); i++)
            //    aux[count[thingToSortAr[i].GetCharKey()]++] = thingToSortAr[i];

            //for (int i = 0; i < thingToSortAr.Count(); i++)
            //    thingToSortAr[i] = aux[i];

            // sortedArray = thingToSort.ToArray();
        }

        public IEnumerable<ICharKey> GetSorted()
        {
            //sortedArray
            return sortedArray;
        }

        // Count array size of alphabet + 1;
        int[] count;
        ICharKey[] sortedArray;
    }
}
