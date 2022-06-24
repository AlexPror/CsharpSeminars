// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
Console.Write("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = -numberN;
while (numberN >= count) 
{
    Console.Write($"{count} ");
    count +=1;
}

// Console.Write("Введите целое число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// for (int i = -numberN; i <= numberN; i++)
// {
//     Console.Write($"{i} ");
// }