// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите  число: ");
int d = int.Parse(Console.ReadLine()!);
if (d > 99)
{
    while(d > 999)
    {
        d /= 10;
    }
    int r = d % 10;
    Console.WriteLine(r);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}