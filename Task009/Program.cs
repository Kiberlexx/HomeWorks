// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a/100*10;
int c = a%10;
Console.WriteLine(b+c);