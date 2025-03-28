using System.Threading;

// Monotasking

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

static void Thread3(){
    Console.WriteLine("Task11");
    Thread.Sleep(200); // delay the next task by 0.2 seconds
    Console.WriteLine("Task12");
    Thread.Sleep(1700); // delay the next task by 1.7 seconds
    Console.WriteLine("Task13");
    Thread.Sleep(500); // delay the next task by 0.5 seconds
    Console.WriteLine("Task14");
    Thread.Sleep(2000); // delay the next task by 2 seconds
    Console.WriteLine("Task15");
}

// Multitasking
Console.WriteLine("================= Multitasking ====================");
Thread t1 = new Thread(Thread2);
t1.Start();
Thread t2 = new Thread(Thread3);
t2.Start();
Thread1();


Console.WriteLine("================= Multitasking: Managing ====================");
Thread t3 = new Thread(Thread2);
Thread t4 = new Thread(Thread3);

t4.Start(); // Start thread `t4` to execute `Thread3` method concurrently.
t4.Join(); // Wait for `t4` to finish before continuing.
Thread1(); // Execute the method `Thread1` in the main thread (this runs sequentially in the main thread).
t3.Start(); // Start thread `t3` to execute `Thread2` concurrently.
t3.Join(); // Wait for `t3` to finish before exiting.


Console.WriteLine("Example 2");
Thread t5 = new Thread(Thread2);
Thread t6 = new Thread(Thread3);

t5.Start();  // Start thread `t5` to execute `Thread2` mehotd concurrently.
t5.Join(); // Wait for thread `t5` (running `Thread2`) to finish before continuing.
t6.Start(); // Start thread `t6` to execute `Thread3` method concurrently.
Thread1();  // Execute the method `Thread1` in the main thread (this runs sequentially).
