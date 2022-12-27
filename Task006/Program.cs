//Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное число:");
int a=int.Parse(Console.ReadLine() ?? "0");
int b= a%10;
Console.WriteLine(b);

