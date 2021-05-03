using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class LSDSort<Type> where Type : IIndexedCharKey
    {
        int N;
        int R;
        Type[] thingToSortAr;
        IAlphabet alphabet;
        public LSDSort(List<Type> data, Alphabet alphabet, int w)
        {
            this.alphabet = alphabet;
            N = data.Count();
            R = 256;
            thingToSortAr = new Type[data.Count];
            data.CopyTo(thingToSortAr);
            Type[] aux = new Type[N];
            for (int d = w - 1; d >= 0; d--)
            {
                int[] count = new int[R + 1];
                for (int i = 0; i < N; i++)
                {
                    count[thingToSortAr[i].GetKeyChar(d) + 1]++;
                }
                for (int r = 0; r < R; r++)
                {
                    count[r + 1] += count[r];
                }
                for (int i = 0; i < N; i++)
                {
                    aux[count[thingToSortAr[i].GetKeyChar(d)]++] = thingToSortAr[i];
                }
                for (int i = 0; i < N; i++)
                {
                    thingToSortAr[i] = aux[i];
                }
            }
        }
        public IEnumerable<Type> GetSorted()
        {
            //sortedArray
            return thingToSortAr;
        }



    }
}

