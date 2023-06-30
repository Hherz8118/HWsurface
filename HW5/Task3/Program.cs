// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



Console.Write("Enter the number of array elements: ");
int length = int.Parse(Console.ReadLine());

double[] numbers = new double[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Enter element #{i + 1}: ");
    numbers[i] = double.Parse(Console.ReadLine());
}

double min = FindMin(numbers);
double max = FindMax(numbers);
double difference = max - min;
Console.WriteLine($"Difference is: {difference}");


double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
