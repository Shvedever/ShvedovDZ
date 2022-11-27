// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void PalCheck(int num)
{
    int dig1 = num / 10000;
    int dig2 = (num / 1000) - dig1 * 10; 
    int dig4 = num % 10;
    int dig3 = num % 100 / 10;

    if(dig1 == dig4 && dig2 == dig3)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else Console.WriteLine($"{num} -> no");
}

Console.WriteLine("Input your 5 digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num > 9999 && user_num < 100000)
{
    PalCheck(user_num);
}
else Console.WriteLine("Wrong number!");
*/ 
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int x = x2 -x1;
    int y = y2 - y1;
    int z = z2 - z1;
    double lengthAB = Math.Sqrt(x * x + y * y + z * z);
    return lengthAB;

}

Console.WriteLine("Input coordinat X of A: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinat Y of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinat Z of B: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinat X of B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinat Y of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinat Z of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, xB, yA, yB, zA, zB);

Console.WriteLine($"Distance between A and B: {dist:f2}");
*/
// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int num)
{
    int current = -num;
    while (current <= num)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.Write($"\b\b.");
}

Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}
else Console.WriteLine("Wrong number!");
*/
