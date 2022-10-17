/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

int[] RandomArray(int arraySize)
{

    int[] array = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
        array[i] = rnd.Next(-10, 10);

    return array;

}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

void SummArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }

    }
    Console.Write($"сумма значений нечетных индексов эллементов {result} ");
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);
SummArray(arr);