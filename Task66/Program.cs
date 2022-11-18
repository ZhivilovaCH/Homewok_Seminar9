// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int GetNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return m + GetNumbers(m+1,n);
    }
 
    return m;
}


void PrintNumbers(int number)
{
    Console.WriteLine(number);
}


Console.Clear();
Console.Write("Введите первое число : ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число : ");
int n = int.Parse(Console.ReadLine()!);

int number = GetNumbers(m, n);
Console.Write($"Cумма натуральных элементов в промежутке от {m} до {n} = ");
PrintNumbers(number);