Console.WriteLine("Введите число: ");
int N =  Convert.ToInt32(Console.ReadLine());
string[] array = new string [N];
array = FillArray(array);

string[] FillArray(string[] array)
{
    Console.WriteLine($"Введите элементы массива : ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

Console.WriteLine($"Исходный массив : ");
for(int i = 0; i < array.Length; i++)
{Console.Write($"{array[i]} ");}

string[] newArray = new string [N];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {newArray[i] = array[i];}
    else {newArray[i] = null;}
}

Console.WriteLine();
Console.WriteLine($"Итоговый массив : ");
for(int i = 0; i < newArray.Length; i++)
{Console.Write($"{newArray[i]} ");}

