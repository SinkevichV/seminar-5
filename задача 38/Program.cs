/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] RandomArray(int arraySize)
{

    double[] array = new double[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
        array[i] = rnd.Next(-10, 10) + rnd.NextDouble();

    return array;

}

void PrintArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

void DifferenceMaxMinArray(double[] array)
{
    int i = 0;
    double maxArray = array[i];
    double minArray = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArray)
        {
            maxArray = array[i];
        }
        if (array[i] < minArray)
        {
            minArray = array[i];
        }
    }
    double result = maxArray - minArray;
    Console.WriteLine($"Максимальный эллемент массива {maxArray} , минимальный элемент массива {minArray} ");
    Console.WriteLine($"Разность между максимальным и минимальным значением равна: {result}");
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
double[] arr = RandomArray(arraySize);
PrintArray(arr);
DifferenceMaxMinArray(arr);