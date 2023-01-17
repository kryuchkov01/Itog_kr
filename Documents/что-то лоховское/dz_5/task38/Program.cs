// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size =  Convert.ToInt32(Console.ReadLine());

double[] array = new double [size];
array = FillArrayWithRandom(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Минимальное значение = {min}, а максимальное = {max}");

double rz = max - min;
Console.WriteLine(Math.Round(rz, 3));