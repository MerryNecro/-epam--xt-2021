using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        protected T[] InternalArray;

        public int Capacity { get; private set; }

        public int Length { get; private set; }

        public DynamicArray()
        {
            Capacity = 8;
            Length = 0;
            InternalArray = new T[Capacity]; 
        }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            Length = 0;
            InternalArray = new T[Capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            T[] TempArray = collection.ToArray();
            Capacity = TempArray.Length;
            Length = Capacity;
            Array.Copy(TempArray, InternalArray, Length);
        }


        public void Add(T ItemToAdd)
        {
            this.Insert(ItemToAdd, Length);
        }


        public void AddRange(IEnumerable<T> collection)
        {
            T[] TempArray = collection.ToArray();
            Length += TempArray.Length;

            while (Capacity <= Length)
            {
                Capacity *= 2;
            }
            Array.Resize(ref InternalArray, Capacity);

            Array.Copy(collection.ToArray(), 0, InternalArray, 0, TempArray.Length);
            
        }


        public bool Remove(T ItemToRemove)
        {
            int indexOfItem = Array.IndexOf(InternalArray, ItemToRemove);

            if (indexOfItem == -1)
            {
                return false;
            }

            Array.Copy(InternalArray, indexOfItem++, InternalArray, indexOfItem, Length - indexOfItem - 1);
            InternalArray[Length-1] = default;
            Length--;
            return true;
        }


        public bool Insert(T ItemToInsert, int IndexOfInsert)
        {
            if(IndexOfInsert < 0 || IndexOfInsert > Length)
            {
                throw new ArgumentOutOfRangeException("Index can't be < 0 or > length");
            }

            if (Capacity == Length)
            {
                Capacity *= 2;
                Array.Resize(ref InternalArray, Capacity);
            }

            if( IndexOfInsert == Length)
            {
                InternalArray[IndexOfInsert] = ItemToInsert;
                Length++;
                return true;
            }

            Array.Copy(InternalArray, IndexOfInsert, InternalArray, IndexOfInsert + 1, Length - IndexOfInsert);
            InternalArray[IndexOfInsert] = ItemToInsert;
            Length++;
            return true;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return InternalArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return InternalArray.GetEnumerator();
        }


        public T this[int index]
        {
            get
            {
                if (index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Index can't be > length");
                }

                if (index < 0)
                {
                    if (-index >= Length)
                    {
                        throw new ArgumentOutOfRangeException("Index modulus can't be > length");
                    }

                    return InternalArray[Length + index];
                }

                return InternalArray[index];
            }

            set
            {
                if (index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Index can't be > length");
                }

                if (index < 0)
                {
                    if (-index >= Length)
                    {
                        throw new ArgumentOutOfRangeException("Index modulus can't be > length");
                    }

                    InternalArray[Length + index] = value;
                }

                InternalArray[index] = value;
            }
        }

        
        public void ChangeCapacity(int NewCapacity)
        {
            if (NewCapacity < 1)
            {
                throw new ArgumentException("Capacity can't be less or equal zero.");
            }

            Array.Resize(ref InternalArray, NewCapacity);
            Capacity = NewCapacity;
        }


        public object Clone()
        {
            return new DynamicArray<T>(InternalArray);
        }


        public T[] ToArray()
        {
            T[] ResultArray = new T[Length];
            Array.Copy(InternalArray, ResultArray, Length);
            return ResultArray;
        }
    }
}
