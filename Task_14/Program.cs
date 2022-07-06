/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

bool Sqrt(int firstDigit, int secondDigit)
{
    if (firstDigit * firstDigit == secondDigit || secondDigit * secondDigit == firstDigit)
        return true;
    else
        return false;
}

bool result = Sqrt(firstDigit, secondDigit);
Console.WriteLine(result);

