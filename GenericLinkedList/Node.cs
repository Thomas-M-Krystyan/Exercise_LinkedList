namespace GenericLinkedList
{
    internal class Node<T>
    {
        internal T Value { get; private set; }  // Not the ID of exact Node, but the information to store in it!
        internal Node<T> Previous { get; set; }
        internal Node<T> Next { get; set; }

        internal Node(T value)
        {
            this.Value = value;
        }
    }
}
