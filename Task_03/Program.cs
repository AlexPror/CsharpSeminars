// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Console.Write("Введите число дня недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber < 1 || dayNumber > 7) Console.Write("Введено некорректное число");
// else if (dayNumber == 1) Console.Write("Monday");
// else if (dayNumber == 2) Console.Write("Tuesday");
// else if (dayNumber == 3) Console.Write("Wednesday");
// else if (dayNumber == 4) Console.Write("Thursday");
// else if (dayNumber == 5) Console.Write("Fridayy");
// else if (dayNumber == 6) Console.Write("Saturday");
// else if (dayNumber == 7) Console.Write("Sunday");

Console.Write("Введите число дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
switch (dayNumber)
{
    case 1: Console.Write("Monday"); break;
    case 2: Console.Write("Tuesday"); break;
    case 3: Console.Write("Wednesday"); break;
    case 4: Console.Write("Thursday"); break;
    case 5: Console.Write("Fridayy"); break;
    case 6: Console.Write("Saturday"); break;
    case 7: Console.Write("Sunday"); break;
    default: Console.Write("Введено некорректное число"); break;
}