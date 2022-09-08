// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива:");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не число, либо оно отрицательное!");
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}

int[] array = FillArray(length);

void PrintArray(int[] array)
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

int GetSum(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 > 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int result = GetSum(array);
Console.WriteLine(result);