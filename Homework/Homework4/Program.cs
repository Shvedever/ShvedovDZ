// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
/*
void Sqrt(int a, int b)
{   
    int res = 1;
    for (int cur = 1;cur <= b; cur++)
        res *= a;
    Console.WriteLine($"{a} to the power of {b} -> {res}");
}

Console.WriteLine("Input number you want to raise: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input power of your number: ");
int power = Convert.ToInt32(Console.ReadLine());

if(power >= 0)
    Sqrt(user_num, power);
else Console.WriteLine("Enter positive power!");
*/
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummOfDig(int num)
{
    int sum = 0;
    while (num > 0 ^ num < 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int res = SummOfDig(user_num);
Console.WriteLine($"{user_num} -> {res}");
*/
// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
/*
void ShowArray8()
{
    int [] array = new int [8];

    for (int i = 0; i < 8; i++)
        array [i] = new Random().Next(-100, 100);

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.Write("\b\b]");     
}

ShowArray8();
*/
