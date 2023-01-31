// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой 
// элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] matrix, int m, int n )
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] matrix, int i, int n)
{
    int sumRow = matrix[i, 0];
    for (int j = 0; j < n; j++)
    {
        sumRow += matrix[i, j];
    }  
    return sumRow;
}

Console.WriteLine("Введите размер массива: ");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m, n];
Console.WriteLine("Ваш массив: ");
FillArray(matrix, m, n);
Console.WriteLine();

int minRow = 0;
int sumRow = Sum(matrix, 0, n);
for (int i = 1; i < m; i++)
{
    int temp = Sum(matrix, i, n);
    if (sumRow > temp)
    {
        sumRow = temp;
        minRow = i;
    }
}
Console.WriteLine($"{minRow+1} строка ({sumRow})");




