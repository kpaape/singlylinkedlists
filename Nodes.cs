using System;

namespace SinglyLinkedLists
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node(int val)
        {
            Value = val;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        public Node Head;
        public bool IsEmpty
        {
            get {
                return Head == null;
            }
        }

        public void AddToFront(int value)
        {
            // create a node object (with value)

            Node newNode = new Node(value);

            newNode.Next = Head;
            Head = newNode;
        }

        public void AddToBack(int value)
        {
            // initialize new node
            Node newNode = new Node(value);
            Node current = Head;

            // Edge Case: Empty List
            if(current == null)
            {
                Head = newNode;
                return;
            }

            // find the end of the list
            while(current.Next != null)
                current = current.Next;
            
            // put the node there!
            current.Next = newNode;

        }

        public void Insert(int value, int num)// will insert the value after the specified index.
        {
            int count = 0;
            if(num < 1)
            {
                Console.WriteLine($"The referenced index must be 1 or greater.");
            }
            Node newNode = new Node(value);
            Node current = Head;
            while(current != null && num > count)
            {
                count++;
                if(count == num)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
                current = current.Next;
            }
            if(count < num)
            {
                Console.WriteLine($"The list does not have a length of {num} or greater.");
            }
        }

        public void Remove(int num)
        {
            int count = 0;
            Node current = Head;
            Node previous;
            if(num == 1)
            {
                Head = current.Next;
                current.Next = null;
            }
            while(current != null && num > count)
            {
                count++;
                previous = current;
                if(count == num - 1)
                {
                    current = current.Next;
                    if(current.Next == null)
                    {
                        previous.Next = null;
                        return;
                    }
                    previous.Next = current.Next;
                    current.Next = null;
                    return;
                }
                current = current.Next;
            }
        }

        public int Size()
        {
            int count = 0;
            Node current = Head;
            while(current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public bool Contains(int value)
        {
            Node current = Head;
            while(current != null)
            {
                if(current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Show()
        {
            int count = 0;
            Node current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                count++;
                current = current.Next;
            }
        }


    }
}