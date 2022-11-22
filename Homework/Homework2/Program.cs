//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void ShowDec (int Num)
{
    if(Num > 99 && Num < 1000)
    {
    int cen = Num / 100;
    int ed = Num % 10;
    int dec = (Num - (cen * 100 + ed)) / 10;
    Console.WriteLine("Second digit of your number is " + dec);
    }
    else 
    Console.WriteLine("It's not 3 digit number!");
}

Console.WriteLine("Enter your 3 digit number");
int userNum = Convert.ToInt32(Console.ReadLine());

ShowDec(userNum);
*/
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirdDig(int number)
{
    if(number > 99)
    {
        while(number > 999)
        {
            number = number / 10;
        }
        int ThiNum = number % 10;
        Console.Write($"Third digit of your number is ");
        Console.WriteLine(ThiNum);
    }
    else
    {
        Console.WriteLine("No third digit in this number!");
    }
}

Console.WriteLine("Please write number here: ");
int userNum = Convert.ToInt32(Console.ReadLine());

ThirdDig(userNum);
*/
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void ChillOrNot(int num)
{
    if(num > 0 && num < 8)
    {
        if(num == 6 | num == 7)
        {
            Console.WriteLine("Congratulations! Rest and restore your energy today.");
        }
        else
        Console.WriteLine("I'm really sorry but you need to go to work today");
    }
    else
    Console.WriteLine("Uncorrect number!");
}

Console.WriteLine("Enter the number of the day of the week: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

ChillOrNot(weekDay);
*/