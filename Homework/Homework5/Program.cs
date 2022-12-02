// Задача 34 Задайте массив заполенный случайными положительными трёхзначными числами. Наишите программу, которая покажет количество чётных числе в массиве.
/*
int [] CreateRandomArray (int size)
{
    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}

Console.WriteLine("Input size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] arrayCreated = CreateRandomArray(arraySize);

int res = CountEven(arrayCreated);
ShowArray(arrayCreated);
Console.Write($" -> {res}");
*/
// Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int FindOddSum(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
            sum += array[i];
    return sum;
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arrayCreated = CreateRandomArray(array_size, minValue, maxValue);
ShowArray(arrayCreated);
int SummOddEl = FindOddSum(arrayCreated);
Console.WriteLine($"-> {SummOddEl}");
*/
// Задача 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

// int Max (int[] array)
// {
//     int max = array[1];

//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) 
//         {
//             max = array[i]; 
//         }
//     }
//     return max;
// }

// int Min (int[] array)
// {
//     int min = array[1];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) 
//             min = array[i];
//     }
//     return min;
// }

int MaxMinDiff (int[] array)
{
    int max = array[0]; 
    int min = array[0]; 
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        }
        else if (array[i] < min)
        { 
            min = array[i];
        }
        
    }
    int diff = max - min;
    return diff;
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arrayCreated = CreateRandomArray(array_size, minValue, maxValue);
ShowArray(arrayCreated);
int DiffMaxMin = MaxMinDiff(arrayCreated);
Console.Write($"-> {DiffMaxMin}");

// int max = Max(arrayCreated);
// int min = Min(arrayCreated);
// Console.WriteLine($"Max of array:{max} Min of array:{min} Difference -> {max - min}");
*/
