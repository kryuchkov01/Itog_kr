// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CreateMatrix(int[,] matrix1, int[,] matrix2, int[,] newMatrix)
{
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < l; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += matrix1[i,k] * matrix2[k,j];
            }
            newMatrix[i,j] = sum;
            Console.Write($"{newMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер матрицы 1: ");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер матрицы 2: ");
int l =  Convert.ToInt32(Console.ReadLine());
int k =  n;

int[,] matrix1 = new int [m, n];
Console.WriteLine("Ваша матрица 1: ");
FillArray(matrix1);
int[,] matrix2 = new int [k, l];
Console.WriteLine();
Console.WriteLine("Ваша матрица 2: ");
FillArray(matrix2);
Console.WriteLine();

int[,] newMatrix = new int [m, l];

Console.WriteLine("Итоговая матрица: ");
CreateMatrix(matrix1, matrix2, newMatrix);

