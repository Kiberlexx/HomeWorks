Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a%2==0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число не четное");
}
