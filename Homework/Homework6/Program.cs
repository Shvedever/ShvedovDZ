// Задача 41 Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
string CountMoreNull(double size)
{   
    double countNum = 0;
    double countPositive = 0;
    string numbers = string.Empty;
    while(countNum < size)
    {
        Console.WriteLine("Input number: ");
        double user_num = Convert.Todouble32(Console.ReadLine());
            if(user_num > 0)
                {
                    countPositive++;
                }
        numbers += user_num + ", ";
        countNum++;
    }
    return numbers + $"\b\b -> {countPositive}";
}

Console.WriteLine("Input quantity of number u want to enter: ");
double user_size = Convert.Todouble32(Console.ReadLine());

if(user_size > 0)
{
    string quan = CountMoreNull(user_size);
    Console.WriteLine(quan);
}
else Console.WriteLine("Quantity of numbers can't be less than 1!");
*/
// Задача 43 Напишите программу, которая найдёт точку пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2, и k2 задаются пользователем.
/*
void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Cross Point of these two straight line is ({x:f1}, {y:f1})");
}
Console.WriteLine("2 two straight lines are described by 2 equations: y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("These lines are parallel");
}
else CrossPoint(k1, b1, k2, b2);
*/
