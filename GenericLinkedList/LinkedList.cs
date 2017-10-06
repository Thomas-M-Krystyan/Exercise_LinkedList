using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericLinkedList
{
    internal class LinkedList<T>
    {
        private Node<T> _currentNode;

        internal void AddNext(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (this._currentNode != null)
            {
                this._currentNode.Next = newNode;
                newNode.Previous = this._currentNode;
            }

            this._currentNode = newNode;
        }

        internal void PrintNodes()
        {
            Dictionary<T, List<T>> nodesDictionary = new Dictionary<T, List<T>>();

            // Collecting of data
            while (this._currentNode != null)
            {
                // Validation of fields
                T currentNode = this._currentNode.Value;
                T previousNode = this._currentNode.Previous != null ? this._currentNode.Previous.Value : default(T);
                T nextNode = this._currentNode.Next != null ? this._currentNode.Next.Value : default(T);

                nodesDictionary.Add(currentNode, new List<T> { previousNode, nextNode });
                if (this._currentNode.Previous == null)
                    break;

                // Countdown
                this._currentNode = this._currentNode.Previous;
            }

            // Displaying results (in descending order)
            foreach (KeyValuePair<T, List<T>> pair in nodesDictionary.Reverse())
            {
                Console.WriteLine($"Current: \"{pair.Key}\"" +
                                    $"\n\tPrevious: \"{pair.Value[0]}\"" +
                                    $"\n\tNext: \"{pair.Value[1]}\"\n");
            }
        }
    }
}
