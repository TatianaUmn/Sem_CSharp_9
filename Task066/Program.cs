// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if (m == n)
    return n;
    return m + Sum(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма элементов от {m} до {n} равна {Sum(m, n)}");
