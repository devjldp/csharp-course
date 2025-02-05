Console.WriteLine("===== While Loop =====");

int number = 10;

// Console.WriteLine("Infinite Loop")
// while (number > 0)
// {
//     Console.WriteLine(number);
// }

Console.WriteLine("Countdown");

while (number > 0)
{
    Console.WriteLine(number);
    number--;
}

number = 0;

while (number > 0) // Condition is false. The code inside of while loop is not executed
{
    Console.WriteLine(number);
    number--;
}

Console.WriteLine("===== Do-While Loop =====");

number = 0;

do // Condition is false. The code inside of while loop is not executed
{
    Console.WriteLine(number);
    number--;
} while (number > 0);


Console.WriteLine("===== For Loop =====");

for(int index = 0; index <= 10; index += 2) // index += 2 => index = index + 2
{
    Console.WriteLine(index);
}

Console.WriteLine("===== Nested For Loop =====");

for(int index1 = 0; index1 <= 5; index1++) // index += 2 => index = index + 2
{
    Console.WriteLine($"Iteration: {index1}");
    for(int index2 = 6; index2 < 10; index2++)
    {
        Console.WriteLine(index2);
    }
}