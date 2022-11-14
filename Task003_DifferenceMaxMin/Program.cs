// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.

int PromptInt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double PromptDouble(string msg)
{
     System.Console.Write(msg);
     double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double[] MyArray(int size)
{
    double [] result = new double [size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = PromptDouble($"Введите элемент массива под индексом {i}: ");
    }
    return result; 
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

double FindMaxValue(double[] array)
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

double FindMinValue(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length-1; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
    }
    return min;
}

double DifferenceMaxMin(double min, double max)
{
    double difference = max - min;
    return difference;
}

int size = PromptInt($"\nВведите количество элементов массива:  ");
double[] arr = MyArray(size);
PrintArray(arr);
double maxValue = FindMaxValue(arr);
double minValue = FindMinValue(arr);
double result = DifferenceMaxMin(minValue, maxValue);
System.Console.WriteLine($"Разница между максимальным значением {maxValue} и минимальным значением {minValue}  массива равна: {result}");