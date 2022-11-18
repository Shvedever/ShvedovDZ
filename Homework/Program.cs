// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Input number 1");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 2");

int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write($"{number1} больше, чем {number2}");
}
else 
{
    Console.Write($"{number2} больше, чем {number1}");
}
*/

//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input number 1 ");

int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 2 ");

int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 3 ");

int numC = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    if(numA > numC)
    {
        Console.WriteLine($"{numA} - Max");
    }
    else 
    {
        Console.WriteLine($"{numC} - Max");
    }
}
else
{
    if (numB > numC)
    {
        Console.WriteLine($"{numB} - Max");
    }
    else
    {
        Console.WriteLine($"{numC} - Max");
    }
}
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input number ");

int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 1)
{
    Console.WriteLine($"Число {number} нечётное");

}
else
{
    Console.WriteLine($"Число {number} чётное");
}
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Input number");

int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

if(current + 1 == num)
    {
        Console.WriteLine("Напишите, пожалуйста, число побольше (>_<)!");
    }

while (current < num)
{
if(current % 2 == 0)
    {
    Console.Write(current + ", ");
    current++;
    }
else
    {
    current++;
    }
}
*/