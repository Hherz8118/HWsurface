// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




int[] ReadArray(int length){
    int[] array = new int[length];
    System.Console.WriteLine($"Enter {length} number: ");
    for ( int i = 0; i < length; i++){
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) array[i] = 0;
        else {
            array[i] = Convert.ToInt32(input);
        }
    }
    return array;
}

void PrintAray(int[] array){
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

int[] numbers = ReadArray(8);
Console.Write("Massiv: ");
PrintAray(numbers);