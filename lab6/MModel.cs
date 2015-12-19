using System;
using System.Collections;


namespace lab6
{
    class MModel : IModel, IEnumerable
    {
        private BinaryThing heap = new BinaryThing();
        public int Count
        {
            get
            {
                return heap.Count;
            }
        }

        public void Add(int value)
        {
            heap.Add(value);
        }

        public void DeleteAt(int index)
        {
            heap.DeleteAt(index);
        }

        public void RemoveMax()
        {
            heap.RemoveMax();
        }

        public void RemoveAll()
        {
            heap.RemoveAll();
        }
        public IEnumerator GetEnumerator()
        {
            return heap.GetEnumerator();
        }

        public void Heapify(int i)
        {
            heap.FixTheIndex(i);
        }

        public void RemoveMin()
        {
            heap.RemoveRand();
        }

        public ThingElement this[int i]
        {
            get
            {
                return heap[i];
            }
            set
            {
                heap[i] = value;
            }
        }
    }
}
