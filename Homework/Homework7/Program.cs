// Задача 47. Задайте двумерный массив размеров m x n, заполненный случайными вещественными числами. m = 3, n = 4.
/*
double [,] Create2dArray(int row, int column)
{
    double [,] created2dArray = new double [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
                created2dArray [i,j] = new Random().Next(-10, 10) + new Random().NextDouble();
    
    return created2dArray;    
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1}" + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double [,] newArray = Create2dArray(3, 4);
Show2dArray(newArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] Create2dArray(int row, int column)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
                created2dArray [i,j] = new Random().Next(-9, 10);
    
    return created2dArray;    
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindNum(int[,] array, int row, int col)
{   
    int findNumCount = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(row - 1 == i && col - 1 == j)
            {
                findNumCount += 1;
            }
        }
    if(findNumCount > 0)
        Console.WriteLine($"Your element is {array[row - 1, col - 1]}");
    else Console.WriteLine("No element with these options!");
}

int [,] newArray = Create2dArray(5,5);
Show2dArray(newArray);

Console.WriteLine("Input row of number: ");
int rowI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column of number: ");
int colI = Convert.ToInt32(Console.ReadLine());

FindNum(newArray, rowI, colI);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] Create2dArray(int row, int column)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
                created2dArray [i,j] = new Random().Next(0, 10);
    
    return created2dArray;    
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMid(int[,] array)
{   
    string res = string.Empty;
    double sum = 0;
    double arif = 0;
    int row = array.GetLength(0);
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        arif = sum / row;
        sum = 0;
        res = res + arif + "; ";
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {res}");
}

int [,] newArray = Create2dArray(5,5);
Show2dArray(newArray);

FindMid(newArray);
*/