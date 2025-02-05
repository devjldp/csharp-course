# Control Structures in C#

## Content

1. [Conditional Statements](#conditional-statments)
    * 1.1 [If statements](#if-statments)
    * 1.2 [else statement](#else-statement)
    * 1.3 [else if sattement](#else-if-statements)
    * 2.  [switch statment](#switch-statements)
2. [Loops](#loops)
    * 2.1 [while loop](#while-loop)
    * 2.2 [do-while loop](#do-while-loop)
    * 2.3 [for loop](#for-loop)

## Conditional Statments:

We are going to use conditional statements to make decision in Code.

For example:
    `If your age is greater than 18, you can access`

### if statments

We are using an `if` statment to make decisions based on a condition. If the condition is true, then the block of code inside of the if stament will be executed.

```csharp
int age = 20;

if(age > 18) // Condition: Compare the value stored in the variable 'age' with the minimum age => 20 > 18 = true. The code inside the block is executed.
{
    Console.WriteLine("You have access");
}
```
The block inside of the if statement will be executed only if the condition is true.  
What happen if the condition is `false`? We use `else` clause.  
**Note:** Inside parenthesis we can use all operators. `Arithmetic operators`, `comparison operators`, `logical operators`, `assignment operators`.

### else statement

The `else` block will be executed only if the `if` condition is false.

```csharp
int age = 16;

if(age > 18) // 16 > 18 = false.
{
    Console.WriteLine("You have access");
} 
else // Since the condition is false, this block of code will be executed.
{
    Console.WriteLine("You don't have access");
}

```
### else-if statements

The `else if` statement is used to specify a new condition if the initial condition is false.


```csharp
int age = 16;

if(age > 18) // 16 > 18 = false.
{
    Console.WriteLine("You have access");
} 
else if (age >= 16 && age < 18 )// Since the first condition is false and the second one is true, this block of code will be executed.
{
    Console.WriteLine("You have limited access");
}
else
{
    Console.WriteLine("You don't have access");
}

```

**Note:** You can use more than one `else if` statement


### switch statements

The `switch` statement is used to evaluate an expression and execute different blocks of code based on its value.

* Evaluate the expression once.
* Compare the result against different cases.
* Execute the code corresponding to the first matching case.
* Optional: Write a default case if there are no matches.

```csharp
int age = 16;

switch (age > 18) // 16 > 18 = false.
{
    case true:
        Console.WriteLine("You have access");
        break;
    case false:
        Console.WriteLine("You don't have access");
        break;
}   

```
**Note:** After each case, we add the keyword break; because we don't want to continue the execution to the next case if the case matches the condition.

*If we add a default option:*

```csharp
Console.WriteLine("Enter a day of the week");
string day = Console.ReadLine();
switch(day.ToLower())
{
    case "monday":
        Console.WriteLine("Work from office");
        break;
    case "tuesday":
        Console.WriteLine("Work from home");
        break;
    case "wednesday":
        Console.WriteLine("Work from home");
        break;
    case "thursday":
        Console.WriteLine("Work from office");
        break;
    case "friday":
        Console.WriteLine("Work from site");
        break;
    default: // If the user enters saturday or sunday the default option will be executed.
        Console.WriteLine("Day off!");
        break;
}
```

---

## Loops

We use a loop to execute the same code until a condition is reached.

### while loop

We use a `while` loop to execute a code until the condition given is true. With a `while` loop first the condition is evaluated.

```csharp
int number = 10;
while(number > 0)
{
    // infinite loop
    Console.WriteLine(number)
}
```
In the code above we are going to display the value of the number variable until its value is greater than 0.  
But we have a problem: *The value of number is always 10.*  Then we will have an infinite loop.

We need to modify the value stored in the variable.

```csharp
int number = 10;
while(number > 0)
{
    Console.WriteLine(number)
    numer--;
}
```


### do-while loop

This loop is similar, with the singularity that the block of code will execute at least once, regardless of whether the condition is false or not.  
**Note:** In a `while` loop, it only executes if the condition is `true`.

```csharp
int number = 0 

// do-while loop
do
{
    Console.WriteLine(number) // Execute this code once => display 0
} while(number > 0)

// while loop
while(number > 0) // Since the condition is false the code inside the while loop will not be executed.
{
    Console.WriteLine(number)
    numer--;
}
```
### for loop

```
Syntax:

for( statement 1; statement 2; statemnet 3)
{
    block of code
}
```
* statement 1: The starting point of your loop. The first point of your iteration.
* statement 2: The final point of your loop. Where the iteration ends.
* statement 3: The step. The amount by which the loop counter is incremented or decremented in each iteration.

```csharp
for(int index = 0; index <= 10; index += 2) // index += 2 => index = index + 2
{
    Console.WriteLine(index);
}
```

Step by step
```
Starting point => index = 0
Final point => index = 10
step(increment) => 2

First iteration: index = 0 ; 0 <= 10 (true); 0+2 = 2
Second iteration: index = 2 ; 2 <= 10 (true); 2+2 = 4
Third iteration: index = 4 ; 4 <= 10 (true); 4+2 = 6
Fourth iteration: index = 6 ; 6 <= 10 (true); 6+2 = 8
Fith iteration: index = 8 ; 8 <= 10 (true); 8+2 = 10
Sixth iteration: index = 10; 10 <= 10 (true); 10 + 2 = 12
Seventh iteration: index = 12; 12 <= 10 (false) => The condition is false, for loop is finished.
```