using System;
using System.Collections;
using System.Collections.Generic;
namespace task03_3
{
    class Program
    {
        static void Main(string[] args)
        {


            
        }
    }
     class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private const int maxCapacity = 8;
        private int ieCapacity = 0;
        private T[] array;

        public int Length { get;  set; }

        public int Capacity
        {
            get => array.Length;
            set
            {

            }
        }

        public DynamicArray()
        {
            
            array = new T[maxCapacity];
            
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            ieCapacity = GetLength(collection);
            array = new T[ieCapacity];

            int i = 0;
            foreach (T element in collection)
            {
                array[i] = element;
                i++;
            }
        }
        public void Add(T el)
        {
            if (Length > Capacity)
                array = new T[Capacity * 2];
            array[Length] = el;
            Length++;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            int newLength = GetLength(collection); ;
            
            if (Length + newLength > Capacity)
            {
                int newCapacity = Capacity + newLength + maxCapacity;
                T[] tempArray = array;
                array = new T[newCapacity];
                Capacity = newCapacity;
                tempArray.CopyTo(array, 0);
            }
            int i = Length;
            foreach (T item in collection)
            {
                array[i] = item;
                i++;
            }
            Length += newLength;

        }
        public T this[int i]
        {
            get
            {
                return array[i];
            }

            set
            {                
                array[i] = value;
            }
        }
        public void Insert(T el, int index)
        {
            if (Length >= Capacity)
                array = new T[Capacity * 2];
            Length++;
            for (int i = index + 1; i < Length; i++)
            {
                array[i] = array[i + 1];
            }
            array[index] = el;
        }
        public bool Remove(T elem)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(elem))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        T buf = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buf;
                    }
                    array[Length - 1] = default;
                    Length--;
                    return true;
                }
            }
            return false;
        }
        private int GetLength(IEnumerable<T> collection)
        {
            int count = 0;

            foreach (T el in collection)
            {
                count++;
            }
            return count;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
