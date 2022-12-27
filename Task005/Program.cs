// Показать четные числа от 1 до N
Console.Write("Введите число:");
int a = int.Parse(Console.ReadLine() ?? "0");
int b=1;
while (b<=a)
{
    if (b%2==0)
    {
        Console.WriteLine(b);
    }
    b=b+1;
}