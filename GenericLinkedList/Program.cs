using System;

namespace GenericLinkedList
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddNext("First");
            linkedList.AddNext("Second");
            linkedList.AddNext("Third");
            linkedList.AddNext("Fourth");
            linkedList.AddNext("Fifth");

            linkedList.PrintNodes();

            Console.ReadLine();
        }
    }
}
