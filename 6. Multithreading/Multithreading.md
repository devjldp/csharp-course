# Multithreading

Multithreading allow multiple threads to run concurrently inside the same application. This is useful for task that can be performed in parallel, like handling multiple requests.

We can divide our applications into two categories:

**Monotasking:** It only performs one task at a time. That is, we do not move on to the next task until the current one is finished.
We say that it only has a single execution thread that runs sequentially.
```csharp
InsertAuthor();
InsertCollection();
InsertBook();
```

Ejemplo
```csharp
using System.Threading;

// Monotasking
// Each task is executed sequentially
Console.WriteLine("Task1");
Thread.Sleep(2000); // delay the next task by 2 seconds
Console.WriteLine("Task2");
Thread.Sleep(2000); // delay the next task by 2 seconds
Console.WriteLine("Task3");
Thread.Sleep(2000); // delay the next task by 2 seconds
Console.WriteLine("Task4");
Thread.Sleep(2000); // delay the next task by 2 seconds
Console.WriteLine("Task5");

Task1
Task2
Task3
Task4
Task5
Task6
Task7
```
**Multitasking:*** It refers to performing several tasks simultaneously. They can have multiple threads running simultaneously.  
[Multithreading](https://www.geeksforgeeks.org/c-sharp-multithreading/)  

### What is a thread?

A thread is a unit of execution in a process. We can have more than one an they share the same resources with the parent process but runs indepently.  
*Process:* A Process is a part of an operating system that is responsible for executing an application.

### Main uses:
* Perform multiple tasks at once.
* Improve performance.
* Improve responsiveness.

## How to use threads?
[Official Documenattion](https://learn.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading)  
[Thread class](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-9.0)

To create a new thread, we instantiate the Thread class. This class allows us to create and manage threads within a program, enabling parallel execution of tasks.

The constructor takes a [delegado](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates). It specifies the method to be executed by the thread. 

In the code below, we will define two methods (Thread1 and Thread2) that simulate some tasks with delays:

```csharp
static void Thread1(){
    Console.WriteLine("Task1");
    Thread.Sleep(2000); // delay the next task by 2 seconds
    Console.WriteLine("Task2");
    Thread.Sleep(500); // delay the next task by 0.5 seconds
    Console.WriteLine("Task3");
    Thread.Sleep(1000); // delay the next task by 1 seconds
    Console.WriteLine("Task4");
    Thread.Sleep(2000); // delay the next task by 2 seconds
    Console.WriteLine("Task5");
}

static void Thread2(){
    Console.WriteLine("Task6");
    Thread.Sleep(1000); // delay the next task by 1 seconds
    Console.WriteLine("Task7");
    Thread.Sleep(700); // delay the next task by 0.7 seconds
    Console.WriteLine("Task8");
    Thread.Sleep(600); // delay the next task by 0.6 seconds
    Console.WriteLine("Task9");
    Thread.Sleep(6000); // delay the next task by 6 seconds
    Console.WriteLine("Task10");
}

// Create a new thread, passing the Thread2 method as the target for the thread to execute.
Thread t = new Thread(Thread2);

// Start the new thread (Thread2 will begin executing in parallel).
t.Start();

// Execute the Thread1 method on the current (main) thread. This runs sequentially after starting Thread2.
Thread1();
```
In this example, Thread1 and Thread2 are executed. The method Thread2 will run in a separate thread, while Thread1 runs in the main thread. The two threads will execute their tasks concurrently (asynchronously), meaning both tasks will proceed at the same time.

**Notes**:
* Thread.Sleep(): This method causes the current thread to pause for a specific period of time. In this example, it simulates a delay between tasks.
* Synchronous behavior (sequential execution): If you structure the code like this:

``` csharp
Thread t = new Thread(Thread2);
Thread1();
t.Start();
```
Main methods:


* [`.Finalize()`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.finalize?view=net-9.0#system-threading-thread-finalize): Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the Thread object.
* [`.Start()`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.start?view=net-9.0#system-threading-thread-start): Causes the operating system to change the state of the current instance to Running.
* [`.Interrupt()`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.interrupt?view=net-9.0#system-threading-thread-interrupt): Interrupts a thread that is in the WaitSleepJoin thread state.
* [`.Join()`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.join?view=net-9.0#system-threading-thread-join): Blocks the calling thread until the thread represented by this instance terminates, while continuing to perform standard COM and SendMessage pumping. It is used to synchronize different threads, ensuring that one thread waits for another to finish before proceeding.
* [`.Sleep(Int32)`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-9.0#system-threading-thread-sleep(system-int32)): Suspends the current thread for the specified number of milliseconds.


## Sincronizacion y bloqueos de hilos
Dependiendo de la aplicacion que estamos creando debemos sincronizar los diferentes hilos que tenemos, es decir el orden en que se ejecutan los diferentes hilos.
Como hemos visto antes el metodo usado para sincronizar hilos es `.Join()`.  

Imahina que tenemos ahora el siguietne codigo:

```csharp
Thread t3 = new Thread(Thread2);
Thread t4 = new Thread(Thread3);

t4.Start(); // Create a new thread `t4` that will execute the method `Thread3` method.
Thread1(); // Execute the method `Thread1` in the main thread (this runs sequentially in the main thread).
t3.Start(); // Start thread `t3` to execute `Thread2` method concurrently.
```
**Explanation:**
* `Thread1()` runs on the main thread.
* `t4` runs concurrently with the main thread (and with t3 once it starts).
* `t3` starts after Thread1(), but it doesn't have to wait for it to finish.


```csharp
Console.WriteLine("================= Multitasking: Managing ====================");
Thread t3 = new Thread(Thread2);
Thread t4 = new Thread(Thread3);

t4.Start(); // // Start thread `t4` to execute `Thread3` method concurrently.
t4.Join(); // Wait for `t4` to finish before continuing.
Thread1(); // Execute the method `Thread1` in the main thread (this runs sequentially in the main thread).
t3.Start(); // Start thread `t3` to execute `Thread2` method concurrently.
t3.Join(); // Wait for `t3` to finish before exiting.
```

**Explanation:**
* The tasks are executed sequentially due to the use of the `.Join()` method.
* `t4.Start()`: This starts *t4* which executes Thread3 method concurrently. However, since we immediately follow it with t4.Join(), the main thread will wait for *t4* to finish before moving on.
* `t4.Join()`: This blocks the main thread until *t4* (running Thread3 method) has finished. So, the main thread does not proceed until *t4* is done.
* `Thread1()`: After *t4* completes, the main thread runs Thread1() method sequentially.
* `t3.Start()`: After Thread1() finishes, *t3* is started (running Thread2 method). However, we immediately call `t3.Join()`, which makes the main thread wait until *t3* finishes.
* `t3.Join()`: This causes the main thread to wait for *t3* to finish before continuing.

```csharp

Console.WriteLine("Example 2");
Thread t5 = new Thread(Thread2);
Thread t6 = new Thread(Thread3);

t5.Start();  // Start thread `t5` to execute `Thread2` mehotd concurrently.
t5.Join(); // Wait for thread `t5` (running `Thread2`) to finish before continuing.
t6.Start(); // Start thread `t6` to execute `Thread3` method concurrently.
Thread1();  // Execute the method `Thread1` in the main thread (this runs sequentially).

```

**Explanation:**
* `t5.Start()`: This starts *t5* which executes Thread3 method concurrently. However, since we immediately follow it with `t5.Join()`, the main thread will wait for *t5* to finish before moving on.
* `t5.Join()`: This blocks the main thread until *t5* (running Thread2 method) has finished. So, the main thread does not proceed until *t5* is done.
* `t6.Start()`:  After *t5* finishes (because the main thread was blocked by `t5.Join()`), *t6* is started to execute the *Thread3* method concurrently.
* `Thread1()`: The main thread then runs the Thread1 method sequentially. The main thread doesn't need to wait for t6 to finish because it doesn't use a `.Join()` for *t6*, so it just proceeds with Thread1().