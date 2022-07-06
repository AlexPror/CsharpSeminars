/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit % secondDigit == 0) 
Console.WriteLine($"Первое число {firstDigit} кратно {secondDigit} ");
else 
Console.WriteLine($"Первое число {firstDigit} НЕ кратно {secondDigit}. Остаток {firstDigit % secondDigit}");

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int remainder = num1 % num2;

// bool Metod(int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     return false;
// }
// bool met = Metod(num1, num2);

