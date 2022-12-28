// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine() ?? "0");
a=a/10;
Console.WriteLine(a%10);
