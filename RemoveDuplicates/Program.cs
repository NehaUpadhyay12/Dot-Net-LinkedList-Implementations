using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class RemoveDuplicates
    {
        LinkedList<string> llWithDuplicates;
        public RemoveDuplicates(LinkedList<string> llWithDuplicates)
        {
            this.llWithDuplicates = llWithDuplicates;
        }

        public void RemoveDuplicatesFromLL()
        {
            LinkedListNode<string> NodeToCompare = llWithDuplicates.First;
            while (NodeToCompare != null)
            {
                var Head = NodeToCompare;
                while (Head.Next != null)
                {
                    if (NodeToCompare.Value != Head.Next.Value)
                        Head = Head.Next;
                    else
                    {
                        llWithDuplicates.Remove(Head.Next);
                    }

                }
                NodeToCompare = NodeToCompare.Next;
            }

            }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<string> sample = new LinkedList<string>();
            sample.AddLast("a");
            sample.AddLast("b");
            sample.AddLast("c");
            sample.AddLast("a");
            sample.AddLast("b");
            sample.AddLast("d");
            sample.AddLast("a");
            RemoveDuplicates obj = new RemoveDuplicates(sample);
            obj.RemoveDuplicatesFromLL();
        }
    }
}
