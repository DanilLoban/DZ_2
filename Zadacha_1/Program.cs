// See https://aka.ms/new-console-template for more information
Console.Write("Введите трехзначное число, ");
int N = Convert.ToInt32(Console.ReadLine());
int S = (N / 10) % 10;
Console.Write(S);