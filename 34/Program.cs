// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
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

int GetEvenNumber(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int result = GetEvenNumber(array);
Console.WriteLine(result);