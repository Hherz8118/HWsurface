// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = ReadNumber("Enter number ");
int sum = DigitNum(number);

int ReadNumber(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}

int DigitNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

System.Console.WriteLine($"The sum of digits is: {sum}");