// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetAkkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return GetAkkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
    else
        return n + 1;
}


void PrintAkkerman(int akk)
{

    Console.WriteLine(akk);
}


Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);

int akk = GetAkkerman(m, n);
Console.WriteLine();
Console.Write($"Результат : ");
PrintAkkerman(akk);
