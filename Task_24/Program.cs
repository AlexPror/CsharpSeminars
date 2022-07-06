/* Задача 24:
Напишите программу, которая принимает на вход число
(А) и выводит сумму чисел от 1 до А*/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i<=numberA; i++)
// {
//     sum = sum + i;
//     if (i < a)
//     {
//         Console.Write($"{i} + ");
//     }
//     else
//     {
//         Console.Write ($"{i} = ");
//     }

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= numberA; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int result = Sum(numberA);
Console.WriteLine($"Сумма чисел от 1 до {numberA} = {result}");

// int a = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// while ( a > 1)
// {
//     result+=a;
//     a--;
// }
// Console.WriteLine(result);
