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
            Console.WriteLine("------------------------------------1");
            Console.WriteLine(list.Contains(5));
            Console.WriteLine("------------------------------------2");
            Console.WriteLine(list.Contains(55));
            Console.WriteLine("------------------------------------3");
            list.Show();
            Console.WriteLine("------------------------------------4");
            list.Insert(10, 3);
            list.Show();
            Console.WriteLine("------------------------------------5");
            list.Insert(10, 7);
            list.Show();
            Console.WriteLine("------------------------------------6");
            list.Insert(10, 9);
            list.Insert(10, 0);
            list.Remove(5);
            list.Show();
            Console.WriteLine("------------------------------------7");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("------------------------------------8");
            list.Remove(2);
            list.Show();
            Console.WriteLine("------------------------------------9");
            list.Remove(1);
            list.Show();
            Console.WriteLine("-----------------------------------10");
            list.Insert(100, 1);
            list.Show();
            Console.WriteLine("-----------------------------------11");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------12");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------13");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------14");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------15");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------16");
            list.Remove(list.Size());
            list.Show();
            Console.WriteLine("-----------------------------------17");
            list.Insert(200, 2);
            list.Insert(100, 1);
            list.Insert(0, 0);// this is the same as add to front
            list.Insert(10, list.Size());// this is the same as add to back but will fail if list is null
            list.Show();
            Console.WriteLine("-----------------------------------18");
            list.Remove(1);
            list.Show();
            Console.WriteLine("-----------------------------------19");
            // I think I need to edit how insert and remove work. Currently, Remove will remove the specified number (non 0 based index) and insert inserts after the specified index (or at 0 based)
        }
    }
}
