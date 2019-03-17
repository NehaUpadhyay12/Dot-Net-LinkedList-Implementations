using System;

namespace LinkedListOperations
{
    public class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next = null;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public Node Head;

        public void InsertNode(int data)
        {
            if(Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node n = Head;
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = new Node(data);
            }
        }

        public void DeleteByValue(int d)
        {
            if (Head == null)
                Console.WriteLine("Linked List is empty. Nothing to delete");
            else
            {
                Node n = Head;
                if (n.data == d)
                    Head = Head.next;
                else
                {
                    while (n.next != null)
                    {
                        if (n.next.data == d)
                        {
                            n.next = n.next.next;
                            break;
                        }
                        n = n.next;
                    }
                }
            }
        }

        public void Traverse()
        {
            if (Head == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                Node n = Head;
                while (n != null)
                {
                    Console.Write(n.data + ",");
                    n = n.next;
                }
                Console.WriteLine();
            }

        }

        public static void Main(string[] args)
        {
            LinkedList obj = new LinkedList();
            obj.InsertNode(10);
            obj.InsertNode(20);
            obj.InsertNode(30);
            obj.InsertNode(40);
            obj.InsertNode(50);
            obj.InsertNode(60);
            obj.Traverse();
            obj.DeleteByValue(10);
            obj.DeleteByValue(50);
            obj.Traverse();
            obj.DeleteByValue(60);
            obj.Traverse();
        }
    }


}
