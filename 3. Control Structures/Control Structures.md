# Control Structures in C#

## Content

1. [Conditional Statements](#conditional-statments)
    * 1.1 [If statements](#if-statments)
    * 1.2 [else statement](#else-statement)
    * 1.3 [else if sattement](#else-if-statement)



## Conditional Statments

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

## else statement

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
## else-if statement

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
