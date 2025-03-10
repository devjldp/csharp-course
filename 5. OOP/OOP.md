# Object Oriented Programming


## Content

1. [Introduction](#introduction)
2. [Objects](#objects)
3. [Classes](#classes)
4. [OOP Principles](#oop-principles)
5. [how to define classes and objects.](#how-to-define-classes-and-objects)
6. [Example.](#example)
7. [Access modifiers](#access-modifiers)
8. [Getters and Setters](#)

### Introduction

C# is a object oriented language, but what does it mean?
It is a programming paradigm that organise the software aroun the concept of objects

### Objects

But what is an object?  
We can see an object as a data structure where we store information organized into fields and methods (functions). Objects are a block of memory.

An object is also called an instance.

### Classes

A class is basically a blueprint for creating different types of objects. Since C# is a strongly typed language, when we create a class, we are defining a new data type.

**Relationship between Objects and Classes**

An `object` is an `instance` of a `class`, representing a specific `entity` with a defined state `(fields)` and behavior `(methods)`.

In the following example, you can think of:
* A class as a car factory that defines the blueprint for creating cars (robots build and assemble the different parts of the car).
* An object as an individual car, each with its own properties, such as color, max speed, and engine type.
![classes and objects](../images/factoryClass.png)


### OOP Principles
* Encapsulation
* Abstraction
* Polymorphism
* Inheritance

### how to define classes and objects.

Defining a new class. We are going to use the keyword `class`
```
access_modifier class Name_of_class
{
  // define fields

  // Define methods
    
    // Constructor: 
    access_modifier Name_of_class(parameters)
    {
      
    }

    // other methods
}
```

Creating an object (instance fo the class). We are going to use the keyword `new`

```
Name_of_class name_of_object = new Name_of_class(arguments);

```
**Note:**
* `class`: The class keyword is used to define a new user-defined data type that encapsulates fields and methods.
* `new`: The new keyword is used to create an instance (object) of a class by allocating memory for it.

### Example.
```csharp
// Defining a new class (a new data type)
class Animal
{
    // Fields (state)
    public string name;
    public string species;
    public int age;

    // Methods (behavior)
    public void MakeSound()
    {
        Console.WriteLine(name + " is making a sound!");
    }

    public void Describe()
    {
        Console.WriteLine("This is a " + species + " named " + name + ", and it is " + age + " years old.");
    }
}


// Creating an instance of the Animal class
Animal myPet = new Animal();
myPet.name = "Buddy";
myPet.species = "Dog";
myPet.age = 5;

// Calling methods on the object
myPet.MakeSound(); // Buddy is making a sound!  
myPet.Describe(); // This is a Dog named Buddy, and it is 5 years old.  

```

### Access Modifiers

In c#, our variables, clases methods... have some type of accessibility level. We are control  if they can be used from another part of code.

The main access modifiers are:
* **public:** Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
* **private:** Only code declared in the same class or struct can access this member.
* **protected:** Only code in the same class or in a derived class can access this type or member.
* **internal:** Only code in the same assembly can access this type or member.
* **protected internal:** Only code in the same assembly or in a derived class in another assembly can access this type or member.
* **private protected:** Only code in the same assembly and in the same class or a derived class can access the type or member.
* **file:** Only code in the same file can access the type or member. It applies only to types. Introduced in C# 11.

**Note:** Information obtained from [Microsoft Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)


```csharp
class Animal
{
    private string name; // Private field, only accessible within this class

    // methods
    public Animal(string name)
    {
      this.name =  name;
    }
}

class Program
{
    static void Main()
    {
        Animal cat = new Animal("Cat");
        
        Console.WriteLien(cat.name) // Error: cat.name  is inaccessible due to its protection level 
    }
}
```


### Getters and Setters

When we have a private field, we cannot access or modify it from outside, only within the same class. So how can we perform these operations? We will create public methods to access and modify the information.

* The `get` method returns the value of the field.
* The `set` method modify the value of the field.

```csharp
class Animal
{
    private string name; // Private field, only accessible within this class

    // methods
    public Animal(string name)
    {
      this.name =  name;
    }

  public string Get(){
    return name;
  }

  public void Set(string newName){
    name = newName;
  }


}

class Program
{
    static void Main()
    {
        Animal cat = new Animal("Michi");
        
        Console.WriteLien(cat.name) // Error: cat.name  is inaccessible due to its protection level 
        Console.WriteLien(cat.Get()) // Michi 
        Console.WriteLien(cat.Set("Tobby")) // Michi 
        Console.WriteLien(cat.Get()) // Tobby 
    }
}

```









