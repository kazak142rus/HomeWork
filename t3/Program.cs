// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

void Main()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine("Ваш случайный массив: ");
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Ваш массив в обратной последовательности: ");
    arrayRevers(array);
}

void arrayRevers(int[] array, int first = 0)
{
    if (first != array.Length)
    {
        arrayRevers(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}

Main();