// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.

void PrintNumbers(int m, int n)
{
    if (m > n)
    return;
    Console.Write($"{m}, ");
    PrintNumbers(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(m, n);
