using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        public CycledDynamicArray() : base() { }

        public CycledDynamicArray(int capacity) : base(capacity) { }

        public CycledDynamicArray(ICollection<T> collection) : base(collection) { }

        public new IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= Length; i++)
            {
                if (i == Length)
                    i = 0;

                yield return InternalArray[i];
            }
        }
    }
}
