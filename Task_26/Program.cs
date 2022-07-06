/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
// while (number > 0)
// {
//     number = number / 10;
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе {number} равно {count}");

int Digit (int num)
{
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int result = Digit (number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");