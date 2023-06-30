// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2





int[] numbers = RandomArray(4);
Console.Write("Array: ");
PrintArray(numbers);

int evenCount = CountNumbers(numbers);
Console.WriteLine($"Qty of even numbers : {evenCount}");


int[] RandomArray(int length)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}