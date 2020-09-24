using System;
using System.Collections.Generic;
using System.Collections;

namespace Calisma37_InterfcEx
{
    class Koleksiyon : IEnumerable<int>
    {
        public int[] Dizi;

        public Koleksiyon(int[] dizi)
        {
            Dizi = dizi;
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            for (int i = 0; i < Dizi.Length; i++)
            {
                // if (Dizi[i]>50)
                // yield break;
                yield return Dizi[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
