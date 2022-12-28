// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a < 1000)
{
    if (a > 99)
    {
        Console.WriteLine(a % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
else
{
    while (a >= 1000)
    {
        a = a / 10;
    }
    Console.WriteLine(a % 10);
}