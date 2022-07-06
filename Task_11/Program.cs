// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 => {rndNum}");

int newDigit (int num)
{
    return num / 100 * 10 + num % 10;
}

int result = newDigit (rndNum);
Console.WriteLine($"Новое число (с помощью метода): {result}");
Console.WriteLine($"Новое число: {rndNum / 100 * 10 + rndNum % 10}");