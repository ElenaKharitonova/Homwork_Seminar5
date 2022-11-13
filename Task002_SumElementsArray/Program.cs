// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int PromptInt(string msg)
{
     System.Console.Write(msg);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
}

double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void PrintArray(double[] array)
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

double SumElements (double[] array)
{   
    double sum = array[0];
    for (int i = 2; i <= array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];
    }
    return sum;
}


int size = PromptInt("Введите количество элементов массива:  ");
int min = PromptInt("Введите минимальное значение элементов массива:  ");
int max = PromptInt("Введите максимальное значение элементов массива:  ");
double[] array = CreateArray(size, min, max+1);
System.Console.WriteLine($"Массив длиной {size}, заполненный случайными числами от {min} до {max}:   ");
PrintArray(array);
double sum = SumElements(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");