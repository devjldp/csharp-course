using System;
using System.Collections;

namespace Hashtabl
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Hashtable myHashTable = new Hashtable();

            myHashTable["1"] = "red";
            myHashTable["red"] = 1;
            myHashTable[2] = true;



           Console.WriteLine(myHashTable["2"]); //is null

           foreach(DictionaryEntry data in myHashTable)
            {
                Console.WriteLine($"Key: {data.Key} - Value: {data.Value}");
            }


            Console.WriteLine("Adding a new element:");
            myHashTable.Add("2", "blue");

            foreach(DictionaryEntry data in myHashTable)
            {
                Console.WriteLine($"Key: {data.Key} - Value: {data.Value}");
            }

            Console.WriteLine("Removing a element:");
            myHashTable.Remove("1");

            Console.WriteLine("Checking if elements are in the hash table:");
            Console.WriteLine(myHashTable.Contains("red"));
            Console.WriteLine(myHashTable.ContainsKey("2"));
            Console.WriteLine(myHashTable.ContainsValue(1));
        }
    }
}







