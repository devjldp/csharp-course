namespace MyLinkedList{
    /// <summary>
    /// This class represent a node in the list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyNode<T>
    {
        public T Key {get; set;}
        public MyNode<T> Next { get; set; }
        public MyNode<T> Previous { get; set; }
        public MyNode(T key)
        {
            Key = key;
            Next = null;
            Previous = null;
        }
    }

    /// <summary>
    /// This class represents a Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyLinkedList<T>
    {
        public MyNode<T> head;

        /// <summary>
        /// This method adds a new node to the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            MyNode<T> newNode = new MyNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
            MyNode<T> current = head;
            MyNode<T> previous = null;
            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            current.Next = newNode;
            current.Previous = previous;
            }
        }
        /// <summary>
        /// This method display all nodes in the linked list
        /// </summary>
        public void Display()
        {
            MyNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Key+ " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}    