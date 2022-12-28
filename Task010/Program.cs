// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine() ?? "0");
if (b % a == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток равен:"+(b % a));
}