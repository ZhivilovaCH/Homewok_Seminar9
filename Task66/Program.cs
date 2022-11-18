// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int GetNumbers(int m, int n)
{
    int number = 0;

    for (int i = m; i <= n; i++)
    {
        number += i;
    }
    return number;
}


void PrintNumbers(int number)
{
    Console.WriteLine(number);
}


Console.Clear();
Console.Write("Введите первое число, в промежутке от : ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число, до числа : ");
int n = int.Parse(Console.ReadLine()!);

int number = GetNumbers(m, n);
Console.Write($"Cумму натуральных элементов в промежутке от {m} до {n} = ");
PrintNumbers(number);