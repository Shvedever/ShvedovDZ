// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
                created2dArray [i,j] = new Random().Next(minVal, maxVal + 1);
    
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

void ElemMaxToMinRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
               
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
    Show2dArray(array);
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
Show2dArray(createdArray);
ElemMaxToMinRows(createdArray);
*/
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
                created2dArray [i,j] = new Random().Next(minVal, maxVal + 1);
    
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

int minSumRow(int[,] array)
{
    int sumRow = 0;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if(sumRow < minSum)
            {
                minSum = sumRow;
            }
        sumRow = 0;
    }
    return minSum;
}

void SummElemRow(int[,] array, int minSum)
{   
    int sumRow = 0;
    int iMinSum = 0;
    string moreOneRow = string.Empty;
    int countEqual = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if(sumRow == minSum)
            {
                iMinSum = i;
                int k = i + 1;
                moreOneRow += k + ", ";
                countEqual++;
            }
        sumRow = 0;
    }
    if(countEqual > 1) 
        {
            Console.WriteLine($"Rows with minimum summ is {moreOneRow}\b\b.");
        }
    else 
        {
        Console.WriteLine($"Row with minimum summ is {iMinSum + 1}");
        }
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
Show2dArray(createdArray);
int minimumSum = minSumRow(createdArray);
SummElemRow(createdArray, minimumSum);
*/
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] Create2dArray1(int row1, int column1, int minVal1, int maxVal1)
{
    int [,] created2dArray = new int [row1, column1];

    for (int i = 0; i < row1; i++)
        for (int j = 0; j < column1; j++)
                created2dArray [i,j] = new Random().Next(minVal1, maxVal1 + 1);
    
    return created2dArray;    
}

int [,] Create2dArray2(int row2, int column2, int minVal2, int maxVal2)
{
    int [,] created2dArray = new int [row2, column2];

    for (int i = 0; i < row2; i++)
        for (int j = 0; j < column2; j++)
                created2dArray [i,j] = new Random().Next(minVal2, maxVal2 + 1);
    
    return created2dArray;    
}

void ShowArrays(int [,] array1, int [,] array2)
{
    Console.WriteLine("First array: ");

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("Second array: ");

    for(int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
}

int [,] MultipleOfTwoMatrix(int [,] array1, int [,] array2)
{
    int [,] arrayMulti = new int [array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < arrayMulti.GetLength(0); i++)
    {
        for(int j = 0; j < arrayMulti.GetLength(1); j++)
        {
            int sumElem = 0;
            for(int m = 0; m < array1.GetLength(1); m++)
            {
                sumElem += array1[i, m] * array2[m, j];                
            }
            arrayMulti[i, j] = sumElem;
        }
    }
    return arrayMulti;
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

Console.Write("Input numbers of rows for the 1st matrix: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns for the 1st matrix: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for the 1st matrix: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value for the 1st matrix: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input numbers of rows for the 2nd matrix: ");
int user_rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns for the 2nd matrix: ");
int user_columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for the 2nd matrix: ");
int user_minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value for the 2nd matrix: ");
int user_maxValue2 = Convert.ToInt32(Console.ReadLine());


int [,] createdArray1 = Create2dArray1(user_rows, user_columns, user_minValue, user_maxValue);
int [,] createdArray2 = Create2dArray2(user_rows2, user_columns2, user_minValue2, user_maxValue2);
int [,] newArrayMulti = MultipleOfTwoMatrix(createdArray1, createdArray2);
if(user_columns == user_rows2)
{
    ShowArrays(createdArray1, createdArray2);
    Console.WriteLine($"Result of multiplying is: ");
    Show2dArray(newArrayMulti);
}
else Console.WriteLine("Columns of the first matrix should be equal to the rows of the second matrix to multiply: ");
*/
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выводит массив, добавляя индексы каждого элемента.
/*
int[] UniqueNumbersArray(int user_rows, int user_columns, int user_z)
{
    int [] arrayUniq  = new int [user_rows * user_columns * user_z];
    for(int i = 0; i < arrayUniq.GetLength(0); i++)
    {
        arrayUniq[i] = new Random().Next(10,100);
        int temp = arrayUniq[i];
        if(i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arrayUniq[i] == arrayUniq[j])
                {
                    arrayUniq[i] = new Random().Next(10, 100);
                    j = 0;
                    temp = arrayUniq[i];
                }
            }
        }
    }
    return arrayUniq;  
}

int[,,] Create3dArray(int row, int column, int thirdindex, int [] array)
{
    int[,,] created3dArray = new int[row, column, thirdindex];
    int index = 0;
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            for (int k = 0; k < thirdindex; k++)
            {
                created3dArray[i, j, k] = array[index];
                index++;
            }
    return created3dArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of z: ");
int user_z = Convert.ToInt32(Console.ReadLine());

int[] newArray = UniqueNumbersArray(user_rows, user_columns, user_z);
int[,,] array3d = Create3dArray(user_rows, user_columns, user_z, newArray);

Show3dArray(array3d);
*/
// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] Create2dArraySpiral(int row, int col)
{
    int[,] arraySpiral = new int[row, col];
    int iMin = 0;
    int jMin = 0;
    int iMax = row;
    int jMax = col;
    int number = 1;
    while (iMin < iMax && jMin < jMax)
    {
        int i = iMin;
        int j = jMin;
        for (j = jMin; j < jMax; j++)
        {
            arraySpiral[i, j] = number;
            number++;
        }
        j = jMax - 1;
        for (i = iMin + 1; i < iMax; i++)
        {
            arraySpiral[i, j] = number;
            number++;
        }
        i = iMax - 1;
        for (j = jMax - 2; j >= jMin; j--)
        {
            arraySpiral[i, j] = number;
            number++;
        }
        j = jMin;
        for (i = iMax - 2; i > iMin; i--)
        {
            arraySpiral[i, j] = number;
            number++;
        }
        iMin++;
        jMin++;
        iMax--;
        jMax--;
    }
    return arraySpiral;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

int[,] spiral = Create2dArraySpiral(user_rows, user_columns);
Show2dArray(spiral);
*/
