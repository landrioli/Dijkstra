using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Min Heap is ");
            BinaryHeapHelper minHeap = new BinaryHeapHelper(15);
            minHeap.Insert(5);
            minHeap.Insert(3);
            minHeap.Insert(17);
            minHeap.Insert(10);
            minHeap.Insert(84);
            minHeap.Insert(19);
            minHeap.Insert(6);
            minHeap.Insert(22);
            minHeap.Insert(9);
            minHeap.MinHeap();

            minHeap.Print();
            Console.WriteLine("The Min val is " + minHeap.Remove());
        }
    }
}
