using System.Collections.Generic;
using System.Collections;
using System;

namespace lab6
{
    class BinaryThing : IEnumerable
    {
        private List<ThingElement> elements;
        public int Count
        {
            get
            {
                return elements.Count;
            }
        }
        public void Add(int value)
        {
            elements.Add(new ThingElement(value));
            int index = elements.Count - 1;
            int parent = (index - 1) / 2;

            while (index > 0 && elements[parent].Value < elements[index].Value)
            {
                ThingElement tmp = elements[index];
                elements[index] = elements[parent];
                elements[parent] = tmp;

                index = parent;
                parent = (index - 1) / 2;
            }
        }
        public void FixTheIndex(int i)//index from 0 to n-1
        {
            int leftChild;
            int rightChild;
            int largestChild;
            for (;;)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < elements.Count && elements[leftChild].Value > elements[largestChild].Value)
                {
                    largestChild = leftChild;
                }

                if (rightChild < elements.Count && elements[rightChild].Value > elements[largestChild].Value)
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                ThingElement temp = elements[i];
                elements[i] = elements[largestChild];
                elements[largestChild] = temp;
                i = largestChild;
            }
        }
        public void DeleteAt(int index)//index from 0 to n-1
        {
            if (elements.Count != 0)
            {
                elements[index] = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                FixTheIndex(index);
            }
        }
        public void RemoveMax()
        {
            DeleteAt(0);
        }
         
        public void RemoveRand()
        {
            Random r = new Random();
            DeleteAt(r.Next(0,Count-1));
        }

        public void RemoveAll()
        {
            elements.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (ThingElement elem in elements)
                yield return elem;
        }

        public BinaryThing()
        {
            elements = new List<ThingElement>();
        }
        public ThingElement this[int i]
        {
            get
            {
                return elements[i];
            }
            set
            {
                elements[i] = value;
            }
        }

    }
}
