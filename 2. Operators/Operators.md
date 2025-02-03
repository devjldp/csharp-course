# Operators in C#

## Content

1. [Arithmetic Operators](#arithmetic-operators)
2. [Comparison Operators](#comparison-operators)
3. [Logical Operators](#logical-operators)
4. [Assignment Operators](#assignment-operators)

---

### Arithmetic Operators

The aritmetic operator are: `+`, `-`, `*`, `/`, `%`.
With them we can perform mathematical operations.

```csharp
5 + 3 // 8
7 - 2 // 5
2 * 4 // 8
6 / 2 // 3
```

`%` is the modulus operator. It returns us the remainder of a division. 

```csharp
5 % 2  // Remainder = 1 => 5 divided by 2 gives a remainder of 1
```


Note:
The **remainder** of a division is the amount left over after dividing one number by another when the division is not exact.


### Comparison Operators

We are going to use comparison operators to compare their operands. They return `true` or `false`.
The comparison operators are:
* `==` *equal to*. Compare if two operands are equal or not.
* `<` *less than*. Compare if the first operand is less than the second operand
* `>` *greater than*. Compare if the first operand is greater than the second operand
* `<=` *less or equal than*. Compare if the first operand is less or equal than the second operand
* `>=` *greater or equal than*. Compare if the first operand is greater or equal than the second operand

### Logical Operators

The logical operators perform logical operations with bool operands:

* `!` *negation operator*
* `&` *Logical **and** operator*. The result is true if both operands are true, otherwise it will be false.
* `|` *Logical **or** operator*. The result is true if one of the operands is true. If botah are false, the result will be false.
* `^` *Logical exclusive **or** operator*. The result is true if one of the operands is true and the another one is false. Otherwise is false.
* `&&` *Conditional logical **and** operator*. The result is true if both operands are true, otherwise it will be false.
* `||` *Conditional logical **or** operator*. The result is true if one of the operands is true. If botah are false, the result will be false.

What is the difference between `&` / `|` and `&&` / `||`? 
* `&` and `|` evaluate both operands, doesn't matter if the first operand is true.
* `&&` and `||` are *short-circuiting*. If the first operand is ture, the second operand is not evaluated.


### Assignment Operators