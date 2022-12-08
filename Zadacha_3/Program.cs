// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 23 == 0)
{
    if (N % 7 == 0)
    {
        Console.Write("Да");
    }
    else
    {
         Console.Write("Нет");
    }
}
else 
{
    Console.Write("Нет");
}
