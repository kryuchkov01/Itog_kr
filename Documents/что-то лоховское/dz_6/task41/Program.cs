// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


Console.WriteLine("Введите размер массива: ");
int size =  Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];
array = FillArray(array);
Console.WriteLine("Ваш массив : ");
Console.Write(string.Join(", ", array));
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }

Console.WriteLine(count);

