using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.AddToFront(1);
            list.AddToFront(2);
            list.AddToFront(3);
            list.AddToBack(45);
            list.AddToBack(55);
            list.AddToBack(65);
            Console.WriteLine(list.Size());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(list.Contains(5));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(list.Contains(55));
            Console.WriteLine("------------------------------------");
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Insert(10, 3);
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Insert(10, 7);
            list.Show();
            list.Insert(10, 9);
            list.Insert(10, 0);
            Console.WriteLine("------------------------------------");
            list.Remove(4);
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(2);
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(1);
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Insert(100, 1);
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------");
        }
    }
}
