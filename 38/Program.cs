Console.WriteLine("Введите количество элементов");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка!");
    return;
}


double[] FillArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

double[] array = FillArray(length);

double GetMax(double[] array)
{
    double max = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double max = GetMax(array);


double GetMin(double[] array)
{
    double min = 100;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double min = GetMin(array);

void PrintArray(double[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

PrintArray(array);



double diff = max - min;
Console.WriteLine($"{diff}");
