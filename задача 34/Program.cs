/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] RandomArray(int arraySize)
{

    int[] array = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
        array[i] = rnd.Next(100, 999);

    return array;

}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

void NumberParity(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + (i + 1) / (i + 1);
        }

    }
    Console.Write($"в данном массиве четных элемментов {result} ");
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);
NumberParity(arr);