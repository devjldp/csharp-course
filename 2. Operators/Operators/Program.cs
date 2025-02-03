// ====== Arithmetic Operators =====

Console.WriteLine(2 + 4); // 6
Console.WriteLine(2 - 5); // -3
Console.WriteLine(4 * 5); // 20
Console.WriteLine(6 / 2); // 3
Console.WriteLine(7 % 2); // 1


// ===== Comparison Operators =====

Console.WriteLine(3 == 3); // true
Console.WriteLine(3 == 2); // false
Console.WriteLine(6 > 4); // true
Console.WriteLine(6 < 4); // false
Console.WriteLine(3 < 9); // true
Console.WriteLine(5 < 3); //false
Console.WriteLine(4 >= 4); // true
Console.WriteLine(5 >= 9); // false
Console.WriteLine(3 <= 6); //true


// ===== Logical Operators =====
Console.WriteLine(5 > 6 && 4 >= 4); // false (The second operand is not checked) is false
Console.WriteLine(5 == 5 & 5 > 3); // true and true is true
Console.WriteLine(5 > 3 || 4 > 4); // true (The secon operand is not checked) is true
Console.WriteLine(5 == 6 | 5 > 3);  // false or true is true
Console.WriteLine(!(5 > 3));; // Not true is false
Console.WriteLine(!( 3 > 5)); // Not flase is true