// Task is a class that allows us to work with asynchronous tasks.
using System;

namespace Asynchronous
{
    class Program
    {
        // Using async and await

        static async Task Main(string[] args) // I need to use async Task in the method, this is similar to using void
        {
            var task = new Task(() => {
                Thread.Sleep(4000);
                Console.WriteLine("The internal task is running");
            });
            task.Start();

            var task2 = new Task(() => {
                Thread.Sleep(1000);
                Console.WriteLine("The internal task 2 is running");
            });
            task2.Start();

            Console.WriteLine("Running something else");
            await task; // We wait for the task to complete
            Console.WriteLine("Running after the task");

            int resultRandom = await RandomAsync();
            Console.WriteLine($"Random result: {resultRandom}");
            Console.WriteLine("Running after all tasks");
        }

        // This method simulates an asynchronous operation that returns a random number
        public static async Task<int> RandomAsync()
        {
            var task = new Task<int>(() =>
            {
                int randomNumber = new Random().Next(1000);
                return randomNumber;
            });

            task.Start();
            int result = await task;

            return result;
        }
    }
}

