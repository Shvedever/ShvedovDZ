// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int N)
{
    if (N < 0) N *=(-1);
    Console.Write(N + ", ");
    if (N > 1) ShowNumbers(N - 1);
    Console.Write("\b\b. ");
}
Console.WriteLine("Input number N: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNumbers(number);
*/
// Задайте значение M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SummBetweenMN(int n, int m)
{    
    if(m > n) return 0;
    else return m + SummBetweenMN(n,m + 1);
}

Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N ");
int n = Convert.ToInt32(Console.ReadLine());

int res = SummBetweenMN(n,m);
Console.WriteLine(res);
*/
// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
/*
void DecToDouble(int number)
{
    if(number > 0) 
    {
        DecToDouble(number / 2);
        Console.Write($"{number % 2}" + "");
    }
}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
DecToDouble(user_number);
*/