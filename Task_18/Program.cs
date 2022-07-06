/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/


Console.WriteLine("Введите номер плоскости: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string Coord(int quarter)
{
    switch (quarter)
    {
        case 1: return "X > 0; Y > 0";
        case 2: return "X < 0; Y > 0";
        case 3: return "X < 0; Y < 0";
        case 4: return "X > 0; Y < 0";
        default: return "введено некорректное число";
    }
}
string result = Coord(quarter);
Console.WriteLine(result);
