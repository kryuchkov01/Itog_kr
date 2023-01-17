// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных 
// чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size =  Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];
array = FillArrayWithRandom(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine(count);