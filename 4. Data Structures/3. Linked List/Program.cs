using System;

namespace LinkedList
{
    public class Program
    {
        public static void DisplayLinkedList<T>(LinkedList<T> list)
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Create a linked list: pets");
            LinkedList<string> pets =  new LinkedList<string>();

            pets.AddFirst("Dog"); // The head will be Dog.
            DisplayLinkedList(pets);
            
            Console.WriteLine("\nAdding a new node at first position");
            pets.AddFirst("Cat"); // now Cat will be the head.
            DisplayLinkedList(pets);
            
            Console.WriteLine("\nAdding a new node at the end");
            pets.AddLast("Parrot"); // Cat will se the last node.
            DisplayLinkedList(pets);

            Console.WriteLine("\nAdding a new node after Dog node");
            LinkedListNode<string> dog = pets.Find("Dog"); // The first parameter has to be a LinkedListNode type
            pets.AddAfter(dog, "Hamster");
            DisplayLinkedList(pets);


            Console.WriteLine(pets.Contains("Dog"));

            // Removing
            Console.WriteLine("\nRemoving a node");
            pets.Remove("Hamster");
            DisplayLinkedList(pets);

            Console.WriteLine("\nRemoving the first node");
            pets.RemoveFirst();
            DisplayLinkedList(pets);

            Console.WriteLine("\nRemoving the last node");
            pets.RemoveLast();
            DisplayLinkedList(pets);
            
        }
    }
}
