// See https://aka.ms/new-console-template for more information
Console.Write("Введите трехзначное число, ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 100)
{
    Console.Write("нет 3 числа");
}
else
{
while (N >= 1000)
{
    N = N / 10;
}
Console.Write(N % 10);
}