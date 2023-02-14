// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите  цифру обозначающую день недели: ");
int DayOfWeek = int.Parse(Console.ReadLine()!);
while (DayOfWeek < 1 || DayOfWeek > 7)
{
    Console.Write("Вы ввели число не в пределах от 1 до 7, введите цифру!");

    DayOfWeek = int.Parse(Console.ReadLine()!);
}
if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}
