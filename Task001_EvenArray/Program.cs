// Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int PromptInt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

int[] FillArray(int length)
{
    int[] elements = new int[length];
    for (int i = 0; i < length; i++)
    {
        elements[i] = new Random().Next(100, 1000);
    }
    return elements;
}

void PrintArray(int[] array)
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int EvenArray (int[] array)
{   
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int size = PromptInt("Введите количество элементов массива  ");
int[] arr = FillArray(size);
PrintArray(arr);
int q = EvenArray(arr);
System.Console.Write($"--> кол-во четных чисел {q}");