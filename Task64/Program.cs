// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


string GetN(int n)
{
    if (n == 0)
    {
        return n.ToString();   
    }
    else if(n>0){
    Console.Write($"{n} ");
    return GetN(n-1);
    }
    else return n.ToString();
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

GetN(n);




