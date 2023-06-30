// See https://aka.ms/new-console-template for more information



// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadNumber(string number)
{
    System.Console.WriteLine(number);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int[] FillArray(int length){
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Enter element {i + 1}");
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int PositiveNum(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}

int length = ReadNumber("Enter number of the elements> ");
int[] array;
array = FillArray(length);
PrintArray(array);
System.Console.WriteLine($"Qty of number more then 0 - {PositiveNum(array)}");