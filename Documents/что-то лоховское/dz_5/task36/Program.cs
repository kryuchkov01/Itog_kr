// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size =  Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];
array = FillArrayWithRandom(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine(sum);