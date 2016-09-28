using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class BinaryHeapHelper
    {
        private int[] Heap;
        private int size;
        private int maxsize;

        private const int FRONT = 1;

        public BinaryHeapHelper(int maxsize)
        {
            this.maxsize = maxsize;
            this.size = 0;
            Heap = new int[this.maxsize + 1];
            Heap[0] = int.MinValue;
        }

        private int Parent(int pos)
        {
            return pos / 2;
        }

        private int LeftChild(int pos)
        {
            return (2 * pos);
        }

        private int RightChild(int pos)
        {
            return (2 * pos) + 1;
        }

        private bool IsLeaf(int pos)
        {
            if (pos >= (size / 2) && pos <= size)
            {
                return true;
            }
            return false;
        }

        private void Swap(int fpos, int spos)
        {
            int tmp;
            tmp = Heap[fpos];
            Heap[fpos] = Heap[spos];
            Heap[spos] = tmp;
        }

        private void MinHeapify(int pos)
        {
            if (!IsLeaf(pos))
            {
                if (Heap[pos] > Heap[LeftChild(pos)] || Heap[pos] > Heap[RightChild(pos)])
                {
                    if (Heap[LeftChild(pos)] < Heap[RightChild(pos)])
                    {
                        Swap(pos, LeftChild(pos));
                        MinHeapify(LeftChild(pos));
                    }
                    else
                    {
                        Swap(pos, RightChild(pos));
                        MinHeapify(RightChild(pos));
                    }
                }
            }
        }

        public void Insert(int element)
        {
            Heap[++size] = element;
            int current = size;

            while (Heap[current] < Heap[Parent(current)])
            {
                Swap(current, Parent(current));
                current = Parent(current);
            }
        }

        public void Print()
        {
            for (int i = 1; i <= size / 2; i++)
            {
                Console.WriteLine(" PARENT : " + Heap[i] + " LEFT CHILD : " + Heap[2 * i] + " RIGHT CHILD :" + Heap[2 * i + 1]);
            }
        }

        public void MinHeap()
        {
            for (int pos = (size / 2); pos >= 1; pos--)
            {
                MinHeapify(pos);
            }
        }

        public int Remove()
        {
            int popped = Heap[FRONT];
            Heap[FRONT] = Heap[size--];
            MinHeapify(FRONT);
            return popped;
        }
    }
}
