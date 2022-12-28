// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10, 100); // 10,11,12..99
int b = a % 10;
int c = a / 10;
if (b > c)
{
    Console.WriteLine("Число " + a);
    Console.WriteLine("Наибольшая цифра: " + b);
}
else
{
    Console.WriteLine("Число " + a);
    Console.WriteLine("Наибольшая цифра: " + c);
}
