using System;

namespace OOP1
{
    public class Animal
    {
        // Fields
        public string type;
        public string breed;
        public string name;
        public int age;

        // Methods
        // Constructor

        public Animal(string type, string breed, string name, int age)
        {
            this.type = type;
            this.breed = breed;
            this.name = name;
            this.age = age;
        }

        public void ShowInfo() {
            Console.WriteLine($"Nombre: {name}, Edad: {age}, Tipo: {type}, Raza: {breed}");
        }

        public void Eat(){
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep(){
            Console.WriteLine($"{name} is sleeping");
        }

           public void Play(){
            Console.WriteLine($"{name} is playing");
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a new object
            Animal tobby = new Animal("Dog", "German Shepperd", "Tobby", 6);

            // using methods
            tobby.ShowInfo();
            tobby.Play();
            tobby.Eat();
            tobby.Sleep();

            // Creating  a new object

            Animal michi = new Animal("Cat", "Siamese", "Michi", 2);

            // using methods
            michi.ShowInfo();
            michi.Play();
            michi.Eat();
            michi.Sleep();
        }
    }
}