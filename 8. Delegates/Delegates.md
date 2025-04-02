# Delegates in C#


[Delegates](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-delegate-type) in C# are function pointers that allow encapsulating references to functions with a specific signature. A `delegate` is a reference type that can be used to encapsulate a named or an anonymous method.

## Key Features
* Delegates are **type-safe**, meaning they can only reference methods that match their exact signature.
* Delegates allow passing methods as parameters. 
* They can be used to define callback methods.
* Multiple methods can be chained into a single delegate.
* They are commonly used in **events and callbacks**.
* Delegates store references to methods and allow the code to work with different behaviors.


## Official Documentation:
* [Using Delegates](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates)
* [Work with delegates](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)


## Basic Syntax of a Delegate
To declare a delegate, use the following syntax:

```csharp
[Access Modifier] delegate [Return Type] [Delegate Name]([Input Parameters]);

// Delegate declaration
public delegate void MyDelegate(string message);

// Class with methods compatible with the delegate
public class Messenger {
    public static void ShowMessage(string message) {
        Console.WriteLine(message);
    }
}

class Program {
    static void Main() {
        // Create an instance of the delegate
        MyDelegate myDelegate = new MyDelegate(Messenger.ShowMessage);
        
        // Invoke the delegate
        myDelegate("Hello from a delegate!");
    }
}
```

## Types of Delegates
### 1. **Single Delegate**
A delegate that points to a single method.

```csharp
public delegate void Operation(int x, int y);

public class Calculator {
    public static void Add(int a, int b) {
        Console.WriteLine($"Sum: {a + b}");
    }
}

class Program {
    static void Main() {
        Operation operation = Calculator.Add;
        operation(10, 5); // Output: Sum: 15
    }
}
```

### 2. **Multicast Delegates**
Delegates can chain multiple methods using `+=` or `-=`.

```csharp
public class Operations {
    public static void Method1() => Console.WriteLine("Method1 executed");
    public static void Method2() => Console.WriteLine("Method2 executed");
}

class Program {
    static void Main() {
        Action delegateInstance = Operations.Method1;
        delegateInstance += Operations.Method2;
        delegateInstance();
        // Output:
        // Method1 executed
        // Method2 executed
    }
}
```

### 3. **Generic Delegates (Func, Action, and Predicate)**

#### **Func<T>**
Used when the delegate returns a value.
```csharp
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(4, 6)); // Output: 10
```

#### **Action<T>**
Used when the delegate **does not return a value**.
```csharp
Action<string> print = message => Console.WriteLine(message);
print("Hello, world!");
```

#### **Predicate<T>**
Returns a `bool` based on a condition.
```csharp
Predicate<int> isEven = num => num % 2 == 0;
Console.WriteLine(isEven(10)); // Output: True
```

## Delegates and Events
Events in C# are based on delegates.

```csharp
public delegate void EventDelegate(string message);

public class Publisher {
    public event EventDelegate MyEvent;
    
    public void TriggerEvent(string message) {
        MyEvent?.Invoke(message);
    }
}

class Subscriber {
    public static void HandleEvent(string message) {
        Console.WriteLine("Event received: " + message);
    }
}

class Program {
    static void Main() {
        Publisher publisher = new Publisher();
        publisher.MyEvent += Subscriber.HandleEvent;
        publisher.TriggerEvent("Hello Event!");
    }
}
```

## Delagtes buitl in C#

* [`Delegate Action`](https://learn.microsoft.com/en-us/dotnet/api/system.action-1?view=net-9.0): The Action delegate is a built-in generic delegate in .NET that represents a method that does not return a value (void). It can take between 0 and 16 input parameters.

* [`Delegate Func`](https://learn.microsoft.com/en-us/dotnet/api/system.func-2?view=net-9.0): The Func delegate is another built-in delegate in .NET that represents a method that returns a value. Like Action, Func comes in multiple versions, supporting between 0 and 16 input parameters. The last type parameter always represents the return type.

* [`Delegate Predicate`](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-9.0): The Predicate delegate is another built-in delegate in .NET, similar to Action and Func. It is specifically designed to evaluate a condition and always returns a Boolean (true or false). *Note: The Predicate delegate always takes exactly one input parameter and returns a Boolean result.*

