// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = ReadNumber("Enter number A ");
int B = ReadNumber("Enter number B ");

int ReadNumber(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result * A;
}

System.Console.WriteLine(result);
