// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayWithRandom(int[,] matrix, int m, int n )
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}


void Average(int[,] matrix, int m, int n)
{
    double sum = 0;
    int column = 1;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {column} = {Math.Round(sum/m, 2)}");
        column++;
        sum = 0;
    }
    
}

Console.WriteLine("Введите размер массива: ");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m, n];
FillArrayWithRandom(matrix, m, n);
Average(matrix, m, n);

